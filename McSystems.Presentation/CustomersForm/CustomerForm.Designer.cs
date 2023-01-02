namespace McSystems.Presentation
{
    partial class CustomerForm
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
            this.txtIdNumber = new System.Windows.Forms.MaskedTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grdCustomer = new System.Windows.Forms.DataGridView();
            this.colCustomerIdNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSavingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCreateId = new System.Windows.Forms.MaskedTextBox();
            this.txtCreateName = new System.Windows.Forms.TextBox();
            this.txtCreateEMail = new System.Windows.Forms.TextBox();
            this.txtCreateSurname = new System.Windows.Forms.TextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.txtCreatePhone = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIdNumber
            // 
            this.txtIdNumber.Location = new System.Drawing.Point(100, 15);
            this.txtIdNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdNumber.Mask = "00000000000";
            this.txtIdNumber.Name = "txtIdNumber";
            this.txtIdNumber.Size = new System.Drawing.Size(207, 23);
            this.txtIdNumber.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(100, 45);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(207, 23);
            this.txtName.TabIndex = 1;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(100, 75);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(207, 23);
            this.txtSurname.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(187, 103);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(119, 22);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Ara";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grdCustomer
            // 
            this.grdCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCustomerIdNumber,
            this.colCustomerName,
            this.colSavingDate});
            this.grdCustomer.Location = new System.Drawing.Point(20, 137);
            this.grdCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grdCustomer.MultiSelect = false;
            this.grdCustomer.Name = "grdCustomer";
            this.grdCustomer.RowHeadersWidth = 62;
            this.grdCustomer.RowTemplate.Height = 33;
            this.grdCustomer.Size = new System.Drawing.Size(363, 179);
            this.grdCustomer.TabIndex = 4;
            this.grdCustomer.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdCustomer_CellMouseDown);
            // 
            // colCustomerIdNumber
            // 
            this.colCustomerIdNumber.DataPropertyName = "IdNumber";
            this.colCustomerIdNumber.HeaderText = "Kimlik No";
            this.colCustomerIdNumber.MinimumWidth = 8;
            this.colCustomerIdNumber.Name = "colCustomerIdNumber";
            this.colCustomerIdNumber.Width = 150;
            // 
            // colCustomerName
            // 
            this.colCustomerName.DataPropertyName = "FullName";
            this.colCustomerName.HeaderText = "Adı-Soyadı";
            this.colCustomerName.MinimumWidth = 8;
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Width = 150;
            // 
            // colSavingDate
            // 
            this.colSavingDate.DataPropertyName = "CreatedDate";
            this.colSavingDate.HeaderText = "Kayıt Tarihi";
            this.colSavingDate.MinimumWidth = 8;
            this.colSavingDate.Name = "colSavingDate";
            this.colSavingDate.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kimlik No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soyadı:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(187, 328);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(288, 328);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCreateId
            // 
            this.txtCreateId.Location = new System.Drawing.Point(105, 27);
            this.txtCreateId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCreateId.Mask = "00000000000";
            this.txtCreateId.Name = "txtCreateId";
            this.txtCreateId.Size = new System.Drawing.Size(214, 23);
            this.txtCreateId.TabIndex = 1;
            // 
            // txtCreateName
            // 
            this.txtCreateName.Location = new System.Drawing.Point(105, 56);
            this.txtCreateName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCreateName.Name = "txtCreateName";
            this.txtCreateName.Size = new System.Drawing.Size(214, 23);
            this.txtCreateName.TabIndex = 2;
            // 
            // txtCreateEMail
            // 
            this.txtCreateEMail.Location = new System.Drawing.Point(105, 219);
            this.txtCreateEMail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCreateEMail.Name = "txtCreateEMail";
            this.txtCreateEMail.Size = new System.Drawing.Size(214, 23);
            this.txtCreateEMail.TabIndex = 7;
            // 
            // txtCreateSurname
            // 
            this.txtCreateSurname.Location = new System.Drawing.Point(105, 89);
            this.txtCreateSurname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCreateSurname.Name = "txtCreateSurname";
            this.txtCreateSurname.Size = new System.Drawing.Size(214, 23);
            this.txtCreateSurname.TabIndex = 3;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(105, 118);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(214, 23);
            this.cmbGender.TabIndex = 4;
            // 
            // cmbCountry
            // 
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(105, 152);
            this.cmbCountry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(214, 23);
            this.cmbCountry.TabIndex = 5;
            // 
            // txtCreatePhone
            // 
            this.txtCreatePhone.Location = new System.Drawing.Point(105, 185);
            this.txtCreatePhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCreatePhone.Mask = "(999) 000-0000";
            this.txtCreatePhone.Name = "txtCreatePhone";
            this.txtCreatePhone.Size = new System.Drawing.Size(214, 23);
            this.txtCreatePhone.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Kimlik No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Adı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Soyadı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 120);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Cinsiyet:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 154);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Ülke:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 221);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "E-Posta:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 187);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Telefon:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(216, 241);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 22);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCreatePhone);
            this.groupBox1.Controls.Add(this.cmbCountry);
            this.groupBox1.Controls.Add(this.cmbGender);
            this.groupBox1.Controls.Add(this.txtCreateSurname);
            this.groupBox1.Controls.Add(this.txtCreateEMail);
            this.groupBox1.Controls.Add(this.txtCreateName);
            this.groupBox1.Controls.Add(this.txtCreateId);
            this.groupBox1.Location = new System.Drawing.Point(448, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(332, 274);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Kayıt";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 375);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdCustomer);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtIdNumber);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CustomerForm";
            this.Text = "Müşteri Formu";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaskedTextBox txtIdNumber;
        private TextBox txtName;
        private TextBox txtSurname;
        private Button btnSearch;
        private DataGridView grdCustomer;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCancel;
        private Button btnAdd;
        private MaskedTextBox txtCreateId;
        private TextBox txtCreateName;
        private TextBox txtCreateEMail;
        private TextBox txtCreateSurname;
        private ComboBox cmbGender;
        private ComboBox cmbCountry;
        private MaskedTextBox txtCreatePhone;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btnSave;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn colCustomerIdNumber;
        private DataGridViewTextBoxColumn colCustomerName;
        private DataGridViewTextBoxColumn colSavingDate;
    }
}