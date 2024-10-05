using MySql.Data.MySqlClient;
using PetPals.entity.model;
using PetPals.util;
using static PetPals.dao.PetDAOImpl;
using System.Data.SqlClient;

namespace PetPals.dao
{



    // Ensure you are using the correct namespace

    public class PetDAOImpl : IPetDAO
    {
        SqlConnection sqlConnection = null;
        SqlCommand cmd = null;

        // Assuming dbconfig.json is for getting connection string, but you are hardcoding it here.
        private string connectionString = "Server=LAPTOP-8D3ITF0I\\SQLEXPRESS;Database=PetPals;User Id=HP;Integrated Security=True;";

        public PetDAOImpl()
        {
            sqlConnection = new SqlConnection(connectionString); // Use SqlConnection if you are connecting to SQL Server
            cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
        }

        public void AddPet(Pet pet)
        {
            // Use the same SqlConnection here
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO pets (name, age, breed, type, availableforadoption, shelterid) " +
                               "VALUES (@name, @age, @breed, @type, @available, @shelterId)";
                using (SqlCommand cmd = new SqlCommand(query, conn)) // Use SqlCommand for SQL Server
                {
                    cmd.Parameters.AddWithValue("@name", pet.Name);
                    cmd.Parameters.AddWithValue("@age", pet.Age);
                    cmd.Parameters.AddWithValue("@breed", pet.Breed);
                    cmd.Parameters.AddWithValue("@type", pet is Dog ? "Dog" : "Cat");
                    cmd.Parameters.AddWithValue("@petid", pet.Petid);
                    cmd.Parameters.AddWithValue("@available", true);
                    cmd.Parameters.AddWithValue("@shelterId", pet.Shelterid); // Example shelterId
                    cmd.ExecuteNonQuery();
                } // cmd will be disposed here
            } // conn will be disposed here
        }
    }

    // Pet and Dog class definitions would also need to be defined elsewhere


    //public void RemovePet(int petId)
    //    {
    //        using (MySqlConnection conn = DBConnection.GetConnection(connectionString))
    //        {
    //            conn.Open();
    //            string query = "DELETE FROM pets WHERE petid = @petId";
    //            MySqlCommand cmd = new MySqlCommand(query, conn);
    //            cmd.Parameters.AddWithValue("@petId", petId);
    //            cmd.ExecuteNonQuery();
    //        }
    //    }

    //    public void ListAvailablePets()
    //    {
    //        using (MySqlConnection conn = DBConnection.GetConnection(connectionString))
    //        {
    //            conn.Open();
    //            string query = "SELECT * FROM pets WHERE availableforadoption = 1";
    //            MySqlCommand cmd = new MySqlCommand(query, conn);
    //            using (MySqlDataReader reader = cmd.ExecuteReader())
    //            {
    //                while (reader.Read())
    //                {
    //                    System.Console.WriteLine($"{reader["name"]}, {reader["breed"]}, Age: {reader["age"]}");
    //                }
    //            }
    //        }
    //    }
}


