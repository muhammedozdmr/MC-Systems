using McSystems.Employees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using McSystems.Business;

namespace McSystems.Presentation.EmployeesForm
{
    public partial class EmployeeCreateForm : EmployeeBaseForm
    {
        private EmployeeService _employeeService = new EmployeeService();
        public EmployeeCreateForm()
        {
            InitializeComponent();
        }

        private void EmployeeCreateForm_Load(object sender, EventArgs e)
        {
            rdGenderNone.Checked = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var employee = new EmployeeDto();
            employee.FirstName=txtFirstName.Text;
            employee.LastName=txtLastName.Text;
            if (rdGenderNone.Checked)
            {
                employee.Gender = Gender.None;
            }
            else if (rdGenderMale.Checked)
            {
                employee.Gender = Gender.Male;
            }
            else
            {
                employee.Gender = Gender.Female;
            }
            employee.DateOfBirth = dtBirthDate.Value;
            employee.HireDate = dtHireDate.Value;
            _employeeService.Create(employee);
            Close();
        }

    }

}
