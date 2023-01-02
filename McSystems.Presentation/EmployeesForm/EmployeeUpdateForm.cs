using McSystems.Business;
using McSystems.DataAccess.Entities;
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

namespace McSystems.Presentation.EmployeesForm
{
    public partial class EmployeeUpdateForm : EmployeeBaseForm
    {
        private EmployeeService _employeeService = new EmployeeService();
        private readonly int _employeeId;

        public EmployeeUpdateForm(int employeeId)
        {
            InitializeComponent();
            this._employeeId = employeeId;
        }

        private void EmployeeUpdateForm_Load(object sender, EventArgs e)
        {
            var employee = _employeeService.GetById(_employeeId);
            txtFirstName.Text = employee.FirstName;
            txtLastName.Text = employee.LastName;
            if (employee.Gender == Gender.Male)
            {
                rdGenderMale.Checked = true;
            }
            else if (employee.Gender == Gender.Female)
            {
                rdGenderFemale.Checked = true;
            }
            else
            {
                rdGenderNone.Checked = true;
            }
            dtBirthDate.Value = employee.DateOfBirth;
            dtHireDate.Value = employee.HireDate;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var employeeDto = new EmployeeDto();
            employeeDto.Id = _employeeId;
            employeeDto.FirstName = txtFirstName.Text;
            employeeDto.LastName = txtLastName.Text;
            employeeDto.DateOfBirth = dtBirthDate.Value;
            employeeDto.HireDate = dtHireDate.Value;
            employeeDto.HireDate = dtHireDate.Value;
            if (rdGenderNone.Checked)
            {
                employeeDto.Gender = Gender.None;
            }
            else if (rdGenderMale.Checked)
            {
                employeeDto.Gender = Gender.Male;
            }
            else
            {
                employeeDto.Gender = Gender.Female;
            }
            _employeeService.Update(employeeDto);
            Close();
            
        }
    }
}
