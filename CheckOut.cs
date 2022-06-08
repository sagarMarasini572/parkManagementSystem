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
    public partial class CheckOut : Form
    {
		// Constructor
        public CheckOut()
        {
            InitializeComponent();
        }

		// declearing logout Button click event
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
			// Hiding checkout form
			this.Hide();
			// Showing Login form
			Login.Show();
        }

       
		// declearing exit btn click event
        private void ExitBtn_Click(object sender, EventArgs e)
        {
			// closing application
            Application.Exit();
        }

		// declearing checkIn button click event
        private void CheckInBtn_Click(object sender, EventArgs e)
        {
            CheckIn checkIn = new CheckIn();
			// Hiding checkout form
			this.Hide();
			// showing checkIn form
			checkIn.Show();
        }

		// declearing getTimePeriod method
		private int getTimePerid(string time) {
			// storing current time in enteyTimelabrl
			EntryTimeTxtLbl.Text = time;
			// converting current time to shgort format
			ExitTimeTxtLbl.Text = DateTime.Now.ToShortTimeString();
			// calculating time interval of the visitor
			int timePeriod = (int)Math.Ceiling((float)DateTime.Now.Subtract(DateTime.Parse(time)).TotalHours);
			// returing the time period
			return timePeriod;
		}


		// declearing checkOut button click event
		private void CheckOutBtn_Click(object sender, EventArgs e)
		{
			if (exitnumericUpDown.Value == 0)
			{
				// showing error message if exitnummericuodown value equals to 0
				MessageBox.Show("Please Choose Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				try
				{
					// declearing required paths
					string filePath1 = Need.samePath + "visitors.csv";
					string filePath2 = Need.samePath + "individual.csv";

					// storing exitnumericUpdown value in id variable
					int id = (int)exitnumericUpDown.Value;
					// setting newVisitor value as empty
					string newVisitor = "";
					// creating new visitors instant
					Visitors visitors = new Visitors();
					// creating new individual instant
					Individual individual = new Individual();
					// storing visitor in visitorList variable
					List<Visitors> visitorList = new List<Visitors>();
					// storing individuals in individuals list variable
					List<Individual> individualList = new List<Individual>();
					// looping visitiors
					foreach (Visitors v in Visitors.getVisitors())
					{
						// if entry visitor id matched to exiit visitor id
						if (v.id == id)
						{
							// if visitor has not exited yet
							if (v.visitorExitTime == "")
							{
								// storing extimetime label value in visitorExitTime variable 
								v.visitorExitTime = ExitTimeTxtLbl.Text;
								// storing totalFee label value in ticketPrice variable 
								v.ticketPrice = int.Parse(TotalFeeTxtLbl.Text);
								// storing visitor data in visitor list
								visitorList.Add(v);
								// storing all the updated data in newVisitor variable
								newVisitor += v.id + "," + v.groupType + "," + v.adultAgeGroup + "," + v.childAgeGroup + "," + v.visitorEntryTime + "," + v.visitorExitTime + "," + v.dateOfVisit + "," + v.ticketPrice + "," + v.visitDay + "\n";
								// replacing the file with updated data
								File.WriteAllText(filePath1, newVisitor);
								// showing visitor exit success message
								MessageBox.Show("Visitor Exit successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}
							else {
								// showing visitor already exit message
								MessageBox.Show("Visitor already Exit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
						}
						

					}
					// looping visitors
					foreach (Individual v in Individual.getIndividual())
					{
						// entry visitor id matched to exiit visitor id
						if (v.id == id)
						{
							// if visitor has not exited yet
							if (v.visitorExitTime == "")
							{
								// storing extimetime label value in visitorExitTime variable 
								v.visitorExitTime = ExitTimeTxtLbl.Text;
								// storing totalFee label value in ticketPrice variable
								v.ticketPrice = int.Parse(TotalFeeTxtLbl.Text);
								// storing visitor data in individual list
								individualList.Add(v);
								// storing all the updated data in str variable
								string str = v.id + "," + v.ageType + "," + v.visitorEntryTime + "," + v.visitorExitTime + "," + v.dateOfVisit + "," + v.ticketPrice + "," + v.visitDay + "\n";
								// replacing the file with updated data
								File.WriteAllText(filePath2, str);
								// showing visitor exit success message
								MessageBox.Show("Visitor exit successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}
							else
							{
								// showing visitor already exit message
								MessageBox.Show("Visitor already Exit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
						}

						}
					// if individuals cout equals 1 and visitor count equals zero
					if (individualList.Count == 1 && visitorList.Count == 0)
					{
						// showing individual list data in visitor check out table grid
						VisitorCheckOutTable.DataSource = individualList;
					}
					else
					{
						// else showing visitor list data in visitor check out table grid
						VisitorCheckOutTable.DataSource = visitorList;
					}
				}
				// throwing exception
				catch (Exception ex)
				{
					// displaying error message if customer does not enter value in the provided nummeric updown
					MessageBox.Show("Please enter visitorExitTime Manually", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				
				}
				
			}
		
		// declearing exitnummericUpdown_keyPress event
		private void exitnumericUpDown_KeyPress(object sender, KeyPressEventArgs e)
		{
			// storing exitnummericUpdown value in int variable id
			int id = (int)exitnumericUpDown.Value;
			// looping visitors
			foreach (Visitors v in Visitors.getVisitors())
			{
				// entry visitor id matched to exiit visitor id
				if (v.id == id)
				{
					// getting visitor entry time of vistor and storing it on timePeriod variable
					int timePeriod = getTimePerid(v.visitorEntryTime);
					// calculating the total visitors
					TotalPersonTxtLbl.Text = (v.adultAgeGroup + v.childAgeGroup).ToString();
					// calculating total fee
					TotalFeeTxtLbl.Text = TicketPrice.getTicketPrice1(v.visitDay, v.groupType, timePeriod).ToString();
				}
			}
			// looping visitors
			foreach (Individual individual in Individual.getIndividual())
			{
				// entry visitor id matched to exiit visitor id
				if (individual.id == id)
				{
					TotalPersonTxtLbl.Text = "1";
					// getting visitor entry time of individuals and storing it on timePeriod variable
					int timePeriod = getTimePerid(individual.visitorEntryTime);
					// getting child feee price according to the visit in day
					int childFee = TicketPrice.getTicketPrice1(individual.visitDay, "Adult", timePeriod);
					// getting adult feee price according to the visit in day
					int adultFee = TicketPrice.getTicketPrice1(individual.visitDay, "Child", timePeriod);
					// initializing totalFee value as zero
					int totalFeeCalculation = 0;
					// if individual is child 
					if (individual.ageType == "Child")
					{
						// storing child fee in totalFeeCalculation variable
						totalFeeCalculation = childFee;
					}
					else 
					{ 
						// else storing adult fee in totalFeeCalculation variable
						totalFeeCalculation = adultFee; 
					}
						// storing totalFeeCalculation tering value to TotalFee label
						TotalFeeTxtLbl.Text = totalFeeCalculation.ToString();
				}

			}
		}
	}
}
