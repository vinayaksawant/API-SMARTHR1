using Microsoft.EntityFrameworkCore.Migrations;

namespace APISMARTHR1.Migrations
{
    public partial class FullExpandedEmployerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "BillingRate",
                table: "Employer",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "EmployerEmail",
                table: "Employer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployerFax",
                table: "Employer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "EmployerImageUrl",
                table: "Employer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployerPhone",
                table: "Employer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployerRating",
                table: "Employer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "OriginCountryFlagImageUrl",
                table: "Employer",
                nullable: true);

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

            migrationBuilder.AddColumn<string>(
                name: "PostalAddressState",
                table: "Employer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PostalAddressZip",
                table: "Employer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BillingRate",
                table: "Employer");

            migrationBuilder.DropColumn(
                name: "EmployerEmail",
                table: "Employer");

            migrationBuilder.DropColumn(
                name: "EmployerFax",
                table: "Employer");

            migrationBuilder.DropColumn(
                name: "EmployerImageUrl",
                table: "Employer");

            migrationBuilder.DropColumn(
                name: "EmployerPhone",
                table: "Employer");

            migrationBuilder.DropColumn(
                name: "EmployerRating",
                table: "Employer");

            migrationBuilder.DropColumn(
                name: "OriginCountryFlagImageUrl",
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
                name: "PostalAddressState",
                table: "Employer");

            migrationBuilder.DropColumn(
                name: "PostalAddressZip",
                table: "Employer");
        }
    }
}
