using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingSystem
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            tm.Start();
        }

        private void tm_Tick(object sender, EventArgs e)
        {
            loadBar.Increment(1);
            if (loadBar.Value == 100)
            {
                tm.Stop();
                LoginForm run = new LoginForm();
                this.Hide();            //Aaron you have to totally Change this bro
                run.ShowDialog();
                
            }
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
