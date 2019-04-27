using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APISMARTHR1.Migrations
{
    public partial class AddedEmployeeTable_and_SomeUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EventComment",
                table: "LifeEvent",
                newName: "LifeEventComment");

            migrationBuilder.AddColumn<int>(
                name: "LifeEventID",
                table: "CoverageEvent",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployeeName = table.Column<string>(nullable: true),
                    EmployerID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CoverageEvent_LifeEventID",
                table: "CoverageEvent",
                column: "LifeEventID");

            migrationBuilder.AddForeignKey(
                name: "FK_CoverageEvent_LifeEvent_LifeEventID",
                table: "CoverageEvent",
                column: "LifeEventID",
                principalTable: "LifeEvent",
                principalColumn: "LifeEventID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CoverageEvent_LifeEvent_LifeEventID",
                table: "CoverageEvent");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_CoverageEvent_LifeEventID",
                table: "CoverageEvent");

            migrationBuilder.DropColumn(
                name: "LifeEventID",
                table: "CoverageEvent");

            migrationBuilder.RenameColumn(
                name: "LifeEventComment",
                table: "LifeEvent",
                newName: "EventComment");
        }
    }
}
