using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MtSafe.Models
{
  public class Report
  {
    public int ReportId {get; set;}
    [Required]
    [DisplayName("Add Date")]
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
    public DateTime Date {get; set;}
    [Required]
    public string Condition {get; set;}
    [Required]
    public string Location {get; set;}
    [Required]
    public string Username {get; set;}
  }
}