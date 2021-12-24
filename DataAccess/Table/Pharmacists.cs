using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;


namespace DataAccess.Table
{
    public class Pharmacists
    {
        SqlConnection conn;
        public Pharmacists()
        {
            string connStr = @"Server = SHANTO\SQLEXPRESS; Database = PharmacyManagementSystem; Integrated Security = true";
            conn = new SqlConnection(connStr);
        }
        public List<Pharmacist> GetAllPharmacists()
        {
            string query = "select * from Pharmacists";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Pharmacist> data = new List<Pharmacist>();

            while (reader.Read())
            {
                Pharmacist Phar = new Pharmacist();
                Phar.pId = reader.GetInt32(reader.GetOrdinal("pId"));
                Phar.pName = reader.GetString(reader.GetOrdinal("pName"));
                Phar.pPhone = reader.GetString(reader.GetOrdinal("pPhone"));
                Phar.pDob = reader.GetString(reader.GetOrdinal("pDob"));
                Phar.pUserName = reader.GetString(reader.GetOrdinal("pUserName"));
                Phar.pPassword = reader.GetString(reader.GetOrdinal("pPassword"));
                data.Add(Phar);
            }
            conn.Close();
            return data;

        }
        public Pharmacist GetPharmacist(int id)
        {
            string query = "select * from Pharmacists where PharmacistId = " + id;
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Pharmacist Phar = null;
            while (reader.Read())
            {
                Phar = new Pharmacist();
                Phar.pId = reader.GetInt32(reader.GetOrdinal("pId"));
                Phar.pName = reader.GetString(reader.GetOrdinal("pName"));
                Phar.pPhone = reader.GetString(reader.GetOrdinal("pPhone"));
                Phar.pDob = reader.GetString(reader.GetOrdinal("pDob"));
                Phar.pUserName = reader.GetString(reader.GetOrdinal("pUserName"));
                Phar.pPassword = reader.GetString(reader.GetOrdinal("pPassword"));
                

            }
            conn.Close();
            return Phar;
        }
        public bool Insert(Pharmacist Phar)
        {
            string query = String.Format("Insert into pharmacists values ('{0}','{1}','{2}','{3}','{4}')", Phar.pName, Phar.pPhone, Phar.pDob, Phar.pUserName, Phar.pPassword);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);

            int r = cmd.ExecuteNonQuery();

            conn.Close();
            if (r > 0) return true;
            return false;

        }
        public bool CheckLogin(string username, string password)
        {
            string query = String.Format("select pName from pharmacists where pUserName='{0}' and pPassword='{1}'", username, password);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                return true;
            }
            return false;

        }
      



    }
}
