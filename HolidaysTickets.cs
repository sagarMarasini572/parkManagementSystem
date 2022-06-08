using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ParkManagementSystem
{
    public partial class HolidaysTickets : Form
    {
        // Constructor
        public HolidaysTickets()
        {
            InitializeComponent();
        }

        // Declearing Normal Ticket button click event
        private void NormalTicketsBtn_Click(object sender, EventArgs e)
        {
            NormalTickets normalTickets = new NormalTickets();
            // hiding HolidaysTickets Form
            this.Hide();
            // Showing normalTickets Form
            normalTickets.Show();
        }

        // Declearing Exit button click event
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            // Closing application
            Application.Exit();
        }

        // Declearing Daily Report button click event
        private void DailyReportBtn_Click(object sender, EventArgs e)
        {
            ViewDailyReport viewDailyReport = new ViewDailyReport();
            // hiding HolidaysTickets Form
            this.Hide();
            // Showing viewDailyReport Form
            viewDailyReport.Show();
        }

        // Declearing WeeklyReport Button Click event
        private void WeeklyReportBtn_Click(object sender, EventArgs e)
        {
            ViewWeeklyReport viewWeeklyReport = new ViewWeeklyReport();
            // hiding HolidaysTickets Form
            this.Hide();
            // Showing viewWeeklyReport Form
            viewWeeklyReport.Show();
        }

        // Declearing Logout button click event
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            // hiding HolidaysTickets Form
            this.Hide();
            // Showing Login Form
            Login.Show();
        }

        // Declearing clearFields to set nummericUpdown values to 0
        private void clearFields()
        {
            childPriceNumeric.Value = 0;
            adultPriceNumeric.Value = 0;
            group5Numeric.Value = 0;
            group10Numeric.Value = 0;
            group10aboveNumeric.Value = 0;
        }

        // Declearing AddTicketButton Click event
        private void AddTicketBtn_Click(object sender, EventArgs e)
		{

            // geting TicketPrice from holiday.csv file
            TicketsTable.DataSource = TicketPrice.getTicketPrice("holiday");
            if (childPriceNumeric.Value == 0 || adultPriceNumeric.Value == 0 || group5Numeric.Value == 0 || group10Numeric.Value == 0 || group10aboveNumeric.Value == 0) {
                // Displaying error message if nay of the nummericUpdown fields are empty
                MessageBox.Show("Fields cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                // initalizing eachTicketPrice liist to store new Ticket Prices
                int[] eachTicketPrice = new int[]{(int)childPriceNumeric.Value, (int)adultPriceNumeric.Value, (int)group5Numeric.Value, (int)group10Numeric.Value, (int)group10aboveNumeric.Value
                   };
                // geting ticket price from holiday.csv file and storing it in TicketPrice List
                List<TicketPrice> t = TicketPrice.getTicketPrice("holiday");
                // storing new ticket price to hour1 in eachTicketPrice list  if onehourRadio is checked
                if (oneHourRadio.Checked == true)
                {
                   for (int i = 0; i < 5; i++)
                   {
                      t[i].hour1 = eachTicketPrice[i];
                   }
                }
                // storing new ticket price to hour2 in eachTicketPrice list  if twohourRadio is checked
                else if (twoHourRadio.Checked == true)
                {
                   for (int i = 0; i < 5; i++)
                   {
                      t[i].hour2 = eachTicketPrice[i];
                   }
                }
                // storing new ticket price to hour3 in eachTicketPrice list  if threehourRadio is checked
                else if (threeHourRadio.Checked == true)
                {
                   for (int i = 0; i < 5; i++)
                   {
                      t[i].hour3 = eachTicketPrice[i];
                   }
                }
                // storing new ticket price to hour4 in eachTicketPrice list  if fourhourRadio is checked
                else if (fourHourRadio.Checked == true)
                {
                   for (int i = 0; i < 5; i++)
                   {
                      t[i].hour4 = eachTicketPrice[i];
                   }
                }
                // storing new ticket price to wholeDay in eachTicketPrice list  if wholeDayRadio is checked
                else if (wholeDayRadio.Checked == true)
                {
                   for (int i = 0; i < 5; i++)
                   {
                      t[i].wholeDay = eachTicketPrice[i];
                   }
                }
                // declear string updateTicket variable to store updated ticket price
                string updatedTicket = "";
                foreach (TicketPrice ticketPrice in t)
                {
                    updatedTicket += ticketPrice.hour1 + "," + ticketPrice.hour2 + "," + ticketPrice.hour3 + "," + ticketPrice.hour4 + "," + ticketPrice.wholeDay + "\n";
                }
                // Writing updated Ticket price to holiday.csv
                File.WriteAllText(Need.samePath + "holiday.csv", updatedTicket);
                // Displaying success message after successful price addition
                MessageBox.Show("Price successfull Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // displaying changes in change price table
                TicketsChangedTable.DataSource = TicketPrice.getTicketPrice("holiday");

            }

        }

        private void EditTicketBtn_Click(object sender, EventArgs e)
		{

             // geting TicketPrice from weekday.csv file
             TicketsTable.DataSource = TicketPrice.getTicketPrice("holiday");
             if (ChooseTicComBox.SelectedIndex == -1 || newPriceNumeric.Value == 0)
             {
                // displaying error messgae if any of ChooseTicComBox or newPriceNumeric are not choose or empty respectively 
                MessageBox.Show("Please enter all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             else
             {
                try
                {
                   // initalizing loacl variable group and storing selected index of ChooseTicBox to String
                   string group = ChooseTicComBox.SelectedItem.ToString();

                   int row = Need.getGroupTypes(group);
                   // initalizing local variable new Price
                   int newPrice = (int)newPriceNumeric.Value;
                   // geting ticket price from holiday.csv file and storing it in TicketPrice List
                   List<TicketPrice> t = TicketPrice.getTicketPrice("holiday");

                   // updating new ticket price to hour1 if onehourRadio is checked
                   if (oneHourRadio.Checked == true)
                   {
                      t[row].hour1 = newPrice;
                   }
                   // updating new ticket price to hour2 if twohourRadio is checked
                   else if (twoHourRadio.Checked == true)
                   {
                      t[row].hour2 = newPrice;
                   }
                   // updating new ticket price to hour3 if threehourRadio is checked
                   else if (threeHourRadio.Checked == true)
                   {

                      t[row].hour3 = newPrice;
                   }
                   // updating new ticket price to hour4 if fourhourRadio is checked
                   else if (fourHourRadio.Checked == true)
                   {
                      t[row].hour4 = newPrice;
                   }
                   // updating new ticket price to wholeday if wholeDayRadio is checked
                   else if (wholeDayRadio.Checked == true)
                   {
                      t[row].wholeDay = newPrice;
                   }
                   // declear string updateTicket variable to store updated ticket price 
                   string updatedTicket = "";
                   foreach (TicketPrice ticketPrice in t)
                   {
                      updatedTicket += ticketPrice.hour1 + "," + ticketPrice.hour2 + "," + ticketPrice.hour3 + "," + ticketPrice.hour4 + "," + ticketPrice.wholeDay + "\n";
                   }
                   // Writing updated Ticket price to holiday.csv
                   File.WriteAllText(Need.samePath + "holiday.csv", updatedTicket);

                   // Displaying success message after successful price update
                   MessageBox.Show("Price successfully Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                // throwing exception
                catch (Exception ex)
                {
                    // displaying an error message 
                    MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    // displaying changes in change price table
                    TicketsChangedTable.DataSource = TicketPrice.getTicketPrice("holiday");
             }
         
        }

        // Declearing HolidaysTickets Form load event
        private void HolidaysTickets_Load(object sender, EventArgs e)
		{
            // making oneHourRadio button checked as defult button
            oneHourRadio.Checked = true;
            // getting holiday table data and showing in Privious Ticket Price Table
            TicketsTable.DataSource = TicketPrice.getTicketPrice("holiday");
		}

        // Declearing oneHourRadio_checkChange event and Calling clearFields method
        private void oneHourRadio_CheckedChanged(object sender, EventArgs e)
        {
            clearFields();
        }

        // Declearing twoHourRadio_checkChange event and Calling clearFields method
        private void twoHourRadio_CheckedChanged(object sender, EventArgs e)
        {
            clearFields();
        }

        // Declearing threeHourRadio_checkChange event and Calling clearFields method
        private void threeHourRadio_CheckedChanged(object sender, EventArgs e)
        {
            clearFields();
        }

        // Declearing fourHourRadio_checkChange event and Calling clearFields method
        private void fourHourRadio_CheckedChanged(object sender, EventArgs e)
        {
            clearFields();
        }

        // Declearing wholeDayRadio_checkChange event and Calling clearFields method
        private void wholeDayRadio_CheckedChanged(object sender, EventArgs e)
        {
            clearFields();
        }

        // Declearing ChooseTicCombBox_SelectIndexChange event and Setting value of newPriceNumeric to 0
        private void ChooseTicComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            newPriceNumeric.Value = 0;
        }
    }
}
