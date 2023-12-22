﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SiteManagementApi.Data.Context;

#nullable disable

namespace SiteManagementApi.Data.Migrations.Dashboard
{
    [DbContext(typeof(DashboardContext))]
    [Migration("20231219114833_CityAndDistrictMigr")]
    partial class CityAndDistrictMigr
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SiteManagementApi.Entities.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<Guid?>("AddressId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CityCode")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("CountryCode")
                        .HasColumnType("varchar(10)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedUserName")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("DistrictCode")
                        .HasColumnType("varchar(10)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("OpenAddress")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Quarter")
                        .HasColumnType("varchar(30)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("UpdatedUserName")
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("SiteManagementApi.Entities.Entities.Core.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CityCode")
                        .HasColumnType("int");

                    b.Property<string>("CityName")
                        .HasColumnType("varchar(50)");

                    b.Property<int>("IsActive")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("SiteManagementApi.Entities.Entities.Core.District", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CityCode")
                        .HasColumnType("int");

                    b.Property<int>("DistrictCode")
                        .HasColumnType("int");

                    b.Property<string>("DistrictName")
                        .HasColumnType("varchar(50)");

                    b.Property<int>("IsActive")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Districts");
                });

            modelBuilder.Entity("SiteManagementApi.Entities.Entities.Core.LogError", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ErrorMessage")
                        .HasColumnType("varchar(350)");

                    b.Property<string>("ErrorMethod")
                        .HasColumnType("varchar(250)");

                    b.Property<DateTime?>("ErrorTime")
                        .HasColumnType("datetime");

                    b.Property<string>("UserCode")
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("LogErrors");
                });

            modelBuilder.Entity("SiteManagementApi.Entities.Entities.Core.Parameter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedUserName")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("GroupCode")
                        .HasColumnType("varchar(50)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("ParameterCode")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ParameterValue")
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("UpdatedUserName")
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Parameters_Tbl");
                });

            modelBuilder.Entity("SiteManagementApi.Entities.Entities.Menu.MenuItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Icon")
                        .HasColumnType("varchar(50)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsVisible")
                        .HasColumnType("bit");

                    b.Property<int>("ItemId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("LastUpdatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("LastUpdatedUserName")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("StringId")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("URL")
                        .HasColumnType("varchar(150)");

                    b.HasKey("Id");

                    b.ToTable("MenuItem");
                });

            modelBuilder.Entity("SiteManagementApi.Entities.Entities.Menu.MenuItemHierarchy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ItemId")
                        .HasColumnType("integer");

                    b.Property<int>("ItemOrder")
                        .HasColumnType("integer");

                    b.Property<int>("ParentId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("MenuItemHierarchy");
                });

            modelBuilder.Entity("SiteManagementApi.Entities.Entities.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonId"));

                    b.Property<Guid?>("AddressId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CommunicationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedUserName")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("FirstName")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("FullName")
                        .HasColumnType("varchar(60)");

                    b.Property<Guid?>("IdentityInformationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("IsActive")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("varchar(30)");

                    b.Property<int?>("PersonType")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("UpdatedUserName")
                        .HasColumnType("varchar(50)");

                    b.HasKey("PersonId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("SiteManagementApi.Entities.Entities.PersonCommunication", b =>
                {
                    b.Property<Guid?>("PersonCommunicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Communication")
                        .HasColumnType("varchar(100)");

                    b.Property<Guid?>("CommunicationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("CommunicationType")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedUserName")
                        .HasColumnType("varchar(50)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsPrimary")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("UpdatedUserName")
                        .HasColumnType("varchar(50)");

                    b.HasKey("PersonCommunicationId");

                    b.ToTable("PersonCommunications");
                });

            modelBuilder.Entity("SiteManagementApi.Entities.Entities.PersonDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CardNumber")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(2000)");

                    b.Property<int?>("EducationType")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .HasColumnType("char(1)");

                    b.Property<int?>("JobDescriptionId")
                        .HasColumnType("int");

                    b.Property<bool?>("MartyrVeteranRelative")
                        .HasColumnType("bit");

                    b.Property<int?>("PersonId")
                        .HasColumnType("int");

                    b.Property<int?>("PetType")
                        .HasColumnType("int");

                    b.Property<bool?>("PrivateInsurance")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("PersonDetails");
                });

            modelBuilder.Entity("SiteManagementApi.Entities.Entities.PersonIdentityInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime");

                    b.Property<string>("BirthPlace")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("BloodType")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("FatherName")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("HomeTown")
                        .HasColumnType("varchar(30)");

                    b.Property<Guid?>("IdentityInformationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long?>("IdentityNumber")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("MaritalDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("MaritalStatus")
                        .HasColumnType("int");

                    b.Property<string>("MotherName")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Nationality")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("OrderNumber")
                        .HasColumnType("varchar(30)");

                    b.Property<long?>("PassportNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("SerialNumber")
                        .HasColumnType("varchar(30)");

                    b.Property<long?>("TaxNumber")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("PersonIdentityInformations");
                });

            modelBuilder.Entity("SiteManagementApi.Entities.Entities.Persons.PersonApartment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<Guid?>("ApartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BankPaymentCode")
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedUserName")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(2000)");

                    b.Property<DateTime?>("EntryDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("Ownership")
                        .HasColumnType("int");

                    b.Property<int?>("PersonId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("QuitDate")
                        .HasColumnType("datetime");

                    b.Property<string>("RelatedPerson")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("UpdatedUserName")
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("PersonApartments");
                });

            modelBuilder.Entity("SiteManagementApi.Entities.Entities.Persons.PersonVehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Color")
                        .HasColumnType("varchar(30)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Model")
                        .HasColumnType("varchar(30)");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("Plate")
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.ToTable("PersonVehicles");
                });

            modelBuilder.Entity("SiteManagementApi.Entities.Entities.Persons.WaitingApprovePerson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedUserName")
                        .HasColumnType("varchar(30)");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("WaitingApprove");
                });

            modelBuilder.Entity("SiteManagementApi.Entities.Entities.Site.Apartment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<Guid?>("AddressId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ApartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ApartmentType")
                        .HasColumnType("int");

                    b.Property<int>("Aspect")
                        .HasColumnType("int");

                    b.Property<string>("Block")
                        .HasColumnType("varchar(30)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedUserName")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("DoorNumber")
                        .HasColumnType("varchar(30)");

                    b.Property<decimal>("Dues")
                        .HasColumnType("decimal(15,2)");

                    b.Property<int>("FloorNumber")
                        .HasColumnType("int");

                    b.Property<decimal>("Gross")
                        .HasColumnType("decimal(15,2)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<decimal>("LandShare")
                        .HasColumnType("decimal(15,2)");

                    b.Property<decimal>("Net")
                        .HasColumnType("decimal(15,2)");

                    b.Property<string>("ParkingSpaceNumber")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("RoomCount")
                        .HasColumnType("varchar(30)");

                    b.Property<Guid?>("SiteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Statu")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("UpdatedUserName")
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Apartments");
                });

            modelBuilder.Entity("SiteManagementApi.Entities.Entities.Site.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<string>("Company")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(2000)");

                    b.Property<string>("MealCard")
                        .HasColumnType("varchar(30)");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("Position")
                        .HasColumnType("varchar(30)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("SiteManagementApi.Entities.Entities.Site.EmployeeBankInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AccountNumber")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Bank")
                        .HasColumnType("varchar(50)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("IBAN")
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.ToTable("EmployeesBankInfo");
                });

            modelBuilder.Entity("SiteManagementApi.Entities.Entities.Site.JobToDo", b =>
                {
                    b.Property<int>("JobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JobId"));

                    b.Property<string>("Description")
                        .HasColumnType("varchar(1000)");

                    b.Property<bool>("EmailAlert")
                        .HasColumnType("bit");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime");

                    b.Property<string>("JobTitle")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Location")
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<bool>("PushAlert")
                        .HasColumnType("bit");

                    b.Property<int>("Renew")
                        .HasColumnType("int");

                    b.Property<DateTime>("RenewalEndDate")
                        .HasColumnType("datetime");

                    b.Property<bool>("SmsAlert")
                        .HasColumnType("bit");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("JobId");

                    b.ToTable("JobToDo");
                });

            modelBuilder.Entity("SiteManagementApi.Entities.Entities.Site.Meeting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Attachment")
                        .HasColumnType("varchar(200)");

                    b.Property<int>("AttendenceId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Location")
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("MeetingDate")
                        .HasColumnType("datetime");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Subject")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Summary")
                        .HasColumnType("varchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Meeting");
                });

            modelBuilder.Entity("SiteManagementApi.Entities.Entities.Site.Site", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<Guid?>("AddressId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedUserName")
                        .HasColumnType("varchar(50)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("ManagerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(100)");

                    b.Property<Guid?>("SiteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("UpdatedUserName")
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Sites");
                });
#pragma warning restore 612, 618
        }
    }
}
