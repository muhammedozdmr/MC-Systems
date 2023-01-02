using McSystems.Business;
using McSystems.Customers;
using McSystems.DataAccess;
using McSystems.DataAccess.Entities;
using McSystems.Reservations;
using McSystems.Rooms;

namespace McSystems.Presentation
{
    public partial class ReservationForm : Form
    {
        private McSystemsContext _context = new McSystemsContext();
        private readonly List<CustomerDto> _customers = new List<CustomerDto>();

        public ReservationForm()
        {
            InitializeComponent();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            grdRooms.Show();
            var reservationService = new ReservationService();
            var reservationList = reservationService.GetAvailableRoomsByDateRange(dtStartDate.Value, dtEndDate.Value);
            grdRooms.DataSource = reservationList;

        }

        private void grdRooms_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                grdRooms.Rows[e.RowIndex].Selected = true;
            }
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            grdRooms.Hide();
            grdSelectedCustomer.Hide();
            grdSelectedCustomer.AutoGenerateColumns = false;
            var employeeService = new EmployeeService();
            var employee = employeeService.GetAll();
            cmbEmployee.DataSource = employee;
            cmbEmployee.DisplayMember = "FirstName";
            cmbEmployee.ValueMember = "Id";
            grdRooms.AutoGenerateColumns = false;
        }

        private void grdRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdRooms.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewButtonCell)
            {
                var roomDto = (RoomDto)grdRooms.Rows[e.RowIndex].DataBoundItem;
                txtSelectedRoom.Text = roomDto.Name;
                txtSelectedRoom.Tag = roomDto.Id;
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (txtSelectedRoom.Text != null)
            {
                grdRooms.Hide();
                grdSelectedCustomer.Show();
                var createCustomer = new CustomerForm();
                createCustomer.Owner = this;
                createCustomer.Show();
            }
            else
            {
                MessageBox.Show("Oda seçimi yapılmadı !");
            }
        }
        public void AddCustomerId(int customerId)
        {
            var customerService = new CustomerService();
            var customerData = customerService.GetById(customerId);
            _customers.Add(customerData);
            grdSelectedCustomer.DataSource = null;
            grdSelectedCustomer.DataSource = _customers;
        }

        private void grdSelectedCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var reservationCustomer = new ReservationDto()
            {
                EmployeeId = cmbEmployee.SelectedValue != null ? (int)cmbEmployee.SelectedValue : null,
                RoomId = (int)txtSelectedRoom.Tag,
                StartDate = dtStartDate.Value,
                EndDate = dtEndDate.Value,
            };

            foreach (var item in _customers)
            {
                reservationCustomer.Customers.Add(item);
            }
            //TODO: Rezervasyon art arda kaydete basınca aynı kaydı birden fazla ekliyor
            if (_context.Reservations.Where(res => reservationCustomer.RoomId == res.RoomId && 
            reservationCustomer.StartDate == res.StartDate && 
            reservationCustomer.EndDate == res.EndDate).Select(res=>res.RoomId).ToList() == null)
            {
                var reservation = new ReservationService();
                reservation.Create(reservationCustomer);
            }
            else
            {
                MessageBox.Show("Bu tarih aralığında bu oda müsait değil!");
            }
        }

    }
}
