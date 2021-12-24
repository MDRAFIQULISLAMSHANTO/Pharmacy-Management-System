using DataAccess;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            Database db = new Database();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void SignClick(object sender, EventArgs e)
        {

            string uname = tbUname.Text;
            string pass = tbPass.Text;

            Database db = new Database();
            try
            {
                bool rs = db.Pharmacists.CheckLogin(uname, pass);
                if (rs == true)
                {
                    this.Hide();
                    new Dashboard().Show();
                }
                else
                {
                    MessageBox.Show("Invalid Usename/ password");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RegistrationClick(object sender, EventArgs e)
        {

            this.Hide();
            new Registration().Show();
        }
    }
}
