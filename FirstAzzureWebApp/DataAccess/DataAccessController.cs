using FirstAzzureWebApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstAzzureWebApp.DataAccess
{
    public class DataAccessController : Controller
    {
        public static List<Customers> GetCustomerData(string phoneNumber)
        {
            System.Console.WriteLine("Getting Customer Data....");
            string connectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|Database.mdf;Integrated Security=True;User Instance=True";
            List<Customers> lists = new List<Customers>();

            using (SqlConnection cn = new SqlConnection(connectionString))
            using (SqlCommand cmd = cn.CreateCommand())
            {
                string query = "SELECT * FROM Customers where phoneNumber='" + phoneNumber + "'";
                cmd.CommandText = query;
                System.Diagnostics.Debug.WriteLine(query);

                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    Customers temp;

                    while (dr.Read())
                    {
                        temp = new Customers();
                        temp.customerID = Convert.ToInt32(dr.GetInt32(0));
                        temp.LastName = dr.GetString(1);
                        temp.FirstName = dr.GetString(2);
                        temp.phoneNumber = dr.GetString(3);
                        temp.email = dr.GetString(4);


                        lists.Add(temp);
                       
                    }
                }
            }

            return lists;
        }
    }
}