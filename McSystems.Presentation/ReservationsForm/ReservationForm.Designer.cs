namespace McSystems.Presentation
{
    partial class ReservationForm
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
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.grdRooms = new System.Windows.Forms.DataGridView();
            this.colRoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomChoice = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.txtSelectedRoom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.grdSelectedCustomer = new System.Windows.Forms.DataGridView();
            this.colIdNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSelectedCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dtStartDate
            // 
            this.dtStartDate.Location = new System.Drawing.Point(120, 31);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(256, 31);
            this.dtStartDate.TabIndex = 0;
            // 
            // dtEndDate
            // 
            this.dtEndDate.Location = new System.Drawing.Point(457, 31);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(251, 31);
            this.dtEndDate.TabIndex = 0;
            // 
            // grdRooms
            // 
            this.grdRooms.AllowUserToAddRows = false;
            this.grdRooms.AllowUserToDeleteRows = false;
            this.grdRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRoomName,
            this.colRoomCapacity,
            this.colRoomDescription,
            this.colRoomChoice});
            this.grdRooms.Location = new System.Drawing.Point(36, 168);
            this.grdRooms.MultiSelect = false;
            this.grdRooms.Name = "grdRooms";
            this.grdRooms.ReadOnly = true;
            this.grdRooms.RowHeadersWidth = 62;
            this.grdRooms.RowTemplate.Height = 33;
            this.grdRooms.Size = new System.Drawing.Size(805, 386);
            this.grdRooms.TabIndex = 1;
            this.grdRooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdRooms_CellContentClick);
            this.grdRooms.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdRooms_CellMouseDown);
            // 
            // colRoomName
            // 
            this.colRoomName.DataPropertyName = "Name";
            this.colRoomName.HeaderText = "Oda";
            this.colRoomName.MinimumWidth = 8;
            this.colRoomName.Name = "colRoomName";
            this.colRoomName.ReadOnly = true;
            this.colRoomName.Width = 150;
            // 
            // colRoomCapacity
            // 
            this.colRoomCapacity.DataPropertyName = "Capacity";
            this.colRoomCapacity.HeaderText = "Kişi Sayısı";
            this.colRoomCapacity.MinimumWidth = 8;
            this.colRoomCapacity.Name = "colRoomCapacity";
            this.colRoomCapacity.ReadOnly = true;
            this.colRoomCapacity.Width = 150;
            // 
            // colRoomDescription
            // 
            this.colRoomDescription.DataPropertyName = "Description";
            this.colRoomDescription.HeaderText = "Açıklama";
            this.colRoomDescription.MinimumWidth = 8;
            this.colRoomDescription.Name = "colRoomDescription";
            this.colRoomDescription.ReadOnly = true;
            this.colRoomDescription.Width = 150;
            // 
            // colRoomChoice
            // 
            this.colRoomChoice.HeaderText = "";
            this.colRoomChoice.MinimumWidth = 8;
            this.colRoomChoice.Name = "colRoomChoice";
            this.colRoomChoice.ReadOnly = true;
            this.colRoomChoice.Text = "Seç";
            this.colRoomChoice.UseColumnTextForButtonValue = true;
            this.colRoomChoice.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Başlangıç:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bitiş:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(730, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 38);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Ara";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Çalışan:";
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(102, 100);
            this.cmbEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(171, 33);
            this.cmbEmployee.TabIndex = 6;
            // 
            // txtSelectedRoom
            // 
            this.txtSelectedRoom.Location = new System.Drawing.Point(419, 102);
            this.txtSelectedRoom.Name = "txtSelectedRoom";
            this.txtSelectedRoom.Size = new System.Drawing.Size(131, 31);
            this.txtSelectedRoom.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Seçilen Oda:";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(577, 95);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(120, 41);
            this.btnAddCustomer.TabIndex = 10;
            this.btnAddCustomer.Text = "Müşteri Ekle";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // grdSelectedCustomer
            // 
            this.grdSelectedCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSelectedCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdNumber,
            this.colFirstName,
            this.colLastName,
            this.colPhone,
            this.colGender});
            this.grdSelectedCustomer.Location = new System.Drawing.Point(36, 168);
            this.grdSelectedCustomer.MultiSelect = false;
            this.grdSelectedCustomer.Name = "grdSelectedCustomer";
            this.grdSelectedCustomer.RowHeadersWidth = 62;
            this.grdSelectedCustomer.RowTemplate.Height = 33;
            this.grdSelectedCustomer.Size = new System.Drawing.Size(966, 398);
            this.grdSelectedCustomer.TabIndex = 11;
            this.grdSelectedCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSelectedCustomer_CellContentClick);
            // 
            // colIdNumber
            // 
            this.colIdNumber.DataPropertyName = "IdNumber";
            this.colIdNumber.HeaderText = "Kimlik No";
            this.colIdNumber.MinimumWidth = 8;
            this.colIdNumber.Name = "colIdNumber";
            this.colIdNumber.Width = 150;
            // 
            // colFirstName
            // 
            this.colFirstName.DataPropertyName = "FirstName";
            this.colFirstName.HeaderText = "İsim";
            this.colFirstName.MinimumWidth = 8;
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Width = 150;
            // 
            // colLastName
            // 
            this.colLastName.DataPropertyName = "LastName";
            this.colLastName.HeaderText = "Soyisim";
            this.colLastName.MinimumWidth = 8;
            this.colLastName.Name = "colLastName";
            this.colLastName.Width = 150;
            // 
            // colPhone
            // 
            this.colPhone.DataPropertyName = "Phone";
            this.colPhone.HeaderText = "Telefon";
            this.colPhone.MinimumWidth = 8;
            this.colPhone.Name = "colPhone";
            this.colPhone.Width = 150;
            // 
            // colGender
            // 
            this.colGender.DataPropertyName = "Gender";
            this.colGender.HeaderText = "Cinsiyet";
            this.colGender.MinimumWidth = 8;
            this.colGender.Name = "colGender";
            this.colGender.Width = 150;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(881, 572);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 47);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(730, 575);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 44);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 644);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grdSelectedCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSelectedRoom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdRooms);
            this.Controls.Add(this.dtEndDate);
            this.Controls.Add(this.dtStartDate);
            this.Name = "ReservationForm";
            this.Text = "Rezervasyon Ekranı";
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSelectedCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected DateTimePicker dtStartDate;
        protected DateTimePicker dtEndDate;
        private Label label1;
        private Label label2;
        protected Button btnSearch;
        private Label label3;
        protected ComboBox cmbEmployee;
        private TextBox txtSelectedRoom;
        private Label label4;
        private Button btnAddCustomer;
        private DataGridView grdSelectedCustomer;
        private DataGridViewTextBoxColumn colRoomName;
        private DataGridViewTextBoxColumn colRoomCapacity;
        private DataGridViewTextBoxColumn colRoomDescription;
        private DataGridViewButtonColumn colRoomChoice;
        protected DataGridView grdRooms;
        private DataGridViewTextBoxColumn colIdNumber;
        private DataGridViewTextBoxColumn colFirstName;
        private DataGridViewTextBoxColumn colLastName;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colGender;
        private Button btnSave;
        private Button btnCancel;
    }
}