﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautyGlory
{
    public partial class Auth : Form
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

        static public int role_user = 0;
        static public string id_user = "";
        int count_auth = 0;
        public static int checkform = 0;

        Captch captch = new Captch();
        MenuAdmin menuadmin = new MenuAdmin();
        MenuManager menumanager = new MenuManager();
        MenuUser menuuser = new MenuUser();
        ViewProduct vprod = new ViewProduct();


        public Auth()
        {
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
                if (count_auth > 1)
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

                    if (flag == true)
                    {
                        if (count_auth > 1)
                        {
                            MessageBox.Show("Внимание! Теперь для авторизации необходимо ввести капчу.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            captch.ShowDialog();
                        }

                        if (tbpass == dbpass)
                        {
                            count_auth = 0;

                            string sql_role = "SELECT UserRole FROM user WHERE UserLogin = '" + tblog + "';";
                            MySqlCommand com = new MySqlCommand(sql_role, connection.GetConnect());
                            role_user = Convert.ToInt32(com.ExecuteScalar());

                            string sql_userid = "SELECT UserID FROM user WHERE UserLogin = '" + tblog + "';";
                            MySqlCommand com_id = new MySqlCommand(sql_userid, connection.GetConnect());
                            id_user = com_id.ExecuteScalar().ToString();

                            tbPass.Clear();
                            tbLog.Clear();

                            this.Visible = false;
                            menuuser.ShowDialog();
                            this.Visible = true;

                            //if (role_user == 1)
                            //{
                            //    checkform = 0;
                            //    this.Visible = false;
                            //    menuadmin.ShowDialog();
                            //    this.Visible = true;
                            //}

                            //else
                            //{
                            //    checkform = 14741;
                            //    this.Visible = false;
                            //    menumanager.ShowDialog();
                            //    this.Visible = true;
                            //}
                        }

                        else
                        {
                            MessageBox.Show("Ошибка! Введен неверный пароль. Повторите попытку.", "Возникла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void bExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
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
    }
}
