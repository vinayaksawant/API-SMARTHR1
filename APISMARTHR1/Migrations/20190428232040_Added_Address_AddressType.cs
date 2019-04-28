using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APISMARTHR1.Migrations
{
    public partial class Added_Address_AddressType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostalAddress1",
                table: "EmployeeEvent");

            migrationBuilder.DropColumn(
                name: "PostalAddress2",
                table: "EmployeeEvent");

            migrationBuilder.DropColumn(
                name: "PostalAddressCity",
                table: "EmployeeEvent");

            migrationBuilder.DropColumn(
                name: "PostalAddressCountry",
                table: "EmployeeEvent");

            migrationBuilder.DropColumn(
                name: "PostalAddressState",
                table: "EmployeeEvent");

            migrationBuilder.DropColumn(
                name: "PostalAddressZip",
                table: "EmployeeEvent");

            migrationBuilder.DropColumn(
                name: "PostalAddress1",
                table: "DependentEvent");

            migrationBuilder.DropColumn(
                name: "PostalAddress2",
                table: "DependentEvent");

            migrationBuilder.DropColumn(
                name: "PostalAddressCity",
                table: "DependentEvent");

            migrationBuilder.DropColumn(
                name: "PostalAddressCountry",
                table: "DependentEvent");

            migrationBuilder.DropColumn(
                name: "PostalAddressState",
                table: "DependentEvent");

            migrationBuilder.DropColumn(
                name: "PostalAddressZip",
                table: "DependentEvent");

            migrationBuilder.DropColumn(
                name: "PostalAddress1",
                table: "BeneficiaryEvent");

            migrationBuilder.DropColumn(
                name: "PostalAddress2",
                table: "BeneficiaryEvent");

            migrationBuilder.DropColumn(
                name: "PostalAddressCity",
                table: "BeneficiaryEvent");

            migrationBuilder.DropColumn(
                name: "PostalAddressCountry",
                table: "BeneficiaryEvent");

            migrationBuilder.DropColumn(
                name: "PostalAddressState",
                table: "BeneficiaryEvent");

            migrationBuilder.DropColumn(
                name: "PostalAddressZip",
                table: "BeneficiaryEvent");

            migrationBuilder.CreateTable(
                name: "AddressType",
                columns: table => new
                {
                    AddressTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddressTypeCode = table.Column<string>(nullable: true),
                    AddressTypeDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressType", x => x.AddressTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    AddressID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddressTypeID = table.Column<int>(nullable: true),
                    PostalAddress1 = table.Column<string>(nullable: true),
                    PostalAddress2 = table.Column<string>(nullable: true),
                    PostalAddressCity = table.Column<string>(nullable: true),
                    PostalAddressState = table.Column<string>(nullable: true),
                    PostalAddressZip = table.Column<int>(nullable: false),
                    PostalAddressCountry = table.Column<string>(nullable: true),
                    BeneficiaryEventID = table.Column<int>(nullable: true),
                    DependentEventID = table.Column<int>(nullable: true),
                    EmployeeEventID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AddressID);
                    table.ForeignKey(
                        name: "FK_Address_AddressType_AddressTypeID",
                        column: x => x.AddressTypeID,
                        principalTable: "AddressType",
                        principalColumn: "AddressTypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Address_BeneficiaryEvent_BeneficiaryEventID",
                        column: x => x.BeneficiaryEventID,
                        principalTable: "BeneficiaryEvent",
                        principalColumn: "BeneficiaryEventID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Address_DependentEvent_DependentEventID",
                        column: x => x.DependentEventID,
                        principalTable: "DependentEvent",
                        principalColumn: "DependentEventID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Address_EmployeeEvent_EmployeeEventID",
                        column: x => x.EmployeeEventID,
                        principalTable: "EmployeeEvent",
                        principalColumn: "EmployeeEventID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_AddressTypeID",
                table: "Address",
                column: "AddressTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Address_BeneficiaryEventID",
                table: "Address",
                column: "BeneficiaryEventID");

            migrationBuilder.CreateIndex(
                name: "IX_Address_DependentEventID",
                table: "Address",
                column: "DependentEventID");

            migrationBuilder.CreateIndex(
                name: "IX_Address_EmployeeEventID",
                table: "Address",
                column: "EmployeeEventID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "AddressType");

            migrationBuilder.AddColumn<string>(
                name: "PostalAddress1",
                table: "EmployeeEvent",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostalAddress2",
                table: "EmployeeEvent",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostalAddressCity",
                table: "EmployeeEvent",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostalAddressCountry",
                table: "EmployeeEvent",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostalAddressState",
                table: "EmployeeEvent",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PostalAddressZip",
                table: "EmployeeEvent",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PostalAddress1",
                table: "DependentEvent",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostalAddress2",
                table: "DependentEvent",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostalAddressCity",
                table: "DependentEvent",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostalAddressCountry",
                table: "DependentEvent",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostalAddressState",
                table: "DependentEvent",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PostalAddressZip",
                table: "DependentEvent",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PostalAddress1",
                table: "BeneficiaryEvent",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostalAddress2",
                table: "BeneficiaryEvent",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostalAddressCity",
                table: "BeneficiaryEvent",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostalAddressCountry",
                table: "BeneficiaryEvent",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostalAddressState",
                table: "BeneficiaryEvent",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PostalAddressZip",
                table: "BeneficiaryEvent",
                nullable: false,
                defaultValue: 0);
        }
    }
}
