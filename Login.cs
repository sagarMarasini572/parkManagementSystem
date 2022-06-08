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
    public partial class Login : Form
    {
        // Constructor
        public Login()
        {
            InitializeComponent();
        }

        // Declearing username textfield click event
        private void Usernametf_Enter(object sender, EventArgs e)
        {
            // initially if text in username text field is Enter your Username
            // but when the the field is enetr the text is set to empty
            // and the fore color is set to black
            if (Usernametf.Text == "Enter your Username")
            {
                Usernametf.Text = "";
                Usernametf.ForeColor = Color.Black;
            }
        }

        // Declearing username textfield leave event
        private void Usernametf_Leave(object sender, EventArgs e)
        {
            // initially if text in username text field is empty
            // but when the the field is enetr the text is set to Enter your Username
            // and the fore color is set to silver
            if (Usernametf.Text == "")
            {
                Usernametf.Text = "Enter your Username";
                Usernametf.ForeColor = Color.Silver;
            }
        }

        // Declearing username textfield click event
        private void Passwordtf_Enter(object sender, EventArgs e)
        {
            // initially if text in password text field is empty
            // but when the the field is enetr the text is set to Enter your Password
            // and the fore color is set to Black
            if (Passwordtf.Text == "Enter your Password")
            {
                Passwordtf.Text = "";
                Passwordtf.ForeColor = Color.Black;
            }
        }

        // Declearing username textfield leave event
        private void Passwordtf_Leave(object sender, EventArgs e)
        {
            // initially if text in password text field is empty
            // but when the the field is enetr the text is set to Enter your password
            // and the fore color is set to silver
            if (Passwordtf.Text == "")
            {
                Passwordtf.Text = "Enter your Password";
                Passwordtf.ForeColor = Color.Silver;
            }
        }

        // Declaring Login button click event
        private void LoginBtn_Click(object sender, EventArgs e)
        {           
            if (RoleSelector.SelectedIndex > -1)
            {
                // if selected role is admin
                if (RoleSelector.SelectedItem.ToString().Equals("Admin"))
                {
                    // if username and password equals to myadmin
                    if (Usernametf.Text.Equals("myadmin") && Passwordtf.Text.Equals("myadmin"))
                    {
                        // Showing an success message if admin username and password are matched
                        MessageBox.Show("Admin login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AdminDashboard adminDashboard = new AdminDashboard();
                        // hiding login form
                        this.Hide();
                        // showing adminDashborad Form
                        adminDashboard.Show();
                    }
                    else
                    {
                        // Showing an error message if admin username and password are mismatched
                        MessageBox.Show("If you are Admin, Enter the Correct Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // if selected role is Staff
                    if (RoleSelector.SelectedItem.ToString().Equals("Staff"))
                    {
                        // if username and password equals to mystaff
                        if (Usernametf.Text.Equals("mystaff") && Passwordtf.Text.Equals("mystaff"))
                        {
                            // Showing an success message if staff username and password are matched
                            MessageBox.Show("Staff login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            StaffDashboard staffDashboard = new StaffDashboard();
                            // hiding login form
                            this.Hide();
                            // Showing staffDashboard Form
                            staffDashboard.Show();
                        }
                        else
                        {
                            // Showing an error message if staff username and password are mismatched
                            MessageBox.Show("If you are Staff, Enter the Correct Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }         
            else
            {
                // Showing an error message if user role is not selected
                MessageBox.Show("Select a Role", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    
        // Declearing MouseHover event
        private void LoginBtn_MouseHover(object sender, EventArgs e)
        {
            // setting background color of Login button to Red
            LoginBtn.BackColor = Color.Red;
            // setting background color of Login button to Red
            LoginBtn.ForeColor = Color.Black;
        }

        // Declearing Exit Label click event
        private void ExitLbl_Click(object sender, EventArgs e)
        {
            // Closing application
            Application.Exit();
        }
    }
}
