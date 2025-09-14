using CuaHangMayTinh.Views;
using CuaHangMayTinh.Views.Manager;
using CuaHangMayTinh.Views.Report;
using CuaHangMayTinh.Views.Sale;
using System;
using System.Windows.Forms;

namespace ComputerStoreManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void formToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       

        private void Management_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Form form = new Form();
            switch (e.ClickedItem.Name)
            {
                
                case "Customer":
                    frmCustomerManagement F_CustomerManagement = new frmCustomerManagement();
                    form = F_CustomerManagement;
                    break;
                case "Employee":
                    frmEmployeeManagement F_EmployeeManagement = new frmEmployeeManagement();
                    form = F_EmployeeManagement;
                    break;
                case "Supplier":
                    frmSupplierManagement F_SupplierManagement = new frmSupplierManagement();
                    form = F_SupplierManagement;
                    break;
                default:
                    break;
            }
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
            form.BringToFront();
        }

        private void Sale_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Form form = new Form();
            switch (e.ClickedItem.Name)
            {
                case "Invoice":
                    frmCreateInvoice F_CreateInvoice = new frmCreateInvoice();
                    form = F_CreateInvoice;
                    break;
                case "InvoiceHistory":
                    frmInvoiceHistory F_InvoiceHistory = new frmInvoiceHistory();
                    form = F_InvoiceHistory;
                    break;
                default:
                    break;
            }
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
            form.BringToFront();
        }

        private void Report_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Form form = new Form();
            switch (e.ClickedItem.Name)
            {
                case "Revenue":
                    frmRevenueReport F_RevenueReport = new frmRevenueReport();
                    form = F_RevenueReport;
                    break;
                case "Inventory":
                    frmInventoryReport F_InventoryReport = new frmInventoryReport();
                    form = F_InventoryReport;
                    break;
                case "BestSeller":
                    frmBestSellersReport F_InvoiceHistory = new frmBestSellersReport();
                    form = F_InvoiceHistory;
                    break;
                default:
                    break;
            }
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
            form.BringToFront();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }
}