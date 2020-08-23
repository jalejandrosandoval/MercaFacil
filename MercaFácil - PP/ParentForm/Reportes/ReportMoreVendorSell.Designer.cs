namespace ParentForm
{
    partial class ReportMoreVendorSell
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
            this.crv_ReportVendorSell = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.MoreVendorSell1 = new ParentForm.Reportes.MoreVendorSell();
            this.SuspendLayout();
            // 
            // crv_ReportVendorSell
            // 
            this.crv_ReportVendorSell.ActiveViewIndex = 0;
            this.crv_ReportVendorSell.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_ReportVendorSell.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_ReportVendorSell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_ReportVendorSell.Location = new System.Drawing.Point(0, 0);
            this.crv_ReportVendorSell.Name = "crv_ReportVendorSell";
            this.crv_ReportVendorSell.ReportSource = this.MoreVendorSell1;
            this.crv_ReportVendorSell.ShowLogo = false;
            this.crv_ReportVendorSell.Size = new System.Drawing.Size(525, 522);
            this.crv_ReportVendorSell.TabIndex = 0;
            this.crv_ReportVendorSell.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // ReportMoreVendorSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 522);
            this.Controls.Add(this.crv_ReportVendorSell);
            this.Name = "ReportMoreVendorSell";
            this.Text = "ReportMoreVendorSell";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private Reportes.MoreVendorSell MoreVendorSell1;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crv_ReportVendorSell;
    }
}