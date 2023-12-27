using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiteManagementApi.Data.Migrations.Dashboard
{
    /// <inheritdoc />
    public partial class dashmigv1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApartmentGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupCode = table.Column<string>(type: "varchar(50)", nullable: true),
                    GroupName = table.Column<string>(type: "varchar(50)", nullable: true),
                    Dues = table.Column<decimal>(type: "decimal(15,2)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserName = table.Column<string>(type: "varchar(50)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedUserName = table.Column<string>(type: "varchar(50)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApartmentGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApartmentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupCode = table.Column<string>(type: "varchar(50)", nullable: true),
                    TypeCode = table.Column<string>(type: "varchar(50)", nullable: true),
                    TypeName = table.Column<string>(type: "varchar(50)", nullable: true),
                    Description = table.Column<string>(type: "varchar(300)", nullable: true),
                    Dues = table.Column<decimal>(type: "decimal(15,2)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserName = table.Column<string>(type: "varchar(50)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedUserName = table.Column<string>(type: "varchar(50)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApartmentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Authorities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(type: "int", nullable: true),
                    AuthType = table.Column<string>(type: "varchar(10)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsCanExportFile = table.Column<bool>(type: "bit", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserName = table.Column<string>(type: "varchar(50)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authorities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BankCases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaseCode = table.Column<int>(type: "int", nullable: true),
                    CaseName = table.Column<string>(type: "varchar(50)", nullable: true),
                    IsShowSummaryPage = table.Column<bool>(type: "bit", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserName = table.Column<string>(type: "varchar(50)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedUserName = table.Column<string>(type: "varchar(50)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankCases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Expense",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpenseCode = table.Column<string>(type: "varchar(50)", nullable: true),
                    ExpenseName = table.Column<string>(type: "varchar(50)", nullable: true),
                    ExpenseGroup = table.Column<string>(type: "varchar(50)", nullable: true),
                    DistribitionType = table.Column<int>(type: "int", nullable: true),
                    PersonForDebited = table.Column<int>(type: "int", nullable: true),
                    ExpenseDesc = table.Column<string>(type: "varchar(250)", nullable: true),
                    IsInclude = table.Column<bool>(type: "bit", nullable: true),
                    NotScatterEmptyFlats = table.Column<bool>(type: "bit", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserName = table.Column<string>(type: "varchar(50)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedUserName = table.Column<string>(type: "varchar(50)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expense", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExpenseGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupCode = table.Column<string>(type: "varchar(50)", nullable: true),
                    GroupName = table.Column<string>(type: "varchar(50)", nullable: true),
                    ParentGroupCode = table.Column<string>(type: "varchar(50)", nullable: true),
                    Description = table.Column<string>(type: "varchar(300)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserName = table.Column<string>(type: "varchar(50)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedUserName = table.Column<string>(type: "varchar(50)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GeneralAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountCode = table.Column<int>(type: "int", nullable: true),
                    Account = table.Column<string>(type: "varchar(50)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserName = table.Column<string>(type: "varchar(50)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedUserName = table.Column<string>(type: "varchar(50)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralAccounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IncomeGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupCode = table.Column<string>(type: "varchar(50)", nullable: true),
                    GroupName = table.Column<string>(type: "varchar(50)", nullable: true),
                    ParentGroupCode = table.Column<string>(type: "varchar(50)", nullable: true),
                    Description = table.Column<string>(type: "varchar(300)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserName = table.Column<string>(type: "varchar(50)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedUserName = table.Column<string>(type: "varchar(50)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomeGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Incomes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IncomeCode = table.Column<string>(type: "varchar(50)", nullable: true),
                    IncomeName = table.Column<string>(type: "varchar(50)", nullable: true),
                    IncomeGroup = table.Column<string>(type: "varchar(50)", nullable: true),
                    DistribitionType = table.Column<int>(type: "int", nullable: true),
                    PersonForCredited = table.Column<int>(type: "int", nullable: true),
                    IncomeDesc = table.Column<string>(type: "varchar(250)", nullable: true),
                    IsInclude = table.Column<bool>(type: "bit", nullable: true),
                    DeductedFromExpense = table.Column<bool>(type: "bit", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserName = table.Column<string>(type: "varchar(50)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedUserName = table.Column<string>(type: "varchar(50)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incomes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Strings_tbl",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StringCode = table.Column<string>(type: "varchar(50)", nullable: true),
                    StringValue = table.Column<string>(type: "varchar(50)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedUserName = table.Column<string>(type: "varchar(50)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedUserName = table.Column<string>(type: "varchar(50)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Strings_tbl", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WaitingApprove_PersonId",
                table: "WaitingApprove",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Sites_AddressId",
                table: "Sites",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Sites_ManagerId",
                table: "Sites",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Sites_SiteId",
                table: "Sites",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonVehicles_Id",
                table: "PersonVehicles",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_PersonVehicles_PersonId",
                table: "PersonVehicles",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_AddressId",
                table: "Persons",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_CommunicationId",
                table: "Persons",
                column: "CommunicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_IdentityInformationId",
                table: "Persons",
                column: "IdentityInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_PersonId",
                table: "Persons",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_PersonType",
                table: "Persons",
                column: "PersonType");

            migrationBuilder.CreateIndex(
                name: "IX_PersonIdentityInformations_Id",
                table: "PersonIdentityInformations",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_PersonIdentityInformations_IdentityInformationId",
                table: "PersonIdentityInformations",
                column: "IdentityInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonDetails_Id",
                table: "PersonDetails",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_PersonDetails_PersonId",
                table: "PersonDetails",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonCommunications_CommunicationId",
                table: "PersonCommunications",
                column: "CommunicationId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonCommunications_Id",
                table: "PersonCommunications",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_PersonApartments_ApartmentId",
                table: "PersonApartments",
                column: "ApartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonApartments_PersonId",
                table: "PersonApartments",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Meeting_MeetingDate",
                table: "Meeting",
                column: "MeetingDate");

            migrationBuilder.CreateIndex(
                name: "IX_Meeting_Status",
                table: "Meeting",
                column: "Status");

            migrationBuilder.CreateIndex(
                name: "IX_JobToDo_EmployeeId",
                table: "JobToDo",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesBankInfo_EmployeeId",
                table: "EmployeesBankInfo",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeId",
                table: "Employees",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PersonId",
                table: "Employees",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_ApartmentId",
                table: "Apartments",
                column: "ApartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_SiteId",
                table: "Apartments",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_AddressId",
                table: "Addresses",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentGroups_GroupCode",
                table: "ApartmentGroups",
                column: "GroupCode");

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentTypes_GroupCode",
                table: "ApartmentTypes",
                column: "GroupCode");

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentTypes_TypeCode",
                table: "ApartmentTypes",
                column: "TypeCode");

            migrationBuilder.CreateIndex(
                name: "IX_Authorities_AuthType",
                table: "Authorities",
                column: "AuthType");

            migrationBuilder.CreateIndex(
                name: "IX_Authorities_PersonId",
                table: "Authorities",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Expense_ExpenseCode",
                table: "Expense",
                column: "ExpenseCode");

            migrationBuilder.CreateIndex(
                name: "IX_Expense_Id",
                table: "Expense",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseGroup_GroupCode",
                table: "ExpenseGroup",
                column: "GroupCode");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralAccounts_AccountCode",
                table: "GeneralAccounts",
                column: "AccountCode");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralAccounts_Id",
                table: "GeneralAccounts",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_IncomeGroups_GroupCode",
                table: "IncomeGroups",
                column: "GroupCode");

            migrationBuilder.CreateIndex(
                name: "IX_Incomes_Id",
                table: "Incomes",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Incomes_IncomeCode",
                table: "Incomes",
                column: "IncomeCode");

            migrationBuilder.CreateIndex(
                name: "IX_Strings_tbl_StringCode",
                table: "Strings_tbl",
                column: "StringCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApartmentGroups");

            migrationBuilder.DropTable(
                name: "ApartmentTypes");

            migrationBuilder.DropTable(
                name: "Authorities");

            migrationBuilder.DropTable(
                name: "BankCases");

            migrationBuilder.DropTable(
                name: "Expense");

            migrationBuilder.DropTable(
                name: "ExpenseGroup");

            migrationBuilder.DropTable(
                name: "GeneralAccounts");

            migrationBuilder.DropTable(
                name: "IncomeGroups");

            migrationBuilder.DropTable(
                name: "Incomes");

            migrationBuilder.DropTable(
                name: "Strings_tbl");

            migrationBuilder.DropIndex(
                name: "IX_WaitingApprove_PersonId",
                table: "WaitingApprove");

            migrationBuilder.DropIndex(
                name: "IX_Sites_AddressId",
                table: "Sites");

            migrationBuilder.DropIndex(
                name: "IX_Sites_ManagerId",
                table: "Sites");

            migrationBuilder.DropIndex(
                name: "IX_Sites_SiteId",
                table: "Sites");

            migrationBuilder.DropIndex(
                name: "IX_PersonVehicles_Id",
                table: "PersonVehicles");

            migrationBuilder.DropIndex(
                name: "IX_PersonVehicles_PersonId",
                table: "PersonVehicles");

            migrationBuilder.DropIndex(
                name: "IX_Persons_AddressId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_CommunicationId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_IdentityInformationId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_PersonId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_PersonType",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_PersonIdentityInformations_Id",
                table: "PersonIdentityInformations");

            migrationBuilder.DropIndex(
                name: "IX_PersonIdentityInformations_IdentityInformationId",
                table: "PersonIdentityInformations");

            migrationBuilder.DropIndex(
                name: "IX_PersonDetails_Id",
                table: "PersonDetails");

            migrationBuilder.DropIndex(
                name: "IX_PersonDetails_PersonId",
                table: "PersonDetails");

            migrationBuilder.DropIndex(
                name: "IX_PersonCommunications_CommunicationId",
                table: "PersonCommunications");

            migrationBuilder.DropIndex(
                name: "IX_PersonCommunications_Id",
                table: "PersonCommunications");

            migrationBuilder.DropIndex(
                name: "IX_PersonApartments_ApartmentId",
                table: "PersonApartments");

            migrationBuilder.DropIndex(
                name: "IX_PersonApartments_PersonId",
                table: "PersonApartments");

            migrationBuilder.DropIndex(
                name: "IX_Meeting_MeetingDate",
                table: "Meeting");

            migrationBuilder.DropIndex(
                name: "IX_Meeting_Status",
                table: "Meeting");

            migrationBuilder.DropIndex(
                name: "IX_JobToDo_EmployeeId",
                table: "JobToDo");

            migrationBuilder.DropIndex(
                name: "IX_EmployeesBankInfo_EmployeeId",
                table: "EmployeesBankInfo");

            migrationBuilder.DropIndex(
                name: "IX_Employees_EmployeeId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_PersonId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Apartments_ApartmentId",
                table: "Apartments");

            migrationBuilder.DropIndex(
                name: "IX_Apartments_SiteId",
                table: "Apartments");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_AddressId",
                table: "Addresses");
        }
    }
}
