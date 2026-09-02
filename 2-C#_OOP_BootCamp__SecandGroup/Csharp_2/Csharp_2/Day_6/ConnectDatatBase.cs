using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Csharp_2.Day_6
{
     class ConnectDatatBase
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=DESKTOP-LRMPGLQ;Database =HR ;User Id=sa ;Password=123 ";
            string Query = "select * from Employees";

            using (SqlConnection conn  = new SqlConnection(connectionString)) 
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(Query, conn);

               SqlDataReader reader =  cmd.ExecuteReader();

                while (reader.Read()) 
                {
                    Console.WriteLine($"Employee LastName : {reader["last_name"]}  Employee Salary : {reader["salary"]}  ");
                }
                reader.Close();
                conn.Close();

            }

        }
    }
}
