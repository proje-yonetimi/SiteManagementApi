using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiteManagementApi.Data.Migrations.Dashboard
{
    /// <inheritdoc />
    public partial class dashv1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    CompanyName = table.Column<string>(type: "varchar(100)", nullable: true),
                    TaxBranch = table.Column<string>(type: "varchar(50)", nullable: true),
                    Sector = table.Column<string>(type: "varchar(50)", nullable: true),
                    Description = table.Column<string>(type: "varchar(50)", nullable: true),
                    Bank = table.Column<string>(type: "varchar(50)", nullable: true),
                    IBAN = table.Column<string>(type: "varchar(50)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserName = table.Column<string>(type: "varchar(50)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedUserName = table.Column<string>(type: "varchar(50)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companys", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Companys_Id",
                table: "Companys",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Companys_PersonId",
                table: "Companys",
                column: "PersonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Companys");
        }
    }
}
