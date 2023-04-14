using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Data;

namespace BeautyGlory
{
    class BackupDB
    {
        public void getBackup()
        {
            try
            {
                string exportPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "BackupDataBaseCSV_" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss"));
                if (!Directory.Exists(exportPath))
                {
                    Directory.CreateDirectory(exportPath);
                }

                using (db_connect db = new db_connect())
                {
                    MySqlConnection connection = db.GetConnect();
                    DataTable schema = connection.GetSchema("Tables");
                    foreach (DataRow row in schema.Rows)
                    {
                        string tableName = row[2].ToString();
                        string sql = string.Format("SELECT * FROM `{0}`", tableName);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            string fileName = Path.Combine(exportPath, tableName + ".csv");
                            using (StreamWriter writer = new StreamWriter(fileName))
                            {
                                foreach (DataRow dataRow in dataTable.Rows)
                                {
                                    string rowText = "";
                                    for (int i = 0; i < dataTable.Columns.Count; i++)
                                    {
                                        rowText += dataRow[i].ToString();
                                        if (i < dataTable.Columns.Count - 1)
                                        {
                                            rowText += ",";
                                        }
                                    }
                                    writer.WriteLine(rowText);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                ;
            }
        }
    }
}
