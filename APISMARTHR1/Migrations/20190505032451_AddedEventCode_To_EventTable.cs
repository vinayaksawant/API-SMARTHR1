using Microsoft.EntityFrameworkCore.Migrations;

namespace APISMARTHR1.Migrations
{
    public partial class AddedEventCode_To_EventTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EventCode",
                table: "Event",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EventCode",
                table: "Event");
        }
    }
}
