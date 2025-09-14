using CuaHangMayTinh.Controllers;
using CuaHangMayTinh.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CuaHangMayTinh.Views.Report
{
    public partial class frmRevenueReport : Form
    {
        public frmRevenueReport()
        {
            InitializeComponent();
        }

        private void frmRevenueReport_Load(object sender, EventArgs e)
        {
            cbReportType.SelectedIndex = 1; // Mặc định theo tháng
            dtpFromDate.Value = DateTime.Now.AddMonths(-6);
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
                    ReportType = 3, // Revenue
                    FromDate = dtpFromDate.Value,
                    ToDate = dtpToDate.Value,
                    GroupBy = GetGroupByValue()
                };

                var result = ReportController.Instance.GenerateReport(request);
                BindRevenueData(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetGroupByValue()
        {
            switch (cbReportType.SelectedIndex)
            {
                case 0: return "Day";
                case 1: return "Month";
                case 2: return "Quarter";
                case 3: return "Year";
                default: return "Month";
            }
        }

        private void BindRevenueData(ReportModel report)
        {
            var data = report.ReportData as List<RevenueReportItem>;

            // Tạo DataTable để hiển thị
            var dt = new DataTable();
            dt.Columns.Add("Kỳ", typeof(string));
            dt.Columns.Add("Số hóa đơn", typeof(int));
            dt.Columns.Add("Tổng doanh thu", typeof(string));
            dt.Columns.Add("Tổng thanh toán", typeof(string));
            dt.Columns.Add("Trung bình/hóa đơn", typeof(string));
            dt.Columns.Add("Số lượng bán", typeof(int));
            dt.Columns.Add("Số khách hàng", typeof(int));

            if (data == null || data.Count == 0)
            {
                // Thêm dòng thông báo không có dữ liệu
                dt.Rows.Add("Chưa có dữ liệu", 0, "0 đ", "0 đ", "0 đ", 0, 0);
            }
            else
            {
                foreach (var item in data)
                {
                    dt.Rows.Add(
                        item.Period,
                        item.SoHoaDon,
                        item.TongDoanhThu.ToString("N0") + " đ",
                        item.TongThanhToan.ToString("N0") + " đ",
                        item.TrungBinhHoaDon.ToString("N0") + " đ",
                        item.TongSoLuongBan,
                        item.SoKhachHang
                    );
                }
            }

            dgvRevenueDetails.DataSource = dt;

            // Cập nhật tổng quan
            lblTotalRevenue.Text = report.TotalRevenue.ToString("N0") + " đ";
            lblTotalInvoices.Text = report.TotalInvoices.ToString();

            if (report.TotalInvoices > 0)
            {
                lblAverageInvoice.Text = (report.TotalRevenue / report.TotalInvoices).ToString("N0") + " đ";
            }
            else
            {
                lblAverageInvoice.Text = "0 đ";
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng xuất Excel tạm thời chưa hỗ trợ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}