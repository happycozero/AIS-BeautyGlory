using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace BeautyGlory
{
    public partial class AuthForm : Form
    {
        static public int role_user = 0;
        static public string id_user = "";
        int count_auth = 0;
        public static int checkform = 0;

        Captch captch = new Captch();
        MenuAdmin menuadmin = new MenuAdmin();
        MenuManager menumanager = new MenuManager();
        MenuUser menuuser = new MenuUser();
        ViewProduct vprod = new ViewProduct();

        public AuthForm()
        {
            BackupDB bk = new BackupDB();
            bk.getBackup();
            InitializeComponent();
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            tbPass.UseSystemPasswordChar = true;
        }

        private void cbPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPass.Checked == true)
            {
                tbPass.UseSystemPasswordChar = false;
            }

            else
            {
                tbPass.UseSystemPasswordChar = true;
            }
        }

        private void bAuth_Click(object sender, EventArgs e)
        {
            try
            {
                if (count_auth > 0)
                {
                    MessageBox.Show("Внимание! Теперь для авторизации необходимо ввести капчу.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    captch.ShowDialog();
                }

                if (tbLog.Text == "" || tbPass.Text == "")
                {
                    MessageBox.Show("Ошибка! Сначала заполните все поля!", "Возникла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    count_auth++;
                }

                else
                {
                    string tblog = tbLog.Text;
                    string tbpass = tbPass.Text;
                    string dbpass = "";
                    bool flag = true;

                    db_connect connection = new db_connect();
                    connection.OpenConnect();

                    string sql = "SELECT UserPassword FROM user WHERE UserLogin = '" + tblog + "';";
                    MySqlCommand command = new MySqlCommand(sql, connection.GetConnect());

                    try
                    {
                        dbpass = command.ExecuteScalar().ToString();
                    }

                    catch
                    {
                        MessageBox.Show("Ошибка! Такого пользователя не существует. Повторите попытку.", "Возникла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbLog.Clear();
                        flag = false;
                        count_auth++;
                    }

                    if (flag)
                    {
                        if (count_auth > 1)
                        {
                            MessageBox.Show("Внимание! Теперь для авторизации необходимо ввести капчу.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            captch.ShowDialog();
                        }

                        if (tbpass == dbpass)
                        {
                            count_auth = 0;

                            var sql_role = "SELECT UserRole FROM user WHERE UserLogin = @tblog;";
                            using (var com = new MySqlCommand(sql_role, connection.GetConnect()))
                            {
                                com.Parameters.AddWithValue("@tblog", tblog);
                                role_user = Convert.ToInt32(com.ExecuteScalar());
                            }

                            var sql_userid = "SELECT UserID FROM user WHERE UserLogin = @tblog;";
                            using (var com_id = new MySqlCommand(sql_userid, connection.GetConnect()))
                            {
                                com_id.Parameters.AddWithValue("@tblog", tblog);
                                id_user = com_id.ExecuteScalar().ToString();
                            }

                            tbPass.Clear();
                            tbLog.Clear();

                            switch (role_user)
                            {
                                case 1:
                                    checkform = 0;
                                    this.Visible = false;
                                    menuuser.ShowDialog();
                                    this.Visible = true;
                                    break;

                                case 2:
                                    checkform = 14741;
                                    this.Visible = false;
                                    menumanager.ShowDialog();
                                    this.Visible = true;
                                    break;

                                case 3:
                                    checkform = 14741;
                                    this.Visible = false;
                                    menuadmin.ShowDialog();
                                    this.Visible = true;
                                    break;

                                default:
                                    break;
                            }

                        }
                        else
                        {
                            MessageBox.Show("Ошибка! Введен неверный пароль.\n Повторите попытку.", "Возникла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tbPass.Clear();
                            count_auth++;
                        }
                    }
                }
            }

            catch (Exception msg)
            {
                MessageBox.Show("Ошибка! " + msg.Message, "Возникла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbLog_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8 || e.KeyChar == ' ')
            {
                return;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tbLog.Clear();
            tbPass.Clear();
            this.Visible = false;
            vprod.ShowDialog();
            this.Visible = true;
        }

        private void Auth_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти из программы?", "Выход из программы", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                e.Cancel = true;
            else
                e.Cancel = false;
        }
    }
}
