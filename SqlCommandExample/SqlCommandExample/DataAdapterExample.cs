using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlCommandExample
{
    internal class DataAdapterExample
    {

        public void run()
        {
            adapter();
        }

        void adapter()
        {

            var connectionStringMySql = "server=localhost;user=root;pasword=;database=dotnet_db";
            var conn = new MySqlConnection(connectionStringMySql);
            var stat = "Select * from product";
            conn.Open();
            var dataAdapter = new MySqlDataAdapter(stat, conn);


            var dataset = new DataSet();
            dataAdapter.Fill(dataset, "product");

            var dsProductTable = dataset.Tables["product"];
            foreach(DataRow item in dsProductTable.Rows)
            {
                Console.WriteLine(item["id"]);
            }

            var newRow = dataset.Tables["product"].NewRow();
            newRow["name"] = "Iphone";
            newRow["price"] = 20.43;
            newRow["category"] = true;
            newRow["stock"] = 50;
            dsProductTable.Rows.Add(newRow);


            var sqlCommandBuilder = new MySqlCommandBuilder(dataAdapter);
            dataAdapter.InsertCommand = sqlCommandBuilder.GetInsertCommand();
            dataAdapter.Update(dataset, "product");
            
        }
    }
}
