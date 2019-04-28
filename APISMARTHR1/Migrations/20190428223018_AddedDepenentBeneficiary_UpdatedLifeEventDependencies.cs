using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APISMARTHR1.Migrations
{
    public partial class AddedDepenentBeneficiary_UpdatedLifeEventDependencies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "EmployeeID",
                table: "LifeEvent",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateTable(
                name: "Beneficiary",
                columns: table => new
                {
                    BeneficiaryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    beneficiaryCode = table.Column<string>(nullable: true),
                    EmployeeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beneficiary", x => x.BeneficiaryID);
                    table.ForeignKey(
                        name: "FK_Beneficiary_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Dependent",
                columns: table => new
                {
                    DependentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DependentCode = table.Column<string>(nullable: true),
                    EmployeeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dependent", x => x.DependentID);
                    table.ForeignKey(
                        name: "FK_Dependent_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeEvent",
                columns: table => new
                {
                    EmployeeEventID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployeeID = table.Column<int>(nullable: true),
                    EmployeeName = table.Column<string>(nullable: true),
                    EmployeeFirstName = table.Column<string>(nullable: true),
                    EmployeeMiddleName = table.Column<string>(nullable: true),
                    EmployeeLastName = table.Column<string>(nullable: true),
                    EmployeeDepartment = table.Column<string>(nullable: true),
                    HireDate = table.Column<DateTime>(nullable: false),
                    TerminationDate = table.Column<DateTime>(nullable: false),
                    RetirementDate = table.Column<DateTime>(nullable: false),
                    PostalAddress1 = table.Column<string>(nullable: true),
                    PostalAddress2 = table.Column<string>(nullable: true),
                    PostalAddressCity = table.Column<string>(nullable: true),
                    PostalAddressState = table.Column<string>(nullable: true),
                    PostalAddressZip = table.Column<int>(nullable: false),
                    PostalAddressCountry = table.Column<string>(nullable: true),
                    EmployeeEmail = table.Column<string>(nullable: true),
                    EmployeePhone = table.Column<int>(nullable: false),
                    LifeEventID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeEvent", x => x.EmployeeEventID);
                    table.ForeignKey(
                        name: "FK_EmployeeEvent_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeEvent_LifeEvent_LifeEventID",
                        column: x => x.LifeEventID,
                        principalTable: "LifeEvent",
                        principalColumn: "LifeEventID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LifeEvent_EmployeeID",
                table: "LifeEvent",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Beneficiary_EmployeeID",
                table: "Beneficiary",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Dependent_EmployeeID",
                table: "Dependent",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeEvent_EmployeeID",
                table: "EmployeeEvent",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeEvent_LifeEventID",
                table: "EmployeeEvent",
                column: "LifeEventID");

            migrationBuilder.AddForeignKey(
                name: "FK_LifeEvent_Employee_EmployeeID",
                table: "LifeEvent",
                column: "EmployeeID",
                principalTable: "Employee",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LifeEvent_Employee_EmployeeID",
                table: "LifeEvent");

            migrationBuilder.DropTable(
                name: "Beneficiary");

            migrationBuilder.DropTable(
                name: "Dependent");

            migrationBuilder.DropTable(
                name: "EmployeeEvent");

            migrationBuilder.DropIndex(
                name: "IX_LifeEvent_EmployeeID",
                table: "LifeEvent");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeID",
                table: "LifeEvent",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
