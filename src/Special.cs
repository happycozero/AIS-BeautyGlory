using Microsoft.Office.Interop.Word;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Macs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautyGlory
{
    public partial class Special : Form
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

        public Special()
        {
            InitializeComponent();
        }

        public void Fill_Import()
        {
            cmImport.Items.Clear();

            db_connect connect = new db_connect();
            connect.OpenConnect();

            string sql = "SHOW TABLES;";
            MySqlCommand com = new MySqlCommand(sql, connect.GetConnect());
            MySqlDataReader reader = null;

            try
            {
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    cmImport.Items.Add(reader[0].ToString());
                }
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                connect.CloseConnect();
            }
        }

        public void Fill_Export()
        {
            cmExport.Items.Clear();

            db_connect connect = new db_connect();
            connect.OpenConnect();

            string sql = "SHOW TABLES;";
            MySqlCommand com = new MySqlCommand(sql, connect.GetConnect());
            MySqlDataReader reader = null;

            try
            {
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    cmExport.Items.Add(reader[0].ToString());
                }
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                connect.CloseConnect();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Fill_Export();
            Fill_Import();
        }

        private void bPath_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tbExport.Text = this.folderBrowserDialog1.SelectedPath;
            }
        }

        private void bExport_Click(object sender, EventArgs e)
        {
            if (tbExport.Text == "")
            {
                MessageBox.Show("Предупреждение! Выберите таблицу для экспорта.", "Экспорт БД", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (cmExport.Text == "")
            {
                MessageBox.Show("Предупреждение! Выберите путь для экспорта.", "Экспорт БД", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (cm1.Text == "")
            {
                MessageBox.Show("Предупреждение! Выберите разделитель для экспорта.", "Экспорт БД", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    string temp = tbExport.Text;
                    tbExport.Text = temp.Replace("\\", "//");
                    db_connect connect = new db_connect();
                    connect.OpenConnect();

                    string sql = "SELECT * FROM " + cmExport.Text + " INTO OUTFILE @file_path FIELDS TERMINATED BY @delimiter;";

                    MySqlCommand com = new MySqlCommand(sql, connect.GetConnect());
                    com.Parameters.AddWithValue("@file_path", tbExport.Text + "//" + cmExport.Text + ".csv");
                    com.Parameters.AddWithValue("@delimiter", cm1.Text);
                    com.ExecuteNonQuery();

                    connect.CloseConnect();

                    cmExport.SelectedIndex = -1;
                    tbExport.Clear();
                    cm1.SelectedIndex = -1;

                    MessageBox.Show("Успешно! Экспорт завершен. Файл сохранен по выбранному пути.", "Экспорт БД", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception msg)
                {
                    MessageBox.Show("Возникла ошибка!" + msg.Message, "Ошибка программы", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                string[] temp = path_csv.Split('.');
                string[] temp2 = temp[0].Split('\\');
                cmImport.Text = temp2[1];
            }
        }

        private void bImport_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbImport.Text))
                {
                    MessageBox.Show("Предупреждение! Выберите файл для импорта.", "Импорт БД", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(cmImport.Text))
                {
                    MessageBox.Show("Предупреждение! Выберите таблицу для импорта.", "Импорт БД", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(cm2.Text))
                {
                    MessageBox.Show("Предупреждение! Выберите разделитель для импорта.", "Импорт БД", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string temp = tbImport.Text;
                tbImport.Text = temp.Replace("\\", "//");

                db_connect connect = new db_connect();
                connect.OpenConnect();

                string sql = string.Format("LOAD DATA INFILE '{0}' IGNORE INTO TABLE {1} FIELDS TERMINATED BY '{2}';", tbImport.Text, cmImport.Text, cm2.Text);

                MySqlCommand com = new MySqlCommand(sql, connect.GetConnect());
                com.ExecuteNonQuery();

                connect.CloseConnect();

                cmImport.SelectedIndex = -1;
                tbImport.Clear();
                cm2.SelectedIndex = -1;

                MessageBox.Show("Успешно! Импорт завершен.", "Импорт БД", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception msg)
            {
                MessageBox.Show("Возникла ошибка! " + msg.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            ClearInfo();
            this.Close();
        }

        public void ClearInfo()
        {
            cmImport.SelectedIndex = -1;
            cm2.SelectedIndex = -1;
            cmExport.SelectedIndex = -1;
            cm1.SelectedIndex = -1;
        }
    }
}
