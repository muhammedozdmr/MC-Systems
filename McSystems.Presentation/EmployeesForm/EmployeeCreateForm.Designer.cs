namespace McSystems.Presentation.EmployeesForm
{
    partial class EmployeeCreateForm
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
            this.SuspendLayout();
            //// 
            //// txtFirstName
            //// 
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            //// 
            //// txtLastName
            //// 
            this.txtLastName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            //// 
            //// dtBirthDate
            //// 
            this.dtBirthDate.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            //// 
            //// dtHireDate
            //// 
            this.dtHireDate.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            //// 
            //// btnSave
            //// 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            //// 
            //// rdGenderMale
            //// 
            this.rdGenderMale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            //// 
            //// rdGenderFemale
            //// 
            this.rdGenderFemale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            //// 
            //// rdGenderNone
            //// 
            this.rdGenderNone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            // 
            // EmployeeCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 316);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "EmployeeCreateForm";
            this.Text = "Yeni Çalışan Kayıt Formu";
            this.Load += new System.EventHandler(this.EmployeeCreateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}