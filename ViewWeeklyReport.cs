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
	public partial class ViewWeeklyReport : Form
	{
		// Constructor
		public ViewWeeklyReport()
		{
			InitializeComponent();
		}

		// Declearing Logout button click event
		private void LogoutBtn_Click(object sender, EventArgs e)
		{
			Login Login = new Login();
			// hiding ViewWeeklyReport Form
			this.Hide();
			// Showing Login Form
			Login.Show();
		}

		// Declearing Tickets Button Click event
		private void TicketsBtn_Click(object sender, EventArgs e)
		{
			NormalTickets tickets = new NormalTickets();
			// hiding ViewEeeklyReport Form
			this.Hide();
			// Showing NormalTickets Form
			tickets.Show();
		}

		// Declearing Daily Report button click event
		private void holidayTicketBtn_Click(object sender, EventArgs e)
		{
			HolidaysTickets holidayTickets = new HolidaysTickets();
			// hiding ViewEeeklyReport Form
			this.Hide();
			// Showing holidaysTickets Form
			holidayTickets.Show();
		}

		private void DailyReportBtn_Click(object sender, EventArgs e)
		{
			ViewDailyReport viewDailyReport = new ViewDailyReport();
			// Closingg ViewEeeklyReport Form
			this.Close();
			// Showing viewDailyReport Form
			viewDailyReport.Show();
		}

		// Declearing Exit button click event
		private void ExitBtn_Click(object sender, EventArgs e)
		{
			// Closing application
			Application.Exit();
		}

		//Declare method for sorting total visitors according to the visitDay's totalVisitor
		private List<(string, int, int)> sortByTotalVisitor(List<(string visitDay, int totalVisitor, int income)> sortingData)
		{
			// declearing temport storage
			List<(string, int, int)> temp = new List<(string, int, int)> { ("visitDay", 1, 1) };
			// sorting data by total visitor
			for (int i = 0; i < sortingData.Count - 1; i++)
			{
				for (int j = 0; j < sortingData.Count - 1; j++)
				{
					if (sortingData[j].totalVisitor < sortingData[j + 1].totalVisitor)
					{
						// swaping sortingData
						temp[0] = sortingData[j];
						sortingData[j] = sortingData[j + 1];
						sortingData[j + 1] = temp[0];
					}

				}
			}
			// returning stored data
			return sortingData;
		}

		//Declare method for sorting total income according to the visitDay's totalVisitor
		private List<(string, int, int)> sortByIncome(List<(string visitDay, int totalVisitor, int income)> sortingData)
		{
			// declearing tempory storage
			List<(string, int, int)> temp = new List<(string, int, int)> { ("visitDay", 1, 1) };
			// sorting data by total income
			for (int i = 0; i < sortingData.Count - 1; i++)
			{
				for (int j = 0; j < sortingData.Count - 1; j++)
				{
					if (sortingData[j].income < sortingData[j + 1].income)
					{
						// Swaping sorting data
						temp[0] = sortingData[j];
						sortingData[j] = sortingData[j + 1];
						sortingData[j + 1] = temp[0];
					}
				}
			}
			// returning sorted data
			return sortingData;
		}

		// Declearing DailyReportDatePicker_ValueChanged event
		private void DailyReportDatePicker_ValueChanged(object sender, EventArgs e)
		{
			// if the choosen date is sunday
			if (WeeklyReportDatePicker.Text.Contains("Sunday"))
			{
				// enable sortBox
				sortBox.Enabled = true;
				// storing weekly report date time picker dat in dt variable
				DateTime dt = DateTime.Parse(WeeklyReportDatePicker.Text);
				// converting weekly report date time data to shortDateString and storing it on date of visit variable
				DateTime dateOfVisit = DateTime.Parse(dt.ToShortDateString());
				List<(string visitDay, int totalVisitor, int income)> data;
				// storing weekly data in data variable
				data = Individual.getDataPerWeek(dateOfVisit);
				// clearing weekly visitor count chart data
				WeeklyChart.Series["Visitors Count"].Points.Clear();
				// clearing chart1 total income data
				chart1.Series["Total Income"].Points.Clear();
				for (int i = 0; i < 7; i++)
				{
					// showing weekly visitor count data on chart
					WeeklyChart.Series["Visitors Count"].Points.AddXY(data[i].visitDay, data[i].totalVisitor);
					// showing chart1 total income data on chart
					chart1.Series["Total Income"].Points.AddXY(data[i].visitDay,data[i].income);
				}
			}
			else
			{
				// disabling sortBox
				sortBox.Enabled = false;
				// showing error message if user selected date is other than sunday
				MessageBox.Show("dateOfVisit must be Sunday", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// declearing sortBox_SelectedIndentChange method event
		private void sortBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			// storing weekly report date time picker dat in dt variable
			DateTime dt = DateTime.Parse(WeeklyReportDatePicker.Text);
			// converting weekly report date time data to shortDateString and storing it on date of visit variable
			DateTime dateOfVisit = DateTime.Parse(dt.ToShortDateString());
			List<(string visitDay, int totalVisitor, int income)> li;
			
			// if user selected item is total visitor
			if (sortBox.SelectedItem.ToString() == "Total Visitors")
			{
				List<(string visitDay, int totalVisitor, int income)> weekData=Individual.getDataPerWeek(dateOfVisit);
				List<(string visitDay, int totalVisitor, int income)> data = sortByTotalVisitor(weekData);
				// clearing weekly visitor count chart data
				WeeklyChart.Series["Visitors Count"].Points.Clear();
				// clearing chart1 total income data
				chart1.Series["Total Income"].Points.Clear();
				for (int i = 0; i < 7; i++)
				{
					// showing weekly visitor count data on chart
					WeeklyChart.Series["Visitors Count"].Points.AddXY(data[i].visitDay, data[i].totalVisitor);
					// showing chart1 total income data on chart
					chart1.Series["Total Income"].Points.AddXY(data[i].visitDay, data[i].income);
				}

			}
			// elseif user selected item is total eraning
			else if (sortBox.SelectedItem.ToString() == "Total Earning")
			{
				List<(string visitDay, int totalVisitor, int income)> weekData =Individual.getDataPerWeek(dateOfVisit);
				List<(string visitDay, int totalVisitor, int income)> data = sortByIncome(weekData);
				// clearing weekly visitor count chart data
				WeeklyChart.Series["Visitors Count"].Points.Clear();
				// clearing chart1 total income data
				chart1.Series["Total Income"].Points.Clear();
				for (int i = 0; i < 7; i++)
				{
					// showing weekly visitor count data on chart
					WeeklyChart.Series["Visitors Count"].Points.AddXY(data[i].visitDay, data[i].totalVisitor);
					// showing chart1 total income data on chart
					chart1.Series["Total Income"].Points.AddXY(data[i].visitDay, data[i].income);
				}

			}
		}

        
    }
}
