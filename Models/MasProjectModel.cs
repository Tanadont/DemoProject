﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoProject.Models
{
    public class MasProjectModel
    {
        public int ProjectId { get; set; }
        public int MdimDimensionId { get; set; }
        public int MdcDiscountId { get; set; }
        public int MbrBrandId { get; set; }
        public int MznZoneId { get; set; }
        public int MpsStatusId { get; set; }
        public int MpvProvinceId { get; set; }
        public int MdtDistrictId { get; set; }
        public int MsdSubdistrictId { get; set; }
        public int MpcPostalCodeId { get; set; }
        public int MvtVatId { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectNameTh { get; set; }
        public string ProjectNameEn { get; set; }
        public string JuristicName { get; set; }
        public string JuristicNumber { get; set; }
        public bool? IsVat { get; set; }
        public decimal? Fund { get; set; }
        public decimal? SecurityDeposite { get; set; }
        public decimal PettyCashBudget { get; set; }
        public DateTime? UtilityDeliveryDate { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string LineId { get; set; }
        public string Tax { get; set; }
        public decimal SalesArea { get; set; }
        public decimal TotalArea { get; set; }
        public decimal TranferredArea { get; set; }
        public decimal RemainedArea { get; set; }
        public int TranferredUnit { get; set; }
        public int? TotalShop { get; set; }
        public decimal DeveloperRatio { get; set; }
        public decimal JuristicRatio { get; set; }
        public int? NoOfBuildings { get; set; }
        public int? NoOfFloors { get; set; }
        public int? NoOfRooms { get; set; }
        public decimal CommonArea { get; set; }
        public int? ParkingLotsAvailability { get; set; }
        public int? ParkingLotsLimit { get; set; }
        public int? NoOfParkingFloors { get; set; }
        public string ParkingFloor { get; set; }
        public int? NoOfServiceLifts { get; set; }
        public int? NoOfPassengerLifts { get; set; }
        public decimal CommonFeeRate { get; set; }
        public bool? BillPayment { get; set; }
        public bool? CrossBank { get; set; }
        public decimal WaterRate { get; set; }
        public decimal WaterUnitAvg { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public bool? IsActive { get; set; }
        public int? McfCommonFeePeriodId { get; set; }
        public int? CommonFeeStartDay { get; set; }
        public int? CommonFeeStartMonth { get; set; }
        public DateTime? ManageStartDate { get; set; }
        public DateTime? ManageEndDate { get; set; }
        public bool? IsDeveloper { get; set; }
        public decimal? TotalUnit { get; set; }
        public string RatioUpdatedMonth { get; set; }
        public string RatioUpdatedYear { get; set; }
        public bool? IsBackupPowerSystem { get; set; }
        public bool? IsWaterSupplySystem { get; set; }
        public bool? IsTvSystem { get; set; }
        public bool? IsFireSystem { get; set; }
        public int? CctvSystem { get; set; }
        public string TelSystem { get; set; }
        public bool? IsDuedate { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? FirstTransferDate { get; set; }
        public decimal? AmountDebit { get; set; }
        public int ApCustomerId { get; set; }
        public int CrmDataFlg { get; set; }
        public DateTime? RatioDate { get; set; }
        public DateTime? DiscountDuedate { get; set; }
        public int? FirstCommonFeeId { get; set; }
        public int? GenbarcodeTypeId { get; set; }
        public string InvRemark { get; set; }
        public string InvRemarkEn { get; set; }
        public decimal? TotalAreaSiteService { get; set; }
        public decimal? TranferredAreaSiteService { get; set; }
        public decimal? WaterMeterMaintainRate { get; set; }
        public decimal? WaterTreatmentRate { get; set; }
        public decimal? CommonAreaAmount { get; set; }
        public bool? Barcode { get; set; }
        public int? ClosedFlg { get; set; }
    }
}
