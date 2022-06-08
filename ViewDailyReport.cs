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
    public partial class ViewDailyReport : Form
    {
        // Constructor
        public ViewDailyReport()
        {
            InitializeComponent();
        }

        // Declearing Logout button click event
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            // hiding viewDailyReport Form
            this.Hide();
            // Showing Login Form
            Login.Show();
        }

        // Declearing Tickets Button Click event
        private void TicketsBtn_Click(object sender, EventArgs e)
        {
            NormalTickets tickets = new NormalTickets();
            // hiding viewDailyReport Form
            this.Hide();
            // Showing NormalTickets Form
            tickets.Show();
        }

        // Declearing Daily Report button click event
        private void HolidayTicketBtn_Click(object sender, EventArgs e)
        {
            HolidaysTickets holidayTickets = new HolidaysTickets();
            // hiding viewDailyReport Form
            this.Hide();
            // Showing holidaysTickets Form
            holidayTickets.Show();
        }

        // Declearing WeeklyReport Button Click event
        private void WeeklyReportBtn_Click(object sender, EventArgs e)
        {
            ViewWeeklyReport viewWeeklyReport = new ViewWeeklyReport();
            // hiding viewDailyReport Form
            this.Hide();
            // Showing viewWeeklyReport Form
            viewWeeklyReport.Show();
        }

        // Declearing Exit button click event
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            // Closing application
            Application.Exit();
        }
        
        // Declearing ViewDailyReport_load event
		private void ViewDailyReport_Load(object sender, EventArgs e)
		{
             // Storing present date and time in dataOfVisit variable
             string dateOfVisit = DateTime.Now.ToShortDateString();
             // getting visitor data and showing it on grid
             DailyTable.DataSource = Visitors.getVisitorPerDay(dateOfVisit);
             // getting individual data and showing it on grid
             DailyIndividual.DataSource = Individual.getVisitorPerDay(dateOfVisit);
             // taking daily count
             (int group5, int group10, int groupAbove10) = Visitors.getCombinedCount(dateOfVisit);
             (int adultAgeGroup, int childAgeGroup) = Individual.getACCount(dateOfVisit);
             if (group5 == 0 && group10 == 0 && groupAbove10 == 0 && adultAgeGroup == 0 && childAgeGroup == 0)
             {
                // showing empty chart if aove parameters are equals to 0
                DailyChart.Series["Series1"].Points.DefaultIfEmpty();
             }
             else {
                // showing respective adult, child, groupof5, groupof10,groupofabove10 data in chart
                DailyChart.Series["Series1"].Points.AddXY("Adult", adultAgeGroup);
                DailyChart.Series["Series1"].Points.AddXY("Child", childAgeGroup);
                DailyChart.Series["Series1"].Points.AddXY("Group of 5", group5);
                DailyChart.Series["Series1"].Points.AddXY("Group of 10", group10);
                DailyChart.Series["Series1"].Points.AddXY("Group of above 10", groupAbove10);
             }

        }

        // Declearing DailyReportDatePicker_ValueChange event
		private void DailyReportDatePicker_ValueChanged(object sender, EventArgs e)
		{
             // Clearing data from chart
             DailyChart.Series["Series1"].Points.Clear();
             // Storing user selected date in dateOfVisit variable
             string dateOfVisit = DateTime.Parse(DailyReportDatePicker.Text).ToShortDateString();
             // getting visitor and showing it on grid
             DailyTable.DataSource = Visitors.getVisitorPerDay(dateOfVisit);
             // getting individuals data and showing it on grid
             DailyIndividual.DataSource = Individual.getVisitorPerDay(dateOfVisit);
             // taking daily count
             (int group5, int group10, int groupAbove10) = Visitors.getCombinedCount(dateOfVisit);
             (int adultAgeGroup, int childAgeGroup) = Individual.getACCount(dateOfVisit);
             // showing respective adult, child, groupof5, groupof10,groupofabove10 data in chart
             DailyChart.Series["Series1"].Points.AddXY("Adult", adultAgeGroup);
             DailyChart.Series["Series1"].Points.AddXY("Child", childAgeGroup);
             DailyChart.Series["Series1"].Points.AddXY("Group of 5", group5);
             DailyChart.Series["Series1"].Points.AddXY("Group of 10", group10);
             DailyChart.Series["Series1"].Points.AddXY("Group of above 10", groupAbove10);
        }

        
    }
}
