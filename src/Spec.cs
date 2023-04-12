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
                    MessageBox.Show("Ошибка! Выберите путь и таблицу для экспорта.", "Экспорт", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    // Получаем выбранный пользователем разделитель из комбобокса
                    char separator = ';';
                    switch (cbrazdel.SelectedIndex)
                    {
                        case 0:
                            separator = ';';
                            break;
                        case 1:
                            separator = ',';
                            break;
                        case 2:
                            separator = '|';
                            break;
                        default:
                            separator = ';';
                            break;
                    }

                    for (int i = 0, len = dt.Columns.Count - 1; i <= len; ++i)
                    {
                        if (i != len)
                            writer.Write(dt.Columns[i].ColumnName + separator);
                        else
                            writer.Write(dt.Columns[i].ColumnName);
                    }

                    writer.Write("\n");

                    int count = dt.Rows.Count;

                    foreach (DataRow dataRow in dt.Rows)
                    {
                        string r = String.Join(separator.ToString(), dataRow.ItemArray);
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
            if (tbExport.Text == "" || cmExport.Text == "")
            {
                MessageBox.Show("Ошибка! Выберите путь и таблицу для экспорта.", "Экспорт", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                // Получаем выбранный пользователем разделитель из комбобокса
                char separator = ';';
                switch (cbrazdel.SelectedIndex)
                {
                    case 0:
                        separator = ';';
                        break;
                    case 1:
                        separator = ',';
                        break;
                    case 2:
                        separator = '|';
                        break;
                    default:
                        separator = ';';
                        break;
                }

                for (int i = 0, len = dt.Columns.Count - 1; i <= len; ++i)
                {
                    if (i != len)
                        writer.Write(dt.Columns[i].ColumnName + separator);
                    else
                        writer.Write(dt.Columns[i].ColumnName);
                }

                writer.Write("\n");

                int count = dt.Rows.Count;

                foreach (DataRow dataRow in dt.Rows)
                {
                    string r = String.Join(separator.ToString(), dataRow.ItemArray);
                    writer.WriteLine(r);
                }

                writer.Close();

                connect.CloseConnect();

                MessageBox.Show("Успешно! Экспорт в текстовый файл CSV произведен успешно. Файл сохранен по выбранному пути.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmExport.SelectedIndex = -1;
                tbExport.Clear();
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
