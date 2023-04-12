using MySql.Data.MySqlClient;
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
    public partial class MenuUser : Form
    {
        Products prod = new Products();
        ViewProduct vprod = new ViewProduct(); 

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

        public MenuUser()
        {
            InitializeComponent();
        }

        private void MenuUser_Load(object sender, EventArgs e)
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

            string sql_role = "SELECT RoleName FROM role WHERE RoleID = " + Auth.role_user + ";";
            MySqlCommand com_role = new MySqlCommand(sql_role, connection.GetConnect());
            lRole.Text = com_role.ExecuteScalar().ToString();

            connection.CloseConnect();

            lFIO.Text = "";

            lFIO.Text = first_name + " " + name + " " + middle_name + " ";
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Auth.role_user == 3)
            {
                this.Visible = false;
                prod.ShowDialog();
                this.Visible = true;
            }

            else
            {
                this.Visible = false;
                vprod.ShowDialog();
                this.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
