using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using MtSafe.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace MtSafe.Controllers
{
  [ApiVersion("1.0")]
  [Route("api/Reports")]
  [ApiController]
  public class ReportsV1Controller : ControllerBase
  {
    private MtSafeContext _db; 
    public ReportsV1Controller(MtSafeContext db)
    {
      _db = db; 
    }
    //GET api/reports
    [HttpGet]
    public ActionResult<IEnumerable<Report>> Get()
    {
      return _db.Reports.ToList();
    }
    //POST api/reports
    [HttpPost]
    public void Post([FromBody] Report report)
    {
      _db.Reports.Add(report);
      _db.SaveChanges();
    }
    //GET api/reports/{id}
    [HttpGet("{id}")]
    public ActionResult<Report> Get(int id)
    {
      return _db.Reports.FirstOrDefault(e => e.ReportId == id);
    }
    // PUT api/reports/{id}
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Report report)
    {
      report.ReportId = id;
      _db.Entry(report).State = EntityState.Modified;
      _db.SaveChanges(); 
    }
    // DELETE api/reports/{id}
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var reportToDelete = _db.Reports.FirstOrDefault(e => e.ReportId == id);
      _db.Reports.Remove(reportToDelete);
      _db.SaveChanges();
    }
  }

  [ApiVersion("2.0")]
  [Route("api/{version:ApiVersion}/Reports")]
  [ApiController]
  public class ReportsV2Controller : ControllerBase
  {
    private MtSafeContext _db; 
    public ReportsV2Controller(MtSafeContext db)
    {
      _db = db; 
    }
    [HttpGet]
    public ActionResult<IEnumerable<Report>> Get(string date, string condition, string location, string username)
    {
      var query = _db.Reports.AsQueryable();
      // if(date != null)
      // {
      //   query = query.Where(entry => entry.Date.Date.ToString() == date);
      // }

      if(condition != null)
      {
        query = query.Where(entry => entry.Condition == condition);
      }

      if(location != null)
      {
        query = query.Where(entry => entry.Location == location);
      }

      if(username != null)
      {
        query = query.Where(entry => entry.Username == username);
      }

      return query.ToList();
    }
  }
}