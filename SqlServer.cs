using MySql.Data.MySqlClient;
using System.Data;

namespace ParcaMuhasebe
{
    internal class SqlServer
    {

        public MySqlConnection connection = new MySqlConnection("Server=localhost;Database=parcalar;Uid=root;Pwd='Ar785493';");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable dataTable;

        public DataTable sqlSorgu(String sorgu) 
        {
            
            dataTable = new DataTable();
            try
            {
                connection.Open();
                adapter = new MySqlDataAdapter(sorgu, connection);
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dataTable;
        }
        public bool sqlEkle(string sorgu)
        {
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(sorgu, connection);
                int affectedRows = command.ExecuteNonQuery();  // Sorguyu çalıştırır ve etkilenen satır sayısını döner
                return affectedRows > 0;  // Eğer etkilenen satır varsa true döner
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                Console.WriteLine("Hata: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
