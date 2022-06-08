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
    public partial class AdminDashboard : Form
    {
        // Constructor
        public AdminDashboard()
        {
            InitializeComponent();
        }
        // Declearing Exit button click event
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            // closing application
            Application.Exit();
        }

        // Declearing Daily Report button click event
        private void DailyReportBtn_Click(object sender, EventArgs e)
        {
            ViewDailyReport viewDailyReport = new ViewDailyReport();
            // hiding admindashboard form
            this.Hide();
            // Showing viewDailyReport Form
            viewDailyReport.Show();
        }

        // Declearing Weekly Report button click event
        private void WeeklyReportBtn_Click(object sender, EventArgs e)
        {
            ViewWeeklyReport viewWeeklyReport = new ViewWeeklyReport();
            // hiding admindashboard form
            this.Hide();
            // Showing viewWeeklyReport Form
            viewWeeklyReport.Show();
        }

        // Declearing Logout button click event
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            // hiding admindashboard form
            this.Hide();
            // Showing Login Form
            Login.Show();
        }

        // Declearing Normal Ticket button click event
        private void NormalTicketsBtn_Click(object sender, EventArgs e)
        {
            NormalTickets normalTickets = new NormalTickets();
            // hiding admindashboard form
            this.Hide();
            // Showing normalTickets Form
            normalTickets.Show();
        }

        // Declearing Holiday Ticket button click event
        private void HolidaysTicketsBtn_Click(object sender, EventArgs e)
        {
            HolidaysTickets holidaysTickets = new HolidaysTickets();
            // hiding admindashboard form
            this.Hide();
            // Showing holidayTickets Form
            holidaysTickets.Show();
        }
    } 

       
}
