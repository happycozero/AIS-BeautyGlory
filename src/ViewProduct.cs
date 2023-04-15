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
    public partial class ViewProduct : Form
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

        string id_prod;

        public ViewProduct()
        {
            InitializeComponent();
        }

        private void ViewProduct_Load(object sender, EventArgs e)
        {
            ProductFill();
            Count();
            cmCat_Fill();
            cmSup_Fill();
            cmMan_Fill();
            FillFilter();
            pbPhoto.ImageLocation = "Photo/img_holder.png";
            bPhoto.Visible = false;
        }

        public void ProductFill()
        {
            db_connect connection = new db_connect();
            connection.OpenConnect();

            string sql = @"SELECT product.ProductArticleNumber AS 'Артикул', 
                         product.ProductName AS 'Название', product.ProductDescription AS 'Описание', 
                         product.ProductCost AS 'Цена', productcategory.Category AS 'Категория', 
                         productmanufacturer.Manufacturer AS 'Производитель', productsupplier.Supplier AS 'Поставщик',
                         product.ProductQuantityInStock AS 'Количество', productunit.unit AS 'Ед.измерения', 
                         product.ProductDiscountAmount AS 'Действующая скидка', ProductMaxDiscount AS 'Максимальная скидка', 
                         product.ProductPhoto AS 'Изображение' FROM product INNER JOIN productmanufacturer ON product.ProductManufacturer = productmanufacturer.idManufacturer
                         INNER JOIN productsupplier ON product.ProductSupplier = productsupplier.idSupplier INNER JOIN productunit ON product.ProductUnit = productunit.idUnit
                         INNER JOIN productcategory ON product.ProductCategory = productcategory.idCategory;";

            MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
            com.ExecuteNonQuery();

            MySqlDataAdapter adapter = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgvProduct.DataSource = dt;

            dgvProduct.Columns[2].Visible = false;
            dgvProduct.Columns[8].Visible = false;
            dgvProduct.Columns[10].Visible = false;
            dgvProduct.Columns[11].Visible = false;

            connection.CloseConnect();

            FillCell();
        }

        private void Count()
        {
            db_connect connection = new db_connect();
            connection.OpenConnect();

            string sql = @"SELECT COUNT(*) FROM product;";

            MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
            int count_db = Convert.ToInt32(com.ExecuteScalar());

            connection.CloseConnect();

            int count_dgv = dgvProduct.Rows.Count;

            lCount.Text = String.Format("Количество записей: {0} из {1}", count_dgv, count_db);
        }

        private void cmCat_Fill()
        {
            cmCategory.Items.Clear();

            db_connect connect = new db_connect();
            connect.OpenConnect();

            string sql = "SELECT * FROM ProductCategory;";

            MySqlCommand com = new MySqlCommand(sql, connect.GetConnect());

            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                cmCategory.Items.Add(reader[1].ToString());
            }

            connect.CloseConnect();
        }

        public void ClearInfo()
        {
            tbDisc.Clear();
            tbDiscMax.Clear();
            tbName.Clear();
            tbDesc.Clear();
            cmMan.SelectedIndex = -1;
            tbPrice.Clear();
            tbQuantly.Clear();
            tbPhoto.Clear();
            cmCategory.SelectedIndex = -1;
            cmSupplier.SelectedIndex = -1;
            pbPhoto.ImageLocation = "Photo/img_holder.png";
        }

        private void cmMan_Fill()
        {
            cmMan.Items.Clear();

            db_connect connect = new db_connect();
            connect.OpenConnect();

            string sql = "SELECT * FROM ProductManufacturer;";

            MySqlCommand com = new MySqlCommand(sql, connect.GetConnect());

            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                cmMan.Items.Add(reader[1].ToString());
            }

            connect.CloseConnect();
        }

        private void cmSup_Fill()
        {
            cmSupplier.Items.Clear();

            db_connect connect = new db_connect();
            connect.OpenConnect();

            string sql = "SELECT * FROM ProductSupplier;";

            MySqlCommand com = new MySqlCommand(sql, connect.GetConnect());

            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                cmSupplier.Items.Add(reader[1].ToString());
            }

            connect.CloseConnect();
        }

        private void dgvProduct_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                id_prod = dgvProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbName.Text = dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbDesc.Text = dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbPrice.Text = dgvProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                cmMan.Text = dgvProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
                cmCategory.Text = dgvProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                cmSupplier.Text = dgvProduct.Rows[e.RowIndex].Cells[6].Value.ToString();
                tbQuantly.Text = dgvProduct.Rows[e.RowIndex].Cells[7].Value.ToString();
                tbPhoto.Text = dgvProduct.Rows[e.RowIndex].Cells[11].Value.ToString();
                tbDisc.Text = dgvProduct.Rows[e.RowIndex].Cells[9].Value.ToString();
                tbDiscMax.Text = dgvProduct.Rows[e.RowIndex].Cells[10].Value.ToString();
                pbPhoto.ImageLocation = "Photo/" + Convert.ToString(dgvProduct.Rows[e.RowIndex].Cells[11].Value.ToString());

                // Путь к базе данных
                string pathToDB = "host=localhost;uid=root;pwd=root;database=trade1;";

                if (string.IsNullOrEmpty(pathToDB))
                {
                    // Если путь к базе данных пустой, то подставляем фото-заглушку
                    pbPhoto.Image = Image.FromFile("Photo/img_holder.png");
                }
                else
                {
                    // Иначе загружаем данные из базы данных
                }

            }

            catch (Exception)
            {
                ;
            }
        }

        private void tbFind_TextChanged(object sender, EventArgs e)
        {
//            if (tbFind.Text.Length > 2)
//            {
//                cmFiltr.Enabled = false;

//                db_connect connection = new db_connect();
//                connection.OpenConnect();

//                string sql = @"SELECT article AS 'Артикул', 
//                         name AS 'Название', description AS 'Описание', 
//                         price AS 'Цена', manufacturer AS 'Производитель', 
//                         сategory AS 'Категория', quantity AS 'Количество', 
//                         photo AS 'Изображение' FROM products WHERE name LIKE '%" + tbFind.Text + "%' OR article LIKE '%" + tbFind.Text + "%';";

//                MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
//                com.ExecuteNonQuery();

//                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
//                DataTable dt = new DataTable();
//                adapter.Fill(dt);

//                dgvProduct.DataSource = dt;

//                dgvProduct.Columns[7].Visible = false;

//                connection.CloseConnect();
//                Count();
//            }

            //else
            //{
            //    //cmFiltr.Enabled = true;
            //    ProductFill();
            //    Count();
            //}
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            ClearInfo();
            this.Close();
        }

        private void FillFilter()
        {
            //cmFiltr.Items.Clear();
            //cmFiltr.Items.Add(" ");

            //db_connect connect = new db_connect();
            //connect.OpenConnect();

            //string sql = "SELECT * FROM ProductCategory;";

            //MySqlCommand com = new MySqlCommand(sql, connect.GetConnect());

            //MySqlDataReader reader = com.ExecuteReader();
            //while (reader.Read())
            //{
            //    //cmFiltr.Items.Add(reader[1].ToString());
            //}

            //connect.CloseConnect();
        }

        private void cmFiltr_SelectedIndexChanged(object sender, EventArgs e)
        {
//            if (cmFiltr.Text == " ")
//            {
//                ProductFill();
//                Count();
//                tbFind.Enabled = true;
//            }

//            else
//            {
//                tbFind.Enabled = false;
//                int id = get_cmCat();
//                db_connect connection = new db_connect();
//                connection.OpenConnect();

//                string sql = @"SELECT article AS 'Артикул', 
//                         name AS 'Название', description AS 'Описание', 
//                         price AS 'Цена', manufacturer AS 'Производитель', 
//                         сategory AS 'Категория', quantity AS 'Количество', 
//                         photo AS 'Изображение' FROM products WHERE сategory = " + id + ";";

//                MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
//                com.ExecuteNonQuery();

//                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
//                DataTable dt = new DataTable();
//                adapter.Fill(dt);

//                dgvProduct.DataSource = dt;

//                dgvProduct.Columns[7].Visible = false;

//                connection.CloseConnect();
//                Count();
//            }
        }

        //private int get_cmCat()
        //{
        //    //db_connect connect = new db_connect();
        //    //connect.OpenConnect();

        //    //string sql = "SELECT id FROM category WHERE name = '" + cmFiltr.Text + "';";

        //    //MySqlCommand com = new MySqlCommand(sql, connect.GetConnect());

        //    //int id = Convert.ToInt32(com.ExecuteScalar());

        //    //connect.CloseConnect();

        //    //return id;
        //}

        private void FillCell()
        {
            for (int i = 0; i < dgvProduct.Rows.Count; i++)
            {
                if (Convert.ToInt32(dgvProduct.Rows[i].Cells[7].Value) == 0)
                {
                    dgvProduct.Rows[i].Cells[7].Style.BackColor = Color.IndianRed;
                }
            }
        }

        private void dgvProduct_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.ColumnIndex < dgvProduct.Columns.Count)
            {
                // код обработки щелчка по заголовку столбца
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgvProduct_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (AuthForm.role_user == 2 || AuthForm.role_user == 1)
            {
                DialogResult result = MessageBox.Show("Вы действительно хотите добавить товар в корзину?", "Корзина", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (id_prod == "")
                        {
                            MessageBox.Show("Ошибка! Сначала выберите товар!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        else
                        {
                            if (Convert.ToInt32(dgvProduct.CurrentRow.Cells[7].Value) == 0)
                            {
                                MessageBox.Show("К сожалению, товар закончился на складе!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                            else
                            {
                                if (CheckCartTovar() == false)
                                {
                                    db_connect connection = new db_connect();
                                    connection.OpenConnect();

                                    MySqlTransaction trans = connection.GetConnect().BeginTransaction();

                                    string sql1 = String.Format("UPDATE cart SET Quantity = (Quantity + 1)  WHERE idProduct = '{0}' AND idUser = {1};", id_prod, AuthForm.id_user);
                                    MySqlCommand com1 = new MySqlCommand(sql1, connection.GetConnect());
                                    com1.Transaction = trans;

                                    string sql2 = String.Format("UPDATE product SET ProductQuantityInStock = (ProductQuantityInStock - 1) WHERE ProductArticleNumber = '{0}';", id_prod);
                                    MySqlCommand com2 = new MySqlCommand(sql2, connection.GetConnect());
                                    com2.Transaction = trans;

                                    try
                                    {
                                        com1.ExecuteNonQuery();
                                        com2.ExecuteNonQuery();
                                        trans.Commit();
                                        ProductFill();

                                        MessageBox.Show("Успешно! Товар с артикулом - " + id_prod + ". Добавлен в корзину в количестве 1-ой позиции.", "Корзина", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                                    double price = Convert.ToDouble(tbPrice.Text);
                                    double disc = Convert.ToInt32(tbDisc.Text) / 100.0;
                                    price = price - (price * disc);
                                    string price2 = Convert.ToString((Math.Round(price, 2))).Replace(",", ".");

                                    string sql1 = String.Format("INSERT INTO cart VALUES(null, {0}, '{1}', '{2}', {3}, 1);", AuthForm.id_user, id_prod, tbName.Text, price2);
                                    MySqlCommand com1 = new MySqlCommand(sql1, connection.GetConnect());
                                    com1.Transaction = trans;

                                    string sql2 = String.Format("UPDATE product SET ProductQuantityInStock = (ProductQuantityInStock - 1) WHERE ProductArticleNumber = '{0}';", id_prod);
                                    MySqlCommand com2 = new MySqlCommand(sql2, connection.GetConnect());
                                    com2.Transaction = trans;

                                    try
                                    {
                                        com1.ExecuteNonQuery();
                                        com2.ExecuteNonQuery();
                                        trans.Commit();
                                        ProductFill();

                                        MessageBox.Show("Успешно! Товар с артикулом - " + id_prod + ". Добавлен в корзину в количестве 1-ой позиции.", "Корзина", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    catch (Exception msg)
                    {
                        MessageBox.Show("Ошибка! " + msg.Message, "Возникла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private bool CheckCartTovar()
        {
            try
            {
                bool flag = false;
                string count = "";

                // Создаем экземпляр класса db_connect и открываем соединение с базой данных
                using (db_connect connect = new db_connect())
                {
                    connect.OpenConnect();

                    // Формируем запрос к базе данных
                    string sql = "SELECT Quantity FROM cart WHERE idUser = @idUser AND idProduct = @idProduct;";

                    // Создаем экземпляр класса MySqlCommand и передаем ему текст запроса и объект подключения к базе данных
                    using (MySqlCommand com = new MySqlCommand(sql, connect.GetConnect()))
                    {
                        // Добавляем параметры к запросу
                        com.Parameters.AddWithValue("@idUser", AuthForm.id_user);
                        com.Parameters.AddWithValue("@idProduct", id_prod);

                        // Выполняем запрос и получаем результат в переменную count
                        object result = com.ExecuteScalar();
                        if (result != null)
                        {
                            count = result.ToString();
                            flag = false;
                        }
                        else
                        {
                            flag = true;
                        }
                    }
                }

                return flag;
            }

            catch (Exception msg)
            {
                MessageBox.Show("Ошибка! " + msg.Message, "Возникла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (tbFind.Text.Length > 2)
            {
                //cmFiltr.Enabled = false;

                db_connect connection = new db_connect();
                connection.OpenConnect();

                string sql = @"SELECT product.ProductArticleNumber AS 'Артикул', 
                         product.ProductName AS 'Название', product.ProductDescription AS 'Описание', 
                         product.ProductCost AS 'Цена', productcategory.Category AS 'Категория', 
                         productmanufacturer.Manufacturer AS 'Производитель', productsupplier.Supplier AS 'Поставщик',
                         product.ProductQuantityInStock AS 'Количество', productunit.unit AS 'Ед.измерения', 
                         product.ProductDiscountAmount AS 'Действующая скидка', ProductMaxDiscount AS 'Максимальная скидка', 
                         product.ProductPhoto AS 'Изображение' FROM product INNER JOIN productmanufacturer ON product.ProductManufacturer = productmanufacturer.idManufacturer
                         INNER JOIN productsupplier ON product.ProductSupplier = productsupplier.idSupplier INNER JOIN productunit ON product.ProductUnit = productunit.idUnit
                         INNER JOIN productcategory ON product.ProductCategory = productcategory.idCategory WHERE product.ProductName LIKE '%" + tbFind.Text + "%' OR product.ProductArticleNumber LIKE '%" + tbFind.Text + "%';";

                MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
                com.ExecuteNonQuery();

                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvProduct.DataSource = dt;

                dgvProduct.Columns[7].Visible = false;

                connection.CloseConnect();
                Count();
            }

            else
            {
                //cmFiltr.Enabled = true;
                ProductFill();
                Count();
            }
        }

    }
}
