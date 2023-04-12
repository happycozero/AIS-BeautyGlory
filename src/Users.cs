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
    public partial class Users : Form
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

        string id_user = "0";
        public Users()
        {
            InitializeComponent();
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateInfo()
        {
            tbLog.Clear();
            tbPass.Clear();
            cmEmp.SelectedIndex = -1;
            cmRole.SelectedIndex = -1;
     
            lCount.Text = "Количество сотрудников: " + dgvUsers.Rows.Count;
        }

        private void Users_Load(object sender, EventArgs e)
        {
            Fill_cmEmp();
            Fill_cmRole();
            FillDgv();

            bEdit.Enabled = false;
            bDel.Enabled = false;

            lCount.Text = "Количество сотрудников: " + dgvUsers.Rows.Count;
        }

        public void FillDgv()
        {
            db_connect connection = new db_connect();
            connection.OpenConnect();

            string sql = @"SELECT users.id AS 'ID', emp.first_name AS 'Фамилия', 
                         emp.name AS 'Имя', emp.middle_name AS 'Отчество', 
                         users.login AS 'Логин', users.password AS 'Пароль', 
                         role.name AS 'Роль', users.id_emp AS 'ID_EMP' FROM `users` INNER JOIN `role` ON role.id = users.role INNER JOIN `emp` ON emp.id = users.id_emp;";

            MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
            com.ExecuteNonQuery();

            MySqlDataAdapter adapter = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgvUsers.DataSource = dt;

            dgvUsers.Columns[0].Visible = false;
            dgvUsers.Columns[1].Width = 180;
            dgvUsers.Columns[2].Width = 180;
            dgvUsers.Columns[3].Width = 180;
            dgvUsers.Columns[4].Width = 119;
            dgvUsers.Columns[5].Width = 180;
            dgvUsers.Columns[6].Width = 180;
            dgvUsers.Columns[7].Visible = false;

            connection.CloseConnect();
        }

        private void Fill_cmEmp()
        {
            cmEmp.Items.Clear();

            db_connect connection = new db_connect();
            connection.OpenConnect();

            string sql = @"SELECT * FROM emp;";
            MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());

            MySqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                string s = reader[0].ToString() + " - " + reader[1].ToString() + " " + reader[2].ToString()[0] + "." + reader[3].ToString()[0] + ".";

                cmEmp.Items.Add(s);
            }

            connection.CloseConnect();
        }

        private void Fill_cmRole()
        {
            cmRole.Items.Clear();

            db_connect connection = new db_connect();
            connection.OpenConnect();

            string sql = @"SELECT * FROM role;";
            MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());

            MySqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                cmRole.Items.Add(reader[1].ToString());
            }

            connection.CloseConnect();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (tbLog.Text == "" || tbPass.Text == "" || cmEmp.Text == "" || cmRole.Text == "")
            {
                MessageBox.Show("Ошибка. Сначала заполните все поля!", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (CheckUser() == false)
                {
                    MessageBox.Show("Данный логин уже занят!", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (CheckAccount() == false)
                {
                    MessageBox.Show("У данного пользователя уже есть действующая учетная запись!", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    string id_emp = cmEmp.Text.ToString();

                    db_connect connection = new db_connect();
                    connection.OpenConnect();

                    string sql = String.Format(@"INSERT INTO `users` VALUES (null, {0}, '{1}', '{2}', {3});", id_emp[0], tbLog.Text, tbPass.Text, get_idRole());

                    MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
                    com.ExecuteNonQuery();

                    connection.CloseConnect();
                    FillDgv();
                    UpdateInfo();

                    MessageBox.Show("Успешно! Запись добавлена.", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private int get_idRole()
        {
            db_connect connect = new db_connect();
            connect.OpenConnect();

            string sql = "SELECT id FROM role WHERE name = '" + cmRole.Text + "';";

            MySqlCommand com = new MySqlCommand(sql, connect.GetConnect());

            int id = Convert.ToInt32(com.ExecuteScalar());

            connect.CloseConnect();

            return id;
        }

        private bool CheckUser()
        {
            try
            {
                bool flag = false;
                string temp = "";
                string id_emp = cmEmp.Text.ToString();

                db_connect connect = new db_connect();
                connect.OpenConnect();

                string sql = "SELECT id FROM users WHERE login = '" + tbLog.Text + "';";

                MySqlCommand com = new MySqlCommand(sql, connect.GetConnect());

                try
                {
                    temp = com.ExecuteScalar().ToString();
                    flag = false;
                }

                catch
                {
                    flag = true;
                    return flag;
                }

                return flag;

            }

            catch (Exception msg)
            {
                MessageBox.Show("Ошибка! " + msg.Message, "Возникла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool CheckAccount()
        {
            try
            {
                bool flag = false;
                string temp = "";
                string id_emp = cmEmp.Text.ToString();

                db_connect connect = new db_connect();
                connect.OpenConnect();

                string sql = "SELECT id FROM users WHERE id_emp = " + id_emp[0] + ";";

                MySqlCommand com = new MySqlCommand(sql, connect.GetConnect());

                try
                {
                    temp = com.ExecuteScalar().ToString();
                    flag = false;
                }

                catch
                {
                    flag = true;
                    return flag;
                }

                return flag;

            }

            catch (Exception msg)
            {
                MessageBox.Show("Ошибка! " + msg.Message, "Возникла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void dgvUsers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                id_user = dgvUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbLog.Text = dgvUsers.Rows[e.RowIndex].Cells[4].Value.ToString();
                tbPass.Text = dgvUsers.Rows[e.RowIndex].Cells[5].Value.ToString();
                cmRole.Text = dgvUsers.Rows[e.RowIndex].Cells[6].Value.ToString();

                string s = dgvUsers.Rows[e.RowIndex].Cells[7].Value.ToString() + " - " + dgvUsers.Rows[e.RowIndex].Cells[1].Value.ToString() + " " + dgvUsers.Rows[e.RowIndex].Cells[2].Value.ToString()[0] + "." + dgvUsers.Rows[e.RowIndex].Cells[3].Value.ToString()[0] + ".";
                cmEmp.Text = s;

                bEdit.Enabled = true;
                bDel.Enabled = true;
            }

            catch (Exception msg)
            {
                MessageBox.Show("Ошибка! " + msg.Message, "Возникла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            if (tbLog.Text == "" || tbPass.Text == "" || cmEmp.Text == "" || cmRole.Text == "")
            {
                MessageBox.Show("Ошибка. Сначала заполните все поля!", "Редактирование", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                 db_connect connection = new db_connect();
                 connection.OpenConnect();

                 string sql = String.Format(@"UPDATE `users` SET login = '{0}', password = '{1}', role = {2} WHERE id = {3};", tbLog.Text, tbPass.Text, get_idRole(), id_user);

                 MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
                 com.ExecuteNonQuery();

                 connection.CloseConnect();
                 FillDgv();
                 UpdateInfo();

                 bEdit.Enabled = false;
                 bDel.Enabled = false; 

                 MessageBox.Show("Успешно! Данные о пользователе изменены.", "Редактирование", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить выбранную запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult.Yes == result)
            {
                db_connect connection = new db_connect();
                connection.OpenConnect();

                string sql = String.Format("DELETE FROM users WHERE id = {0}", id_user);

                MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
                com.ExecuteNonQuery();

                connection.CloseConnect();
                FillDgv();
                UpdateInfo();

                bEdit.Enabled = false;
                bDel.Enabled = false; 

                MessageBox.Show("Успешно! Учетная запись пользователя удалена.", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
