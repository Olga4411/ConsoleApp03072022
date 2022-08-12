using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using ConsoleApp03072022.Models;
using ConsoleApp03072022.Datalayer;




namespace ConsoleApp03072022
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerModel cust1 = DL.Customer.ByID(1);
            CustomerModel cust2 = DL.Customer.ByID(3);
            Console.ReadKey();

            Console.WriteLine(cust1);


            // Employee
            EmployeeModel employee1 = new EmployeeModel(5,"Михайлов","Роман","06-05-2022",5,4500);
            //DL.Employee.Add(employee1);
            Console.WriteLine(employee1);

            

            //string connectionstring = "Data Source=HELGA-PC\\SQLEXPRESS; Database=Company_DB; Trusted_Connection=True";
            //string connectionstring = ConfigurationManager.ConnectionStrings["Company_DB"].ConnectionString;
            //using (SqlConnection conn = new SqlConnection(connectionstring))
            //{
            //    conn.Open();

            //string insertEmpl = "INSERT INTO [Company_DB].[dbo].[Employee]([FirstName], [Lastname],[BirthDate],[PositionID],[Salary])VALUES('Ella', 'Chernogor', '2000-10-20', 5, 2000)";
            //SqlCommand ins = new SqlCommand(insertEmpl, conn);
            //int res = ins.ExecuteNonQuery();

            //string sqlcommand = "[dbo].[stp_EmployeeDelete_1]";
            //SqlCommand cmd = new SqlCommand(sqlcommand, conn);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("EmployeeID",1007);

            //int res = cmd.ExecuteNonQuery();
            //conn.Close();
            //if (res == -1) Console.WriteLine("OK");
            //else Console.WriteLine ("Error");

            //string sqlcommand = "[dbo].[stp_CustomerByID]";
            //SqlCommand cmd = new SqlCommand(sqlcommand, conn);
            //cmd.CommandType = CommandType.StoredProcedure;
            //SqlParameter custID = cmd.Parameters.Add("@customerID", SqlDbType.Int);
            //custID.Value = 3;
            ////  cmd.Parameters.AddWithValue("@EmployeeID",13);

            //SqlDataReader dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    var f1 = dr[0];
            //    var f2 = dr[1];
            //    var f3 = dr[2];
            //    Console.WriteLine($"{f1} {f2} {f3}");
            //}

            //add
            //string sqlcommand = "[dbo].[stp_CustomerAdd]";
            //SqlCommand cmd = new SqlCommand(sqlcommand, conn);
            //cmd.CommandType = CommandType.StoredProcedure;

            // создать объект, который будет возвращать строку c кодом объекта который добавили
            // создаем объект, который будет из процедуры возвращать коллекцию параметров
            //SqlCommandBuilder.DeriveParameters(cmd);
            //cmd.Parameters[4].Value = DBNull.Value;
            // cmd.Parameters[1].Value = "Ella";
            // cmd.Parameters[2].Value = "Chernogor";
            // cmd.Parameters[3].Value = DateTime.Now.AddYears(-1).ToShortDateString();
            // cmd.ExecuteNonQuery();
            // int newCustomers = (int)cmd.Parameters[4].Value;
            // Console.WriteLine(newCustomers);


            //}
            Console.ReadKey();

           




        }
           
            
    }

}
