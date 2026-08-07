using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace IrancellApp
{
    partial class Form1
    {
        private IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFatherName = new System.Windows.Forms.Label();
            this.lblMeliCode = new System.Windows.Forms.Label();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.txtMeliCode = new System.Windows.Forms.TextBox();
            this.txtBirthdate = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.lblSearchMobile = new System.Windows.Forms.Label();
            this.txtSearchMobile = new System.Windows.Forms.TextBox();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(420, 20);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(71, 15);
            this.lblMobile.TabIndex = 0;
            this.lblMobile.Text = "شماره همراه:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(420, 53);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(24, 15);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "نام:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(420, 80);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(72, 15);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "نام خانوادگی:";
            // 
            // lblFatherName
            // 
            this.lblFatherName.AutoSize = true;
            this.lblFatherName.Location = new System.Drawing.Point(420, 110);
            this.lblFatherName.Name = "lblFatherName";
            this.lblFatherName.Size = new System.Drawing.Size(42, 15);
            this.lblFatherName.TabIndex = 3;
            this.lblFatherName.Text = "نام پدر:";
            this.lblFatherName.Click += new System.EventHandler(this.lblFatherName_Click);
            // 
            // lblMeliCode
            // 
            this.lblMeliCode.AutoSize = true;
            this.lblMeliCode.Location = new System.Drawing.Point(105, 23);
            this.lblMeliCode.Name = "lblMeliCode";
            this.lblMeliCode.Size = new System.Drawing.Size(46, 15);
            this.lblMeliCode.TabIndex = 4;
            this.lblMeliCode.Text = "کد ملی:";
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Location = new System.Drawing.Point(105, 50);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(57, 15);
            this.lblBirthdate.TabIndex = 5;
            this.lblBirthdate.Text = "تاریخ تولد:";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(497, 20);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(158, 23);
            this.txtMobile.TabIndex = 6;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(497, 50);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(158, 23);
            this.txtFirstName.TabIndex = 7;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(497, 80);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(158, 23);
            this.txtLastName.TabIndex = 8;
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(497, 107);
            this.txtFatherName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(158, 23);
            this.txtFatherName.TabIndex = 9;
            // 
            // txtMeliCode
            // 
            this.txtMeliCode.Location = new System.Drawing.Point(183, 22);
            this.txtMeliCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMeliCode.Name = "txtMeliCode";
            this.txtMeliCode.Size = new System.Drawing.Size(158, 23);
            this.txtMeliCode.TabIndex = 10;
            // 
            // txtBirthdate
            // 
            this.txtBirthdate.Location = new System.Drawing.Point(183, 50);
            this.txtBirthdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBirthdate.Name = "txtBirthdate";
            this.txtBirthdate.Size = new System.Drawing.Size(158, 23);
            this.txtBirthdate.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(455, 146);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 26);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "ثبت";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(359, 146);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(79, 26);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(262, 146);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 26);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.lblSearchMobile);
            this.grpSearch.Controls.Add(this.txtSearchMobile);
            this.grpSearch.Location = new System.Drawing.Point(26, 184);
            this.grpSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpSearch.Size = new System.Drawing.Size(648, 52);
            this.grpSearch.TabIndex = 15;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "جستجو";
            // 
            // lblSearchMobile
            // 
            this.lblSearchMobile.AutoSize = true;
            this.lblSearchMobile.Location = new System.Drawing.Point(569, 22);
            this.lblSearchMobile.Name = "lblSearchMobile";
            this.lblSearchMobile.Size = new System.Drawing.Size(71, 15);
            this.lblSearchMobile.TabIndex = 0;
            this.lblSearchMobile.Text = "شماره همراه:";
            // 
            // txtSearchMobile
            // 
            this.txtSearchMobile.Location = new System.Drawing.Point(394, 20);
            this.txtSearchMobile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchMobile.Name = "txtSearchMobile";
            this.txtSearchMobile.Size = new System.Drawing.Size(158, 23);
            this.txtSearchMobile.TabIndex = 1;
            this.txtSearchMobile.TextChanged += new System.EventHandler(this.txtSearchMobile_TextChanged);
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(26, 248);
            this.dgvCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.Size = new System.Drawing.Size(648, 165);
            this.dgvCustomer.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 428);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBirthdate);
            this.Controls.Add(this.txtMeliCode);
            this.Controls.Add(this.txtFatherName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.lblBirthdate);
            this.Controls.Add(this.lblMeliCode);
            this.Controls.Add(this.lblFatherName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblMobile);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ایرانسل";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMobile;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblFatherName;
        private Label lblMeliCode;
        private Label lblBirthdate;
        private TextBox txtMobile;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtFatherName;
        private TextBox txtMeliCode;
        private TextBox txtBirthdate;
        private Button btnSave;
        private Button btnEdit;
        private Button btnDelete;
        private GroupBox grpSearch;
        private Label lblSearchMobile;
        private TextBox txtSearchMobile;
        private DataGridView dgvCustomer;
    }
}
