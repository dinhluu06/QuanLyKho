﻿namespace QL_Kho
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ckcSave = new System.Windows.Forms.CheckBox();
            this.ckcHienpw = new System.Windows.Forms.CheckBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtacc = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Login)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 105);
            this.panel1.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(408, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phần Mềm Quản Lý Kho";
            // 
            // Login
            // 
            this.Login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Login.BackgroundImage")));
            this.Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Login.Location = new System.Drawing.Point(0, 112);
            this.Login.Margin = new System.Windows.Forms.Padding(4);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(520, 283);
            this.Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Login.TabIndex = 29;
            this.Login.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 210);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 171);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "User";
            // 
            // ckcSave
            // 
            this.ckcSave.AutoSize = true;
            this.ckcSave.Location = new System.Drawing.Point(125, 255);
            this.ckcSave.Margin = new System.Windows.Forms.Padding(4);
            this.ckcSave.Name = "ckcSave";
            this.ckcSave.Size = new System.Drawing.Size(80, 21);
            this.ckcSave.TabIndex = 35;
            this.ckcSave.Text = "Ghi nhớ";
            this.ckcSave.UseVisualStyleBackColor = true;
            // 
            // ckcHienpw
            // 
            this.ckcHienpw.AutoSize = true;
            this.ckcHienpw.Location = new System.Drawing.Point(303, 255);
            this.ckcHienpw.Margin = new System.Windows.Forms.Padding(4);
            this.ckcHienpw.Name = "ckcHienpw";
            this.ckcHienpw.Size = new System.Drawing.Size(121, 21);
            this.ckcHienpw.TabIndex = 34;
            this.ckcHienpw.Text = "Hiện mật khẩu";
            this.ckcHienpw.UseVisualStyleBackColor = true;
            this.ckcHienpw.CheckedChanged += new System.EventHandler(this.ckcHienpw_CheckedChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleDescription = "";
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThoat.Location = new System.Drawing.Point(328, 283);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(101, 90);
            this.btnThoat.TabIndex = 33;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDangnhap.FlatAppearance.BorderSize = 0;
            this.btnDangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDangnhap.Image = ((System.Drawing.Image)(resources.GetObject("btnDangnhap.Image")));
            this.btnDangnhap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDangnhap.Location = new System.Drawing.Point(161, 283);
            this.btnDangnhap.Margin = new System.Windows.Forms.Padding(4);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(123, 90);
            this.btnDangnhap.TabIndex = 32;
            this.btnDangnhap.Text = "Đăng nhập";
            this.btnDangnhap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDangnhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDangnhap.UseVisualStyleBackColor = true;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtpass.Location = new System.Drawing.Point(163, 207);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(267, 26);
            this.txtpass.TabIndex = 31;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // txtacc
            // 
            this.txtacc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtacc.Location = new System.Drawing.Point(163, 162);
            this.txtacc.Margin = new System.Windows.Forms.Padding(4);
            this.txtacc.Name = "txtacc";
            this.txtacc.Size = new System.Drawing.Size(267, 26);
            this.txtacc.TabIndex = 30;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(521, 401);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckcSave);
            this.Controls.Add(this.ckcHienpw);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangnhap);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtacc);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckcSave;
        private System.Windows.Forms.CheckBox ckcHienpw;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangnhap;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtacc;
    }
}