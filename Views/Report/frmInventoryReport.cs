using CuaHangMayTinh.Controllers;
using CuaHangMayTinh.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CuaHangMayTinh.Views.Report
{
    public partial class frmInventoryReport : Form
    {
        public frmInventoryReport()
        {
            InitializeComponent();
        }

        private void frmInventoryReport_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadData();

            // Gán sự kiện
            btnViewReport.Click += btnViewReport_Click;
            buttonClear.Click += buttonClear_Click;
            btnExport.Click += btnExport_Click;
        }

        private void LoadCategories()
        {
            try
            {
                var categories = CategoryController.Instance.GetAllCategories();
                cbCategory.DataSource = categories;
                cbCategory.DisplayMember = "TenDanhMuc";
                cbCategory.ValueMember = "MaDanhMuc";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh mục: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            try
            {
                int? categoryId = null;
                if (cbCategory.SelectedValue != null && cbCategory.SelectedValue is int selectedId)
                {
                    categoryId = selectedId;
                }

                int? minStock = null;
                if (!string.IsNullOrEmpty(txtMinStock.Text) && int.TryParse(txtMinStock.Text, out int min))
                {
                    minStock = min;
                }

                int? maxStock = null;
                if (!string.IsNullOrEmpty(txtMaxStock.Text) && int.TryParse(txtMaxStock.Text, out int max))
                {
                    maxStock = max;
                }

                var request = new ReportModel
                {
                    ReportType = 1, // Inventory
                    CategoryId = categoryId,
                    MinStock = minStock,
                    MaxStock = maxStock
                };

                var result = ReportController.Instance.GenerateReport(request);
                BindInventoryData(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindInventoryData(ReportModel report)
        {
            var data = report.ReportData as List<InventoryReportItem>;

            // Tạo DataTable để hiển thị
            var dt = new DataTable();
            dt.Columns.Add("Mã SP", typeof(int));
            dt.Columns.Add("Tên SP", typeof(string));
            dt.Columns.Add("Danh mục", typeof(string));
            dt.Columns.Add("Nhà cung cấp", typeof(string));
            dt.Columns.Add("Số lượng tồn", typeof(int));
            dt.Columns.Add("Giá bán", typeof(string));
            dt.Columns.Add("Giá nhập", typeof(string));
            dt.Columns.Add("Tổng giá trị", typeof(string));
            dt.Columns.Add("Trạng thái", typeof(string));

            if (data == null || data.Count == 0)
            {
                // Thêm dòng thông báo không có dữ liệu
                dt.Rows.Add(0, "Chưa có dữ liệu", "", "", 0, "0 đ", "0 đ", "0 đ", "");
            }
            else
            {
                foreach (var item in data)
                {
                    dt.Rows.Add(
                        item.MaSP,
                        item.TenSP,
                        item.TenDanhMuc,
                        item.TenNCC,
                        item.SoLuongTon,
                        item.GiaBan.ToString("N0") + " đ",
                        item.GiaNhap.ToString("N0") + " đ",
                        item.TongGiaTriTonKho.ToString("N0") + " đ",
                        item.TrangThaiTonKho
                    );
                }
            }

            dataGridViewProduct.DataSource = dt;

            // Cập nhật tổng quan
            lblTotalProducts.Text = report.TotalProducts.ToString();
            lblOutOfStock.Text = report.OutOfStockCount.ToString();
            lblLowStock.Text = report.LowStockCount.ToString();
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtMinStock.Text = "";
            txtMaxStock.Text = "";
            LoadData();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng xuất Excel tạm thời chưa hỗ trợ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Có thể load lại data khi đổi danh mục
            LoadData();
        }
    }
}