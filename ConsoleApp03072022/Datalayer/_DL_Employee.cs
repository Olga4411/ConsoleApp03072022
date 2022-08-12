using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using ConsoleApp03072022.Models;


namespace ConsoleApp03072022.Datalayer
{
    class _DL_Employee
    {
        public static string ConnectionString { get; private set; } = ConfigurationManager.ConnectionStrings["Company_DB"].ConnectionString;
        public static class Employee
        {
            public static void Add(EmployeeModel employee)
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    SqlCommand addEmpl = new SqlCommand("stp_EmployeeAdd", conn);
                    addEmpl.CommandType = CommandType.StoredProcedure;
                    addEmpl.Parameters.AddWithValue("EmployeeID", employee.EmployeeID);
                    addEmpl.Parameters.AddWithValue("FirstName", employee.FirstName);
                    addEmpl.Parameters.AddWithValue("LastName", employee.LastName);
                    addEmpl.Parameters.AddWithValue("BirthDate", employee.BirthDate);
                    addEmpl.Parameters.AddWithValue("PositionID", employee.PositionID);
                    addEmpl.Parameters.AddWithValue("Salary", employee.Salary);

                    addEmpl.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}
