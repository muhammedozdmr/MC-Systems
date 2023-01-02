using McSystems.Business;
using McSystems.Customers;
using McSystems.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace McSystems.Presentation.CustomersForm
{
    public partial class CustomerUpdateForm : Form
    {
        private CustomerService _customerService = new CustomerService();
        private readonly int _customerId;

        public CustomerUpdateForm(int customerId)
        {
            InitializeComponent();
            this._customerId = customerId;
        }

        private void CustomerUpdateForm_Load(object sender, EventArgs e)
        {
            var customer = _customerService.GetById(_customerId);
            txtIdNumber.Text = customer.IdNumber;
            txtName.Text = customer.FirstName;
            txtLastName.Text = customer.LastName;
            if(customer.Gender == Gender.Male)
            {
                rdGenderMale.Checked = true;
            }    
            else if(customer.Gender == Gender.Female)
            {
                rdGenderFemale.Checked = true;
            }
            else
            {
                rdGenderMale.Checked = false;
                rdGenderFemale.Checked = false;
            }
            var countryService = new CountryService();
            var customerCountry = countryService.GetAll();
            cmbCountry.DataSource = customerCountry;
            cmbCountry.SelectedValue = customer.CountryId;
            txtPhone.Text = customer.Phone;
            txtEMail.Text = customer.EmailAddress;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var customerDto = new CustomerDto();
            customerDto.Id = _customerId;
            customerDto.FirstName = txtName.Text;
            customerDto.LastName = txtLastName.Text;
            if (rdGenderMale.Checked)
            {
                customerDto.Gender = Gender.Male;
            }
            else if (rdGenderFemale.Checked)
            {
                customerDto.Gender = Gender.Female;
            }
            else
            {
                customerDto.Gender = Gender.None;
            }
            customerDto.CountryId = (int)cmbCountry.SelectedValue;
            customerDto.Phone = txtPhone.Text;
            customerDto.EmailAddress = txtEMail.Text;
            _customerService.Update(customerDto);
            Close();
        }
    }
}
