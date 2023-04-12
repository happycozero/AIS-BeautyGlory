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
    public partial class MenuAdmin : Form
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

        Products prod = new Products();
        Users user = new Users();
        Guide guide = new Guide();
        Spec spec = new Spec();
        ViewOrders vieworders = new ViewOrders();

        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {
            FillLabel();
        }

        public void FillLabel()
        {
            db_connect connection = new db_connect();
            connection.OpenConnect();

            string sql_first_name = "SELECT UserSurname FROM user WHERE UserID = " + Auth.id_user + ";";
            MySqlCommand com1 = new MySqlCommand(sql_first_name, connection.GetConnect());
            string first_name = com1.ExecuteScalar().ToString();

            string sql_name = "SELECT UserName FROM user WHERE UserID = " + Auth.id_user + ";";
            MySqlCommand com2 = new MySqlCommand(sql_name, connection.GetConnect());
            string name = com2.ExecuteScalar().ToString();

            string sql_middle_name = "SELECT UserPatronymic FROM user WHERE UserID = " + Auth.id_user + ";";
            MySqlCommand com3 = new MySqlCommand(sql_middle_name, connection.GetConnect());
            string middle_name = com3.ExecuteScalar().ToString();

            connection.CloseConnect();

            lFIO.Text = "";

            lFIO.Text = first_name + " " + name[0] + ". " + middle_name[0] + ". ";
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите выйти из учетной записи?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void bProducts_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            prod.ShowDialog();
            this.Visible = true;
        }

        private void bUser_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            user.ShowDialog();
            this.Visible = true;
        }

        private void bGuide_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            guide.ShowDialog();
            this.Visible = true;
        }

        private void bSpec_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            spec.ShowDialog();
            this.Visible = true;
        }

        private void bOrder_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            vieworders.ShowDialog();
            this.Visible = true;
        }
    }
}
