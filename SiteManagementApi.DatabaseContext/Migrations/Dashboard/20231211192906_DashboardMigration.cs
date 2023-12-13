using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiteManagementApi.Data.Migrations.Dashboard
{
    /// <inheritdoc />
    public partial class DashboardMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonAddresses",
                columns: table => new
                {
                    PersonAddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CountryCode = table.Column<string>(type: "varchar(10)", nullable: false),
                    CityCode = table.Column<string>(type: "varchar(10)", nullable: false),
                    DistrictCode = table.Column<string>(type: "varchar(10)", nullable: false),
                    Quarter = table.Column<string>(type: "varchar(30)", nullable: false),
                    Address = table.Column<string>(type: "varchar(100)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserName = table.Column<string>(type: "varchar(50)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedUserName = table.Column<string>(type: "varchar(50)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonAddresses", x => x.PersonAddressId);
                });

            migrationBuilder.CreateTable(
                name: "PersonCommunications",
                columns: table => new
                {
                    PersonCommunicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CommunicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CommunicationType = table.Column<int>(type: "int", nullable: true),
                    Communication = table.Column<string>(type: "varchar(50)", nullable: true),
                    IsPrimary = table.Column<bool>(type: "bit", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserName = table.Column<string>(type: "varchar(50)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedUserName = table.Column<string>(type: "varchar(50)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonCommunications", x => x.PersonCommunicationId);
                });

            migrationBuilder.CreateTable(
                name: "PersonDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(type: "int", nullable: true),
                    Gender = table.Column<string>(type: "char(1)", nullable: true),
                    EducationType = table.Column<int>(type: "int", nullable: true),
                    JobDescriptionId = table.Column<int>(type: "int", nullable: true),
                    CardNumber = table.Column<string>(type: "varchar(30)", nullable: true),
                    PrivateInsurance = table.Column<bool>(type: "bit", nullable: true),
                    MartyrVeteranRelative = table.Column<bool>(type: "bit", nullable: true),
                    PetType = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "varchar(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonIdentityInformations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentityInformationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdentityNumber = table.Column<long>(type: "bigint", nullable: true),
                    PassportNumber = table.Column<long>(type: "bigint", nullable: true),
                    TaxNumber = table.Column<long>(type: "bigint", nullable: true),
                    Nationality = table.Column<string>(type: "varchar(10)", nullable: true),
                    SerialNumber = table.Column<string>(type: "varchar(30)", nullable: true),
                    OrderNumber = table.Column<string>(type: "varchar(30)", nullable: true),
                    FatherName = table.Column<string>(type: "varchar(30)", nullable: true),
                    MotherName = table.Column<string>(type: "varchar(30)", nullable: true),
                    BirthPlace = table.Column<string>(type: "varchar(30)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    MaritalStatus = table.Column<int>(type: "int", nullable: true),
                    MaritalDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    HomeTown = table.Column<string>(type: "varchar(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonIdentityInformations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(30)", nullable: true),
                    LastName = table.Column<string>(type: "varchar(30)", nullable: true),
                    FullName = table.Column<string>(type: "varchar(60)", nullable: true),
                    IdentityInformationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CommunicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserName = table.Column<string>(type: "varchar(50)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedUserName = table.Column<string>(type: "varchar(50)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.PersonId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonAddresses");

            migrationBuilder.DropTable(
                name: "PersonCommunications");

            migrationBuilder.DropTable(
                name: "PersonDetails");

            migrationBuilder.DropTable(
                name: "PersonIdentityInformations");

            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
