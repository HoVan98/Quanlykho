﻿namespace QLKVCGT.GUI
{
    partial class Employees_Store
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees_Store));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.gctEmployees = new DevExpress.XtraGrid.GridControl();
            this.dgvEmployees = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dtpkDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.tbEmployeesName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEmployeesID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1725, 731);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightBlue;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Location = new System.Drawing.Point(456, 8);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1265, 711);
            this.panel3.TabIndex = 18;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Location = new System.Drawing.Point(3, 2);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(965, 700);
            this.panel6.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label15);
            this.panel5.Location = new System.Drawing.Point(6, 10);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(955, 144);
            this.panel5.TabIndex = 63;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(346, 89);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(247, 28);
            this.label15.TabIndex = 18;
            this.label15.Text = "Danh sách nhân viên";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.gctEmployees);
            this.panel8.Location = new System.Drawing.Point(6, 153);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(953, 546);
            this.panel8.TabIndex = 0;
            // 
            // gctEmployees
            // 
            this.gctEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gctEmployees.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gctEmployees.Location = new System.Drawing.Point(0, 0);
            this.gctEmployees.MainView = this.dgvEmployees;
            this.gctEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gctEmployees.Name = "gctEmployees";
            this.gctEmployees.Size = new System.Drawing.Size(953, 546);
            this.gctEmployees.TabIndex = 0;
            this.gctEmployees.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvEmployees});
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.DetailHeight = 431;
            this.dgvEmployees.GridControl = this.gctEmployees;
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.OptionsBehavior.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Location = new System.Drawing.Point(3, -5);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(447, 706);
            this.panel2.TabIndex = 17;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(24, 501);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(156, 48);
            this.btnUpdate.TabIndex = 80;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(24, 592);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(156, 48);
            this.btnDelete.TabIndex = 79;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(24, 410);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 48);
            this.btnAdd.TabIndex = 78;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(234, 534);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(156, 48);
            this.btnCancel.TabIndex = 76;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dtpkDateOfBirth);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.tbCountry);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.tbPhone);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.tbSalary);
            this.panel7.Controls.Add(this.tbEmployeesName);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.tbEmployeesID);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.tbUserName);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(3, 2);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(433, 402);
            this.panel7.TabIndex = 1;
            // 
            // dtpkDateOfBirth
            // 
            this.dtpkDateOfBirth.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkDateOfBirth.Location = new System.Drawing.Point(162, 223);
            this.dtpkDateOfBirth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpkDateOfBirth.Name = "dtpkDateOfBirth";
            this.dtpkDateOfBirth.Size = new System.Drawing.Size(185, 27);
            this.dtpkDateOfBirth.TabIndex = 81;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(20, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 26);
            this.label10.TabIndex = 80;
            this.label10.Text = "Quê quán:";
            // 
            // tbCountry
            // 
            this.tbCountry.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCountry.Location = new System.Drawing.Point(163, 186);
            this.tbCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(185, 27);
            this.tbCountry.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(20, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 26);
            this.label3.TabIndex = 76;
            this.label3.Text = "Số điện thoại:";
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.Location = new System.Drawing.Point(162, 261);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(185, 27);
            this.tbPhone.TabIndex = 75;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(20, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 26);
            this.label8.TabIndex = 74;
            this.label8.Text = "Hệ số lương:";
            // 
            // tbSalary
            // 
            this.tbSalary.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSalary.Location = new System.Drawing.Point(162, 295);
            this.tbSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(185, 27);
            this.tbSalary.TabIndex = 73;
            // 
            // tbEmployeesName
            // 
            this.tbEmployeesName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmployeesName.Location = new System.Drawing.Point(162, 140);
            this.tbEmployeesName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmployeesName.Name = "tbEmployeesName";
            this.tbEmployeesName.Size = new System.Drawing.Size(185, 27);
            this.tbEmployeesName.TabIndex = 69;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(20, 143);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(120, 26);
            this.label16.TabIndex = 70;
            this.label16.Text = "Tên nhân viên:";
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(20, 228);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(120, 26);
            this.label17.TabIndex = 72;
            this.label17.Text = "Ngày sinh:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(17, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 26);
            this.label4.TabIndex = 66;
            this.label4.Text = "Mã số:";
            // 
            // tbEmployeesID
            // 
            this.tbEmployeesID.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmployeesID.Location = new System.Drawing.Point(161, 103);
            this.tbEmployeesID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmployeesID.Name = "tbEmployeesID";
            this.tbEmployeesID.Size = new System.Drawing.Size(185, 27);
            this.tbEmployeesID.TabIndex = 65;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(17, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 26);
            this.label9.TabIndex = 54;
            this.label9.Text = "UserName";
            // 
            // tbUserName
            // 
            this.tbUserName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.Location = new System.Drawing.Point(161, 68);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(185, 27);
            this.tbUserName.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 28);
            this.label1.TabIndex = 58;
            this.label1.Text = "Thông tin chi tiết nhân viên";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(234, 457);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 48);
            this.btnSave.TabIndex = 77;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Employees_Store
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1571, 741);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Employees_Store";
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.Employees_Store_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private DevExpress.XtraGrid.GridControl gctEmployees;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvEmployees;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.TextBox tbEmployeesName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEmployeesID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private System.Windows.Forms.DateTimePicker dtpkDateOfBirth;
    }
}