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
        Guide guide = new Guide();
        Special spec = new Special();
        ViewOrders vieword = new ViewOrders();

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

            string sql_query = "SELECT UserSurname, UserName, UserPatronymic FROM user WHERE UserID = @id_user;";
            MySqlCommand command = new MySqlCommand(sql_query, connection.GetConnect());
            command.Parameters.AddWithValue("@id_user", AuthForm.id_user);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    string first_name = reader.GetString(0);
                    string name = reader.GetString(1);
                    string middle_name = reader.GetString(2);

                    lFIO.Text = string.Format("{0} {1}. {2}.", first_name, name[0], middle_name[0]);
                }
            }

            connection.CloseConnect();
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
        private void bGuide_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            guide.ShowDialog();
            this.Visible = true;
        }
        private void bSpecial_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            spec.ShowDialog();
            this.Visible = true;
        }

        private void bOrders_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            vieword.ShowDialog();
            this.Visible = true;
        }
    }
}
