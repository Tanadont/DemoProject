using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoProject.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MasProject",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MdimDimensionId = table.Column<int>(type: "int", nullable: false),
                    MdcDiscountId = table.Column<int>(type: "int", nullable: false),
                    MbrBrandId = table.Column<int>(type: "int", nullable: false),
                    MznZoneId = table.Column<int>(type: "int", nullable: false),
                    MpsStatusId = table.Column<int>(type: "int", nullable: false),
                    MpvProvinceId = table.Column<int>(type: "int", nullable: false),
                    MdtDistrictId = table.Column<int>(type: "int", nullable: false),
                    MsdSubdistrictId = table.Column<int>(type: "int", nullable: false),
                    MpcPostalCodeId = table.Column<int>(type: "int", nullable: false),
                    MvtVatId = table.Column<int>(type: "int", nullable: false),
                    ProjectCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectNameTh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectNameEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JuristicName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JuristicNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsVat = table.Column<bool>(type: "bit", nullable: true),
                    Fund = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityDeposite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PettyCashBudget = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UtilityDeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LineId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalesArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TranferredArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RemainedArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TranferredUnit = table.Column<int>(type: "int", nullable: false),
                    TotalShop = table.Column<int>(type: "int", nullable: true),
                    DeveloperRatio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JuristicRatio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoOfBuildings = table.Column<int>(type: "int", nullable: true),
                    NoOfFloors = table.Column<int>(type: "int", nullable: true),
                    NoOfRooms = table.Column<int>(type: "int", nullable: true),
                    CommonArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParkingLotsAvailability = table.Column<int>(type: "int", nullable: true),
                    ParkingLotsLimit = table.Column<int>(type: "int", nullable: true),
                    NoOfParkingFloors = table.Column<int>(type: "int", nullable: true),
                    ParkingFloor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoOfServiceLifts = table.Column<int>(type: "int", nullable: true),
                    NoOfPassengerLifts = table.Column<int>(type: "int", nullable: true),
                    CommonFeeRate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillPayment = table.Column<bool>(type: "bit", nullable: true),
                    CrossBank = table.Column<bool>(type: "bit", nullable: true),
                    WaterRate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WaterUnitAvg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    McfCommonFeePeriodId = table.Column<int>(type: "int", nullable: true),
                    CommonFeeStartDay = table.Column<int>(type: "int", nullable: true),
                    CommonFeeStartMonth = table.Column<int>(type: "int", nullable: true),
                    ManageStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ManageEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeveloper = table.Column<bool>(type: "bit", nullable: true),
                    TotalUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RatioUpdatedMonth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RatioUpdatedYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsBackupPowerSystem = table.Column<bool>(type: "bit", nullable: true),
                    IsWaterSupplySystem = table.Column<bool>(type: "bit", nullable: true),
                    IsTvSystem = table.Column<bool>(type: "bit", nullable: true),
                    IsFireSystem = table.Column<bool>(type: "bit", nullable: true),
                    CctvSystem = table.Column<int>(type: "int", nullable: true),
                    TelSystem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDuedate = table.Column<bool>(type: "bit", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    FirstTransferDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AmountDebit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApCustomerId = table.Column<int>(type: "int", nullable: false),
                    CrmDataFlg = table.Column<int>(type: "int", nullable: false),
                    RatioDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DiscountDuedate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FirstCommonFeeId = table.Column<int>(type: "int", nullable: true),
                    GenbarcodeTypeId = table.Column<int>(type: "int", nullable: true),
                    InvRemark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvRemarkEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalAreaSiteService = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TranferredAreaSiteService = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WaterMeterMaintainRate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WaterTreatmentRate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommonAreaAmount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Barcode = table.Column<bool>(type: "bit", nullable: true),
                    ClosedFlg = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasProject", x => x.ProjectId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MasProject");
        }
    }
}
