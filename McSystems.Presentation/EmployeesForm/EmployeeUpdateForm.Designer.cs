namespace McSystems.Presentation.EmployeesForm
{
    partial class EmployeeUpdateForm
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
            // 
            // txtFirstName
            // 
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            // 
            // txtLastName
            // 
            this.txtLastName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EmployeeUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 370);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "EmployeeUpdateForm";
            this.Text = "Çalışan Bilgi Güncelleme Ekranı";
            this.Load += new System.EventHandler(this.EmployeeUpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}