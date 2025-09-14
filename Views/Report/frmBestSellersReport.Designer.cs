namespace CuaHangMayTinh.Views.Report
{
    partial class frmBestSellersReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cbReportType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.xemLịchSửBánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemChiTiếtSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nudTopCount = new System.Windows.Forms.NumericUpDown();
            this.grbBestSellersList = new System.Windows.Forms.GroupBox();
            this.dgvBestSellers = new System.Windows.Forms.DataGridView();
            this.btnViewReport = new System.Windows.Forms.Button();
            this.grbChart = new System.Windows.Forms.GroupBox();
            this.panelChart = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grbFilter = new System.Windows.Forms.GroupBox();
            this.labelChart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTopCount)).BeginInit();
            this.grbBestSellersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBestSellers)).BeginInit();
            this.grbChart.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại báo cáo:";
            // 
            // cbReportType
            // 
            this.cbReportType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReportType.FormattingEnabled = true;
            this.cbReportType.Items.AddRange(new object[] {
            "Theo số lượng",
            "Theo doanh thu"});
            this.cbReportType.Location = new System.Drawing.Point(103, 3);
            this.cbReportType.Name = "cbReportType";
            this.cbReportType.Size = new System.Drawing.Size(114, 21);
            this.cbReportType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Từ ngày:";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFromDate.Location = new System.Drawing.Point(323, 3);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(114, 20);
            this.dtpFromDate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đến ngày:";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpToDate.Location = new System.Drawing.Point(543, 3);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(54, 20);
            this.dtpToDate.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(619, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Top sản phẩm:";
            // 
            // xemLịchSửBánToolStripMenuItem
            // 
            this.xemLịchSửBánToolStripMenuItem.Name = "xemLịchSửBánToolStripMenuItem";
            this.xemLịchSửBánToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.xemLịchSửBánToolStripMenuItem.Text = "Xem lịch sử bán";
            // 
            // xemChiTiếtSảnPhẩmToolStripMenuItem
            // 
            this.xemChiTiếtSảnPhẩmToolStripMenuItem.Name = "xemChiTiếtSảnPhẩmToolStripMenuItem";
            this.xemChiTiếtSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.xemChiTiếtSảnPhẩmToolStripMenuItem.Text = "Xem chi tiết sản phẩm";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemChiTiếtSảnPhẩmToolStripMenuItem,
            this.xemLịchSửBánToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(193, 48);
            // 
            // nudTopCount
            // 
            this.nudTopCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudTopCount.Location = new System.Drawing.Point(703, 3);
            this.nudTopCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTopCount.Name = "nudTopCount";
            this.nudTopCount.Size = new System.Drawing.Size(322, 20);
            this.nudTopCount.TabIndex = 7;
            this.nudTopCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // grbBestSellersList
            // 
            this.grbBestSellersList.Controls.Add(this.dgvBestSellers);
            this.grbBestSellersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbBestSellersList.Location = new System.Drawing.Point(0, 280);
            this.grbBestSellersList.Name = "grbBestSellersList";
            this.grbBestSellersList.Size = new System.Drawing.Size(1034, 231);
            this.grbBestSellersList.TabIndex = 7;
            this.grbBestSellersList.TabStop = false;
            this.grbBestSellersList.Text = "Danh sách sản phẩm bán chạy";
            // 
            // dgvBestSellers
            // 
            this.dgvBestSellers.AllowUserToAddRows = false;
            this.dgvBestSellers.AllowUserToDeleteRows = false;
            this.dgvBestSellers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBestSellers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBestSellers.Location = new System.Drawing.Point(3, 16);
            this.dgvBestSellers.Name = "dgvBestSellers";
            this.dgvBestSellers.ReadOnly = true;
            this.dgvBestSellers.Size = new System.Drawing.Size(1028, 212);
            this.dgvBestSellers.TabIndex = 3;
            // 
            // btnViewReport
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnViewReport, 2);
            this.btnViewReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnViewReport.Location = new System.Drawing.Point(3, 33);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(214, 25);
            this.btnViewReport.TabIndex = 8;
            this.btnViewReport.Text = "Xem báo cáo";
            this.btnViewReport.UseVisualStyleBackColor = true;
            // 
            // grbChart
            // 
            this.grbChart.Controls.Add(this.panelChart);
            this.grbChart.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbChart.Location = new System.Drawing.Point(0, 80);
            this.grbChart.Name = "grbChart";
            this.grbChart.Size = new System.Drawing.Size(1034, 200);
            this.grbChart.TabIndex = 5;
            this.grbChart.TabStop = false;
            this.grbChart.Text = "Biểu đồ doanh thu";
            // 
            // panelChart
            // 
            this.panelChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChart.Location = new System.Drawing.Point(3, 16);
            this.panelChart.Name = "panelChart";
            this.panelChart.Size = new System.Drawing.Size(1028, 181);
            this.panelChart.TabIndex = 0;
            // 
            // btnExport
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnExport, 2);
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExport.Location = new System.Drawing.Point(223, 33);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(214, 25);
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "Xuất Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbReportType, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpFromDate, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpToDate, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.nudTopCount, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnViewReport, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnExport, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1028, 61);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // grbFilter
            // 
            this.grbFilter.Controls.Add(this.tableLayoutPanel1);
            this.grbFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbFilter.Location = new System.Drawing.Point(0, 0);
            this.grbFilter.Name = "grbFilter";
            this.grbFilter.Size = new System.Drawing.Size(1034, 80);
            this.grbFilter.TabIndex = 4;
            this.grbFilter.TabStop = false;
            this.grbFilter.Text = "Bộ lọc báo cáo";
            // 
            // labelChart
            // 
            this.labelChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelChart.Location = new System.Drawing.Point(0, 0);
            this.labelChart.Name = "labelChart";
            this.labelChart.Size = new System.Drawing.Size(1034, 511);
            this.labelChart.TabIndex = 6;
            this.labelChart.Text = "Biểu đồ sẽ được hiển thị ở đây";
            this.labelChart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelChart.Visible = false;
            // 
            // frmBestSellersReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 511);
            this.Controls.Add(this.grbBestSellersList);
            this.Controls.Add(this.grbChart);
            this.Controls.Add(this.grbFilter);
            this.Controls.Add(this.labelChart);
            this.Name = "frmBestSellersReport";
            this.Text = "frmBestSellersReport";
            this.Load += new System.EventHandler(this.frmBestSellersReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudTopCount)).EndInit();
            this.grbBestSellersList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBestSellers)).EndInit();
            this.grbChart.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.grbFilter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox grbBestSellersList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xemChiTiếtSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemLịchSửBánToolStripMenuItem;
        private System.Windows.Forms.GroupBox grbChart;
        private System.Windows.Forms.Panel panelChart;
        private System.Windows.Forms.GroupBox grbFilter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbReportType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudTopCount;
        private System.Windows.Forms.Button btnViewReport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label labelChart;
        private System.Windows.Forms.DataGridView dgvBestSellers;
    }
}