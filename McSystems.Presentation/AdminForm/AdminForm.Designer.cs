namespace McSystems.Presentation
{
    partial class AdminForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.müşteriYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCreateCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuListCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışanYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCreateEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGetEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervasyonYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCreateReservation = new System.Windows.Forms.ToolStripMenuItem();
            this.menuListReservation = new System.Windows.Forms.ToolStripMenuItem();
            this.odaYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuListRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.grdListEmployee = new System.Windows.Forms.DataGridView();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripEmployee = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.grdListCustomer = new System.Windows.Forms.DataGridView();
            this.contextMenuCustomer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.grdListReservation = new System.Windows.Forms.DataGridView();
            this.colRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grdListRoom = new System.Windows.Forms.DataGridView();
            this.contextMenuStripRoom = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colIdNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmailAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeleteCustomer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colCustomerUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListEmployee)).BeginInit();
            this.contextMenuStripEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListCustomer)).BeginInit();
            this.contextMenuCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListReservation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdListRoom)).BeginInit();
            this.contextMenuStripRoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriYönetimiToolStripMenuItem,
            this.çalışanYönetimiToolStripMenuItem,
            this.rezervasyonYönetimiToolStripMenuItem,
            this.odaYönetimiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(939, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // müşteriYönetimiToolStripMenuItem
            // 
            this.müşteriYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCreateCustomer,
            this.menuListCustomer});
            this.müşteriYönetimiToolStripMenuItem.Name = "müşteriYönetimiToolStripMenuItem";
            this.müşteriYönetimiToolStripMenuItem.Size = new System.Drawing.Size(160, 29);
            this.müşteriYönetimiToolStripMenuItem.Text = "Müşteri Yönetimi";
            // 
            // menuCreateCustomer
            // 
            this.menuCreateCustomer.Name = "menuCreateCustomer";
            this.menuCreateCustomer.Size = new System.Drawing.Size(209, 34);
            this.menuCreateCustomer.Text = "Yeni Müşteri";
            this.menuCreateCustomer.Click += new System.EventHandler(this.menuCreateCustomer_Click);
            // 
            // menuListCustomer
            // 
            this.menuListCustomer.Name = "menuListCustomer";
            this.menuListCustomer.Size = new System.Drawing.Size(209, 34);
            this.menuListCustomer.Text = "Müşteriler";
            this.menuListCustomer.Click += new System.EventHandler(this.menuListCustomer_Click);
            // 
            // çalışanYönetimiToolStripMenuItem
            // 
            this.çalışanYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCreateEmployee,
            this.menuGetEmployee});
            this.çalışanYönetimiToolStripMenuItem.Name = "çalışanYönetimiToolStripMenuItem";
            this.çalışanYönetimiToolStripMenuItem.Size = new System.Drawing.Size(156, 29);
            this.çalışanYönetimiToolStripMenuItem.Text = "Çalışan Yönetimi";
            // 
            // menuCreateEmployee
            // 
            this.menuCreateEmployee.Name = "menuCreateEmployee";
            this.menuCreateEmployee.Size = new System.Drawing.Size(205, 34);
            this.menuCreateEmployee.Text = "Yeni Çalışan";
            this.menuCreateEmployee.Click += new System.EventHandler(this.menuCreateEmployee_Click);
            // 
            // menuGetEmployee
            // 
            this.menuGetEmployee.Name = "menuGetEmployee";
            this.menuGetEmployee.Size = new System.Drawing.Size(205, 34);
            this.menuGetEmployee.Text = "Çalışanlar";
            this.menuGetEmployee.Click += new System.EventHandler(this.menuGetEmployee_Click);
            // 
            // rezervasyonYönetimiToolStripMenuItem
            // 
            this.rezervasyonYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCreateReservation,
            this.menuListReservation});
            this.rezervasyonYönetimiToolStripMenuItem.Name = "rezervasyonYönetimiToolStripMenuItem";
            this.rezervasyonYönetimiToolStripMenuItem.Size = new System.Drawing.Size(199, 29);
            this.rezervasyonYönetimiToolStripMenuItem.Text = "Rezervasyon Yönetimi";
            // 
            // menuCreateReservation
            // 
            this.menuCreateReservation.Name = "menuCreateReservation";
            this.menuCreateReservation.Size = new System.Drawing.Size(248, 34);
            this.menuCreateReservation.Text = "Yeni Rezervasyon";
            this.menuCreateReservation.Click += new System.EventHandler(this.menuCreateReservation_Click);
            // 
            // menuListReservation
            // 
            this.menuListReservation.Name = "menuListReservation";
            this.menuListReservation.Size = new System.Drawing.Size(248, 34);
            this.menuListReservation.Text = "Rezervasyonlar";
            this.menuListReservation.Click += new System.EventHandler(this.menuListReservation_Click);
            // 
            // odaYönetimiToolStripMenuItem
            // 
            this.odaYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuListRoom});
            this.odaYönetimiToolStripMenuItem.Name = "odaYönetimiToolStripMenuItem";
            this.odaYönetimiToolStripMenuItem.Size = new System.Drawing.Size(135, 29);
            this.odaYönetimiToolStripMenuItem.Text = "Oda Yönetimi";
            // 
            // menuListRoom
            // 
            this.menuListRoom.Name = "menuListRoom";
            this.menuListRoom.Size = new System.Drawing.Size(167, 34);
            this.menuListRoom.Text = "Odalar";
            // 
            // grdListEmployee
            // 
            this.grdListEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFirstName,
            this.colLastName,
            this.colGender,
            this.colBirthDate,
            this.colHireDate});
            this.grdListEmployee.Location = new System.Drawing.Point(23, 93);
            this.grdListEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdListEmployee.MultiSelect = false;
            this.grdListEmployee.Name = "grdListEmployee";
            this.grdListEmployee.RowHeadersWidth = 62;
            this.grdListEmployee.RowTemplate.ContextMenuStrip = this.contextMenuStripEmployee;
            this.grdListEmployee.RowTemplate.Height = 25;
            this.grdListEmployee.Size = new System.Drawing.Size(867, 345);
            this.grdListEmployee.TabIndex = 2;
            this.grdListEmployee.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdListEmployee_CellMouseDown);
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
            // colGender
            // 
            this.colGender.DataPropertyName = "Gender";
            this.colGender.HeaderText = "Cinsiyet";
            this.colGender.MinimumWidth = 8;
            this.colGender.Name = "colGender";
            this.colGender.Width = 150;
            // 
            // colBirthDate
            // 
            this.colBirthDate.DataPropertyName = "DateOfBirth";
            this.colBirthDate.HeaderText = "Doğum Tarihi";
            this.colBirthDate.MinimumWidth = 8;
            this.colBirthDate.Name = "colBirthDate";
            this.colBirthDate.Width = 150;
            // 
            // colHireDate
            // 
            this.colHireDate.DataPropertyName = "HireDate";
            this.colHireDate.HeaderText = "İşe Giriş Tarihi";
            this.colHireDate.MinimumWidth = 8;
            this.colHireDate.Name = "colHireDate";
            this.colHireDate.Width = 150;
            // 
            // contextMenuStripEmployee
            // 
            this.contextMenuStripEmployee.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStripEmployee.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateEmployee,
            this.deleteEmployee});
            this.contextMenuStripEmployee.Name = "contextMenuStripEmployee";
            this.contextMenuStripEmployee.Size = new System.Drawing.Size(148, 68);
            // 
            // updateEmployee
            // 
            this.updateEmployee.Name = "updateEmployee";
            this.updateEmployee.Size = new System.Drawing.Size(147, 32);
            this.updateEmployee.Text = "Düzenle";
            this.updateEmployee.Click += new System.EventHandler(this.updateEmployee_Click);
            // 
            // deleteEmployee
            // 
            this.deleteEmployee.Name = "deleteEmployee";
            this.deleteEmployee.Size = new System.Drawing.Size(147, 32);
            this.deleteEmployee.Text = "Sil";
            this.deleteEmployee.Click += new System.EventHandler(this.deleteEmployee_Click);
            // 
            // grdListCustomer
            // 
            this.grdListCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdNumber,
            this.colCustomerFirstName,
            this.colCustomerLastName,
            this.colPhone,
            this.colEmailAdress,
            this.colDeleteCustomer,
            this.colCustomerUpdate});
            this.grdListCustomer.Location = new System.Drawing.Point(23, 93);
            this.grdListCustomer.MultiSelect = false;
            this.grdListCustomer.Name = "grdListCustomer";
            this.grdListCustomer.RowHeadersWidth = 62;
            this.grdListCustomer.RowTemplate.ContextMenuStrip = this.contextMenuCustomer;
            this.grdListCustomer.RowTemplate.Height = 33;
            this.grdListCustomer.Size = new System.Drawing.Size(867, 345);
            this.grdListCustomer.TabIndex = 3;
            this.grdListCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdListCustomer_CellContentClick);
            this.grdListCustomer.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdListCustomer_CellMouseDown);
            // 
            // contextMenuCustomer
            // 
            this.contextMenuCustomer.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuCustomer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateCustomer,
            this.deleteCustomer});
            this.contextMenuCustomer.Name = "contextMenuStrip1";
            this.contextMenuCustomer.Size = new System.Drawing.Size(148, 68);
            // 
            // updateCustomer
            // 
            this.updateCustomer.Name = "updateCustomer";
            this.updateCustomer.Size = new System.Drawing.Size(147, 32);
            this.updateCustomer.Text = "Düzenle";
            // 
            // deleteCustomer
            // 
            this.deleteCustomer.Name = "deleteCustomer";
            this.deleteCustomer.Size = new System.Drawing.Size(147, 32);
            this.deleteCustomer.Text = "Sil";
            // 
            // grdListReservation
            // 
            this.grdListReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListReservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRoom,
            this.colStartDate,
            this.colEndDate,
            this.colDelete,
            this.colUpdate});
            this.grdListReservation.Location = new System.Drawing.Point(23, 93);
            this.grdListReservation.MultiSelect = false;
            this.grdListReservation.Name = "grdListReservation";
            this.grdListReservation.RowHeadersWidth = 62;
            this.grdListReservation.RowTemplate.Height = 33;
            this.grdListReservation.Size = new System.Drawing.Size(867, 345);
            this.grdListReservation.TabIndex = 4;
            this.grdListReservation.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdListReservation_CellMouseDown);
            // 
            // colRoom
            // 
            this.colRoom.DataPropertyName = "RoomId";
            this.colRoom.HeaderText = "Oda";
            this.colRoom.MinimumWidth = 8;
            this.colRoom.Name = "colRoom";
            this.colRoom.Width = 150;
            // 
            // colStartDate
            // 
            this.colStartDate.DataPropertyName = "StartDate";
            this.colStartDate.HeaderText = "Başlangıç Tarihi";
            this.colStartDate.MinimumWidth = 8;
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.Width = 150;
            // 
            // colEndDate
            // 
            this.colEndDate.DataPropertyName = "EndDate";
            this.colEndDate.HeaderText = "Bitiş Tarihi";
            this.colEndDate.MinimumWidth = 8;
            this.colEndDate.Name = "colEndDate";
            this.colEndDate.Width = 150;
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "";
            this.colDelete.MinimumWidth = 8;
            this.colDelete.Name = "colDelete";
            this.colDelete.Text = "Sil";
            this.colDelete.UseColumnTextForButtonValue = true;
            this.colDelete.Width = 150;
            // 
            // colUpdate
            // 
            this.colUpdate.HeaderText = "";
            this.colUpdate.MinimumWidth = 8;
            this.colUpdate.Name = "colUpdate";
            this.colUpdate.Text = "Güncelle";
            this.colUpdate.UseColumnTextForButtonValue = true;
            this.colUpdate.Width = 150;
            // 
            // grdListRoom
            // 
            this.grdListRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListRoom.Location = new System.Drawing.Point(23, 93);
            this.grdListRoom.MultiSelect = false;
            this.grdListRoom.Name = "grdListRoom";
            this.grdListRoom.RowHeadersWidth = 62;
            this.grdListRoom.RowTemplate.ContextMenuStrip = this.contextMenuStripRoom;
            this.grdListRoom.RowTemplate.Height = 33;
            this.grdListRoom.Size = new System.Drawing.Size(867, 345);
            this.grdListRoom.TabIndex = 6;
            // 
            // contextMenuStripRoom
            // 
            this.contextMenuStripRoom.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStripRoom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateRoom});
            this.contextMenuStripRoom.Name = "contextMenuStripRoom";
            this.contextMenuStripRoom.Size = new System.Drawing.Size(148, 36);
            // 
            // updateRoom
            // 
            this.updateRoom.Name = "updateRoom";
            this.updateRoom.Size = new System.Drawing.Size(147, 32);
            this.updateRoom.Text = "Düzenle";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(71, 45);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(253, 31);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(23, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ara:";
            // 
            // colIdNumber
            // 
            this.colIdNumber.DataPropertyName = "IdNumber";
            this.colIdNumber.HeaderText = "Kimlik No";
            this.colIdNumber.MinimumWidth = 8;
            this.colIdNumber.Name = "colIdNumber";
            this.colIdNumber.Width = 150;
            // 
            // colCustomerFirstName
            // 
            this.colCustomerFirstName.DataPropertyName = "FirstName";
            this.colCustomerFirstName.HeaderText = "Ad";
            this.colCustomerFirstName.MinimumWidth = 8;
            this.colCustomerFirstName.Name = "colCustomerFirstName";
            this.colCustomerFirstName.Width = 150;
            // 
            // colCustomerLastName
            // 
            this.colCustomerLastName.DataPropertyName = "LastName";
            this.colCustomerLastName.HeaderText = "Soyad";
            this.colCustomerLastName.MinimumWidth = 8;
            this.colCustomerLastName.Name = "colCustomerLastName";
            this.colCustomerLastName.Width = 150;
            // 
            // colPhone
            // 
            this.colPhone.DataPropertyName = "Phone";
            this.colPhone.HeaderText = "Telefon";
            this.colPhone.MinimumWidth = 8;
            this.colPhone.Name = "colPhone";
            this.colPhone.Width = 150;
            // 
            // colEmailAdress
            // 
            this.colEmailAdress.DataPropertyName = "EmailAddress";
            this.colEmailAdress.HeaderText = "E-Posta";
            this.colEmailAdress.MinimumWidth = 8;
            this.colEmailAdress.Name = "colEmailAdress";
            this.colEmailAdress.Width = 150;
            // 
            // colDeleteCustomer
            // 
            this.colDeleteCustomer.HeaderText = "";
            this.colDeleteCustomer.MinimumWidth = 8;
            this.colDeleteCustomer.Name = "colDeleteCustomer";
            this.colDeleteCustomer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDeleteCustomer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colDeleteCustomer.Text = "Sil";
            this.colDeleteCustomer.UseColumnTextForButtonValue = true;
            this.colDeleteCustomer.Width = 150;
            // 
            // colCustomerUpdate
            // 
            this.colCustomerUpdate.HeaderText = "";
            this.colCustomerUpdate.MinimumWidth = 8;
            this.colCustomerUpdate.Name = "colCustomerUpdate";
            this.colCustomerUpdate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCustomerUpdate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colCustomerUpdate.Text = "Düzenle";
            this.colCustomerUpdate.UseColumnTextForButtonValue = true;
            this.colCustomerUpdate.Width = 150;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 480);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.grdListRoom);
            this.Controls.Add(this.grdListReservation);
            this.Controls.Add(this.grdListCustomer);
            this.Controls.Add(this.grdListEmployee);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminForm";
            this.Text = "Yönetim Ekranı";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListEmployee)).EndInit();
            this.contextMenuStripEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdListCustomer)).EndInit();
            this.contextMenuCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdListReservation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdListRoom)).EndInit();
            this.contextMenuStripRoom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem çalışanYönetimiToolStripMenuItem;
        private ToolStripMenuItem menuCreateEmployee;
        private ToolStripMenuItem menuGetEmployee;
        private ToolStripMenuItem odaYönetimiToolStripMenuItem;
        private ToolStripMenuItem menuListRoom;
        private ToolStripMenuItem müşteriYönetimiToolStripMenuItem;
        private ToolStripMenuItem menuCreateCustomer;
        private ToolStripMenuItem menuListCustomer;
        private DataGridView grdListEmployee;
        private DataGridView grdListCustomer;
        private DataGridView grdListReservation;
        private DataGridView grdListRoom;
        private ContextMenuStrip contextMenuStripRoom;
        private ToolStripMenuItem updateRoom;
        private ContextMenuStrip contextMenuStripEmployee;
        private ToolStripMenuItem updateEmployee;
        private ToolStripMenuItem deleteEmployee;
        private ContextMenuStrip contextMenuCustomer;
        private ToolStripMenuItem updateCustomer;
        private ToolStripMenuItem deleteCustomer;
        private ToolStripMenuItem rezervasyonYönetimiToolStripMenuItem;
        private ToolStripMenuItem menuCreateReservation;
        private ToolStripMenuItem menuListReservation;
        private TextBox txtSearch;
        private Label label1;
        private DataGridViewTextBoxColumn colFirstName;
        private DataGridViewTextBoxColumn colLastName;
        private DataGridViewTextBoxColumn colGender;
        private DataGridViewTextBoxColumn colBirthDate;
        private DataGridViewTextBoxColumn colHireDate;
        private DataGridViewTextBoxColumn colRoom;
        private DataGridViewTextBoxColumn colStartDate;
        private DataGridViewTextBoxColumn colEndDate;
        private DataGridViewButtonColumn colDelete;
        private DataGridViewButtonColumn colUpdate;
        private DataGridViewTextBoxColumn colIdNumber;
        private DataGridViewTextBoxColumn colCustomerFirstName;
        private DataGridViewTextBoxColumn colCustomerLastName;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colEmailAdress;
        private DataGridViewButtonColumn colDeleteCustomer;
        private DataGridViewButtonColumn colCustomerUpdate;
    }
}