using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _20200709_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\GitHub\CSharp20200601\_20200709_Database\_20200709_Database\DuomenuBaze.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            string querry = "SELECT * FROM Preke WHERE Kaina > 0.4";
            SqlCommand command = new SqlCommand(querry, connection);
            connection.Open();
            var skaitytojas = command.ExecuteReader();
            while (skaitytojas.Read())
            {
                Console.Write(skaitytojas["Id"].ToString() + " ");
                Console.Write(skaitytojas["Pavadinima"] + " ");
                Console.WriteLine(skaitytojas["Kaina"].ToString());
            }
            
        }

        private static void NaujoIrasoGeneravimas()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\GitHub\CSharp20200601\_20200709_Database\_20200709_Database\DuomenuBaze.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            string querry = "INSERT INTO PREKE(Pavadinima, Kaina) Values(@Pavadinima, @Kaina)";
            SqlCommand command = new SqlCommand(querry, connection);
            Console.WriteLine("Iveskite prekes pavadinima");
            command.Parameters.AddWithValue("@Pavadinima", Console.ReadLine());
            Console.WriteLine("Iveskite kaina");
            command.Parameters.AddWithValue("@Kaina", Convert.ToDouble(Console.ReadLine()));

            connection.Open();
            int result = command.ExecuteNonQuery();
            if (result < 0)
            {
                Console.WriteLine("Ivyko klaida ivykdant uzklausa");
            }
            else
            {
                Console.WriteLine("Uzklausa igyvendinta");
            }
        }
    }
}
