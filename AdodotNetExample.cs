using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AdodotNetExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string ConString = "data source=.; database=master; integrated security=SSPI";
                using (SqlConnection con = new SqlConnection(ConString))
                {
                    // Creating SqlCommand object   
                    SqlCommand cm = new SqlCommand("select * from Emp", con);
                    // Opening Connection  
                    con.Open();
                    // Executing the SQL query  
                    SqlDataReader sdr = cm.ExecuteReader();
                    while (sdr.Read())
                    {
                        Console.WriteLine(sdr["Id"] + ",  " + sdr["FirstName"] + ", " + sdr["LastName"] + ","+ sdr["City"] + ","+ sdr["Country"] + ", "+ sdr["Phone"]);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e);
            }
            Console.ReadKey();
        }
    }
}