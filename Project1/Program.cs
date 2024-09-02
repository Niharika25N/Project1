using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().ReadTable();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=LAPTOP-NUO9P4D4\\SQLEXPRESS;database=project;integrated security=SSPI");
                SqlCommand s1 = new SqlCommand("create table Demo(id int not null,name varchar(30),branch varchar(60)", con);
                con.Open();
                s1.ExecuteNonQuery();
                Console.WriteLine("table created successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void InsertTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=LAPTOP-NUO9P4D4\\SQLEXPRESS;database=project;integrated security=SSPI");
                SqlCommand s1 = new SqlCommand("insert into Demo(id,name,branch) values(42,'niharika','iot')", con);
                con.Open();
                s1.ExecuteNonQuery();
                Console.WriteLine("data inserted successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void ReadTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=LAPTOP-NUO9P4D4\\SQLEXPRESS;database=project;integrated security=SSPI");
                SqlCommand s2 = new SqlCommand("select * from Demo", con);
                con.Open();
                SqlDataReader r = s2.ExecuteReader();
                while (r.Read())
                {
                    Console.WriteLine("ID:" + r["id"].ToString());
                    Console.WriteLine("name:" + r["name"].ToString());
                    Console.WriteLine("branch:" + r["branch"].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
