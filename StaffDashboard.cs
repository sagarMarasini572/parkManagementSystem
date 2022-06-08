using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkManagementSystem
{
    public partial class StaffDashboard : Form
    {
        // Constructor
        public StaffDashboard()
        {
            InitializeComponent();
        }

        // Declearing Exit Button Click event
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            // Closing application
            Application.Exit();
        }
        
        // Declearing Logout Button Click event
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            // Hiding staffDashboard Form
            this.Hide();
            // Showing Login Form
            Login.Show();
        }

        // Declearing Checkin Button Click event
        private void CheckInBtn_Click(object sender, EventArgs e)
        {
            CheckIn checkIn = new CheckIn();
            // Hiding staffDashboard Form
            this.Hide();
            // Showing CheckIn Form
            checkIn.Show();
        }

        // Decleaing checkOut button click event
        private void CheckOutBtn_Click(object sender, EventArgs e)
        {
            CheckOut checkOut = new CheckOut();
            // Hiding staffDashboard Form
            this.Hide();
            // showing checkOut Form
            checkOut.Show();
        }
    }
}
