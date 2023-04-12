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
    public partial class Guide : Form
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

        string id_role = "";
        string id_cat = "";
        string id_emp = "";
        bool flag_category = false;
        bool flag_role = false;

        public Guide()
        {
            InitializeComponent();
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Guide_Load(object sender, EventArgs e)
        {
            FillRole();
            FillCat();
            FillEmp();
            CountRowsDgv();
            bDel_Role.Enabled = false;
            bEdit_Role.Enabled = false;
            bDel_Emp.Enabled = false;
            bEdit_Emp.Enabled = false;
            bDel_Cat.Enabled = false;
            bUpd_Cat.Enabled = false;
        }

        public void FillRole()
        {
            db_connect connection = new db_connect();
            connection.OpenConnect();

            string sql = @"SELECT RoleID AS 'ID', RoleName AS 'Доступ пользователя' FROM role;";

            MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
            com.ExecuteNonQuery();

            MySqlDataAdapter adapter = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgvRole.DataSource = dt;

            dgvRole.RowTemplate.Height = 60;

            dgvRole.Columns[0].Visible = false;
            dgvRole.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvRole.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            connection.CloseConnect();
        }

        public void FillCat()
        {
            try
            {
                db_connect connection = new db_connect();
                connection.OpenConnect();

                string sql = @"SELECT idCategory AS 'ID', Category AS 'Категория товара' FROM productcategory;";

                MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
                com.ExecuteNonQuery();

                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvCat.DataSource = dt;

                dgvCat.RowTemplate.Height = 60;

                dgvCat.Columns[0].Visible = false;
                dgvCat.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                connection.CloseConnect();
            }
            catch (Exception msg)
            {
                MessageBox.Show("Ошибка! " + msg.Message, "Возникла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillEmp()
        {
            db_connect connection = new db_connect();
            connection.OpenConnect();

            string sql = @"SELECT UserID AS 'ID', UserSurname AS 'Фамилия', USerName AS 'Имя', UserPatronymic AS 'Отчество', UserLogin AS 'Логин', UserPassword AS 'Пароль' FROM user;";

            MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
            com.ExecuteNonQuery();

            MySqlDataAdapter adapter = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgvEmp.DataSource = dt;

            dgvCat.RowTemplate.Height = 60;

            dgvEmp.Columns[0].Visible = false;
            dgvEmp.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvEmp.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvEmp.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvEmp.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvEmp.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvEmp.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvEmp.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvEmp.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvEmp.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvEmp.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            connection.CloseConnect();
        }

        private void bAdd_Cat_Click(object sender, EventArgs e)
        {
            if (tbCat.Text == "")
            {
                 MessageBox.Show("Ошибка! Сначала заполните все поля.", "Добавление категории", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (GetCategory() != 1012)
                {
                    MessageBox.Show("Ошибка! Такая категория уже существует.", "Добавление категории", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbCat.Clear();
                }

                else
                {
                    db_connect connection = new db_connect();
                    connection.OpenConnect();

                    string sql = String.Format("INSERT INTO productcategory VALUES (null, '{0}');", tbCat.Text);

                    MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
                    com.ExecuteNonQuery();

                    connection.CloseConnect();
                    tbCat.Clear();
                    FillCat();
                    CountRowsDgv();

                    MessageBox.Show("Успешно! Запись добавлена.", "Добавление категории", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void bAdd_Role_Click(object sender, EventArgs e)
        {
            if (tbRole.Text == "")
            {
                MessageBox.Show("Ошибка! Сначала заполните все поля.", "Добавление роли", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (GetRole() != 1012)
                {
                    MessageBox.Show("Ошибка! Такая роль уже существует.", "Добавление роли", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbRole.Clear();
                }

                else
                {
                    db_connect connection = new db_connect();
                    connection.OpenConnect();

                    string sql = String.Format("INSERT INTO role VALUES(null, '{0}') ;", tbRole.Text);

                    MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
                    com.ExecuteNonQuery();

                    connection.CloseConnect();
                    tbRole.Clear();
                    FillRole();
                    CountRowsDgv(); 

                    MessageBox.Show("Успешно! Запись добавлена.", "Добавление роли", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgvRole_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                id_role = dgvRole.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbRole.Text = dgvRole.Rows[e.RowIndex].Cells[1].Value.ToString();

                bDel_Role.Enabled = true;
                bEdit_Role.Enabled = true;
            }

            catch (Exception msg)
            {
                MessageBox.Show("Ошибка! " + msg.Message, "Возникла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCat_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                id_cat = dgvCat.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbCat.Text = dgvCat.Rows[e.RowIndex].Cells[1].Value.ToString();

                bDel_Cat.Enabled = true;
                bUpd_Cat.Enabled = true;
            }

            catch (Exception msg)
            {
                MessageBox.Show("Ошибка! " + msg.Message, "Возникла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bDel_Cat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить выбранную запись?", "Удаление категории", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult.Yes == result)
            {
                Check_Cat_Using();

                if (flag_category == true)
                {
                    db_connect connection = new db_connect();
                    connection.OpenConnect();

                    string sql = @"DELETE FROM productcategory WHERE idCategory = " + id_cat + ";";

                    MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
                    com.ExecuteNonQuery();

                    connection.CloseConnect();

                    MessageBox.Show("Запись успешно удалена.", "Удаление категории", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    bDel_Cat.Enabled = false;
                    bUpd_Cat.Enabled = false;

                    tbCat.Clear();
                    FillCat();
                    CountRowsDgv();
                }

                else
                {
                    MessageBox.Show("Ошибка! Данная категория используется.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void bDel_Role_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить выбранную запись?", "Удаление роли", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult.Yes == result)
            {
                Check_Role_Using();

                if (flag_role == true)
                {
                    db_connect connection = new db_connect();
                    connection.OpenConnect();

                    string sql = @"DELETE FROM role WHERE RoleID = " + id_role + ";";

                    MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
                    com.ExecuteNonQuery();

                    connection.CloseConnect();

                    MessageBox.Show("Запись успешно удалена.", "Удаление роли", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    bDel_Role.Enabled = false;
                    bEdit_Role.Enabled = false;
                    tbRole.Clear();

                    FillRole();
                    CountRowsDgv();
                }

                else
                {
                    MessageBox.Show("Ошибка! Данная роль используется.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void bUpd_Cat_Click(object sender, EventArgs e)
        {
            if (GetCategory() != 1012)
            {
                MessageBox.Show("Ошибка! Такая категория уже существует.", "Добавление категории", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbCat.Clear();
            }

            else
            {
                db_connect connection = new db_connect();
                connection.OpenConnect();

                string sql = String.Format("UPDATE productcategory SET Category = '{0}' WHERE idCategory = {1};", tbCat.Text, id_cat);

                MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
                com.ExecuteNonQuery();

                connection.CloseConnect();

                MessageBox.Show("Запись успешно отредактирована.", "Редактирование категории", MessageBoxButtons.OK, MessageBoxIcon.Information);

                bDel_Cat.Enabled = false;
                bUpd_Cat.Enabled = false;

                tbCat.Clear();
                FillCat();
                CountRowsDgv();
            }
        }

        private void bEdit_Role_Click(object sender, EventArgs e)
        {
            if (GetRole() != 1012)
            {
                MessageBox.Show("Ошибка! Такая роль уже существует.", "Добавление роли", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbRole.Clear();
            }

            else
            {
                db_connect connection = new db_connect();
                connection.OpenConnect();

                string sql = String.Format("UPDATE role SET RoleName = '{0}' WHERE RoleID = {1};", tbRole.Text, id_role);

                MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
                com.ExecuteNonQuery();

                connection.CloseConnect();

                MessageBox.Show("Запись успешно отредактирована.", "Редактирование роли", MessageBoxButtons.OK, MessageBoxIcon.Information);

                bDel_Role.Enabled = false;
                bEdit_Role.Enabled = false;
                tbRole.Clear();

                FillRole();
                CountRowsDgv();
            }
        }

        private void tbRole_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'а' && e.KeyChar <= 'я' || e.KeyChar >= 'А' && e.KeyChar <= 'Я' ||  e.KeyChar == 8 || e.KeyChar == ' ')
            {
                return;
            }

            else
            {
                e.Handled = true;
            }
        }

        private int GetCategory()
        {
            try
            {
                db_connect connect = new db_connect();
                connect.OpenConnect();

                string sql = "SELECT idCategory FROM productcategory WHERE Category ='" + tbCat.Text + "';";

                MySqlCommand com = new MySqlCommand(sql, connect.GetConnect());

                object result = com.ExecuteScalar();

                if (result != null)
                {
                    int temp = Convert.ToInt32(result.ToString());
                    return temp;
                }
                else
                {
                    // handle the case where the query does not return any results
                    return 1012;
                }
            }
            catch
            {
                // handle any other exceptions that may occur
                return 1012;
            }
        }

        private int GetRole()
        {
            try
            {
                db_connect connect = new db_connect();
                connect.OpenConnect();

                string sql = "SELECT RoleID FROM role WHERE RoleName ='" + tbRole.Text + "';";

                MySqlCommand com = new MySqlCommand(sql, connect.GetConnect());

                object result = com.ExecuteScalar();

                if (result != null)
                {
                    int temp = Convert.ToInt32(result.ToString());
                    return temp;
                }
                else
                {
                    // handle the case where the query does not return any results
                    return 1012;
                }
            }
            catch
            {
                // handle any other exceptions that may occur
                return 1012;
            }
        }

        private void Check_Cat_Using()
        {
            try
            {
                db_connect connect = new db_connect();
                connect.OpenConnect();

                string sql = "SELECT ProductName FROM product WHERE ProductCategory =" + GetCategory() + ";";

                MySqlCommand com = new MySqlCommand(sql, connect.GetConnect());

                try
                {
                    string temp = com.ExecuteScalar().ToString();
                    flag_category = false;
                }

                catch
                {
                    flag_category = true;
                }
            }

            catch (Exception msg)
            {
                MessageBox.Show("Ошибка! " + msg.Message, "Возникла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Check_Role_Using()
        {
            try
            {
                db_connect connect = new db_connect();
                connect.OpenConnect();

                string sql = "SELECT name FROM users WHERE role =" + GetRole() + ";";

                MySqlCommand com = new MySqlCommand(sql, connect.GetConnect());

                try
                {
                    string temp = com.ExecuteScalar().ToString();
                    flag_role = false;
                }

                catch
                {
                    flag_role = true;
                }
            }

            catch (Exception msg)
            {
                MessageBox.Show("Ошибка! " + msg.Message, "Возникла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CountRowsDgv()
        {
            label6.Text = "Количество категорий: " + dgvCat.Rows.Count;
            label8.Text = "Количество ролей: " + dgvRole.Rows.Count;
            label9.Text = "Количество сотрудников: " + dgvEmp.Rows.Count;
        }

        private void bAdd_Emp_Click(object sender, EventArgs e)
        {
            if (tbFirst_name.Text == "" || tbName.Text == "" || tbMiddle_name.Text == "" || tbLogin.Text == "")
            {
                MessageBox.Show("Ошибка! Сначала заполните все поля.", "Добавление пользователя", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if(CheckNum() != 1012)
                {
                    MessageBox.Show("Предупреждение! Данный логин уже используется другим сотрудником.", "Добавление пользователя", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    db_connect connection = new db_connect();
                    connection.OpenConnect();

                    string sql = String.Format("INSERT INTO user VALUES(null, '{0}', '{1}', '{2}', '{3}') ;", tbFirst_name.Text, tbName.Text, tbMiddle_name.Text, tbLogin.Text);

                    MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
                    com.ExecuteNonQuery();

                    connection.CloseConnect();

                    ClearTbEmp();
                    FillEmp();
                    CountRowsDgv();

                    MessageBox.Show("Успешно! Запись добавлена.", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void bEdit_Emp_Click(object sender, EventArgs e)
        {
            if (tbFirst_name.Text == "" || tbName.Text == "" || tbMiddle_name.Text == "" || tbLogin.Text == "")
            {
                MessageBox.Show("Ошибка! Сначала заполните все поля.", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (CheckNumUpd() != 1012)
                {
                    MessageBox.Show("Предупреждение! Данный логин уже используется другим сотрудником.", "Добавление пользователя ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbLogin.Clear();
                }

                else
                {
                    db_connect connection = new db_connect();
                    connection.OpenConnect();

                    string sql = String.Format("UPDATE user SET UserSurname = '{0}', UserName = '{1}', UserPatronymic = '{2}', UserLogin = '{3}' WHERE UserID = {4};", tbFirst_name.Text, tbName.Text, tbMiddle_name.Text, tbLogin.Text, id_emp);

                    MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
                    com.ExecuteNonQuery();

                    connection.CloseConnect();

                    ClearTbEmp();
                    FillEmp();
                    CountRowsDgv();

                    MessageBox.Show("Успешно! Запись отредактирована.", "Редактирование", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void bDel_Emp_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить выбранную запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult.Yes == result)
            {
                db_connect connection = new db_connect();
                connection.OpenConnect();

                string sql = @"DELETE FROM user WHERE UserID = " + id_emp + ";";

                MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
                com.ExecuteNonQuery();

                connection.CloseConnect();

                MessageBox.Show("Запись успешно удалена.", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);

                bEdit_Emp.Enabled = false;
                bDel_Emp.Enabled = false;
                ClearTbEmp();

                FillEmp();
                CountRowsDgv();
            }
        }

        private int CheckNum()
        {
            try
            {
                db_connect connect = new db_connect();
                connect.OpenConnect();

                string sql = "SELECT UserID FROM user WHERE UserLogin ='" + tbLogin.Text + "';";

                MySqlCommand com = new MySqlCommand(sql, connect.GetConnect());

                int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
                
                return temp;
            }

            catch
            {
                return 1012;
            }
        }

        private void dgvEmp_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                id_emp = dgvEmp.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbFirst_name.Text = dgvEmp.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbName.Text = dgvEmp.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbMiddle_name.Text = dgvEmp.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbLogin.Text = dgvEmp.Rows[e.RowIndex].Cells[4].Value.ToString();

                bEdit_Emp.Enabled = true;
                bDel_Emp.Enabled = true;
            }

            catch (Exception msg)
            {
                MessageBox.Show("Ошибка! " + msg.Message, "Возникла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearTbEmp()
        {
            tbFirst_name.Clear();
            tbName.Clear();
            tbMiddle_name.Clear();
            tbLogin.Clear();
        }

        private int CheckNumUpd()
        {
            try
            {
                db_connect connect = new db_connect();
                connect.OpenConnect();

                string sql = "SELECT UserID FROM user WHERE UserLogin ='" + tbLogin.Text + "';";

                MySqlCommand com = new MySqlCommand(sql, connect.GetConnect());

                int temp = Convert.ToInt32(com.ExecuteScalar().ToString());

                if (temp == Convert.ToInt32(id_emp))
                {
                    return 1012;
                }
                
                else
                {
                    return temp;
                }
            }

            catch
            {
                return 1012;
            }
        }

        private void tbRole_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvCat_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dgvCat.Columns[e.ColumnIndex].Selected)
            {
                try
                {
                    //
                }
                catch (Exception msg)
                {
                    //
                }
            }
        }
    }
}
