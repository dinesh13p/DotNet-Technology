using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SqlCommandExample
{
    internal class ReadAndCommandExample
    {

        public void run()
        {
            selectUsingDataReader();
            insertUsingCommand();
        }

        public void insertUsingCommand()
        {

            var connectionStringMySql = "server=localhost;user=root;pasword=;database=dotnet_db";
            var conn = new MySqlConnection(connectionStringMySql);
            var sqlstment = "INSERT INTO product(name,price , category, is_active,stock) VALUES(@name , @price , @category , @is_active , @stock)";
            var cmd = new MySqlCommand(sqlstment, conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@name", "Laptop");
            cmd.Parameters.AddWithValue("@price", 300.3);
            cmd.Parameters.AddWithValue("@category", "Electronics");
            cmd.Parameters.AddWithValue("@is_active", true); // Added missing parameter
            cmd.Parameters.AddWithValue("@stock", 25);

            var noOffectedRows = cmd.ExecuteNonQuery();
            

        }
            
 void selectUsingDataReader()
        {
            var connectionStringMySql = "server=localhost;user=root;pasword=;database=dotnet_db";
            var conn = new MySqlConnection(connectionStringMySql);
            Console.WriteLine(connectionStringMySql);
            conn.Open();

            var stmt = "select * from product";
            var cmd = new MySqlCommand(stmt,conn);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(reader.GetValue(1));
            }
        }

        
        
    }
}
