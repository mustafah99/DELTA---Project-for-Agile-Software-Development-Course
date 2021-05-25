using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DELTA___Ballin_Out_Web_Application.Migrations
{
    public partial class AddEventDatabaseModelToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EventImage = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EventLocation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EventDescription = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    EventDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");
        }
    }
}
