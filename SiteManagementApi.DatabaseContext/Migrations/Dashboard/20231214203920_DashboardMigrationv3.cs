using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiteManagementApi.Data.Migrations.Dashboard
{
    /// <inheritdoc />
    public partial class DashboardMigrationv3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Sites",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedUserName",
                table: "Sites",
                type: "varchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Sites",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Sites",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedUserName",
                table: "Sites",
                type: "varchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BloodType",
                table: "PersonIdentityInformations",
                type: "varchar(10)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ApartmentId",
                table: "PersonApartments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Apartments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApartmentType = table.Column<int>(type: "int", nullable: false),
                    Block = table.Column<string>(type: "varchar(30)", nullable: true),
                    DoorNumber = table.Column<string>(type: "varchar(30)", nullable: true),
                    RoomCount = table.Column<string>(type: "varchar(30)", nullable: true),
                    Gross = table.Column<decimal>(type: "decimal(15,2)", nullable: false),
                    Net = table.Column<decimal>(type: "decimal(15,2)", nullable: false),
                    LandShare = table.Column<decimal>(type: "decimal(15,2)", nullable: false),
                    FloorNumber = table.Column<int>(type: "int", nullable: false),
                    Statu = table.Column<int>(type: "int", nullable: false),
                    Dues = table.Column<decimal>(type: "decimal(15,2)", nullable: false),
                    ParkingSpaceNumber = table.Column<string>(type: "varchar(30)", nullable: true),
                    Aspect = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserName = table.Column<string>(type: "varchar(50)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedUserName = table.Column<string>(type: "varchar(50)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    Company = table.Column<string>(type: "varchar(30)", nullable: true),
                    Position = table.Column<string>(type: "varchar(30)", nullable: true),
                    MealCard = table.Column<string>(type: "varchar(30)", nullable: true),
                    Description = table.Column<string>(type: "varchar(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "EmployeesBankInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Bank = table.Column<string>(type: "varchar(50)", nullable: true),
                    AccountNumber = table.Column<string>(type: "varchar(20)", nullable: true),
                    IBAN = table.Column<string>(type: "varchar(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeesBankInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobToDo",
                columns: table => new
                {
                    JobId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    JobTitle = table.Column<string>(type: "varchar(100)", nullable: true),
                    Location = table.Column<string>(type: "varchar(100)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Renew = table.Column<int>(type: "int", nullable: false),
                    RenewalEndDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    SmsAlert = table.Column<bool>(type: "bit", nullable: false),
                    EmailAlert = table.Column<bool>(type: "bit", nullable: false),
                    PushAlert = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "varchar(1000)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobToDo", x => x.JobId);
                });

            migrationBuilder.CreateTable(
                name: "Meeting",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subject = table.Column<string>(type: "varchar(100)", nullable: true),
                    Summary = table.Column<string>(type: "varchar(250)", nullable: true),
                    Location = table.Column<string>(type: "varchar(100)", nullable: true),
                    Content = table.Column<string>(type: "varchar(500)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    MeetingDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Attachment = table.Column<string>(type: "varchar(200)", nullable: true),
                    AttendenceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meeting", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Apartments");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "EmployeesBankInfo");

            migrationBuilder.DropTable(
                name: "JobToDo");

            migrationBuilder.DropTable(
                name: "Meeting");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Sites");

            migrationBuilder.DropColumn(
                name: "CreatedUserName",
                table: "Sites");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Sites");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Sites");

            migrationBuilder.DropColumn(
                name: "UpdatedUserName",
                table: "Sites");

            migrationBuilder.DropColumn(
                name: "BloodType",
                table: "PersonIdentityInformations");

            migrationBuilder.DropColumn(
                name: "ApartmentId",
                table: "PersonApartments");
        }
    }
}
