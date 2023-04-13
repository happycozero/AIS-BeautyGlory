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
    public partial class MenuManager : Form
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

        ViewProduct viewprod = new ViewProduct();
        public static string globalFIO = "";

        public MenuManager()
        {
            InitializeComponent();
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
            viewprod.ShowDialog();
            this.Visible = true;
        }

        private void MenuManager_Load(object sender, EventArgs e)
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
            globalFIO = lFIO.Text;
        }


    }
}
