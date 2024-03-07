using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace DatabaseTest
{
    class Program
    {
        MySqlConnection conn;
        MySqlCommand command;

        // Method to create a database connection
        void CreateConnection()
        {
            string constr = "SERVER=localhost;  DATABASE=bcapractice; UID=root;  PASSWORD=;";
            conn = new MySqlConnection(constr);
            conn.Open();
        }

        // Method to perform insert, update, or delete operation
        void InsertUpdateDelete(string sql, params MySqlParameter[] parameters)
        {
            command = new MySqlCommand(sql, conn);
            command.Parameters.AddRange(parameters);
            command.ExecuteNonQuery();
            Console.WriteLine("Operation Performed Successfully!");
        }

        // Method to select records from the database
        void SelectRecords(string sql, params MySqlParameter[] parameters)
        {
            command = new MySqlCommand(sql, conn);
            command.Parameters.AddRange(parameters);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            // Display the result
            if (dt.Rows.Count != 0)
            {
                Console.WriteLine("Sid\t  Name\t  Address");
                foreach (DataRow row in dt.Rows)
                {
                    string sid = row["id"].ToString();
                    string name = row["name"].ToString();
                    string address = row["address"].ToString();
                    Console.WriteLine($"{sid}\t{name}\t{address}");
                }
            }
        }

        static void Main(string[] args)
        {
            Program obj = new Program();

            try
            {
                obj.CreateConnection();

                while (true)
                {
                    Console.WriteLine("1.Insert\t  2.Update\t  3.Delete\t4.Select\t5.Exit");
                    Console.WriteLine("Enter your choice: ");
                    int n = Convert.ToInt32(Console.ReadLine());

                    // Variables for input values
                    string nm = "", add = "";
                    int id = 0;

                    switch (n)
                    {
                        case 1:
                            Console.WriteLine("Enter Name of Student:");
                            nm = Console.ReadLine();
                            Console.WriteLine("Enter Address of Student:");
                            add = Console.ReadLine();
                            string insertSql = "INSERT INTO student (name, address) VALUES (@name, @address)";
                            obj.InsertUpdateDelete(insertSql, new MySqlParameter("@name", nm), new MySqlParameter("@address", add));
                            break;

                        case 2:
                            Console.WriteLine("Enter id to be updated");
                            id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Name of Student:");
                            nm = Console.ReadLine();
                            Console.WriteLine("Enter Address of Student:");
                            add = Console.ReadLine();
                            string updateSql = "UPDATE student SET name=@name, address=@address WHERE id=@id";
                            obj.InsertUpdateDelete(updateSql, new MySqlParameter("@name", nm), new MySqlParameter("@address", add), new MySqlParameter("@id", id));
                            break;

                        case 3:
                            Console.WriteLine("Enter id to be deleted");
                            id = Convert.ToInt32(Console.ReadLine());
                            string deleteSql = "DELETE FROM student WHERE id=@id";
                            obj.InsertUpdateDelete(deleteSql, new MySqlParameter("@id", id));
                            break;

                        case 4:
                            string selectSql = "SELECT * FROM student";
                            obj.SelectRecords(selectSql);
                            break;

                        case 5:
                            // Exit the program
                            return;

                        default:
                            Console.WriteLine("Wrong Choice");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Connection Failed!");
            }
            finally
            {
                // Close the connection in the finally block
                obj.conn.Close();
            }
        }
    }
}
