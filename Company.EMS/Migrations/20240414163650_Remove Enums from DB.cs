using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company.EMS.Migrations
{
    /// <inheritdoc />
    public partial class RemoveEnumsfromDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_Complexity_ComplexityId",
                table: "Assignments");

            migrationBuilder.DropForeignKey(
                name: "FK_DeveloperReports_ReportStatus_ReportStatusId",
                table: "DeveloperReports");

            migrationBuilder.DropForeignKey(
                name: "FK_Developers_ProgrammerType_ProgrammerTypeId",
                table: "Developers");

            migrationBuilder.DropForeignKey(
                name: "FK_DeveloperTechnologies_Technology_TechnologyId",
                table: "DeveloperTechnologies");

            migrationBuilder.DropForeignKey(
                name: "FK_Engagements_EngagementType_EngagementTypeId",
                table: "Engagements");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_ProjectStatus_ProjectStatusId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_ProjectType_ProjectTypeId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectTechnologies_Technology_TechnologyId",
                table: "ProjectTechnologies");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesManagerReports_ReportStatus_ReportStatusId",
                table: "SalesManagerReports");

            migrationBuilder.DropTable(
                name: "Complexity");

            migrationBuilder.DropTable(
                name: "EngagementType");

            migrationBuilder.DropTable(
                name: "ProgrammerType");

            migrationBuilder.DropTable(
                name: "ProjectStatus");

            migrationBuilder.DropTable(
                name: "ProjectType");

            migrationBuilder.DropTable(
                name: "ReportStatus");

            migrationBuilder.DropTable(
                name: "Technology");

            migrationBuilder.DropIndex(
                name: "IX_SalesManagerReports_ReportStatusId",
                table: "SalesManagerReports");

            migrationBuilder.DropIndex(
                name: "IX_ProjectTechnologies_TechnologyId",
                table: "ProjectTechnologies");

            migrationBuilder.DropIndex(
                name: "IX_Projects_ProjectStatusId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_ProjectTypeId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Engagements_EngagementTypeId",
                table: "Engagements");

            migrationBuilder.DropIndex(
                name: "IX_DeveloperTechnologies_TechnologyId",
                table: "DeveloperTechnologies");

            migrationBuilder.DropIndex(
                name: "IX_Developers_ProgrammerTypeId",
                table: "Developers");

            migrationBuilder.DropIndex(
                name: "IX_DeveloperReports_ReportStatusId",
                table: "DeveloperReports");

            migrationBuilder.DropIndex(
                name: "IX_Assignments_ComplexityId",
                table: "Assignments");

            migrationBuilder.RenameColumn(
                name: "ReportStatusId",
                table: "SalesManagerReports",
                newName: "ReportStatus");

            migrationBuilder.RenameColumn(
                name: "TechnologyId",
                table: "ProjectTechnologies",
                newName: "Technology");

            migrationBuilder.RenameColumn(
                name: "ProjectTypeId",
                table: "Projects",
                newName: "ProjectType");

            migrationBuilder.RenameColumn(
                name: "ProjectStatusId",
                table: "Projects",
                newName: "ProjectStatus");

            migrationBuilder.RenameColumn(
                name: "EngagementTypeId",
                table: "Engagements",
                newName: "EngagementType");

            migrationBuilder.RenameColumn(
                name: "TechnologyId",
                table: "DeveloperTechnologies",
                newName: "Technology");

            migrationBuilder.RenameColumn(
                name: "ProgrammerTypeId",
                table: "Developers",
                newName: "ProgrammerType");

            migrationBuilder.RenameColumn(
                name: "ReportStatusId",
                table: "DeveloperReports",
                newName: "ReportStatus");

            migrationBuilder.RenameColumn(
                name: "ComplexityId",
                table: "Assignments",
                newName: "Complexity");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReportStatus",
                table: "SalesManagerReports",
                newName: "ReportStatusId");

            migrationBuilder.RenameColumn(
                name: "Technology",
                table: "ProjectTechnologies",
                newName: "TechnologyId");

            migrationBuilder.RenameColumn(
                name: "ProjectType",
                table: "Projects",
                newName: "ProjectTypeId");

            migrationBuilder.RenameColumn(
                name: "ProjectStatus",
                table: "Projects",
                newName: "ProjectStatusId");

            migrationBuilder.RenameColumn(
                name: "EngagementType",
                table: "Engagements",
                newName: "EngagementTypeId");

            migrationBuilder.RenameColumn(
                name: "Technology",
                table: "DeveloperTechnologies",
                newName: "TechnologyId");

            migrationBuilder.RenameColumn(
                name: "ProgrammerType",
                table: "Developers",
                newName: "ProgrammerTypeId");

            migrationBuilder.RenameColumn(
                name: "ReportStatus",
                table: "DeveloperReports",
                newName: "ReportStatusId");

            migrationBuilder.RenameColumn(
                name: "Complexity",
                table: "Assignments",
                newName: "ComplexityId");

            migrationBuilder.CreateTable(
                name: "Complexity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complexity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EngagementType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EngagementType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProgrammerType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgrammerType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReportStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Technology",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technology", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SalesManagerReports_ReportStatusId",
                table: "SalesManagerReports",
                column: "ReportStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTechnologies_TechnologyId",
                table: "ProjectTechnologies",
                column: "TechnologyId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ProjectStatusId",
                table: "Projects",
                column: "ProjectStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ProjectTypeId",
                table: "Projects",
                column: "ProjectTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Engagements_EngagementTypeId",
                table: "Engagements",
                column: "EngagementTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DeveloperTechnologies_TechnologyId",
                table: "DeveloperTechnologies",
                column: "TechnologyId");

            migrationBuilder.CreateIndex(
                name: "IX_Developers_ProgrammerTypeId",
                table: "Developers",
                column: "ProgrammerTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DeveloperReports_ReportStatusId",
                table: "DeveloperReports",
                column: "ReportStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_ComplexityId",
                table: "Assignments",
                column: "ComplexityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_Complexity_ComplexityId",
                table: "Assignments",
                column: "ComplexityId",
                principalTable: "Complexity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeveloperReports_ReportStatus_ReportStatusId",
                table: "DeveloperReports",
                column: "ReportStatusId",
                principalTable: "ReportStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Developers_ProgrammerType_ProgrammerTypeId",
                table: "Developers",
                column: "ProgrammerTypeId",
                principalTable: "ProgrammerType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeveloperTechnologies_Technology_TechnologyId",
                table: "DeveloperTechnologies",
                column: "TechnologyId",
                principalTable: "Technology",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Engagements_EngagementType_EngagementTypeId",
                table: "Engagements",
                column: "EngagementTypeId",
                principalTable: "EngagementType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_ProjectStatus_ProjectStatusId",
                table: "Projects",
                column: "ProjectStatusId",
                principalTable: "ProjectStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_ProjectType_ProjectTypeId",
                table: "Projects",
                column: "ProjectTypeId",
                principalTable: "ProjectType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectTechnologies_Technology_TechnologyId",
                table: "ProjectTechnologies",
                column: "TechnologyId",
                principalTable: "Technology",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesManagerReports_ReportStatus_ReportStatusId",
                table: "SalesManagerReports",
                column: "ReportStatusId",
                principalTable: "ReportStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
