using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using DataAccess.Table;



namespace DataAccess
{
    public class Database
    {
        public Medicines Medicines { get; set; }
        public Pharmacists Pharmacists { get; set; }

        public Database()
        {
            
            Medicines = new Medicines();
            Pharmacists = new Pharmacists();


        }
    }
}
