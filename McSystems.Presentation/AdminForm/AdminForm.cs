using McSystems.Business;
using McSystems.Customers;
using McSystems.DataAccess;
using McSystems.Employees;
using McSystems.Presentation.CustomersForm;
using McSystems.Presentation.EmployeesForm;
using Microsoft.VisualBasic;
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
    public partial class AdminForm : Form
    {
        private EmployeeService _employeeService = new EmployeeService();
        private ReservationService _reservationService = new ReservationService();
        private CustomerService _customerService = new CustomerService();
        private McSystemsContext _context = new McSystemsContext();
        public AdminForm()
        {
            InitializeComponent();
        }

        //EmployeeDataGried
        private void menuCreateEmployee_Click(object sender, EventArgs e)
        {
            var createEmployee = new EmployeeCreateForm();
            createEmployee.Show();
            createEmployee.FormClosed += CreateEmployee_FormClosed;
        }

        private void CreateEmployee_FormClosed(object? sender, FormClosedEventArgs e)
        {
            RefreshListEmployee();
        }

        private void menuGetEmployee_Click(object sender, EventArgs e)
        {
            grdListEmployee.Show();
            grdListCustomer.Hide();
            grdListReservation.Hide();
            grdListRoom.Hide();
            var listEmployee = _employeeService.GetAll();
            grdListEmployee.DataSource = listEmployee;
        }

        private void updateEmployee_Click(object sender, EventArgs e)
        {
            if (grdListEmployee.SelectedRows.Count > 0)
            {
                var employeeDto = (EmployeeDto)grdListEmployee.SelectedRows[0].DataBoundItem;
                var employeeUpdateForm = new EmployeeUpdateForm(employeeDto.Id);
                employeeUpdateForm.MdiParent = this.MdiParent;
                employeeUpdateForm.Show();
                employeeUpdateForm.FormClosed += EmployeeUpdateForm_FormClosed;
            }
        }

        private void EmployeeUpdateForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            RefreshListEmployee();
        }

        private void grdListEmployee_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                grdListEmployee.Rows[e.RowIndex].Selected = true;
            }
        }

        public void RefreshListEmployee()
        {
            var employee = _employeeService.GetAll();
            grdListEmployee.DataSource = employee;
        }

        private void deleteEmployee_Click(object sender, EventArgs e)
        {
            var employeeDto = (EmployeeDto)grdListEmployee.SelectedRows[0].DataBoundItem;
            var result = MessageBox.Show($"{employeeDto.FirstName} isimli çalışanı silmek istediğinize emin misiniz ?", "Dikkat !", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    _employeeService.Delete(employeeDto);
                    MessageBox.Show("Silindi !");
                    RefreshListEmployee();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        //Main Form Load
        private void AdminForm_Load(object sender, EventArgs e)
        {
            grdListCustomer.Hide();
            grdListEmployee.Hide();
            grdListReservation.Hide();
            grdListRoom.Hide();
        }

        //ReservationDataGried
        private void menuCreateReservation_Click(object sender, EventArgs e)
        {
            var createReservation = new ReservationForm();
            createReservation.Show();
            createReservation.FormClosed += CreateReservation_FormClosed;
        }

        private void CreateReservation_FormClosed(object? sender, FormClosedEventArgs e)
        {
            RefreshListReservation();
        }
        public void RefreshListReservation()
        {
            var reservation = _reservationService.GetAll();
            grdListReservation.DataSource = reservation;
        }

        private void menuListReservation_Click(object sender, EventArgs e)
        {
            grdListReservation.Show();
            grdListEmployee.Hide();
            grdListCustomer.Hide();
            grdListRoom.Hide();
            var reservationList = _reservationService.GetAll();
            grdListReservation.DataSource = reservationList;
        }

        private void grdListReservation_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                grdListReservation.Rows[e.RowIndex].Selected = true;
            }
        }

        //CustomerDataGried
        private void menuCreateCustomer_Click(object sender, EventArgs e)
        {
            var createCustomer = new CustomerCreateForm();
            createCustomer.Show();
            createCustomer.FormClosed += CreateCustomer_FormClosed;
        }

        private void CreateCustomer_FormClosed(object? sender, FormClosedEventArgs e)
        {
            RefreshListCustomer();
        }

        public void RefreshListCustomer()
        {
            var customer = _customerService.GetAll();
            grdListReservation.DataSource = customer;
        }

        private void menuListCustomer_Click(object sender, EventArgs e)
        {
            grdListCustomer.Show();
            grdListEmployee.Hide();
            grdListReservation.Hide();
            grdListRoom.Hide();
            var customerList = _customerService.GetAll();
            grdListCustomer.DataSource = customerList;
        }
        private void grdListCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdListCustomer.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewButtonCell)
            {
                if (grdListCustomer.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.Name == "colDeleteCustomer")
                {
                    var customerDto = (CustomerDto)grdListCustomer.Rows[e.RowIndex].DataBoundItem;
                    _customerService.Delete(customerDto);
                    RefreshListCustomer();
                }
                else
                {
                    var customerDtoUpdate = (CustomerDto)grdListCustomer.Rows[e.RowIndex].DataBoundItem;
                    var customerUpdateForm = new CustomerUpdateForm(customerDtoUpdate.Id);
                    customerUpdateForm.Show();
                    Hide();
                    customerUpdateForm.FormClosed += CustomerUpdateForm_FormClosed;
                }
            }
        }

        private void CustomerUpdateForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Show();
            RefreshListCustomer();
        }

        private void grdListCustomer_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                grdListCustomer.Rows[e.RowIndex].Selected = true;
            }
        }

        //All Forms Search Bar
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var searchValue = txtSearch.Text;
            if (grdListCustomer.Visible)
            {
                var searchCustomer = _context.Customers.Where(customer => customer.FirstName.Contains(searchValue)).ToList();
                grdListCustomer.DataSource = searchCustomer;
            }
            else if (grdListEmployee.Visible)
            {
                var searchEmployee = _context.Employees.Where(employee => employee.FirstName.Contains(searchValue)).ToList();
                grdListEmployee.DataSource = searchEmployee;
            }
            else if (grdListReservation.Visible)
            {
                var searchEmployee = _context.Reservations.Where(reservation => reservation.RoomId.Equals(searchValue)).ToList();
                grdListEmployee.DataSource = searchEmployee;
            }
            else
            {
                var searchRoom = _context.Rooms.Where(room => room.Name.Contains(searchValue)).ToList();
                grdListRoom.DataSource = searchRoom;
            }

        }


    }
}
