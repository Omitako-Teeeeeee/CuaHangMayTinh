using CuaHangMayTinh.Controllers;
using CuaHangMayTinh.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CuaHangMayTinh.Views.Report
{
    public partial class frmBestSellersReport : Form
    {
        public frmBestSellersReport()
        {
            InitializeComponent();
        }

        private void frmBestSellersReport_Load(object sender, EventArgs e)
        {
            cbReportType.SelectedIndex = 0;
            dtpFromDate.Value = DateTime.Now.AddMonths(-1);
            dtpToDate.Value = DateTime.Now;

            // Gán sự kiện
            btnViewReport.Click += btnViewReport_Click;
            btnExport.Click += btnExport_Click;
        }



        private void btnViewReport_Click(object sender, EventArgs e)
        {
            try
            {
                var request = new ReportModel
                {
                    ReportType = 2, // Best Sellers
                    FromDate = dtpFromDate.Value,
                    ToDate = dtpToDate.Value,
                    TopCount = (int)nudTopCount.Value,
                    SortBy = cbReportType.SelectedIndex == 0 ? "Quantity" : "Revenue"
                };

                var result = ReportController.Instance.GenerateReport(request);
                BindBestSellersData(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindBestSellersData(ReportModel report)
        {
            var data = report.ReportData as List<BestSellerReportItem>;

            // Tạo DataTable để hiển thị
            var dt = new DataTable();
            dt.Columns.Add("Mã SP", typeof(int));
            dt.Columns.Add("Tên SP", typeof(string));
            dt.Columns.Add("Danh mục", typeof(string));
            dt.Columns.Add("Số lượng bán", typeof(int));
            dt.Columns.Add("Doanh thu", typeof(string));
            dt.Columns.Add("Đơn giá TB", typeof(string));
            dt.Columns.Add("Số đơn hàng", typeof(int));

            if (data == null || data.Count == 0)
            {
                // Thêm dòng thông báo không có dữ liệu
                dt.Rows.Add(0, "Chưa có dữ liệu", "", 0, "0 đ", "0 đ", 0);
            }
            else
            {
                foreach (var item in data)
                {
                    dt.Rows.Add(
                        item.MaSP,
                        item.TenSP,
                        item.TenDanhMuc,
                        item.TongSoLuongBan,
                        item.TongDoanhThu.ToString("N0") + " đ",
                        item.DonGiaTrungBinh.ToString("N0") + " đ",
                        item.SoDonHang
                    );
                }
            }

            dgvBestSellers.DataSource = dt;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng xuất Excel tạm thời chưa hỗ trợ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}