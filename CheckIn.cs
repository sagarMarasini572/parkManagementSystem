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
using System.Runtime.Serialization.Formatters.Binary;

namespace ParkManagementSystem
{
    public partial class CheckIn : Form
    {
        // global variable serializeData
        Visitors serializeData = new Visitors();

        // Constructor
        public CheckIn()
        {
            InitializeComponent();
        }

        // Declearing logout button click event
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            // serializing childUpdown value
            serializeData.childAgeGroup = (int)ChildUpDown.Value;
            // serializing adultUpdown value
            serializeData.adultAgeGroup = (int)AdultDown.Value;
            // serializing estimatedHourUpdown value
            serializeData.estimated = (int)EstimatedHourUpDown.Value;
            // serialize visit Day
            serializeData.visitDay = dayComboBox.SelectedItem.ToString();
            // serialize groupType
            serializeData.groupType = GroupTypeComBox.SelectedItem.ToString();
            // creating file to store data
            FileStream stream = new FileStream(Need.samePath + "serializeData", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            // serialize stream object
            formatter.Serialize(stream, serializeData);
            // closing stram
            stream.Close();
            Login Login = new Login();
            // Hiding checkin Form
            this.Hide();
            // Showing Login Form
            Login.Show();
        }

        // Declearing exit button click event
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            // serializing childUpdown value
            serializeData.childAgeGroup = (int)ChildUpDown.Value;
            // serializing adultUpdown value
            serializeData.adultAgeGroup = (int)AdultDown.Value;
            // serializing estimatedHourUpdown value
            serializeData.estimated = (int)EstimatedHourUpDown.Value;
            // if user select index from dayCombobox
            if (dayComboBox.SelectedIndex != -1)
            {
                // serialize visit Day
                serializeData.visitDay = dayComboBox.SelectedItem.ToString();
            }
            // if user select index from GroupTypeComBox
            if (GroupTypeComBox.SelectedIndex != -1)
            {
                // serialize groupType
                serializeData.groupType = GroupTypeComBox.SelectedItem.ToString();
            }        
                // creating new stream
                FileStream stream = new FileStream(Need.samePath + "serializeData", FileMode.Create);
                // declearing new BinaryFormatter
                BinaryFormatter formatter = new BinaryFormatter();
                // serialize straem object
                formatter.Serialize(stream, serializeData);
                // closing stram
                stream.Close();
                // closing application
                Application.Exit();
        }

        // Declearing CheckOut Button Click event
        private void CheckOuBtn_Click(object sender, EventArgs e)
        {
            // serializing childUpdown value
            serializeData.childAgeGroup = (int)ChildUpDown.Value;
            // serializing adultUpdown value
            serializeData.adultAgeGroup = (int)AdultDown.Value;
            // serializing estimatedHourUpdown value
            serializeData.estimated = (int)EstimatedHourUpDown.Value;
        // if user select index from dayCombobox
        if (dayComboBox.SelectedIndex != -1) 
        { 
            // serialize visit Day
            serializeData.visitDay = dayComboBox.SelectedItem.ToString(); 
        }
        // if user select index from dayCombobox
        if (GroupTypeComBox.SelectedIndex != -1)
        {
            // serialize groupType
            serializeData.groupType = GroupTypeComBox.SelectedItem.ToString();
        }
            // creating new stream
            FileStream stream = new FileStream(Need.samePath + "serializeData", FileMode.Create);
            // declearing new BinaryFormatter
            BinaryFormatter formatter = new BinaryFormatter();
            // serialize straem object
            formatter.Serialize(stream, serializeData);
            // closing stream
            stream.Close();
            // creating new checkOut form
            CheckOut checkOut = new CheckOut();
            // hiding checkin form
            this.Hide();
            // showing check out form
            checkOut.Show();
        }

        // Declearing checkin Button click event
		private void CheckIn_Load(object sender, EventArgs e)
		{
            // getting ticket price from weekday.csv and storing it on visitor checkIn table grid
            VisitorCheckInTable.DataSource = TicketPrice.getTicketPrice("weekday");
            IdTxtLbl.Text = ((Visitors.getVisitors().Count+Individual.getIndividual().Count) + 1).ToString();

        }

         // Declearing getChildTicketPrice method
         private void getChildTicketPrice() 
         {  
            // getting childTicketPrice based on estimated time interval
            int childTicketPrice = TicketPrice.getTicketPrice1(dayComboBox.SelectedItem.ToString(), "Child", (int)EstimatedHourUpDown.Value);
            // getting adultTicketPrice based on estimated time interval
            int adultTicketPrice = TicketPrice.getTicketPrice1(dayComboBox.SelectedItem.ToString(), "Adult", (int)EstimatedHourUpDown.Value);
            // calculating total price
            int total = childTicketPrice + adultTicketPrice;
            // storing it on estimatedPrice textfield
            EstimatedPriceTf.Text = total.ToString();
         }

         // declearing getAdultTicketPrice method
         private void getAdultTicketPrice()
         {     
             // getting ticket price
             int Price = TicketPrice.getTicketPrice1(dayComboBox.SelectedItem.ToString(), GroupTypeComBox.SelectedItem.ToString(),(int)EstimatedHourUpDown.Value);
             // storing it on estimateddPrice textfield
             EstimatedPriceTf.Text = Price.ToString();
         }

         // declearing getEstimatedPersonTicketPrice method
         private void getEstimatedPersonTicketPrice() { 
             // storing childUpdown value in childAgeGroup variable
             int childAgeGroup= (int)ChildUpDown.Value;
             // storing adultUpdown value in adultAgeGroup variable
             int adultAgeGroup =(int)AdultDown.Value;
             // calculating total person
             int totalPerson = childAgeGroup + adultAgeGroup;
             // storing calculated total person value in totalPersonTf.Text
             TotalPersonTf.Text = totalPerson.ToString();
             // if user select below 5 from combo box 
             if (GroupTypeComBox.SelectedItem.ToString() == "Below 5")
             {
                // get child TickeT price
                getChildTicketPrice();
             }
             else {
                // else get adult ticket price
                getAdultTicketPrice();
             }
         
         }

        // declearing adultDown_keyPress event and getting estimated person Ticket Price
		 private void AdultDown_KeyPress(object sender, KeyPressEventArgs e)
		 {
             getEstimatedPersonTicketPrice();
		 }

          // declearing childUpdown_KeyPress event and getting Estimated Person Ticket Price
		 private void ChildUpDown_KeyPress(object sender, KeyPressEventArgs e)
		 {
             getEstimatedPersonTicketPrice();
         }

         // declearing checkInBt_Click event
		 private void CheckInBtn_Click(object sender, EventArgs e)
		 {
            // if user does not selct any of the provided combo box or nummeric value
			 if (dayComboBox.SelectedIndex == -1 || GroupTypeComBox.SelectedIndex == -1 || ChildUpDown.Value == 0 || AdultDown.Value == 0 || EstimatedHourUpDown.Value == 0)
			 {
                // displaying error message indicating fields cannot be empty
				 MessageBox.Show("Field cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			 }
			 else
			 {
                // else getting startTime and Edit time from need.getBussinessHour 
                 (double startTimeCompare, double endTimeCompare) = Need.getBussinessHour();
                 // validating entry time
                 if (startTimeCompare >= 0 && endTimeCompare < 0)
                 {
                    // storing visitor selected group type index in look variable
                    string look = GroupTypeComBox.SelectedItem.ToString();
                    // getting group type froom need.getGroupType method and storing it on result variable
                    string result = Need.getGrouptype((int)ChildUpDown.Value+(int)AdultDown.Value);
                    // if group type matched then
                    if (look == result)
                    {
                        // if sum of adultDown value and childUpDown value is smaller then 5
                        if (AdultDown.Value + ChildUpDown.Value < 5)
                        {
                             // setting path to store data
                            string filePath = Need.samePath + "individual.csv";
                            for (int i = 0; i < ChildUpDown.Value; i++)
                            {
                                 // creating new instant Individual
                                Individual ind = new Individual();
                                // storing values in individuals
                                ind.id = int.Parse(IdTxtLbl.Text);
                                ind.ageType = "Child";
                                ind.visitorEntryTime = DateTime.Now.ToShortTimeString();
                                ind.visitorExitTime = "";
                                ind.ticketPrice = 0;
                                ind.dateOfVisit = DateTime.Now.ToShortDateString();
                                // storing updated data in string variable st
                                string str = ind.id + "," + ind.ageType + "," + ind.visitorEntryTime + "," + ind.visitorExitTime + "," + ind.dateOfVisit + "," + ind.ticketPrice + "\n";
                                // appending the file to st
                                File.AppendAllText(filePath, str);
                                // increaing id by 1 and storing in IdTxtLbl
                                IdTxtLbl.Text = (int.Parse(IdTxtLbl.Text) + 1).ToString();


                            }
                            for (int i = 0; i < AdultDown.Value; i++)
                            {
                                // creating new instance Individual
                                Individual ind = new Individual();
                                // storing values in individuals
                                ind.id = int.Parse(IdTxtLbl.Text) + i;
                                ind.ageType = "Adult";
                                ind.visitorEntryTime = DateTime.Now.ToShortTimeString();
                                ind.visitorExitTime = "";
                                ind.ticketPrice = 0;
                                ind.dateOfVisit = DateTime.Now.ToShortDateString();
                                ind.visitDay = dayComboBox.SelectedItem.ToString();
                                // storing updated data in string variable st
                                string st = ind.id + "," + ind.ageType + "," + ind.visitorEntryTime + "," + ind.visitorExitTime + "," + ind.dateOfVisit + "," + ind.ticketPrice +","+ind.visitDay+ "\n";
                                // appending the file to st
                                File.AppendAllText(filePath, st);
                                // increaing id by 1 and storing in IdTxtLbl
                                IdTxtLbl.Text = (int.Parse(IdTxtLbl.Text) + 1).ToString();
                            }
                                // getting individuals data and storing in individuals list
                                List<Individual> individuals = Individual.getIndividual();
                                // calculating total individuals
                                int totalIndividuals = (int)(AdultDown.Value + ChildUpDown.Value);
                                // storing and displaying updated data invisitorChedkInTable grid
                                VisitorCheckInTable.DataSource = individuals.Skip(Math.Max(0, individuals.Count() - totalIndividuals)).Take(totalIndividuals);
                                // showing success message
                                MessageBox.Show("Visitor Successfully Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                             // declaing file path 
                             string filePath = Need.samePath + "visitors.csv";
                             try
                             {
                                // creating new instance visitors
                                Visitors v = new Visitors();
                                // storing valus in visitors
                                v.id = int.Parse(IdTxtLbl.Text);
                                v.adultAgeGroup = (int)AdultDown.Value;
                                v.groupType = GroupTypeComBox.Text;
                                v.childAgeGroup = (int)ChildUpDown.Value;
                                v.visitorEntryTime = DateTime.Now.ToShortTimeString();
                                v.visitorExitTime = "";
                                v.ticketPrice = 0;
                                v.dateOfVisit = DateTime.Now.ToShortDateString();
                                v.visitDay = dayComboBox.SelectedItem.ToString();
                                // storing updated data in string variable st
                                string str = v.id + "," + v.groupType + "," + v.adultAgeGroup + "," + v.childAgeGroup + "," + v.visitorEntryTime + "," + v.visitorExitTime + "," + v.dateOfVisit + "," + v.ticketPrice +","+v.visitDay+ "\n";
                                // appending new visitor
                                File.AppendAllText(filePath, str);
                                // creating new list visitors and storing visitors data
                                List<Visitors> visitors = new List<Visitors> {v};
                                // storing visitors data in visitor checkInTable grid view
                                VisitorCheckInTable.DataSource = visitors;
                                // showing success after visitor success fully added
                                MessageBox.Show("Visitor Successfully Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                             }
                             // throwing exception 
                             catch (Exception exe)
                             {
                                // displaying error message
                                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                             }
                        }
                    }
                    else
                    {
                        // showing error message if group limit exceeds
                        MessageBox.Show("Group Limit Exceeds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                 }
                 else
                 {
                    // displaying error message if user try to enter visitor defor or after office hour
                    MessageBox.Show("Entry Time Exceeds.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
             }
	     }

        // declearing deserialize button click event
	    private void DeserializeBtn_Click(object sender, EventArgs e)
	    {
            try
            {
                // opening the file content
                FileStream stream = new FileStream(Need.samePath + "serializeData", FileMode.Open);
                // creating new instance for binaryFormatter
                BinaryFormatter formatter = new BinaryFormatter();
                // deserializing the object
                serializeData = (Visitors)formatter.Deserialize(stream);
                ChildUpDown.Value = serializeData.childAgeGroup;
                AdultDown.Value = serializeData.adultAgeGroup;
                EstimatedHourUpDown.Value = serializeData.estimated;
                dayComboBox.Text = serializeData.visitDay;
                GroupTypeComBox.Text = serializeData.groupType;
                stream.Flush();
                // closing stream
                stream.Close();
            }
            // throwing exception
            catch (Exception exe)
            {
                // displaying error message if user try to click deserize button without serializing the data
                MessageBox.Show("Serialize Data Couldnot Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
         
            }
	    }
}
