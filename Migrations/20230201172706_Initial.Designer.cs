﻿// <auto-generated />
using System;
using DemoProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DemoProject.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230201172706_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DemoProject.Models.MasProjectModel", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjectId"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AmountDebit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ApCustomerId")
                        .HasColumnType("int");

                    b.Property<bool?>("Barcode")
                        .HasColumnType("bit");

                    b.Property<bool?>("BillPayment")
                        .HasColumnType("bit");

                    b.Property<int?>("CctvSystem")
                        .HasColumnType("int");

                    b.Property<int?>("ClosedFlg")
                        .HasColumnType("int");

                    b.Property<string>("CommonArea")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommonAreaAmount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommonFeeRate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CommonFeeStartDay")
                        .HasColumnType("int");

                    b.Property<int?>("CommonFeeStartMonth")
                        .HasColumnType("int");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CrmDataFlg")
                        .HasColumnType("int");

                    b.Property<bool?>("CrossBank")
                        .HasColumnType("bit");

                    b.Property<string>("DeveloperRatio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DiscountDuedate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fax")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FirstCommonFeeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FirstTransferDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Fund")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GenbarcodeTypeId")
                        .HasColumnType("int");

                    b.Property<string>("InvRemark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InvRemarkEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsBackupPowerSystem")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDeveloper")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDuedate")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsFireSystem")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsTvSystem")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsVat")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsWaterSupplySystem")
                        .HasColumnType("bit");

                    b.Property<string>("JuristicName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JuristicNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JuristicRatio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LineId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ManageEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ManageStartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MbrBrandId")
                        .HasColumnType("int");

                    b.Property<int?>("McfCommonFeePeriodId")
                        .HasColumnType("int");

                    b.Property<int>("MdcDiscountId")
                        .HasColumnType("int");

                    b.Property<int>("MdimDimensionId")
                        .HasColumnType("int");

                    b.Property<int>("MdtDistrictId")
                        .HasColumnType("int");

                    b.Property<int>("MpcPostalCodeId")
                        .HasColumnType("int");

                    b.Property<int>("MpsStatusId")
                        .HasColumnType("int");

                    b.Property<int>("MpvProvinceId")
                        .HasColumnType("int");

                    b.Property<int>("MsdSubdistrictId")
                        .HasColumnType("int");

                    b.Property<int>("MvtVatId")
                        .HasColumnType("int");

                    b.Property<int>("MznZoneId")
                        .HasColumnType("int");

                    b.Property<int?>("NoOfBuildings")
                        .HasColumnType("int");

                    b.Property<int?>("NoOfFloors")
                        .HasColumnType("int");

                    b.Property<int?>("NoOfParkingFloors")
                        .HasColumnType("int");

                    b.Property<int?>("NoOfPassengerLifts")
                        .HasColumnType("int");

                    b.Property<int?>("NoOfRooms")
                        .HasColumnType("int");

                    b.Property<int?>("NoOfServiceLifts")
                        .HasColumnType("int");

                    b.Property<string>("ParkingFloor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParkingLotsAvailability")
                        .HasColumnType("int");

                    b.Property<int?>("ParkingLotsLimit")
                        .HasColumnType("int");

                    b.Property<string>("PettyCashBudget")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectNameEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectNameTh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RatioDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RatioUpdatedMonth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RatioUpdatedYear")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RemainedArea")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SalesArea")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityDeposite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tax")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelSystem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TotalArea")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TotalAreaSiteService")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TotalShop")
                        .HasColumnType("int");

                    b.Property<string>("TotalUnit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TranferredArea")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TranferredAreaSiteService")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TranferredUnit")
                        .HasColumnType("int");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UtilityDeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("WaterMeterMaintainRate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WaterRate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WaterTreatmentRate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WaterUnitAvg")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjectId");

                    b.ToTable("MasProject");
                });
#pragma warning restore 612, 618
        }
    }
}