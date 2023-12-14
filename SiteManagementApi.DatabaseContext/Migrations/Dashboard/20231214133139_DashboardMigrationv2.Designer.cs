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
    [Migration("20231214133139_DashboardMigrationv2")]
    partial class DashboardMigrationv2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("varchar(30)");

                    b.Property<int>("PersonType")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("UpdatedUserName")
                        .HasColumnType("varchar(50)");

                    b.HasKey("PersonId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("SiteManagementApi.Entities.Entities.PersonAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<Guid>("AddressId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CityCode")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("CountryCode")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedUserName")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("DistrictCode")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Quarter")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("UpdatedUserName")
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("PersonAddresses");
                });

            modelBuilder.Entity("SiteManagementApi.Entities.Entities.PersonCommunication", b =>
                {
                    b.Property<Guid>("PersonCommunicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Communication")
                        .HasColumnType("varchar(50)");

                    b.Property<Guid>("CommunicationId")
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

                    b.Property<string>("FatherName")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("HomeTown")
                        .HasColumnType("varchar(30)");

                    b.Property<Guid>("IdentityInformationId")
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

            modelBuilder.Entity("SiteManagementApi.Entities.Entities.Site.Site", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<Guid>("AddressId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ManagerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(100)");

                    b.Property<Guid>("SiteId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Sites");
                });
#pragma warning restore 612, 618
        }
    }
}
