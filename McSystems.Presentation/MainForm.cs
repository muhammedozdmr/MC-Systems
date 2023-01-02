namespace McSystems.Presentation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Hide();
            var adminForm = new AdminForm();
            adminForm.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            var reservationUserForm = new ReservationUserForm();
            reservationUserForm.Show();
        }
    }
}