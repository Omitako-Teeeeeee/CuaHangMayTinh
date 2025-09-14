namespace CuaHangMayTinh.Views.Report
{
    partial class frmRevenueReport
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
            this.grbDetails = new System.Windows.Forms.GroupBox();
            this.dgvRevenueDetails = new System.Windows.Forms.DataGridView();
            this.lblAverageInvoice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalInvoices = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.grbSummary = new System.Windows.Forms.GroupBox();
            this.panelChart = new System.Windows.Forms.Panel();
            this.labelChart = new System.Windows.Forms.Label();
            this.grbChart = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbReportType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.btnViewReport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grbFilter = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.grbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenueDetails)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.grbSummary.SuspendLayout();
            this.panelChart.SuspendLayout();
            this.grbChart.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // grbDetails
            // 
            this.grbDetails.Controls.Add(this.dgvRevenueDetails);
            this.grbDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbDetails.Location = new System.Drawing.Point(0, 360);
            this.grbDetails.Name = "grbDetails";
            this.grbDetails.Size = new System.Drawing.Size(800, 90);
            this.grbDetails.TabIndex = 8;
            this.grbDetails.TabStop = false;
            this.grbDetails.Text = "Chi tiết doanh thu";
            // 
            // dgvRevenueDetails
            // 
            this.dgvRevenueDetails.AllowUserToAddRows = false;
            this.dgvRevenueDetails.AllowUserToDeleteRows = false;
            this.dgvRevenueDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRevenueDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRevenueDetails.Location = new System.Drawing.Point(3, 16);
            this.dgvRevenueDetails.Name = "dgvRevenueDetails";
            this.dgvRevenueDetails.ReadOnly = true;
            this.dgvRevenueDetails.Size = new System.Drawing.Size(794, 71);
            this.dgvRevenueDetails.TabIndex = 3;
            // 
            // lblAverageInvoice
            // 
            this.lblAverageInvoice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAverageInvoice.AutoSize = true;
            this.lblAverageInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblAverageInvoice.ForeColor = System.Drawing.Color.Blue;
            this.lblAverageInvoice.Location = new System.Drawing.Point(663, 24);
            this.lblAverageInvoice.Name = "lblAverageInvoice";
            this.lblAverageInvoice.Size = new System.Drawing.Size(26, 13);
            this.lblAverageInvoice.TabIndex = 5;
            this.lblAverageInvoice.Text = "0 đ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(28, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tổng doanh thu:";
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTotalRevenue.ForeColor = System.Drawing.Color.Green;
            this.lblTotalRevenue.Location = new System.Drawing.Point(135, 24);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(26, 13);
            this.lblTotalRevenue.TabIndex = 1;
            this.lblTotalRevenue.Text = "0 đ";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(285, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tổng số hóa đơn:";
            // 
            // lblTotalInvoices
            // 
            this.lblTotalInvoices.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalInvoices.AutoSize = true;
            this.lblTotalInvoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTotalInvoices.Location = new System.Drawing.Point(399, 24);
            this.lblTotalInvoices.Name = "lblTotalInvoices";
            this.lblTotalInvoices.Size = new System.Drawing.Size(14, 13);
            this.lblTotalInvoices.TabIndex = 3;
            this.lblTotalInvoices.Text = "0";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblTotalRevenue, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblTotalInvoices, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblAverageInvoice, 5, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 61);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(532, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Trung bình/hóa đơn:";
            // 
            // grbSummary
            // 
            this.grbSummary.Controls.Add(this.tableLayoutPanel2);
            this.grbSummary.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbSummary.Location = new System.Drawing.Point(0, 280);
            this.grbSummary.Name = "grbSummary";
            this.grbSummary.Size = new System.Drawing.Size(800, 80);
            this.grbSummary.TabIndex = 7;
            this.grbSummary.TabStop = false;
            this.grbSummary.Text = "Tổng hợp";
            // 
            // panelChart
            // 
            this.panelChart.BackColor = System.Drawing.Color.White;
            this.panelChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChart.Controls.Add(this.labelChart);
            this.panelChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChart.Location = new System.Drawing.Point(3, 16);
            this.panelChart.Name = "panelChart";
            this.panelChart.Size = new System.Drawing.Size(794, 181);
            this.panelChart.TabIndex = 0;
            // 
            // labelChart
            // 
            this.labelChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelChart.ForeColor = System.Drawing.Color.Gray;
            this.labelChart.Location = new System.Drawing.Point(0, 0);
            this.labelChart.Name = "labelChart";
            this.labelChart.Size = new System.Drawing.Size(792, 179);
            this.labelChart.TabIndex = 0;
            this.labelChart.Text = "BIỂU ĐỒ DOANH THU THEO THÁNG\r\n(Dữ liệu sẽ hiển thị khi xem báo cáo)";
            this.labelChart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbChart
            // 
            this.grbChart.Controls.Add(this.panelChart);
            this.grbChart.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbChart.Location = new System.Drawing.Point(0, 80);
            this.grbChart.Name = "grbChart";
            this.grbChart.Size = new System.Drawing.Size(800, 200);
            this.grbChart.TabIndex = 6;
            this.grbChart.TabStop = false;
            this.grbChart.Text = "Biểu đồ doanh thu";
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
            "Theo ngày",
            "Theo tháng",
            "Theo quý",
            "Theo năm"});
            this.cbReportType.Location = new System.Drawing.Point(103, 3);
            this.cbReportType.Name = "cbReportType";
            this.cbReportType.Size = new System.Drawing.Size(144, 21);
            this.cbReportType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Từ ngày:";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFromDate.Location = new System.Drawing.Point(353, 3);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(144, 20);
            this.dtpFromDate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(541, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đến ngày:";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpToDate.Location = new System.Drawing.Point(603, 3);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(188, 20);
            this.dtpToDate.TabIndex = 5;
            // 
            // btnViewReport
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnViewReport, 2);
            this.btnViewReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnViewReport.Location = new System.Drawing.Point(3, 33);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(244, 25);
            this.btnViewReport.TabIndex = 6;
            this.btnViewReport.Text = "Xem báo cáo";
            this.btnViewReport.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnExport, 2);
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExport.Location = new System.Drawing.Point(253, 33);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(244, 25);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Xuất Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbReportType, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpFromDate, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpToDate, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnViewReport, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnExport, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 61);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // grbFilter
            // 
            this.grbFilter.Controls.Add(this.tableLayoutPanel1);
            this.grbFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbFilter.Location = new System.Drawing.Point(0, 0);
            this.grbFilter.Name = "grbFilter";
            this.grbFilter.Size = new System.Drawing.Size(800, 80);
            this.grbFilter.TabIndex = 5;
            this.grbFilter.TabStop = false;
            this.grbFilter.Text = "Bộ lọc báo cáo";
            // 
            // frmRevenueReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbDetails);
            this.Controls.Add(this.grbSummary);
            this.Controls.Add(this.grbChart);
            this.Controls.Add(this.grbFilter);
            this.Name = "frmRevenueReport";
            this.Text = "frmRevenueReport";
            this.Load += new System.EventHandler(this.frmRevenueReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.grbDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenueDetails)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.grbSummary.ResumeLayout(false);
            this.panelChart.ResumeLayout(false);
            this.grbChart.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.grbFilter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox grbDetails;
        private System.Windows.Forms.GroupBox grbSummary;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalInvoices;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAverageInvoice;
        private System.Windows.Forms.GroupBox grbChart;
        private System.Windows.Forms.Panel panelChart;
        private System.Windows.Forms.Label labelChart;
        private System.Windows.Forms.GroupBox grbFilter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbReportType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Button btnViewReport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridView dgvRevenueDetails;
    }
}