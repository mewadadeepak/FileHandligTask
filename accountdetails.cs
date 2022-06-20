using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Ado.net
{
    internal class accountdetails
    {
        public static string sqlConnectionStr = @"Data Source=DEEPAK;Initial Catalog=BankDb;Integrated Security=True";

        public string InsertAccountHolder()
        {

            Console.WriteLine("Enter the Account Number");
            int AccNum  = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Account Holder  Name");
            string AccHolName = Console.ReadLine();

            Console.WriteLine("Enter the Account  holder age");
            int AccHolAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Account Holder  Address");
            string AccHolAddress = Console.ReadLine();

            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            SqlCommand cmd = new SqlCommand("insert into AccountHolder values(" + AccNum + ",'" + AccHolName + "'," + AccHolAge + ",'" + AccHolAddress + "')", sqlConnection);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            return "INSERTED";
        }

    }
}
