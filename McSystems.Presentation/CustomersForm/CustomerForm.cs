using McSystems.Business;
using McSystems.Customers;
using McSystems.DataAccess;
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

namespace McSystems.Presentation
{
    public partial class CustomerForm : Form
    {
        private McSystemsContext _context = new McSystemsContext();
        private CustomerService _customerService = new CustomerService();
        public CustomerForm()
        {
            InitializeComponent();
            grdCustomer.AutoGenerateColumns = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var customer = new CustomerDto()
            {
                IdNumber = txtCreateId.Text,
                FirstName = txtCreateName.Text,
                LastName = txtCreateSurname.Text,
                Phone = txtCreatePhone.Text,
                EmailAddress = txtCreateEMail.Text,
                CountryId = (int)cmbCountry.SelectedValue,
                Gender = (Gender)cmbGender.SelectedValue,
            };
            var result = _customerService.Create(customer);
            var customerSummary = new CustomerSummary()
            {
                IdNumber = txtCreateId.Text,

            };
            if (result.IsSucces)
            {
                LoadData();
            }
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            LoadData();
            var customerCountry = new CountryService();
            var country = customerCountry.GetAll();
            cmbGender.DataSource = Enum.GetValues<Gender>();
            cmbCountry.DataSource = country;
            cmbCountry.DisplayMember = "Name";
            cmbCountry.ValueMember = "Id";
        }

        private void grdCustomer_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                grdCustomer.Rows[e.RowIndex].Selected = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (grdCustomer.SelectedRows.Count > 0)
            {
                var customerRegistrationInfo = (CustomerRegistrationInfo)grdCustomer.SelectedRows[0].DataBoundItem;
                var reservationForm = (ReservationForm)Owner;
                reservationForm.AddCustomerId(customerRegistrationInfo.Id);
            }
        }
        private void LoadData()
        {
            var searchCustomer = _customerService.SearchCustomers(txtIdNumber.Text, txtName.Text, txtSurname.Text);
            grdCustomer.DataSource = searchCustomer;
        }
    }
}
