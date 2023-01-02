namespace McSystems.Presentation
{
    partial class ReservationUserForm
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grdAvailableRooms = new System.Windows.Forms.DataGridView();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.grdAvailableRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(428, 52);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Ara";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Bitiş:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Başlangıç:";
            // 
            // grdAvailableRooms
            // 
            this.grdAvailableRooms.AllowUserToAddRows = false;
            this.grdAvailableRooms.AllowUserToDeleteRows = false;
            this.grdAvailableRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdAvailableRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAvailableRooms.Cursor = System.Windows.Forms.Cursors.No;
            this.grdAvailableRooms.Location = new System.Drawing.Point(40, 98);
            this.grdAvailableRooms.Margin = new System.Windows.Forms.Padding(2);
            this.grdAvailableRooms.MultiSelect = false;
            this.grdAvailableRooms.Name = "grdAvailableRooms";
            this.grdAvailableRooms.ReadOnly = true;
            this.grdAvailableRooms.RowHeadersWidth = 62;
            this.grdAvailableRooms.RowTemplate.Height = 33;
            this.grdAvailableRooms.Size = new System.Drawing.Size(469, 170);
            this.grdAvailableRooms.TabIndex = 10;
            // 
            // dtEndDate
            // 
            this.dtEndDate.Location = new System.Drawing.Point(234, 52);
            this.dtEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(177, 23);
            this.dtEndDate.TabIndex = 8;
            // 
            // dtStartDate
            // 
            this.dtStartDate.Location = new System.Drawing.Point(40, 52);
            this.dtStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(177, 23);
            this.dtStartDate.TabIndex = 9;
            // 
            // ReservationUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 288);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdAvailableRooms);
            this.Controls.Add(this.dtEndDate);
            this.Controls.Add(this.dtStartDate);
            this.Name = "ReservationUserForm";
            this.Text = "ReservationUserForm";
            ((System.ComponentModel.ISupportInitialize)(this.grdAvailableRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected Button btnSearch;
        private Label label2;
        private Label label1;
        protected DataGridView grdAvailableRooms;
        protected DateTimePicker dtEndDate;
        protected DateTimePicker dtStartDate;
    }
}