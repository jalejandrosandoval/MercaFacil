namespace ParentForm
{
    partial class ReportMostSoldProduct
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
            this.crv_ReportProductMostSell = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.MostSoldProduct1 = new ParentForm.Reportes.MostSoldProduct();
            this.SuspendLayout();
            // 
            // crv_ReportProductMostSell
            // 
            this.crv_ReportProductMostSell.ActiveViewIndex = 0;
            this.crv_ReportProductMostSell.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_ReportProductMostSell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_ReportProductMostSell.Location = new System.Drawing.Point(0, 0);
            this.crv_ReportProductMostSell.Name = "crv_ReportProductMostSell";
            this.crv_ReportProductMostSell.ReportSource = this.MostSoldProduct1;
            this.crv_ReportProductMostSell.ReuseParameterValuesOnRefresh = true;
            this.crv_ReportProductMostSell.ShowLogo = false;
            this.crv_ReportProductMostSell.Size = new System.Drawing.Size(676, 512);
            this.crv_ReportProductMostSell.TabIndex = 0;
            this.crv_ReportProductMostSell.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // ReportMostSoldProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 512);
            this.Controls.Add(this.crv_ReportProductMostSell);
            this.Name = "ReportMostSoldProduct";
            this.Text = "ReportMostSoldProduct";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private Reportes.MostSoldProduct MostSoldProduct1;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crv_ReportProductMostSell;
    }
}