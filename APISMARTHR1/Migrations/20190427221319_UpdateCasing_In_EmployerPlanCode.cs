using Microsoft.EntityFrameworkCore.Migrations;

namespace APISMARTHR1.Migrations
{
    public partial class UpdateCasing_In_EmployerPlanCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Plancode",
                table: "EmployerPlan",
                newName: "PlanCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PlanCode",
                table: "EmployerPlan",
                newName: "Plancode");
        }
    }
}
