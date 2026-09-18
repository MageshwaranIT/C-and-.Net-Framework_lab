using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace DisconnectedDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString =
                "Server=localhost;Database=CollegeDB;Uid=root;Pwd=sqllab26.;";

            string query =
                "SELECT Id, Name, Department, Mark FROM Students";

            DataSet dataSet = new DataSet();

            using (MySqlConnection connection =
                   new MySqlConnection(connectionString))
            {
                MySqlDataAdapter adapter =
                    new MySqlDataAdapter(query, connection);

                adapter.Fill(dataSet, "Students");
            }

            Console.WriteLine("Database connection closed.");
            Console.WriteLine(
                "Data retrieved using disconnected environment.\n");

            DataTable table = dataSet.Tables["Students"];

            Console.WriteLine("Student Details");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("ID\tName\tDepartment\t\tMark");
            Console.WriteLine("---------------------------------------------");

            foreach (DataRow row in table.Rows)
            {
                Console.WriteLine(
                    $"{row["Id"]}\t" +
                    $"{row["Name"]}\t" +
                    $"{row["Department"]}\t" +
                    $"{row["Mark"]}");
            }

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine(
                "\nTotal Records: " + table.Rows.Count);

            Console.ReadLine();
        }
    }
}