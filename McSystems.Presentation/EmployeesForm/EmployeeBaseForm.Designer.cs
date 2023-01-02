namespace McSystems.Presentation
{
    partial class EmployeeBaseForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.dtBirthDate = new System.Windows.Forms.DateTimePicker();
            this.dtHireDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.rdGenderMale = new System.Windows.Forms.RadioButton();
            this.rdGenderFemale = new System.Windows.Forms.RadioButton();
            this.rdGenderNone = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyisim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cinsiyet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 168);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Doğum Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 213);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "İşe Giriş Tarihi:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(169, 25);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(284, 31);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(169, 68);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(284, 31);
            this.txtLastName.TabIndex = 2;
            // 
            // dtBirthDate
            // 
            this.dtBirthDate.Location = new System.Drawing.Point(169, 155);
            this.dtBirthDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtBirthDate.Name = "dtBirthDate";
            this.dtBirthDate.Size = new System.Drawing.Size(284, 31);
            this.dtBirthDate.TabIndex = 4;
            // 
            // dtHireDate
            // 
            this.dtHireDate.Location = new System.Drawing.Point(169, 203);
            this.dtHireDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtHireDate.Name = "dtHireDate";
            this.dtHireDate.Size = new System.Drawing.Size(284, 31);
            this.dtHireDate.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(343, 252);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 40);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // rdGenderMale
            // 
            this.rdGenderMale.AutoSize = true;
            this.rdGenderMale.Location = new System.Drawing.Point(169, 118);
            this.rdGenderMale.Name = "rdGenderMale";
            this.rdGenderMale.Size = new System.Drawing.Size(79, 29);
            this.rdGenderMale.TabIndex = 6;
            this.rdGenderMale.TabStop = true;
            this.rdGenderMale.Text = "Erkek";
            this.rdGenderMale.UseVisualStyleBackColor = true;
            // 
            // rdGenderFemale
            // 
            this.rdGenderFemale.AutoSize = true;
            this.rdGenderFemale.Location = new System.Drawing.Point(254, 118);
            this.rdGenderFemale.Name = "rdGenderFemale";
            this.rdGenderFemale.Size = new System.Drawing.Size(81, 29);
            this.rdGenderFemale.TabIndex = 7;
            this.rdGenderFemale.TabStop = true;
            this.rdGenderFemale.Text = "Kadın";
            this.rdGenderFemale.UseVisualStyleBackColor = true;
            // 
            // rdGenderNone
            // 
            this.rdGenderNone.AutoSize = true;
            this.rdGenderNone.Location = new System.Drawing.Point(341, 118);
            this.rdGenderNone.Name = "rdGenderNone";
            this.rdGenderNone.Size = new System.Drawing.Size(215, 29);
            this.rdGenderNone.TabIndex = 8;
            this.rdGenderNone.TabStop = true;
            this.rdGenderNone.Text = "Belirtmek İstemiyorum";
            this.rdGenderNone.UseVisualStyleBackColor = true;
            // 
            // EmployeeBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 328);
            this.Controls.Add(this.rdGenderNone);
            this.Controls.Add(this.rdGenderFemale);
            this.Controls.Add(this.rdGenderMale);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtHireDate);
            this.Controls.Add(this.dtBirthDate);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EmployeeBaseForm";
            this.Text = "Çalışan Kayıt Formu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        protected TextBox txtFirstName;
        protected TextBox txtLastName;
        protected DateTimePicker dtBirthDate;
        protected DateTimePicker dtHireDate;
        protected Button btnSave;
        protected RadioButton rdGenderMale;
        protected RadioButton rdGenderFemale;
        protected RadioButton rdGenderNone;
    }
}