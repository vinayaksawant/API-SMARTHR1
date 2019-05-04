using Microsoft.EntityFrameworkCore.Migrations;

namespace APISMARTHR1.Migrations
{
    public partial class RemovedEmployerID_FromEventAndEmployerPlan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployerPlan_Employer_EmployerID",
                table: "EmployerPlan");

            migrationBuilder.AlterColumn<int>(
                name: "EmployerID",
                table: "EmployerPlan",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_EmployerPlan_Employer_EmployerID",
                table: "EmployerPlan",
                column: "EmployerID",
                principalTable: "Employer",
                principalColumn: "EmployerID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployerPlan_Employer_EmployerID",
                table: "EmployerPlan");

            migrationBuilder.AlterColumn<int>(
                name: "EmployerID",
                table: "EmployerPlan",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployerPlan_Employer_EmployerID",
                table: "EmployerPlan",
                column: "EmployerID",
                principalTable: "Employer",
                principalColumn: "EmployerID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
