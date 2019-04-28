using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APISMARTHR1.Migrations
{
    public partial class Added_Updated_LifeEventDependencies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmployeeName",
                table: "EmployeeEvent",
                newName: "EmployeeCode");

            migrationBuilder.RenameColumn(
                name: "EmployeeName",
                table: "Employee",
                newName: "EmployeeCode");

            migrationBuilder.RenameColumn(
                name: "beneficiaryCode",
                table: "Beneficiary",
                newName: "BeneficiaryCode");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "EmployeeEvent",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "RelationshipID",
                table: "EmployeeEvent",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Relationship",
                columns: table => new
                {
                    RelationshipID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RelationshipCode = table.Column<string>(nullable: true),
                    RelationshipCodeDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relationship", x => x.RelationshipID);
                });

            migrationBuilder.CreateTable(
                name: "BeneficiaryEvent",
                columns: table => new
                {
                    BeneficiaryEventID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BeneficiaryID = table.Column<int>(nullable: true),
                    BeneficiaryCode = table.Column<string>(nullable: true),
                    BeneficiaryFirstName = table.Column<string>(nullable: true),
                    BeneficiaryMiddleName = table.Column<string>(nullable: true),
                    BeneficiaryLastName = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    RelationshipID = table.Column<int>(nullable: true),
                    PostalAddress1 = table.Column<string>(nullable: true),
                    PostalAddress2 = table.Column<string>(nullable: true),
                    PostalAddressCity = table.Column<string>(nullable: true),
                    PostalAddressState = table.Column<string>(nullable: true),
                    PostalAddressZip = table.Column<int>(nullable: false),
                    PostalAddressCountry = table.Column<string>(nullable: true),
                    BeneficiaryEmail = table.Column<string>(nullable: true),
                    BeneficiaryPhone = table.Column<int>(nullable: false),
                    LifeEventID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeneficiaryEvent", x => x.BeneficiaryEventID);
                    table.ForeignKey(
                        name: "FK_BeneficiaryEvent_Beneficiary_BeneficiaryID",
                        column: x => x.BeneficiaryID,
                        principalTable: "Beneficiary",
                        principalColumn: "BeneficiaryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BeneficiaryEvent_LifeEvent_LifeEventID",
                        column: x => x.LifeEventID,
                        principalTable: "LifeEvent",
                        principalColumn: "LifeEventID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BeneficiaryEvent_Relationship_RelationshipID",
                        column: x => x.RelationshipID,
                        principalTable: "Relationship",
                        principalColumn: "RelationshipID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DependentEvent",
                columns: table => new
                {
                    DependentEventID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DependentID = table.Column<int>(nullable: true),
                    DependentCode = table.Column<string>(nullable: true),
                    DependentFirstName = table.Column<string>(nullable: true),
                    DependentMiddleName = table.Column<string>(nullable: true),
                    DependentLastName = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    RelationshipID = table.Column<int>(nullable: true),
                    PostalAddress1 = table.Column<string>(nullable: true),
                    PostalAddress2 = table.Column<string>(nullable: true),
                    PostalAddressCity = table.Column<string>(nullable: true),
                    PostalAddressState = table.Column<string>(nullable: true),
                    PostalAddressZip = table.Column<int>(nullable: false),
                    PostalAddressCountry = table.Column<string>(nullable: true),
                    DependentEmail = table.Column<string>(nullable: true),
                    DependentPhone = table.Column<int>(nullable: false),
                    LifeEventID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DependentEvent", x => x.DependentEventID);
                    table.ForeignKey(
                        name: "FK_DependentEvent_Dependent_DependentID",
                        column: x => x.DependentID,
                        principalTable: "Dependent",
                        principalColumn: "DependentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DependentEvent_LifeEvent_LifeEventID",
                        column: x => x.LifeEventID,
                        principalTable: "LifeEvent",
                        principalColumn: "LifeEventID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DependentEvent_Relationship_RelationshipID",
                        column: x => x.RelationshipID,
                        principalTable: "Relationship",
                        principalColumn: "RelationshipID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeEvent_RelationshipID",
                table: "EmployeeEvent",
                column: "RelationshipID");

            migrationBuilder.CreateIndex(
                name: "IX_BeneficiaryEvent_BeneficiaryID",
                table: "BeneficiaryEvent",
                column: "BeneficiaryID");

            migrationBuilder.CreateIndex(
                name: "IX_BeneficiaryEvent_LifeEventID",
                table: "BeneficiaryEvent",
                column: "LifeEventID");

            migrationBuilder.CreateIndex(
                name: "IX_BeneficiaryEvent_RelationshipID",
                table: "BeneficiaryEvent",
                column: "RelationshipID");

            migrationBuilder.CreateIndex(
                name: "IX_DependentEvent_DependentID",
                table: "DependentEvent",
                column: "DependentID");

            migrationBuilder.CreateIndex(
                name: "IX_DependentEvent_LifeEventID",
                table: "DependentEvent",
                column: "LifeEventID");

            migrationBuilder.CreateIndex(
                name: "IX_DependentEvent_RelationshipID",
                table: "DependentEvent",
                column: "RelationshipID");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeEvent_Relationship_RelationshipID",
                table: "EmployeeEvent",
                column: "RelationshipID",
                principalTable: "Relationship",
                principalColumn: "RelationshipID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeEvent_Relationship_RelationshipID",
                table: "EmployeeEvent");

            migrationBuilder.DropTable(
                name: "BeneficiaryEvent");

            migrationBuilder.DropTable(
                name: "DependentEvent");

            migrationBuilder.DropTable(
                name: "Relationship");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeEvent_RelationshipID",
                table: "EmployeeEvent");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "EmployeeEvent");

            migrationBuilder.DropColumn(
                name: "RelationshipID",
                table: "EmployeeEvent");

            migrationBuilder.RenameColumn(
                name: "EmployeeCode",
                table: "EmployeeEvent",
                newName: "EmployeeName");

            migrationBuilder.RenameColumn(
                name: "EmployeeCode",
                table: "Employee",
                newName: "EmployeeName");

            migrationBuilder.RenameColumn(
                name: "BeneficiaryCode",
                table: "Beneficiary",
                newName: "beneficiaryCode");
        }
    }
}
