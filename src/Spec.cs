using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautyGlory
{
    public partial class Spec : Form
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        } 

        public string path_csv = "";

        public Spec()
        {
            InitializeComponent();
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Spec_Load(object sender, EventArgs e)
        {
            Fill_Import();
            Fill_Export();
        }

        public void Fill_Import()
        {
            cmImport.Items.Clear();

            db_connect connect = new db_connect();
            connect.OpenConnect();

            string sql = "SHOW TABLES;";

            MySqlCommand com = new MySqlCommand(sql, connect.GetConnect());

            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                cmImport.Items.Add(reader[0].ToString());
            }

            connect.CloseConnect();
        }

        public void Fill_Export()
        {
            cmExport.Items.Clear();

            db_connect connect = new db_connect();
            connect.OpenConnect();

            string sql = "SHOW TABLES;";

            MySqlCommand com = new MySqlCommand(sql, connect.GetConnect());

            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                cmExport.Items.Add(reader[0].ToString());
            }

            connect.CloseConnect();
        }

        private void bExport_Click(object sender, EventArgs e)
        {
            if (tbExport.Text == "" || cmExport.Text == "")
            {
                MessageBox.Show("Ошибка выберите путь и таблицу для экспорта!", "Экспорт", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                string path = tbExport.Text;

                db_connect connect = new db_connect();
                connect.OpenConnect();

                string sql = String.Format("SELECT * FROM {0}", cmExport.Text);

                MySqlCommand cmd = new MySqlCommand(sql, connect.GetConnect());
                MySqlDataReader rdr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(rdr);

                StreamWriter writer = new StreamWriter(path + "\\" + cmExport.Text + ".csv", false);

                for (int i = 0, len = dt.Columns.Count - 1; i <= len; ++i)
                {
                    if (i != len)
                        writer.Write(dt.Columns[i].ColumnName + ";");
                    else
                        writer.Write(dt.Columns[i].ColumnName);
                }

                writer.Write("\n");

                int count = dt.Rows.Count;

                foreach (DataRow dataRow in dt.Rows)
                {
                    string r = String.Join(";", dataRow.ItemArray);
                    writer.WriteLine(r);
                }


                writer.Close();

                connect.CloseConnect();



                MessageBox.Show("Успешно! Экспорт в текстовый файл CSV произведен успешно. Файл сохранен по выбранному пути.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmExport.SelectedIndex = -1;
                tbExport.Clear();
            }
        }

        private void bPath_Click(object sender, EventArgs e)
        {
            DialogResult result = this.folderBrowserDialog1.ShowDialog();
            string foldername = "";
            if (result == DialogResult.OK)
            {
                foldername = this.folderBrowserDialog1.SelectedPath;
            }

            tbExport.Text = foldername;
        }

        private void bImport_Click(object sender, EventArgs e)
        {
            if (tbImport.Text == "" || cmImport.Text == "")
            {
                MessageBox.Show("Ошибка выберите файл и таблицу для импорта!", "Импорт", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                ArrayList arrayStr = new ArrayList();
                StreamReader FILE = null;
                FILE = new StreamReader(path_csv);
                string curStr = "";

                while ((curStr = FILE.ReadLine()) != null)
                {
                    arrayStr.Add(curStr);
                }

                MessageBox.Show("Внимание! Импорт данных начался. Ожидайте окончания импорта...", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                string sep = ";";
                char Separator = Convert.ToChar(sep);

                string[] array;

                int n = arrayStr.Count;

                if (cmImport.Text == "products")
                {
                  
                    for (int a = 1; a < arrayStr.Count; a++)
                    {

               products:
                        try
                        {
                            string tmpStr = Convert.ToString(arrayStr[a]);
                            array = tmpStr.Split(Separator);

                            db_connect connection = new db_connect();
                            connection.OpenConnect();

                            string sql = String.Format("INSERT INTO products VALUES ({0}, '{1}', '{2}', {3}, '{4}', {5}, '{6}', '{7}');",
                                                                    array[0], array[1], array[2], array[3], array[4], array[5], array[6], array[7]);

                            MySqlCommand command = new MySqlCommand(sql, connection.GetConnect());

                            command.ExecuteNonQuery();

                            connection.CloseConnect();
                        }

                        catch (Exception)
                        {
                            a++;
                            goto products;
                        }
                    }

                    MessageBox.Show("Успешно! Импорт завершен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cmImport.SelectedIndex = -1;
                    tbImport.Clear();
                }

                else if(cmImport.Text == "users")
                {
                    for (int a = 1; a < arrayStr.Count; a++)
                    {

                  users:
                        try
                        {
                            string tmpStr = Convert.ToString(arrayStr[a]);
                            array = tmpStr.Split(Separator);

                            db_connect connection = new db_connect();
                            connection.OpenConnect();

                            string sql = String.Format("INSERT INTO users VALUES ({0}, {1}, '{2}', '{3}', {4});", array[0], array[1], array[2], array[3], array[4]);

                            MySqlCommand command = new MySqlCommand(sql, connection.GetConnect());

                            command.ExecuteNonQuery();

                            connection.CloseConnect();
                        }

                        catch(Exception)
                        {
                            a++;
                            goto users;
                        }
                    }

                    MessageBox.Show("Успешно! Импорт завершен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cmImport.SelectedIndex = -1;
                    tbImport.Clear();
                }

                else if (cmImport.Text == "emp")
                {

                emp:
                    for (int a = 1; a < arrayStr.Count; a++)
                    {
                        try
                        {
                            string tmpStr = Convert.ToString(arrayStr[a]);
                            array = tmpStr.Split(Separator);

                            db_connect connection = new db_connect();
                            connection.OpenConnect();

                            string sql = String.Format("INSERT INTO emp VALUES ({0}, '{1}', '{2}', '{3}', '{4}');", array[0], array[1], array[2], array[3], array[4]);

                            MySqlCommand command = new MySqlCommand(sql, connection.GetConnect());

                            command.ExecuteNonQuery();

                            connection.CloseConnect();
                        }

                        catch (Exception)
                        {
                            a++;
                            goto emp;
                        }
                    }

                    MessageBox.Show("Успешно! Импорт завершен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cmImport.SelectedIndex = -1;
                    tbImport.Clear();
                }

                else if (cmImport.Text == "category")
                {
                    for (int a = 1; a < arrayStr.Count; a++)
                    {

                 category:
                        try
                        {
                            string tmpStr = Convert.ToString(arrayStr[a]);
                            array = tmpStr.Split(Separator);

                            db_connect connection = new db_connect();
                            connection.OpenConnect();

                            string sql = String.Format("INSERT INTO category VALUES ({0}, '{1}');", array[0], array[1]);

                            MySqlCommand command = new MySqlCommand(sql, connection.GetConnect());

                            command.ExecuteNonQuery();
                            connection.CloseConnect();
                        }

                        catch (Exception)
                        {
                            a++;
                            goto category;
                        }
                    }

                    MessageBox.Show("Успешно! Импорт завершен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cmImport.SelectedIndex = -1;
                    tbImport.Clear();
                }

                else if (cmImport.Text == "role")
                {
                    for (int a = 1; a < arrayStr.Count; a++)
                    {

                  role:
                        try
                        {
                            string tmpStr = Convert.ToString(arrayStr[a]);
                            array = tmpStr.Split(Separator);

                            db_connect connection = new db_connect();
                            connection.OpenConnect();

                            string sql = String.Format("INSERT INTO role VALUES ({0}, '{1}');", array[0], array[1]);

                            MySqlCommand command = new MySqlCommand(sql, connection.GetConnect());

                            command.ExecuteNonQuery();

                            connection.CloseConnect();
                        }

                        catch (Exception)
                        {
                            a++;
                            goto role;
                        }
                    }

                    MessageBox.Show("Успешно! Импорт завершен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cmImport.SelectedIndex = -1;
                    tbImport.Clear();
                }

                else
                {
                    MessageBox.Show("Данная функция в разработке", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void bFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog upload = new OpenFileDialog())
            {
                upload.Filter = "csv Files |*.csv";

                if (upload.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                
                path_csv = upload.FileName;
                tbImport.Text = path_csv;
            }
        }
    }
}
