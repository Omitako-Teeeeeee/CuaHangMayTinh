using System;
using System.Collections.Generic;

namespace CuaHangMayTinh.Models
{
    /// <summary>
    /// Model thống nhất cho tất cả các báo cáo
    /// </summary>
    public class ReportModel
    {
        #region COMMON PROPERTIES (Tất cả báo cáo)

        public int ReportType { get; set; } // 1: Tồn kho, 2: Bán chạy, 3: Doanh thu
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string ReportTitle { get; set; }
        public DateTime GeneratedDate { get; set; } = DateTime.Now;

        #endregion

        #region INVENTORY REPORT PROPERTIES (Báo cáo tồn kho)

        public int? CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int? MinStock { get; set; }
        public int? MaxStock { get; set; }

        // Tổng quan tồn kho
        public int TotalProducts { get; set; }
        public int OutOfStockCount { get; set; }
        public int LowStockCount { get; set; }
        public decimal TotalInventoryValue { get; set; }

        #endregion

        #region BEST SELLERS REPORT PROPERTIES (Báo cáo bán chạy)

        public int TopCount { get; set; } = 10;
        public string SortBy { get; set; } = "Quantity"; // Quantity or Revenue

        #endregion

        #region REVENUE REPORT PROPERTIES (Báo cáo doanh thu)

        public string GroupBy { get; set; } = "Month"; // Day, Month, Quarter, Year
        public int? EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int? CustomerId { get; set; }
        public string CustomerName { get; set; }

        // Tổng quan doanh thu
        public int TotalInvoices { get; set; }
        public decimal TotalRevenue { get; set; }
        public decimal TotalPayment { get; set; }
        public decimal AverageInvoiceValue { get; set; }
        public int TotalProductsSold { get; set; }
        public int TotalCustomers { get; set; }

        #endregion

        #region REPORT DATA (Dữ liệu báo cáo)

        // Dữ liệu chi tiết của báo cáo
        public object ReportData { get; set; }

        // Các thuộc tính hỗ trợ binding
        public bool HasData
        {
            get { return ReportData != null; }
        }

        public string DateRange
        {
            get { return $"{FromDate:dd/MM/yyyy} - {ToDate:dd/MM/yyyy}"; }
        }

        public string ReportTypeName
        {
            get { return GetReportTypeName(); }
        }

        #endregion

        #region CONSTRUCTORS

        public ReportModel() { }

        public ReportModel(int reportType, DateTime fromDate, DateTime toDate)
        {
            ReportType = reportType;
            FromDate = fromDate;
            ToDate = toDate;
            ReportTitle = GetReportTypeName();
        }

        public ReportModel(int reportType, DateTime fromDate, DateTime toDate,
                          int? categoryId, int? minStock, int? maxStock)
            : this(reportType, fromDate, toDate)
        {
            CategoryId = categoryId;
            MinStock = minStock;
            MaxStock = maxStock;
        }

        public ReportModel(int reportType, DateTime fromDate, DateTime toDate,
                          int topCount, string sortBy)
            : this(reportType, fromDate, toDate)
        {
            TopCount = topCount;
            SortBy = sortBy;
        }

        public ReportModel(int reportType, DateTime fromDate, DateTime toDate,
                          string groupBy, int? employeeId, int? customerId)
            : this(reportType, fromDate, toDate)
        {
            GroupBy = groupBy;
            EmployeeId = employeeId;
            CustomerId = customerId;
        }

        #endregion

        #region HELPER METHODS

        private string GetReportTypeName()
        {
            switch (ReportType)
            {
                case 1:
                    return "BÁO CÁO TỒN KHO";
                case 2:
                    return "BÁO CÁO SẢN PHẨM BÁN CHẠY";
                case 3:
                    return "BÁO CÁO DOANH THU";
                default:
                    return "BÁO CÁO";
            }
        }

        public string GetFilterSummary()
        {
            switch (ReportType)
            {
                case 1:
                    return GetInventoryFilterSummary();
                case 2:
                    return GetBestSellersFilterSummary();
                case 3:
                    return GetRevenueFilterSummary();
                default:
                    return "Không có bộ lọc";
            }
        }

        private string GetInventoryFilterSummary()
        {
            var filters = new List<string>();

            if (CategoryId.HasValue && CategoryId > 0)
                filters.Add($"Danh mục: {CategoryName}");

            if (MinStock.HasValue)
                filters.Add($"Tồn tối thiểu: {MinStock}");

            if (MaxStock.HasValue && MaxStock < int.MaxValue)
                filters.Add($"Tồn tối đa: {MaxStock}");

            if (filters.Count > 0)
                return string.Join(" | ", filters);
            else
                return "Tất cả sản phẩm";
        }

        private string GetBestSellersFilterSummary()
        {
            if (SortBy == "Quantity")
            {
                return $"Top {TopCount} theo số lượng";
            }
            else
            {
                return $"Top {TopCount} theo doanh thu";
            }
        }

        private string GetRevenueFilterSummary()
        {
            var filters = new List<string>();

            filters.Add($"Nhóm theo: {GetGroupByName()}");

            if (EmployeeId.HasValue)
                filters.Add($"Nhân viên: {EmployeeName}");

            if (CustomerId.HasValue)
                filters.Add($"Khách hàng: {CustomerName}");

            return string.Join(" | ", filters);
        }

        private string GetGroupByName()
        {
            switch (GroupBy)
            {
                case "Day":
                    return "Ngày";
                case "Month":
                    return "Tháng";
                case "Quarter":
                    return "Quý";
                case "Year":
                    return "Năm";
                default:
                    return GroupBy;
            }
        }

        #endregion
    }

    /// <summary>
    /// Item cho báo cáo tồn kho
    /// </summary>
    public class InventoryReportItem
    {
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public string TenDanhMuc { get; set; }
        public string TenNCC { get; set; }
        public int SoLuongTon { get; set; }
        public decimal GiaBan { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal TongGiaTriTonKho { get; set; }
        public string TrangThaiTonKho { get; set; }

        // Format properties for display
        public string GiaBanFormatted
        {
            get { return GiaBan.ToString("N0") + " đ"; }
        }

        public string GiaNhapFormatted
        {
            get { return GiaNhap.ToString("N0") + " đ"; }
        }

        public string TongGiaTriFormatted
        {
            get { return TongGiaTriTonKho.ToString("N0") + " đ"; }
        }
    }

    /// <summary>
    /// Item cho báo cáo sản phẩm bán chạy
    /// </summary>
    public class BestSellerReportItem
    {
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public string TenDanhMuc { get; set; }
        public int TongSoLuongBan { get; set; }
        public decimal TongDoanhThu { get; set; }
        public decimal DonGiaTrungBinh { get; set; }
        public int SoDonHang { get; set; }

        // Format properties for display
        public string TongDoanhThuFormatted
        {
            get { return TongDoanhThu.ToString("N0") + " đ"; }
        }

        public string DonGiaTrungBinhFormatted
        {
            get { return DonGiaTrungBinh.ToString("N0") + " đ"; }
        }

        public string DoanhThuTrungBinhFormatted
        {
            get
            {
                decimal avgRevenue = SoDonHang == 0 ? 0 : TongDoanhThu / SoDonHang;
                return avgRevenue.ToString("N0") + " đ";
            }
        }
    }

    /// <summary>
    /// Item cho báo cáo doanh thu
    /// </summary>
    public class RevenueReportItem
    {
        public string Period { get; set; } // Ngày/Tháng/Năm
        public int SoHoaDon { get; set; }
        public decimal TongDoanhThu { get; set; }
        public decimal TongThanhToan { get; set; }
        public decimal TrungBinhHoaDon { get; set; }
        public int TongSoLuongBan { get; set; }
        public int SoKhachHang { get; set; }

        // Format properties for display
        public string TongDoanhThuFormatted
        {
            get { return TongDoanhThu.ToString("N0") + " đ"; }
        }

        public string TongThanhToanFormatted
        {
            get { return TongThanhToan.ToString("N0") + " đ"; }
        }

        public string TrungBinhHoaDonFormatted
        {
            get { return TrungBinhHoaDon.ToString("N0") + " đ"; }
        }
    }
}