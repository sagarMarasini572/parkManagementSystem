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
    public partial class Splash : Form
    {
        // constructor
        public Splash()
        {
            InitializeComponent();
        }
        // Declearing Splashload event
        private void Splash_Load(object sender, EventArgs e)
        {
            // Starting progress bar right after the form load
            MyProgressTimer.Start();
        }

        // Initializing instance variable startpoint as 0.
        int startpoint = 0;
        private void MyProgressTimer_Tick(object sender, EventArgs e)
        {   
            // increasing value by 1
            startpoint += 1;
            MyProgress.Value = startpoint;
            // showing the progress in progress bar
            Progress.Text = MyProgress.Value.ToString() + "%";
            // if progressbar value is equal to 100 then showing login form
            if (MyProgress.Value == 100)
            {
                MyProgress.Value = 0;
                MyProgressTimer.Stop();
                Login login = new Login();
                this.Hide();
                login.Show();
            }
        }    
    }
}
