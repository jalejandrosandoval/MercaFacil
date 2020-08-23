namespace ParentForm
{
    partial class ReportMoreClientBuy
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
            this.crv_ReportProduct = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.MoreClientBuy1 = new ParentForm.Reportes.MoreClientBuy();
            this.SuspendLayout();
            // 
            // crv_ReportProduct
            // 
            this.crv_ReportProduct.ActiveViewIndex = 0;
            this.crv_ReportProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_ReportProduct.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_ReportProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_ReportProduct.Location = new System.Drawing.Point(0, 0);
            this.crv_ReportProduct.Name = "crv_ReportProduct";
            this.crv_ReportProduct.ReportSource = this.MoreClientBuy1;
            this.crv_ReportProduct.ShowLogo = false;
            this.crv_ReportProduct.Size = new System.Drawing.Size(722, 541);
            this.crv_ReportProduct.TabIndex = 0;
            this.crv_ReportProduct.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // ReportMoreClientBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 541);
            this.Controls.Add(this.crv_ReportProduct);
            this.Name = "ReportMoreClientBuy";
            this.Text = "ReportMoreClientBuy";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private Reportes.MoreClientBuy MoreClientBuy1;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crv_ReportProduct;
    }
}