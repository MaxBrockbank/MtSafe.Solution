using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MtSafe.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "ReportId", "Condition", "Date", "Location", "Username" },
                values: new object[,]
                {
                    { 1, "Icy", new DateTime(2021, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mt. Hood", "doublejep" },
                    { 2, "Blizzard", new DateTime(2020, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mt. Hood", "RyGuy" },
                    { 3, "Packed Powder", new DateTime(2021, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Crystal Mountain", "2 Chains" },
                    { 4, "High Avalanche Danger", new DateTime(2021, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mt. Hood", "Albert" },
                    { 5, "Blue Bird", new DateTime(2021, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mt. Bachelor", "Peter" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: 5);
        }
    }
}
