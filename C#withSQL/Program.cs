using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_withSQL
{
    internal class Program
    {

        static void Main(string[] args)
        {
            SqlConnection connenction = new SqlConnection(@"Data Source=PREDATOR;Initial Catalog=DbVisit;Integrated Security=True;TrustServerCertificate=True");

            void list()
            {
                connenction.Open();
                SqlCommand cmdList = new SqlCommand("select * from TblPersons", connenction);
                SqlDataReader reader = cmdList.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader[0] + " " + reader[1] + " " + reader[2]);
                    Console.WriteLine("-----------------------------------");
                }
                connenction.Close();
            }


            //connenction.Open();
            //SqlCommand cmdInsert = new SqlCommand("insert into TblPersons (personName,PersonCity) values (@p1,@p2)", connenction);
            //Console.WriteLine("Name: ");
            //cmdInsert.Parameters.AddWithValue("@p1", Console.ReadLine());
            //Console.WriteLine("Surname: ");
            //cmdInsert.Parameters.AddWithValue("@p2", Console.ReadLine());
            //cmdInsert.ExecuteNonQuery();
            //connenction.Close();
            //list();


            //list();
            //connenction.Open();
            //SqlCommand cmdUpdate = new SqlCommand("update TblPersons set personName=@p1,PersonCity=@p2 where personId=@p3", connenction);
            //Console.WriteLine("Id: ");
            //cmdUpdate.Parameters.AddWithValue("@p3", Console.ReadLine());
            //Console.WriteLine("Name: ");
            //cmdUpdate.Parameters.AddWithValue("@p1", Console.ReadLine());
            //Console.WriteLine("Surname: ");
            //cmdUpdate.Parameters.AddWithValue("@p2", Console.ReadLine());
            //cmdUpdate.ExecuteNonQuery();
            //connenction.Close();
            //list();


            //list();
            //connenction.Open();
            //SqlCommand cmdUpdate = new SqlCommand("delete from TblPersons where personId=@p1", connenction);
            //Console.WriteLine("Id: ");
            //cmdUpdate.Parameters.AddWithValue("@p1", Console.ReadLine());
            //cmdUpdate.ExecuteNonQuery();
            //connenction.Close();
            //list();


            //Console.WriteLine("Name:");
            //string value = Console.ReadLine();
            //connenction.Open();
            //SqlCommand cmdSearch = new SqlCommand("select * from TblPersons where personCity=@p1",connenction);
            //cmdSearch.Parameters.AddWithValue("@p1", value);
            //SqlDataReader sqlDataReader = cmdSearch.ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    Console.WriteLine(sqlDataReader[0] + " " + sqlDataReader[1] + " " + sqlDataReader[2]);
            //}
            //connenction.Close();


            //connenction.Open();
            //SqlCommand cmd = new SqlCommand("select count(*) from TblPersons", connenction);
            //SqlDataReader sqlDataReader = cmd.ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    Console.WriteLine(sqlDataReader[0]);
            //}
            //connenction.Close();


            //connenction.Open();
            //SqlCommand cmd1 = new SqlCommand("select avg(flightPrice) from TblFlights", connenction);
            //SqlDataReader sqlDataReader1 = cmd1.ExecuteReader();
            //while (sqlDataReader1.Read())
            //{
            //    Console.WriteLine(sqlDataReader1[0]);
            //}
            //connenction.Close();


            //connenction.Open();
            //SqlCommand cmd2 = new SqlCommand("select sum(flightPrice) from TblPersons", connenction);
            //SqlDataReader sqlDataReader2 = cmd2.ExecuteReader();
            //while (sqlDataReader2.Read())
            //{
            //    Console.WriteLine(sqlDataReader2[0]);
            //}
            //connenction.Close();


            //connenction.Open();
            //SqlCommand cmd3 = new SqlCommand("select personCity, count(personName) from TblPersons group by personCity", connenction);
            //SqlDataReader sqlDataReader3 = cmd3.ExecuteReader();
            //while (sqlDataReader3.Read())
            //{
            //    Console.WriteLine(sqlDataReader3[0] + " " + sqlDataReader3[1]);
            //}
            //connenction.Close();


            //connenction.Open();
            //SqlCommand cmd4 = new SqlCommand("select personCity, count(personName) from TblPersons group by personCity order by count(*) desc", connenction);
            //SqlDataReader sqlDataReader4 = cmd4.ExecuteReader();
            //while (sqlDataReader4.Read())
            //{
            //    Console.WriteLine(sqlDataReader4[0] + " " + sqlDataReader4[1]);
            //}
            //connenction.Close();


            connenction.Open();
            //SqlCommand cmd5 = new SqlCommand("select c.countryCapital, a.countryCapital, flightPrice, flightCapacity, flightDate from TblFlights p " +
            //    "inner join TblCountries c on c.countryId = p.flightDeparture " +
            //    "inner join TblCountries a on a.countryId = p.flightArrival", connenction);
            SqlCommand cmd5 = new SqlCommand("execute flights", connenction);
            SqlDataReader sqlDataReader5 = cmd5.ExecuteReader();
            while (sqlDataReader5.Read())
            {
                Console.WriteLine(sqlDataReader5[0] + " " + sqlDataReader5[1] + " " + sqlDataReader5[2] + " " + sqlDataReader5[3] + " " + sqlDataReader5[4]);
                Console.WriteLine("--------------------------");
            }
            connenction.Close();






            Console.ReadLine();
        }
    }
}
