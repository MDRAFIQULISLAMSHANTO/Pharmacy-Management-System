
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
using DataAccess.Entities;


namespace PharmacyManagementSystem
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
            Database db = new Database();
            try
            { 
                dtplist.DataSource = db.Pharmacists.GetAllPharmacists();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void View_Load(object sender, EventArgs e)
        {

        }

        private void backClick(object sender, EventArgs e)
        {
            this.Hide();
            new Dashboard().Show();
        }
    }
}
