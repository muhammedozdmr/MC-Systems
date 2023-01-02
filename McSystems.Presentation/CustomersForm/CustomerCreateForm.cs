using McSystems.Business;
using McSystems.Customers;
using McSystems.DataAccess;
using Microsoft.EntityFrameworkCore.Query.Internal;
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
    public partial class CustomerCreateForm : Form
    {
        private McSystemsContext _context = new McSystemsContext();
        private CustomerService _customerService = new CustomerService();
        public CustomerCreateForm()
        {
            InitializeComponent();
        }

        private void CustomerCreateForm_Load(object sender, EventArgs e)
        {
            var countryService = new CountryService();
            var customerCountry = countryService.GetAll();
            cmbCountry.DataSource = customerCountry;
            cmbCountry.DisplayMember = "Name";
            cmbCountry.ValueMember = "Id";
            rdGenderMale.Checked = false;
            rdGenderFemale.Checked = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var customer = new CustomerDto();
            customer.IdNumber = txtIdNumber.Text;
            customer.FirstName = txtName.Text;
            customer.LastName = txtLastName.Text;
            customer.Phone = txtPhone.Text;
            if (rdGenderMale.Checked)
            {
                customer.Gender = Gender.Male;
            }
            else if (rdGenderFemale.Checked)
            {
                customer.Gender = Gender.Female;
            }
            else
            {
                customer.Gender = Gender.None;
            }
            customer.CountryId = (int)cmbCountry.SelectedValue;
            customer.EmailAddress = txtEMail.Text;
            _customerService.Create(customer);
        }
    }
}
