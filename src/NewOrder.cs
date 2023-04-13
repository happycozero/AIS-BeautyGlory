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
    public partial class NewOrder : Form
    {
        private string cellErrorText;

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

        OrderView orderview = new OrderView();

        string id_prod = "";
        string id_cart = "";
        string id_prod_cart = "";

        public static string[] art_global;
        public static string[] quan_global;
        public static string[] price_global;
        public static int N_global;

        public NewOrder()
        {
            InitializeComponent();
        }

        private void NewOrder_Load(object sender, EventArgs e)
        {
            #region FIO

            db_connect connection = new db_connect();
            connection.OpenConnect();

            string sql_first_name = "SELECT UserSurname FROM user WHERE UserID = " + AuthForm.id_user + ";";
            MySqlCommand com1 = new MySqlCommand(sql_first_name, connection.GetConnect());
            string first_name = com1.ExecuteScalar().ToString();

            string sql_name = "SELECT UserName FROM user WHERE UserID = " + AuthForm.id_user + ";";
            MySqlCommand com2 = new MySqlCommand(sql_name, connection.GetConnect());
            string name = com2.ExecuteScalar().ToString();

            string sql_middle_name = "SELECT UserPatronymic FROM user WHERE UserID = " + AuthForm.id_user + ";";
            MySqlCommand com3 = new MySqlCommand(sql_middle_name, connection.GetConnect());
            string middle_name = com3.ExecuteScalar().ToString();

            connection.CloseConnect();

            lFIO.Text = first_name + " " + name + " " + middle_name + " ";

            #endregion

            lDate.Text = DateTime.Now.ToString("dd.MM.yyyy");

            bAdd.Enabled = false;
            bDel.Enabled = false;
            CartFill();
            labelFill();
        }
        public void CartFill()
        {
            db_connect connection = new db_connect();
            connection.OpenConnect();

            string sql = @"SELECT idCart AS 'ИД', idUser AS 'useer', idProduct AS 'Артикул',
                           NameProduct AS 'Название', Quantity AS 'Количество', Price AS 'Цена' FROM cart WHERE idUser = " + AuthForm.id_user + ";";

            MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
            com.ExecuteNonQuery();

            MySqlDataAdapter adapter = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgvCart.DataSource = dt;

            dgvCart.Columns[0].Visible = false;
            dgvCart.Columns[1].Visible = false;

            connection.CloseConnect();
        }

        public static string Count()
        {
            db_connect connection = new db_connect();
            connection.OpenConnect();

            string sql = @"SELECT SUM(Quantity) FROM cart WHERE idUser = " + AuthForm.id_user + ";";

            MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
            string count = com.ExecuteScalar().ToString();

            connection.CloseConnect();

            return count;
        }

        public static string Price()
        {
            db_connect connection = new db_connect();
            connection.OpenConnect();

            string sql = @"SELECT SUM(Quantity * Price) FROM cart WHERE idUser = " + AuthForm.id_user + ";";

            MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
            string price = com.ExecuteScalar().ToString();

            connection.CloseConnect();

            return price;
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckQun() == 1)
                {
                    db_connect connection = new db_connect();
                    connection.OpenConnect();

                    MySqlTransaction trans = connection.GetConnect().BeginTransaction();

                    string sql1 = String.Format("UPDATE cart SET Quantity = (Quantity + {0}) WHERE idProduct = '{1}' AND idUser = {2};", tbCount.Text, id_prod_cart, AuthForm.id_user);
                    MySqlCommand com1 = new MySqlCommand(sql1, connection.GetConnect());
                    com1.Transaction = trans;

                    string sql2 = String.Format("UPDATE product SET ProductQuantityInStock = (ProductQuantityInStock - {0}) WHERE ProductArticleNumber = '{1}';", tbCount.Text, id_prod_cart);
                    MySqlCommand com2 = new MySqlCommand(sql2, connection.GetConnect());
                    com2.Transaction = trans;

                    try
                    {
                        com1.ExecuteNonQuery();
                        com2.ExecuteNonQuery();
                        trans.Commit();
                        CartFill();
                        labelFill();
                        tbCount.Value = 1;

                        bDel.Enabled = false;
                        bAdd.Enabled = false;
                    }

                    catch (Exception msg)
                    {
                        MessageBox.Show("Ошибка! " + msg.Message, "Возникла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        trans.Rollback();
                    }
                }
            }

            catch (Exception msg)
            {
                MessageBox.Show("Ошибка! " + msg.Message, "Возникла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool CheckCartTovar()
        {
            try
            {
                bool flag = false;
                string count = "";

                db_connect connect = new db_connect();
                connect.OpenConnect();

                string sql = "SELECT quantity FROM cart WHERE id_user = " + AuthForm.id_user + " AND article = " + id_prod + ";";

                MySqlCommand com = new MySqlCommand(sql, connect.GetConnect());

                try
                {
                    count = com.ExecuteScalar().ToString();
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

        private void labelFill()
        {
            if (dgvCart.Rows.Count == 0)
            {
                lCount.Text = "";
                lPrice.Text = "";
            }

            else
            {
                lCount.Text = Count() + " шт.";
                lPrice.Text = Price() + " руб.";
            }
        }

        private int CartAmount()
        {
            int ecx = 0;

            db_connect connection = new db_connect();
            connection.OpenConnect();

            string sql = String.Format("SELECT quantity FROM cart WHERE article = {0} AND id_user = {1};", id_prod, AuthForm.id_user);

            MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
            ecx = Convert.ToInt32(com.ExecuteScalar().ToString());

            connection.CloseConnect();

            return ecx;
        }

        private int ProdAmount()
        {
            int ecx = 0;

            db_connect connection = new db_connect();
            connection.OpenConnect();

            string sql = String.Format("SELECT quantity FROM products WHERE article = {0};", id_prod);

            MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
            ecx = Convert.ToInt32(com.ExecuteScalar().ToString());

            connection.CloseConnect();

            return ecx;
        }

        private int ProdAmountCart()
        {
            int ecx = 0;

            db_connect connection = new db_connect();
            connection.OpenConnect();

            string sql = String.Format("SELECT quantity FROM products WHERE article = {0};", id_prod_cart);

            MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
            ecx = Convert.ToInt32(com.ExecuteScalar().ToString());

            connection.CloseConnect();

            return ecx;
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            if (dgvCart.Rows.Count == 0)
            {
                MessageBox.Show("Корзина пустая!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                int ecx = Convert.ToInt32(dgvCart.CurrentRow.Cells[4].Value) - Convert.ToInt32(tbCount.Value);

                if (ecx < 0)
                {
                    MessageBox.Show("В корзине нет столько товара!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbCount.Value = 1;
                }

                else
                {
                    //int pRow = dgvCart.CurrentCell.RowIndex;
                    //int pColumn = dgvCart.CurrentCell.ColumnIndex;
                    //dgvCart.CurrentCell = dgvCart[pColumn, pRow];

                    if (ecx == 0)
                    {
                        db_connect connection = new db_connect();
                        connection.OpenConnect();

                        MySqlTransaction trans = connection.GetConnect().BeginTransaction();

                        string sql1 = String.Format("DELETE FROM cart WHERE idCart = {0};", id_cart);
                        MySqlCommand com1 = new MySqlCommand(sql1, connection.GetConnect());
                        com1.Transaction = trans;

                        string sql2 = String.Format("UPDATE product SET ProductQuantityInStock = (ProductQuantityInStock + {0}) WHERE ProductArticleNumber = '{1}';", tbCount.Text, id_prod_cart);
                        MySqlCommand com2 = new MySqlCommand(sql2, connection.GetConnect());
                        com2.Transaction = trans;

                        try
                        {
                            com1.ExecuteNonQuery();
                            com2.ExecuteNonQuery();
                            trans.Commit();
                            CartFill();
                            labelFill();
                            tbCount.Value = 1;

                            bDel.Enabled = false;
                            bAdd.Enabled = false;
                        }

                        catch (Exception msg)
                        {
                            MessageBox.Show("Ошибка! " + msg.Message, "Возникла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            trans.Rollback();
                        }
                    }

                    else
                    {
                        db_connect connection = new db_connect();
                        connection.OpenConnect();

                        MySqlTransaction trans = connection.GetConnect().BeginTransaction();

                        string sql1 = String.Format("UPDATE cart SET Quantity = (Quantity - {0}) WHERE idProduct = '{1}' AND idUser = {2};", tbCount.Text, id_prod_cart, AuthForm.id_user);
                        MySqlCommand com1 = new MySqlCommand(sql1, connection.GetConnect());
                        com1.Transaction = trans;

                        string sql2 = String.Format("UPDATE product SET ProductQuantityInStock = (ProductQuantityInStock + {0}) WHERE ProductArticleNumber = '{1}';", tbCount.Text, id_prod_cart);
                        MySqlCommand com2 = new MySqlCommand(sql2, connection.GetConnect());
                        com2.Transaction = trans;

                        try
                        {
                            com1.ExecuteNonQuery();
                            com2.ExecuteNonQuery();
                            trans.Commit();
                            CartFill();
                            labelFill();
                            tbCount.Value = 1;

                            bDel.Enabled = false;
                            bAdd.Enabled = false;
                        }

                        catch (Exception msg)
                        {
                            MessageBox.Show("Ошибка! " + msg.Message, "Возникла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            trans.Rollback();
                        }
                    }
                }
            }
        }

        private void dgvCart_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                id_cart = dgvCart.Rows[e.RowIndex].Cells[0].Value.ToString();
                bDel.Enabled = true;
                bAdd.Enabled = true;
                id_prod_cart = dgvCart.Rows[e.RowIndex].Cells[2].Value.ToString();
            }

            catch (Exception msg)
            {
                MessageBox.Show("Ошибка! " + msg.Message, "Возникла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            if (dgvCart.Rows.Count == 0)
            {
                MessageBox.Show("Корзина пустая!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                DialogResult dg = MessageBox.Show("Вы действительно хотите полностью очистить корзину?", "Корзина", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dg == DialogResult.Yes)
                {
                    try
                    {
                        DelAll();
                        CartFill();
                        labelFill();
                    }

                    catch (Exception msg)
                    {
                        MessageBox.Show("Ошибка! " + msg.Message, "Возникла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void DelAll()
        {
            #region GetCount

            db_connect connection = new db_connect();
            connection.OpenConnect();

            string sql = String.Format("SELECT COUNT(*) FROM cart WHERE idUser = {0};", AuthForm.id_user);

            MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
            int N = Convert.ToInt32(com.ExecuteScalar());

            #endregion

            int[] vIdCart = new int[N];
            string art = "";
            int quan = 0;
            int quan_prod = 0;
            int ecx = 0;

            string sql_id = "SELECT idCart FROM cart WHERE idUser = " + AuthForm.id_user;

            MySqlCommand com_id = new MySqlCommand(sql_id, connection.GetConnect());

            MySqlDataReader reader_id = com_id.ExecuteReader();

            while (reader_id.Read())
            {
                vIdCart[ecx] = Convert.ToInt32(reader_id[0].ToString());
                ecx++;
            }

            connection.CloseConnect();

            for(int i = 0; i < N; i++)
            {
                connection.OpenConnect();

                string sql_upd = "SELECT Quantity, idProduct FROM cart WHERE idCart = " + vIdCart[i];

                MySqlCommand com_upd = new MySqlCommand(sql_upd, connection.GetConnect());

                MySqlDataReader reader = com_upd.ExecuteReader();
                
                while (reader.Read())
                {
                    quan = Convert.ToInt32(reader[0].ToString());
                    art = reader[1].ToString();
                }

                connection.CloseConnect();

                connection.OpenConnect();

                string sql_prod = String.Format("SELECT ProductQuantityInStock FROM product WHERE ProductArticleNumber = '{0}';", art);

                MySqlCommand com_prod = new MySqlCommand(sql_prod, connection.GetConnect());
                quan_prod = Convert.ToInt32(com_prod.ExecuteScalar().ToString());

                string sql_prod_upd = String.Format("UPDATE product SET ProductQuantityInStock = {0} WHERE ProductArticleNumber = '{1}';", quan + quan_prod, art);

                MySqlCommand com_prod_upd = new MySqlCommand(sql_prod_upd, connection.GetConnect());
                com_prod_upd.ExecuteNonQuery();

                string sql_del = "DELETE FROM cart WHERE idCart = " + vIdCart[i];

                MySqlCommand com_del = new MySqlCommand(sql_del, connection.GetConnect());
                com_del.ExecuteNonQuery();

                connection.CloseConnect();
            }

            MessageBox.Show("Успешно! Теперь корзина пустая.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bOrder_Click(object sender, EventArgs e)
        {
            if (dgvCart.Rows.Count == 0)
            {
                MessageBox.Show("В корзине нет ни одного товара! Для оформления заказа добавьте хотя бы 1 товар в корзину.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                orderview.ShowDialog();
                CartFill();
                labelFill();
            }
        }

        private int CheckQun()
        {
            db_connect connection = new db_connect();
            connection.OpenConnect();

            string sql = "SELECT ProductQuantityInStock FROM product WHERE ProductArticleNumber = '" + id_prod_cart + "';";
            MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
            
            int n = Convert.ToInt32(com.ExecuteScalar().ToString());

            if (n < Convert.ToInt32(tbCount.Text))
            {
                MessageBox.Show("На складе не достаточно товара. Остаток товара: " + n, "Корзина", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbCount.Value = 1;
                return 0;
            }

            else
            {
                return 1;
            }
        }

        public void AddProductOrder()
        {
            db_connect connection = new db_connect();
            connection.OpenConnect();

            string sql = "SELECT MAX(OrderID) FROM orderproduct;";
            MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
            int num = Convert.ToInt32(com.ExecuteScalar()) + 1;

            string sql2 = "SELECT COUNT(*) FROM cart WHERE idUser = " + AuthForm.id_user + ";";
            MySqlCommand com2 = new MySqlCommand(sql2, connection.GetConnect());
            int N = Convert.ToInt32(com2.ExecuteScalar());
            N_global = N;

            string[] art = new string[N];
            string[] count = new string[N];
            string[] price = new string[N];
            int i = 0;

            string sql3 = "SELECT idProduct, Quantity, Price FROM cart WHERE idUser = " + AuthForm.id_user + ";";
            MySqlCommand com3 = new MySqlCommand(sql3, connection.GetConnect());

            MySqlDataReader reader = com3.ExecuteReader();
            while (reader.Read())
            {
                art[i] = reader[0].ToString();
                count[i] = reader[1].ToString();
                price[i] = reader[2].ToString();
                i++;
            }

            art_global = art;
            quan_global = count;
            price_global = price;
            //Array.Copy(art, art_global, N);
            //Array.Copy(count, quan_global, N);
            //Array.Copy(price, price_global, N);

            connection.CloseConnect();

            for (int j = 0; j < N; j++)
            {
                connection.OpenConnect();

                string sql4 = String.Format("INSERT INTO orderproduct VALUES({0}, '{1}', {2});", num, art[j], count[j]);

                MySqlCommand com4 = new MySqlCommand(sql4, connection.GetConnect());
                com4.ExecuteNonQuery();

                connection.CloseConnect();
            }

            for (int j = 0; j < N; j++)
            {
                connection.OpenConnect();

                string sql4 = String.Format("DELETE FROM cart WHERE idUser =  {0} AND idProduct = '{1}';", AuthForm.id_user, art[j]);

                MySqlCommand com4 = new MySqlCommand(sql4, connection.GetConnect());
                com4.ExecuteNonQuery();

                connection.CloseConnect();
            }

            bOrder.Enabled = false;
        }
    }
}
