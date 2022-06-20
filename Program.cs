
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Xml;
using System.IO;
using System.Configuration;
namespace Ado.net
{ 
public class Program 
{
    public static void Main(string[] args){
        string str = "Mumbai";
        Program ob = new Program();
        ob.DisplayCustomerByLocation(str);
    }
    
    public Dictionary<string,string> DisplayCustomerByLocation(string location){
        Dictionary<string,string> d = new Dictionary<string,string>();
        string xyz = ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString;
        SqlConnection conn = new SqlConnection(xyz);
        using(conn){
            string q = "select AccountName, Location from Account where Location=@location order by AccountName asc";
            conn.Open();
            SqlCommand cmd = new SqlCommand(q,conn);
            cmd.Parameters.AddWithValue("@location",location);
            SqlDataReader rd = cmd.ExecuteReader();
            while(rd.Read()){
                string name = rd[0].ToString();
                string loc = rd[1].ToString();
                d.Add(name,loc);
            }
            conn.Close();
        }
        return d;
    }
  }
}

