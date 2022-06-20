using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Ado.net
{
    internal class employeedetails
    {
        public static string sqlConnectionStr = @"Data Source=SAI;Initial Catalog=BankDb;Integrated Security=True";

        public string InsertEmployee()
        {
            Console.WriteLine("Enter the employee ID");
            int EmpId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Employee Name");
            string EmpName = Console.ReadLine();

            Console.WriteLine("Enter the employee age");
            int EmpAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Employee Name");
            string EmpAddress = Console.ReadLine();

            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            SqlCommand cmd = new SqlCommand("insert into Employee values(" + EmpId + ",'" + EmpName + "'," + EmpAge + ",'" + EmpAddress + "')", sqlConnection);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            return "INSERTED";
        }
    }
}
// internal class employeedetails
