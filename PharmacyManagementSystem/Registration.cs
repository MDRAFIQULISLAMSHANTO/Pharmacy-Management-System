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
using DataAccess;

namespace PharmacyManagementSystem
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void RegisterClick(object sender, EventArgs e)
        {
            var name = tbName.Text;

            var Phone = tbPhone.Text;
            var Dob = tbDob.Text;
            var username = tbUserName.Text;
            var password = tbPassword.Text;
            Pharmacist Phar = new Pharmacist();
            Phar.pName = name;
            Phar.pPhone = Phone;
            Phar.pDob = Dob;
            Phar.pUserName = username;
            Phar.pPassword = password;
            Database db = new Database();
            var r = db.Pharmacists.Insert(Phar);
            if (r)
            {
                MessageBox.Show("Inserted");
            }
            else
            {
                MessageBox.Show("Error occured");
            }
        }

        private void BackClick(object sender, EventArgs e)
        {
            this.Hide();
            new LogIn().Show();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
    }
}
