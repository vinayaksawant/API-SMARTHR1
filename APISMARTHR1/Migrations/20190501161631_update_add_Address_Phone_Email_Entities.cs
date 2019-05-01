using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APISMARTHR1.Migrations
{
    public partial class update_add_Address_Phone_Email_Entities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployerEmail",
                table: "Employer");

            migrationBuilder.DropColumn(
                name: "EmployerFax",
                table: "Employer");

            migrationBuilder.DropColumn(
                name: "EmployerPhone",
                table: "Employer");

            migrationBuilder.DropColumn(
                name: "PostalAddress1",
                table: "Employer");

            migrationBuilder.DropColumn(
                name: "PostalAddress2",
                table: "Employer");

            migrationBuilder.DropColumn(
                name: "PostalAddressCity",
                table: "Employer");

            migrationBuilder.DropColumn(
                name: "PostalAddressCountry",
                table: "Employer");

            migrationBuilder.DropColumn(
                name: "PostalAddressZip",
                table: "Employer");

            migrationBuilder.DropColumn(
                name: "EmployeeEmail",
                table: "EmployeeEvent");

            migrationBuilder.DropColumn(
                name: "EmployeePhone",
                table: "EmployeeEvent");

            migrationBuilder.DropColumn(
                name: "DependentEmail",
                table: "DependentEvent");

            migrationBuilder.DropColumn(
                name: "DependentPhone",
                table: "DependentEvent");

            migrationBuilder.DropColumn(
                name: "BeneficiaryEmail",
                table: "BeneficiaryEvent");

            migrationBuilder.DropColumn(
                name: "BeneficiaryPhone",
                table: "BeneficiaryEvent");

            migrationBuilder.RenameColumn(
                name: "PostalAddressState",
                table: "Employer",
                newName: "EmployerWebsite");

            migrationBuilder.AlterColumn<int>(
                name: "EmployerID",
                table: "Event",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "EmployerID",
                table: "Employee",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "EmployerID",
                table: "Address",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EmailType",
                columns: table => new
                {
                    EmailTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmailTypeCode = table.Column<string>(nullable: true),
                    EmailTypeDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailType", x => x.EmailTypeID);
                });

            migrationBuilder.CreateTable(
                name: "PhoneType",
                columns: table => new
                {
                    PhoneTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PhoneTypeCode = table.Column<string>(nullable: true),
                    PhoneTypeDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneType", x => x.PhoneTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Email",
                columns: table => new
                {
                    EmailID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmailTypeID = table.Column<int>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    BeneficiaryEventID = table.Column<int>(nullable: true),
                    DependentEventID = table.Column<int>(nullable: true),
                    EmployeeEventID = table.Column<int>(nullable: true),
                    EmployerID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Email", x => x.EmailID);
                    table.ForeignKey(
                        name: "FK_Email_BeneficiaryEvent_BeneficiaryEventID",
                        column: x => x.BeneficiaryEventID,
                        principalTable: "BeneficiaryEvent",
                        principalColumn: "BeneficiaryEventID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Email_DependentEvent_DependentEventID",
                        column: x => x.DependentEventID,
                        principalTable: "DependentEvent",
                        principalColumn: "DependentEventID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Email_EmailType_EmailTypeID",
                        column: x => x.EmailTypeID,
                        principalTable: "EmailType",
                        principalColumn: "EmailTypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Email_EmployeeEvent_EmployeeEventID",
                        column: x => x.EmployeeEventID,
                        principalTable: "EmployeeEvent",
                        principalColumn: "EmployeeEventID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Email_Employer_EmployerID",
                        column: x => x.EmployerID,
                        principalTable: "Employer",
                        principalColumn: "EmployerID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Phone",
                columns: table => new
                {
                    PhoneID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PhoneTypeID = table.Column<int>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    BeneficiaryEventID = table.Column<int>(nullable: true),
                    DependentEventID = table.Column<int>(nullable: true),
                    EmployeeEventID = table.Column<int>(nullable: true),
                    EmployerID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phone", x => x.PhoneID);
                    table.ForeignKey(
                        name: "FK_Phone_BeneficiaryEvent_BeneficiaryEventID",
                        column: x => x.BeneficiaryEventID,
                        principalTable: "BeneficiaryEvent",
                        principalColumn: "BeneficiaryEventID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Phone_DependentEvent_DependentEventID",
                        column: x => x.DependentEventID,
                        principalTable: "DependentEvent",
                        principalColumn: "DependentEventID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Phone_EmployeeEvent_EmployeeEventID",
                        column: x => x.EmployeeEventID,
                        principalTable: "EmployeeEvent",
                        principalColumn: "EmployeeEventID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Phone_Employer_EmployerID",
                        column: x => x.EmployerID,
                        principalTable: "Employer",
                        principalColumn: "EmployerID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Phone_PhoneType_PhoneTypeID",
                        column: x => x.PhoneTypeID,
                        principalTable: "PhoneType",
                        principalColumn: "PhoneTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Event_EmployerID",
                table: "Event",
                column: "EmployerID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployerPlan_EmployerID",
                table: "EmployerPlan",
                column: "EmployerID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_EmployerID",
                table: "Employee",
                column: "EmployerID");

            migrationBuilder.CreateIndex(
                name: "IX_Address_EmployerID",
                table: "Address",
                column: "EmployerID");

            migrationBuilder.CreateIndex(
                name: "IX_Email_BeneficiaryEventID",
                table: "Email",
                column: "BeneficiaryEventID");

            migrationBuilder.CreateIndex(
                name: "IX_Email_DependentEventID",
                table: "Email",
                column: "DependentEventID");

            migrationBuilder.CreateIndex(
                name: "IX_Email_EmailTypeID",
                table: "Email",
                column: "EmailTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Email_EmployeeEventID",
                table: "Email",
                column: "EmployeeEventID");

            migrationBuilder.CreateIndex(
                name: "IX_Email_EmployerID",
                table: "Email",
                column: "EmployerID");

            migrationBuilder.CreateIndex(
                name: "IX_Phone_BeneficiaryEventID",
                table: "Phone",
                column: "BeneficiaryEventID");

            migrationBuilder.CreateIndex(
                name: "IX_Phone_DependentEventID",
                table: "Phone",
                column: "DependentEventID");

            migrationBuilder.CreateIndex(
                name: "IX_Phone_EmployeeEventID",
                table: "Phone",
                column: "EmployeeEventID");

            migrationBuilder.CreateIndex(
                name: "IX_Phone_EmployerID",
                table: "Phone",
                column: "EmployerID");

            migrationBuilder.CreateIndex(
                name: "IX_Phone_PhoneTypeID",
                table: "Phone",
                column: "PhoneTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Employer_EmployerID",
                table: "Address",
                column: "EmployerID",
                principalTable: "Employer",
                principalColumn: "EmployerID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Employer_EmployerID",
                table: "Employee",
                column: "EmployerID",
                principalTable: "Employer",
                principalColumn: "EmployerID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployerPlan_Employer_EmployerID",
                table: "EmployerPlan",
                column: "EmployerID",
                principalTable: "Employer",
                principalColumn: "EmployerID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Employer_EmployerID",
                table: "Event",
                column: "EmployerID",
                principalTable: "Employer",
                principalColumn: "EmployerID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Employer_EmployerID",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Employer_EmployerID",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployerPlan_Employer_EmployerID",
                table: "EmployerPlan");

            migrationBuilder.DropForeignKey(
                name: "FK_Event_Employer_EmployerID",
                table: "Event");

            migrationBuilder.DropTable(
                name: "Email");

            migrationBuilder.DropTable(
                name: "Phone");

            migrationBuilder.DropTable(
                name: "EmailType");

            migrationBuilder.DropTable(
                name: "PhoneType");

            migrationBuilder.DropIndex(
                name: "IX_Event_EmployerID",
                table: "Event");

            migrationBuilder.DropIndex(
                name: "IX_EmployerPlan_EmployerID",
                table: "EmployerPlan");

            migrationBuilder.DropIndex(
                name: "IX_Employee_EmployerID",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Address_EmployerID",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "EmployerID",
                table: "Address");

            migrationBuilder.RenameColumn(
                name: "EmployerWebsite",
                table: "Employer",
                newName: "PostalAddressState");

            migrationBuilder.AlterColumn<int>(
                name: "EmployerID",
                table: "Event",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmployerEmail",
                table: "Employer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployerFax",
                table: "Employer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployerPhone",
                table: "Employer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PostalAddress1",
                table: "Employer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostalAddress2",
                table: "Employer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostalAddressCity",
                table: "Employer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostalAddressCountry",
                table: "Employer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PostalAddressZip",
                table: "Employer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "EmployeeEmail",
                table: "EmployeeEvent",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeePhone",
                table: "EmployeeEvent",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "EmployerID",
                table: "Employee",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DependentEmail",
                table: "DependentEvent",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DependentPhone",
                table: "DependentEvent",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BeneficiaryEmail",
                table: "BeneficiaryEvent",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BeneficiaryPhone",
                table: "BeneficiaryEvent",
                nullable: false,
                defaultValue: 0);
        }
    }
}
