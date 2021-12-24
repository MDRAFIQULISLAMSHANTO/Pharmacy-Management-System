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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void LogOutClick(object sender, EventArgs e)
        {
            this.Hide();
            new LogIn().Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void pViewClick(object sender, EventArgs e)
        {
            this.Hide();
            new View().Show();
        }
    }
}
