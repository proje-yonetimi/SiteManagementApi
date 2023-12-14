using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiteManagementApi.Data.Migrations.Dashboard
{
    /// <inheritdoc />
    public partial class DashboardMigrationv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonAddresses",
                table: "PersonAddresses");

            migrationBuilder.DropIndex(
                name: "IX_MenuItem_ItemId",
                table: "MenuItem");

            migrationBuilder.DropColumn(
                name: "PersonAddressId",
                table: "PersonAddresses");

            migrationBuilder.AddColumn<int>(
                name: "PersonType",
                table: "Persons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "PersonAddresses",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonAddresses",
                table: "PersonAddresses",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "PersonApartments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(type: "int", nullable: true),
                    Ownership = table.Column<int>(type: "int", nullable: true),
                    EntryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    QuitDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    RelatedPerson = table.Column<string>(type: "varchar(50)", nullable: true),
                    Description = table.Column<string>(type: "varchar(2000)", nullable: true),
                    BankPaymentCode = table.Column<string>(type: "varchar(100)", nullable: true),
                    CreatedUserName = table.Column<string>(type: "varchar(50)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedUserName = table.Column<string>(type: "varchar(50)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonApartments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonVehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    Plate = table.Column<string>(type: "varchar(30)", nullable: true),
                    Brand = table.Column<string>(type: "varchar(30)", nullable: true),
                    Model = table.Column<string>(type: "varchar(30)", nullable: true),
                    Color = table.Column<string>(type: "varchar(30)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonVehicles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", nullable: true),
                    ManagerId = table.Column<int>(type: "int", nullable: false),
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sites", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonApartments");

            migrationBuilder.DropTable(
                name: "PersonVehicles");

            migrationBuilder.DropTable(
                name: "Sites");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_PersonAddresses",
            //    table: "PersonAddresses");

            //migrationBuilder.DropColumn(
            //    name: "PersonType",
            //    table: "Persons");

            //migrationBuilder.DropColumn(
            //    name: "Id",
            //    table: "PersonAddresses");

            //migrationBuilder.AddColumn<Guid>(
            //    name: "PersonAddressId",
            //    table: "PersonAddresses",
            //    type: "uniqueidentifier",
            //    nullable: false,
            //    defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_PersonAddresses",
            //    table: "PersonAddresses",
            //    column: "PersonAddressId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_MenuItem_ItemId",
            //    table: "MenuItem",
            //    column: "ItemId",
            //    unique: true);

        }
    }
}
