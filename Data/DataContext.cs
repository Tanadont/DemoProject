using System.Collections.Generic;
using DemoProject.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoProject.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }
        
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<MasProjectModel>(entity =>
            {
                entity.HasKey(e => e.ProjectId)
                    .HasName("mas_project_PK");

                entity.ToTable("mas_project");

                entity.HasIndex(e => e.MdimDimensionId, "mas_project_mdim_dimension_id_IDX")
                    .HasFillFactor((byte)100);

                entity.HasIndex(e => e.MpsStatusId, "mas_project_mps_status_id_IDX")
                    .HasFillFactor((byte)100);

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("address")
                    .HasComment("Thai_CI_AS");

                entity.Property(e => e.AmountDebit)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("amount_debit");

                entity.Property(e => e.ApCustomerId).HasColumnName("ap_customer_id");

                entity.Property(e => e.Barcode)
                    .HasColumnName("barcode")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BillPayment).HasColumnName("bill_payment");

                entity.Property(e => e.CctvSystem).HasColumnName("cctv_system");

                entity.Property(e => e.ClosedFlg)
                    .HasColumnName("closed_flg")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CommonArea)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("common_area");

                entity.Property(e => e.CommonAreaAmount)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("common_area_amount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CommonFeeRate)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("common_fee_rate");

                entity.Property(e => e.CommonFeeStartDay).HasColumnName("common_fee_start_day");

                entity.Property(e => e.CommonFeeStartMonth).HasColumnName("common_fee_start_month");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date");

                entity.Property(e => e.CrmDataFlg).HasColumnName("crm_data_flg");

                entity.Property(e => e.CrossBank).HasColumnName("cross_bank");

                entity.Property(e => e.DeveloperRatio)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("developer_ratio");

                entity.Property(e => e.DiscountDuedate)
                    .HasColumnType("date")
                    .HasColumnName("discount_duedate");

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fax");

                entity.Property(e => e.FirstCommonFeeId).HasColumnName("first_common_fee_id");

                entity.Property(e => e.FirstTransferDate)
                    .HasColumnType("datetime")
                    .HasColumnName("first_transfer_date");

                entity.Property(e => e.Fund)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("fund");

                entity.Property(e => e.GenbarcodeTypeId).HasColumnName("genbarcode_type_id");

                entity.Property(e => e.InvRemark)
                    .HasMaxLength(1000)
                    .HasColumnName("inv_remark")
                    .HasComment("Thai_CI_AS");

                entity.Property(e => e.InvRemarkEn)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("inv_remark_en");

                entity.Property(e => e.IsActive)
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsBackupPowerSystem).HasColumnName("is_backup_power_system");

                entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");

                entity.Property(e => e.IsDeveloper).HasColumnName("is_developer");

                entity.Property(e => e.IsDuedate).HasColumnName("is_duedate");

                entity.Property(e => e.IsFireSystem).HasColumnName("is_fire_system");

                entity.Property(e => e.IsTvSystem).HasColumnName("is_tv_system");

                entity.Property(e => e.IsVat)
                    .HasColumnName("is_vat")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsWaterSupplySystem).HasColumnName("is_water_supply_system");

                entity.Property(e => e.JuristicName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("juristic_name")
                    .HasComment("Thai_CI_AS");

                entity.Property(e => e.JuristicNumber)
                    .IsRequired()
                    .HasMaxLength(13)
                    .HasColumnName("juristic_number");

                entity.Property(e => e.JuristicRatio)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("juristic_ratio");

                entity.Property(e => e.LineId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("lineID");

                entity.Property(e => e.ManageEndDate)
                    .HasColumnType("date")
                    .HasColumnName("manage_end_date");

                entity.Property(e => e.ManageStartDate)
                    .HasColumnType("date")
                    .HasColumnName("manage_start_date");

                entity.Property(e => e.MbrBrandId).HasColumnName("mbr_brand_id");

                entity.Property(e => e.McfCommonFeePeriodId).HasColumnName("mcf_common_fee_period_id");

                entity.Property(e => e.MdcDiscountId).HasColumnName("mdc_discount_id");

                entity.Property(e => e.MdimDimensionId).HasColumnName("mdim_dimension_id");

                entity.Property(e => e.MdtDistrictId).HasColumnName("mdt_district_id");

                entity.Property(e => e.MpcPostalCodeId).HasColumnName("mpc_postal_code_id");

                entity.Property(e => e.MpsStatusId).HasColumnName("mps_status_id");

                entity.Property(e => e.MpvProvinceId).HasColumnName("mpv_province_id");

                entity.Property(e => e.MsdSubdistrictId).HasColumnName("msd_subdistrict_id");

                entity.Property(e => e.MvtVatId).HasColumnName("mvt_vat_id");

                entity.Property(e => e.MznZoneId).HasColumnName("mzn_zone_id");

                entity.Property(e => e.NoOfBuildings).HasColumnName("no_of_buildings");

                entity.Property(e => e.NoOfFloors).HasColumnName("no_of_floors");

                entity.Property(e => e.NoOfParkingFloors).HasColumnName("no_of_parking_floors");

                entity.Property(e => e.NoOfPassengerLifts).HasColumnName("no_of_passenger_lifts");

                entity.Property(e => e.NoOfRooms).HasColumnName("no_of_rooms");

                entity.Property(e => e.NoOfServiceLifts).HasColumnName("no_of_service_lifts");

                entity.Property(e => e.ParkingFloor)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("parking_floor");

                entity.Property(e => e.ParkingLotsAvailability).HasColumnName("parking_lots_availability");

                entity.Property(e => e.ParkingLotsLimit).HasColumnName("parking_lots_limit");

                entity.Property(e => e.PettyCashBudget)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("petty_cash_budget");

                entity.Property(e => e.ProjectCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("project_code")
                    .HasComment("Thai_CI_AS");

                entity.Property(e => e.ProjectNameEn)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("project_name_en")
                    .HasComment("Thai_CI_AS");

                entity.Property(e => e.ProjectNameTh)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("project_name_th")
                    .HasComment("Thai_CI_AS");

                entity.Property(e => e.RatioDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ratio_date");

                entity.Property(e => e.RatioUpdatedMonth)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ratio_updated_month")
                    .HasComment("Thai_CI_AS");

                entity.Property(e => e.RatioUpdatedYear)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ratio_updated_year")
                    .HasComment("Thai_CI_AS");

                entity.Property(e => e.RemainedArea)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("remained_area");

                entity.Property(e => e.SalesArea)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("sales_area");

                entity.Property(e => e.SecurityDeposite)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("security_deposite");

                entity.Property(e => e.Tax)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("tax");

                entity.Property(e => e.TelSystem)
                    .HasMaxLength(100)
                    .HasColumnName("tel_system")
                    .HasComment("Thai_CI_AS");

                entity.Property(e => e.Telephone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("telephone");

                entity.Property(e => e.TotalArea)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("total_area");

                entity.Property(e => e.TotalAreaSiteService)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("total_area_site_service");

                entity.Property(e => e.TotalShop).HasColumnName("total_shop");

                entity.Property(e => e.TotalUnit)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("total_unit");

                entity.Property(e => e.TranferredArea)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("tranferred_area");

                entity.Property(e => e.TranferredAreaSiteService)
                    .HasColumnType("decimal(11, 2)")
                    .HasColumnName("tranferred_area_site_service");

                entity.Property(e => e.TranferredUnit).HasColumnName("tranferred_unit");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_date");

                entity.Property(e => e.UtilityDeliveryDate)
                    .HasColumnType("date")
                    .HasColumnName("utility_delivery_date");

                entity.Property(e => e.WaterMeterMaintainRate)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("water_meter_maintain_rate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WaterRate)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("water_rate");

                entity.Property(e => e.WaterTreatmentRate)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("water_treatment_rate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WaterUnitAvg)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("water_unit_avg");
            });
        }
        public DbSet<MasProjectModel> MasProject { get; set; }
    }
}
