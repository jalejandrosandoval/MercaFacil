namespace ParentForm
{
    partial class AddExp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddExp));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_Minus = new System.Windows.Forms.Button();
            this.btn_Plus = new System.Windows.Forms.Button();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Ventas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Reg = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(221, 142);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(350, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // btn_Minus
            // 
            this.btn_Minus.BackColor = System.Drawing.Color.Transparent;
            this.btn_Minus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Minus.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Minus.Location = new System.Drawing.Point(369, 238);
            this.btn_Minus.Name = "btn_Minus";
            this.btn_Minus.Size = new System.Drawing.Size(25, 25);
            this.btn_Minus.TabIndex = 14;
            this.btn_Minus.Text = "-";
            this.btn_Minus.UseVisualStyleBackColor = false;
            this.btn_Minus.Click += new System.EventHandler(this.btn_Minus_Click);
            // 
            // btn_Plus
            // 
            this.btn_Plus.BackColor = System.Drawing.Color.Transparent;
            this.btn_Plus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Plus.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Plus.Location = new System.Drawing.Point(369, 213);
            this.btn_Plus.Name = "btn_Plus";
            this.btn_Plus.Size = new System.Drawing.Size(25, 25);
            this.btn_Plus.TabIndex = 13;
            this.btn_Plus.Text = "+";
            this.btn_Plus.UseVisualStyleBackColor = false;
            this.btn_Plus.Click += new System.EventHandler(this.btn_Plus_Click);
            // 
            // txt_Amount
            // 
            this.txt_Amount.Location = new System.Drawing.Point(338, 227);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(31, 22);
            this.txt_Amount.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbl_Ventas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 61);
            this.panel1.TabIndex = 16;
            // 
            // lbl_Ventas
            // 
            this.lbl_Ventas.AutoSize = true;
            this.lbl_Ventas.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Ventas.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Ventas.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Ventas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Ventas.Location = new System.Drawing.Point(252, 7);
            this.lbl_Ventas.Name = "lbl_Ventas";
            this.lbl_Ventas.Size = new System.Drawing.Size(210, 35);
            this.lbl_Ventas.TabIndex = 5;
            this.lbl_Ventas.Text = "Fecha Vencimiento";
            this.lbl_Ventas.Click += new System.EventHandler(this.lbl_Ventas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(59, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha Vencimiento";
            this.label1.Click += new System.EventHandler(this.lbl_Ventas_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(252, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cantidad";
            this.label2.Click += new System.EventHandler(this.lbl_Ventas_Click);
            // 
            // btn_Reg
            // 
            this.btn_Reg.BackColor = System.Drawing.Color.Transparent;
            this.btn_Reg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Reg.Font = new System.Drawing.Font("Tw Cen MT", 13F);
            this.btn_Reg.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Reg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Reg.Location = new System.Drawing.Point(310, 343);
            this.btn_Reg.Name = "btn_Reg";
            this.btn_Reg.Size = new System.Drawing.Size(102, 32);
            this.btn_Reg.TabIndex = 29;
            this.btn_Reg.Text = "Registrar";
            this.btn_Reg.UseVisualStyleBackColor = false;
            // 
            // AddExp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(679, 396);
            this.Controls.Add(this.btn_Reg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Minus);
            this.Controls.Add(this.btn_Plus);
            this.Controls.Add(this.txt_Amount);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "AddExp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_Minus;
        private System.Windows.Forms.Button btn_Plus;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Ventas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Reg;
    }
}