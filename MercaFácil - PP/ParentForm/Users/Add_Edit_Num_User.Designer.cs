﻿namespace ParentForm
{
    partial class Add_Edit_Num_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Edit_Num_User));
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.lbl_NumId = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NumTel = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.BackColor = System.Drawing.Color.Transparent;
            this.btn_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Confirm.Font = new System.Drawing.Font("Tw Cen MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirm.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Confirm.Location = new System.Drawing.Point(230, 264);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(90, 29);
            this.btn_Confirm.TabIndex = 16;
            this.btn_Confirm.Text = "Agregar";
            this.btn_Confirm.UseVisualStyleBackColor = false;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // lbl_NumId
            // 
            this.lbl_NumId.AutoSize = true;
            this.lbl_NumId.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NumId.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumId.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_NumId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_NumId.Location = new System.Drawing.Point(195, 101);
            this.lbl_NumId.Name = "lbl_NumId";
            this.lbl_NumId.Size = new System.Drawing.Size(72, 23);
            this.lbl_NumId.TabIndex = 12;
            this.lbl_NumId.Text = "Numero";
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Id.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Id.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Id.Location = new System.Drawing.Point(72, 101);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(124, 23);
            this.lbl_Id.TabIndex = 13;
            this.lbl_Id.Text = "Identificacion: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(72, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Numero:";
            // 
            // txt_NumTel
            // 
            this.txt_NumTel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_NumTel.Location = new System.Drawing.Point(194, 189);
            this.txt_NumTel.Name = "txt_NumTel";
            this.txt_NumTel.Size = new System.Drawing.Size(266, 22);
            this.txt_NumTel.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 62);
            this.panel1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(126, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 34);
            this.label2.TabIndex = 16;
            this.label2.Text = "Agregar Num. Telefono";
            // 
            // Add_Edit_Num_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(519, 303);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.lbl_NumId);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_NumTel);
            this.Name = "Add_Edit_Num_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Confirm;
        public System.Windows.Forms.Label lbl_NumId;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NumTel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}