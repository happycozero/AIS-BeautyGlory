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

        public NewOrder()
        {
            InitializeComponent();
        }

        private void NewOrder_Load(object sender, EventArgs e)
        {
            lDate.Text = DateTime.Now.ToString("dd.MM.yyyy");

            bAdd.Enabled = false;
            bDel.Enabled = false;
            ProductFill();
            CartFill();
            labelFill();
        }

        private void ProductFill()
        {
            db_connect connection = new db_connect();
            connection.OpenConnect();

            string sql = @"SELECT products.article AS 'Артикул', 
                         products.name AS 'Название', products.description AS 'Описание', 
                         products.price AS 'Цена', products.manufacturer AS 'Производитель', 
                         category.name AS 'Категория', products.quantity AS 'Количество', 
                         products.photo AS 'Изображение' FROM products INNER JOIN category ON products.сategory = category.id;";

            MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
            com.ExecuteNonQuery();

            MySqlDataAdapter adapter = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgvProduct.DataSource = dt;

            dgvProduct.Columns[2].Visible = false;
            dgvProduct.Columns[4].Visible = false;
            dgvProduct.Columns[5].Visible = false;
            dgvProduct.Columns[7].Visible = false;

            connection.CloseConnect();

            FillCell();
        }

        public void CartFill()
        {
            db_connect connection = new db_connect();
            connection.OpenConnect();

            string sql = @"SELECT id AS 'ИД', id_user AS 'useer', article AS 'Артикул',
                           name AS 'Название', quantity AS 'Количество', price AS 'Цена' FROM cart WHERE id_user = " + Auth.id_user + ";";

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

            string sql = @"SELECT SUM(quantity) FROM cart WHERE id_user = " + Auth.id_user + ";";

            MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
            string count = com.ExecuteScalar().ToString();

            connection.CloseConnect();

            return count;
        }

        public static string Price()
        {
            db_connect connection = new db_connect();
            connection.OpenConnect();

            string sql = @"SELECT SUM(quantity * price) FROM cart WHERE id_user = " + Auth.id_user + ";";

            MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
            string price = com.ExecuteScalar().ToString();

            connection.CloseConnect();

            return price;
        }

        private void dgvProduct_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                id_prod = dgvProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
                bAdd.Enabled = true;
                bDel.Enabled = false;

                lArt.Text = dgvProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
                lName.Text = dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbDesc.Text = dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                lCat.Text = dgvProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
                pbPhoto.ImageLocation = "Photo/" + Convert.ToString(dgvProduct.Rows[e.RowIndex].Cells[7].Value.ToString());
            }

            catch (Exception msg)
            {
                MessageBox.Show("Ошибка! " + msg.Message, "Возникла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (id_prod == "")
                {
                    MessageBox.Show("Ошибка! Сначала выберите товар!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Convert.ToInt32(dgvProduct.CurrentRow.Cells[6].Value) == 0)
                    {
                        MessageBox.Show("К сожалению, товар закончился на складе!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    else
                    {
                        int pRow = dgvProduct.CurrentCell.RowIndex;
                        int pColumn = dgvProduct.CurrentCell.ColumnIndex;

                        if (CheckCartTovar() == true)
                        {
                            if (Convert.ToInt32(dgvProduct.CurrentRow.Cells[6].Value) - Convert.ToInt32(tbCount.Value) < 0)
                            {
                                MessageBox.Show("К сожалению, на складе нет столько товара!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                            else
                            {
                                int count = Convert.ToInt32(tbCount.Value);
                                string name = dgvProduct.CurrentRow.Cells[1].Value.ToString();
                                string price = dgvProduct.CurrentRow.Cells[3].Value.ToString();

                                db_connect connection = new db_connect();
                                connection.OpenConnect();

                                string sql = String.Format("INSERT INTO cart VALUES(null, {0}, {1}, '{2}', {3}, {4});", Auth.id_user, id_prod, name, count, price);

                                MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
                                com.ExecuteNonQuery();

                                connection.CloseConnect();

                                CartFill();
                                DelProdQuan();
                                labelFill();
                                tbCount.Value = 1;
                                dgvProduct.CurrentCell = dgvProduct[pColumn, pRow];
                            }
                        }

                        else
                        {
                            if (Convert.ToInt32(dgvProduct.CurrentRow.Cells[6].Value) - Convert.ToInt32(tbCount.Value) < 0)
                            {
                                MessageBox.Show("К сожалению, на складе нет столько товара!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                            else
                            {
                                int count = CartAmount() + Convert.ToInt32(tbCount.Value);

                                db_connect connection = new db_connect();
                                connection.OpenConnect();

                                string sql = String.Format("UPDATE cart SET quantity = {0} WHERE id_user = {1} AND article = {2};", count, Auth.id_user, id_prod);

                                MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
                                com.ExecuteNonQuery();

                                connection.CloseConnect();

                                CartFill();
                                DelProdQuan();
                                labelFill();
                                tbCount.Value = 1;
                                dgvProduct.CurrentCell = dgvProduct[pColumn, pRow];
                            }
                        }
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

        private void tbFind_TextChanged(object sender, EventArgs e)
        {
            if (tbFind.Text.Length > 2)
            {
                db_connect connection = new db_connect();
                connection.OpenConnect();

                string sql = @"SELECT article AS 'Артикул', 
                         name AS 'Название', description AS 'Описание', 
                         price AS 'Цена', manufacturer AS 'Производитель', 
                         сategory AS 'Категория', quantity AS 'Количество', 
                         photo AS 'Изображение' FROM products WHERE name LIKE '%" + tbFind.Text + "%' OR article LIKE '%" + tbFind.Text + "%';";

                MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
                com.ExecuteNonQuery();

                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvProduct.DataSource = dt;

                dgvProduct.Columns[2].Visible = false;
                dgvProduct.Columns[4].Visible = false;
                dgvProduct.Columns[5].Visible = false;
                dgvProduct.Columns[7].Visible = false;

                connection.CloseConnect();
            }

            else
            {
                ProductFill();
            }
        }

        private bool CheckCartTovar()
        {
            try
            {
                bool flag = false;
                string count = "";

                db_connect connect = new db_connect();
                connect.OpenConnect();

                string sql = "SELECT quantity FROM cart WHERE id_user = " + Auth.id_user + " AND article = " + id_prod + ";";

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

        private void DelProdQuan()
        {
            int count = Convert.ToInt32(dgvProduct.CurrentRow.Cells[6].Value) - Convert.ToInt32(tbCount.Value);

            db_connect connection = new db_connect();
            connection.OpenConnect();

            string sql = String.Format("UPDATE products SET quantity = {0} WHERE article = {1};", count, id_prod);

            MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
            com.ExecuteNonQuery();

            connection.CloseConnect();

            ProductFill();
        }

        private void AddProdQuan()
        {
            int count = Convert.ToInt32(tbCount.Value) + ProdAmountCart();

            db_connect connection = new db_connect();
            connection.OpenConnect();

            string sql = String.Format("UPDATE products SET quantity = {0} WHERE article = {1};", count, id_prod_cart);

            MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
            com.ExecuteNonQuery();

            connection.CloseConnect();
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

            string sql = String.Format("SELECT quantity FROM cart WHERE article = {0} AND id_user = {1};", id_prod, Auth.id_user);

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
                    int pRow = dgvCart.CurrentCell.RowIndex;
                    int pColumn = dgvCart.CurrentCell.ColumnIndex;

                    if (ecx == 0)
                    {
                        AddProdQuan();

                        db_connect connection = new db_connect();
                        connection.OpenConnect();

                        string sql = String.Format("DELETE FROM cart WHERE id = {0};", id_cart);

                        MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
                        com.ExecuteNonQuery();

                        connection.CloseConnect();
                        tbCount.Value = 1;
                        ProductFill();
                        CartFill();
                        labelFill();
                        bDel.Enabled = false;
                    }

                    else
                    {
                        AddProdQuan();

                        db_connect connection = new db_connect();
                        connection.OpenConnect();

                        string sql = String.Format("UPDATE cart SET quantity = {0} WHERE id = {1};", ecx, id_cart);

                        MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
                        com.ExecuteNonQuery();

                        connection.CloseConnect();

                        tbCount.Value = 1;
                        ProductFill();
                        CartFill();
                        labelFill();
                        dgvCart.CurrentCell = dgvCart[pColumn, pRow];
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
                bAdd.Enabled = false;
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
                        ProductFill();
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

            string sql = String.Format("SELECT COUNT(*) FROM cart WHERE id_user = {0};", Auth.id_user);

            MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
            int N = Convert.ToInt32(com.ExecuteScalar());

            #endregion

            int[] vIdCart = new int[N];
            int art = 0;
            int quan = 0;
            int quan_prod = 0;
            int ecx = 0;

            string sql_id = "SELECT id FROM cart WHERE id_user = " + Auth.id_user;

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

                string sql_upd = "SELECT quantity, article FROM cart WHERE id = " + vIdCart[i];

                MySqlCommand com_upd = new MySqlCommand(sql_upd, connection.GetConnect());

                MySqlDataReader reader = com_upd.ExecuteReader();
                
                while (reader.Read())
                {
                    quan = Convert.ToInt32(reader[0].ToString());
                    art = Convert.ToInt32(reader[1].ToString());
                }

                connection.CloseConnect();

                connection.OpenConnect();

                string sql_prod = String.Format("SELECT quantity FROM products WHERE article = {0};", art);

                MySqlCommand com_prod = new MySqlCommand(sql_prod, connection.GetConnect());
                quan_prod = Convert.ToInt32(com_prod.ExecuteScalar().ToString());

                string sql_prod_upd = String.Format("UPDATE products SET quantity = {0} WHERE article = {1};", quan + quan_prod, art);

                MySqlCommand com_prod_upd = new MySqlCommand(sql_prod_upd, connection.GetConnect());
                com_prod_upd.ExecuteNonQuery();

                string sql_del = "DELETE FROM cart WHERE id = " + vIdCart[i];

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
                MessageBox.Show("Корзина пустая! Для просмотра заказа добавьте хотя бы один товар.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                this.Visible = false;
                orderview.ShowDialog();
                this.Visible = true;
                CartFill();
                labelFill();
            }
        }

        private void FillCell()
        {
            for (int i = 0; i < dgvProduct.Rows.Count; i++)
            {
                if (Convert.ToInt32(dgvProduct.Rows[i].Cells[6].Value) == 0)
                {
                    dgvProduct.Rows[i].Cells[6].Style.BackColor = Color.DarkRed;
                }
            }
        } 
    }
}
