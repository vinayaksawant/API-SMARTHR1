using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APISMARTHR1.Migrations
{
    public partial class AddedEmployeeEventTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployerID",
                table: "Event",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EventTypeID",
                table: "Event",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EmployerPlan",
                columns: table => new
                {
                    EmployerPlanID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BenefitID = table.Column<int>(nullable: true),
                    Plancode = table.Column<string>(nullable: true),
                    PlanName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployerPlan", x => x.EmployerPlanID);
                    table.ForeignKey(
                        name: "FK_EmployerPlan_Benefit_BenefitID",
                        column: x => x.BenefitID,
                        principalTable: "Benefit",
                        principalColumn: "BenefitID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EventType",
                columns: table => new
                {
                    EventTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EventName = table.Column<string>(nullable: true),
                    EventDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventType", x => x.EventTypeID);
                });

            migrationBuilder.CreateTable(
                name: "LifeEvent",
                columns: table => new
                {
                    LifeEventID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployeeID = table.Column<int>(nullable: false),
                    EventID = table.Column<int>(nullable: true),
                    EventComment = table.Column<string>(nullable: true),
                    LifeEventDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LifeEvent", x => x.LifeEventID);
                    table.ForeignKey(
                        name: "FK_LifeEvent_Event_EventID",
                        column: x => x.EventID,
                        principalTable: "Event",
                        principalColumn: "EventID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CoverageEvent",
                columns: table => new
                {
                    CoverageEventID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PlanEmployerPlanID = table.Column<int>(nullable: true),
                    PlanOptions = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoverageEvent", x => x.CoverageEventID);
                    table.ForeignKey(
                        name: "FK_CoverageEvent_EmployerPlan_PlanEmployerPlanID",
                        column: x => x.PlanEmployerPlanID,
                        principalTable: "EmployerPlan",
                        principalColumn: "EmployerPlanID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Event_EventTypeID",
                table: "Event",
                column: "EventTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_CoverageEvent_PlanEmployerPlanID",
                table: "CoverageEvent",
                column: "PlanEmployerPlanID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployerPlan_BenefitID",
                table: "EmployerPlan",
                column: "BenefitID");

            migrationBuilder.CreateIndex(
                name: "IX_LifeEvent_EventID",
                table: "LifeEvent",
                column: "EventID");

            migrationBuilder.AddForeignKey(
                name: "FK_Event_EventType_EventTypeID",
                table: "Event",
                column: "EventTypeID",
                principalTable: "EventType",
                principalColumn: "EventTypeID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_EventType_EventTypeID",
                table: "Event");

            migrationBuilder.DropTable(
                name: "CoverageEvent");

            migrationBuilder.DropTable(
                name: "EventType");

            migrationBuilder.DropTable(
                name: "LifeEvent");

            migrationBuilder.DropTable(
                name: "EmployerPlan");

            migrationBuilder.DropIndex(
                name: "IX_Event_EventTypeID",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "EmployerID",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "EventTypeID",
                table: "Event");
        }
    }
}
