using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepairLog
{
    class DatabaseManager
    {
        private static SQLiteConnection _dbConnection = new SQLiteConnection("Data Source=RepairLog.sqlite;Version=3;");

        private void CreateTableIfNotExists()
        {
            _dbConnection.Open();
            string sql = @"CREATE TABLE IF NOT EXISTS [Repairs](
                                   [ID] INTEGER PRIMARY KEY AUTOINCREMENT,
                                   [ItemRepaired] TEXT,
                                   [DatePurchased] TEXT,
                                   [Cost] REAL,
                                   [Store] TEXT,
                                   [Description] TEXT)";
            SQLiteCommand command = new SQLiteCommand(sql, _dbConnection);
            command.ExecuteNonQuery();
            _dbConnection.Close();
        }
        public static void InsertDataIntoTable(TextBox textBox_ItemRepaired, DateTimePicker dateTimePicker1, TextBox textBox_Cost, TextBox textBox_Store, TextBox textBox_Description)
        {
            _dbConnection.Open();
            string sql = "INSERT INTO Repairs(ItemRepaired, DatePurchased, Cost, Store, Description) VALUES (@ItemRepaired, @DatePurchased, @Cost, @Store, @Description)";

            SQLiteCommand command = new SQLiteCommand(sql, _dbConnection);
            command.Parameters.AddWithValue("@ItemRepaired", textBox_ItemRepaired.Text.Trim());
            command.Parameters.AddWithValue("@DatePurchased", dateTimePicker1.Value);
            command.Parameters.AddWithValue("@Cost", textBox_Cost.Text.TrimStart('$').Replace(",", ""));
            command.Parameters.AddWithValue("@Store", textBox_Store.Text.Trim());
            command.Parameters.AddWithValue("@Description", textBox_Description.Text.Trim());

            int returnVal = command.ExecuteNonQuery();
            if (returnVal > 0)
            {
                MessageBox.Show("Inserted Successfully");
                //resetFormFields();
            }
            else
            {
                MessageBox.Show("Failure to insert");
            }

        }

    }
}
