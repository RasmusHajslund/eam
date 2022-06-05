using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnterpriseArchitectManagement.Migrations
{
    public partial class CRUDandApplicationModelUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Application_Application_ApplicationID",
                table: "Application");

            migrationBuilder.DropIndex(
                name: "IX_Application_ApplicationID",
                table: "Application");

            migrationBuilder.DropColumn(
                name: "ApplicationID",
                table: "Application");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Application",
                type: "int",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.CreateTable(
                name: "Component",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuditDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GoLiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndOfLifeDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodeComplexity = table.Column<int>(type: "int", nullable: false),
                    LinesOfCode = table.Column<int>(type: "int", nullable: false),
                    SonarQube = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StandardComponent = table.Column<bool>(type: "bit", nullable: false),
                    PatternsUsed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Security = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodeLanguage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Infrastructure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThirdPartyPackages = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpgradeSuggestions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecuritySuggestions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicationID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Component", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Component_Application_ApplicationID",
                        column: x => x.ApplicationID,
                        principalTable: "Application",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ComponentComponent",
                columns: table => new
                {
                    InfrastructureComponentsID = table.Column<int>(type: "int", nullable: false),
                    IntegrationComponentsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComponentComponent", x => new { x.InfrastructureComponentsID, x.IntegrationComponentsID });
                    table.ForeignKey(
                        name: "FK_ComponentComponent_Component_InfrastructureComponentsID",
                        column: x => x.InfrastructureComponentsID,
                        principalTable: "Component",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComponentComponent_Component_IntegrationComponentsID",
                        column: x => x.IntegrationComponentsID,
                        principalTable: "Component",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Component_ApplicationID",
                table: "Component",
                column: "ApplicationID");

            migrationBuilder.CreateIndex(
                name: "IX_ComponentComponent_IntegrationComponentsID",
                table: "ComponentComponent",
                column: "IntegrationComponentsID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComponentComponent");

            migrationBuilder.DropTable(
                name: "Component");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Application");

            migrationBuilder.AddColumn<int>(
                name: "ApplicationID",
                table: "Application",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Application_ApplicationID",
                table: "Application",
                column: "ApplicationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Application_Application_ApplicationID",
                table: "Application",
                column: "ApplicationID",
                principalTable: "Application",
                principalColumn: "ID");
        }
    }
}
