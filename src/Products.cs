using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautyGlory
{
    public partial class Products : Form
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

        string id = "";
        bool flag_product = false;
        string art = "";

        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            ProductFill();
            Count();
            cmCat_Fill();
            cmMan_Fill();
            cmSup_Fill();
            cmUnit_Fill();
            bEdit.Enabled = false;
            bDel.Enabled = false;
            pbPhoto.ImageLocation = "Photo/picture.png";
        }

        private void ProductFillNew()
        {

            db_connect connection = new db_connect();
            connection.OpenConnect();

            string sql = String.Format(@"SELECT product.ProductArticleNumber AS 'Артикул', 
                         product.ProductName AS 'Название', product.ProductDescription AS 'Описание', 
                         product.ProductCost AS 'Цена', productcategory.Category AS 'Категория', 
                         productmanufacturer.Manufacturer AS 'Производитель', productsupplier.Supplier AS 'Поставщик',
                         product.ProductQuantityInStock AS 'Количество', productunit.unit AS 'Ед.измерения', 
                         product.ProductDiscountAmount AS 'Действующая скидка', ProductMaxDiscount AS 'Максимальная скидка', 
                         product.ProductPhoto AS 'Изображение' FROM product INNER JOIN productmanufacturer ON product.ProductManufacturer = productmanufacturer.idManufacturer
                         INNER JOIN productsupplier ON product.ProductSupplier = productsupplier.idSupplier INNER JOIN productunit ON product.ProductUnit = productunit.idUnit
                         INNER JOIN productcategory ON product.ProductCategory = productcategory.idCategory 
                         ORDER BY CASE WHEN ProductArticleNumber = '{0}' THEN 0 ELSE 1 END, ProductArticleNumber;", art);

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

        private void bBack_Click(object sender, EventArgs e)
        {
            ClearInfo();
            this.Close();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbName.Text == "" || tbDesc.Text == "" || cmMan.Text == "" || tbPrice.Text == "" || tbQuantly.Text == "" || cmCategory.Text == "" || tbPhoto.Text == "" || tbDiscMax.Text == "" || tbDisc.Text == "" || cmUnit.Text == "" || cmSupplier.Text == "")
                {
                    MessageBox.Show("Ошибка! Сначала заполните все поля!", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (Convert.ToInt32(tbDiscMax.Text) < Convert.ToInt32(tbDisc.Text))
                {
                    MessageBox.Show("Ошибка! Максимальная скидка не должна быть меньше действующей!", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    CheckProduct();

                    if (flag_product == false)
                    {
                        MessageBox.Show("Ошибка! Такой товар уже заведен на складе.", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClearInfo();
                    }

                    else
                    {

                        #region genart

                        string abc = "QWERTYUIOPASDFGHJKLZXCVBNM";
                        Random rnd = new Random();
                        art = "";

                        for (int i = 0; i < 6; i++)
                        {
                            if (i == 0 || i == 4)
                            {
                                art += abc[rnd.Next(1, abc.Length)];
                            }

                            else
                            {
                                art += rnd.Next(0, 9);
                            }
                        }

                        #endregion

                        int cat = get_cmCat();
                        int man = get_cmMan();
                        int sup = get_cmSup();
                        int unit = get_cmUnit();

                        string name = tbName.Text;
                        string desc = tbDesc.Text;
                        string price = tbPrice.Text.Replace(",", ".");
                        string quan = tbQuantly.Text;
                        string mdisc = tbDiscMax.Text;
                        string disc = tbDisc.Text;

                        db_connect connection = new db_connect();
                        connection.OpenConnect();

                        string sql = String.Format(@"INSERT INTO `product` VALUES ('{0}', '{1}', '{2}', {3}, '{4}', {5}, {6}, {7}, {8}, {9}, {10}, {11});", art, name, desc, cat, tbPhoto.Text, man, price, disc, quan, unit, sup, mdisc);

                        MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
                        com.ExecuteNonQuery();

                        connection.CloseConnect();

                        MessageBox.Show("Успешно! Запись добавлена.", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearInfo();
                        ProductFillNew();
                        Count();
                    }
                }
            }

            catch (Exception msg)
            {
                MessageBox.Show("Ошибка! " + msg.Message, "Возникла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void bDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить выбранную запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult.Yes == result)
            {
                db_connect connection = new db_connect();
                connection.OpenConnect();

                string sql = @"DELETE FROM product WHERE ProductArticleNumber = '" + id + "';";

                MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
                com.ExecuteNonQuery();

                connection.CloseConnect();

                MessageBox.Show("Запись успешно удалена.", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearInfo();
                ProductFill();
                Count();
            }
        }

        public void ClearInfo()
        {
            tbDisc.Clear();
            tbDiscMax.Clear();
            cmUnit.SelectedIndex = -1;
            tbName.Clear();
            tbDesc.Clear();
            cmMan.SelectedIndex = -1;
            tbPrice.Clear();
            tbQuantly.Clear();
            tbPhoto.Clear();
            cmCategory.SelectedIndex = -1;
            cmSupplier.SelectedIndex = -1;
            pbPhoto.ImageLocation = "Photo/picture.png";
        }

        private void dgvProduct_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                bDel.Enabled = true;
                bEdit.Enabled = true;
                id = dgvProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
                art = dgvProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbName.Text = dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbDesc.Text = dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbPrice.Text = dgvProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                cmMan.Text = dgvProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
                cmCategory.Text = dgvProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                cmSupplier.Text = dgvProduct.Rows[e.RowIndex].Cells[6].Value.ToString();
                tbQuantly.Text = dgvProduct.Rows[e.RowIndex].Cells[7].Value.ToString();
                tbPhoto.Text = dgvProduct.Rows[e.RowIndex].Cells[11].Value.ToString();
                cmUnit.Text = dgvProduct.Rows[e.RowIndex].Cells[8].Value.ToString();
                tbDisc.Text = dgvProduct.Rows[e.RowIndex].Cells[9].Value.ToString();
                tbDiscMax.Text = dgvProduct.Rows[e.RowIndex].Cells[10].Value.ToString();
                pbPhoto.ImageLocation = "Photo/" + Convert.ToString(dgvProduct.Rows[e.RowIndex].Cells[11].Value.ToString());
            }
            catch (Exception)
            {
                ;
            }
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

        private void cmUnit_Fill()
        {
            cmUnit.Items.Clear();

            db_connect connect = new db_connect();
            connect.OpenConnect();

            string sql = "SELECT * FROM ProductUnit;";

            MySqlCommand com = new MySqlCommand(sql, connect.GetConnect());

            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                cmUnit.Items.Add(reader[1].ToString());
            }

            connect.CloseConnect();
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

        public int get_cmCat()
        {
            db_connect connect = new db_connect();
            connect.OpenConnect();

            string sql = "SELECT idCategory FROM productcategory WHERE Category = '" + cmCategory.Text + "';";

            MySqlCommand com = new MySqlCommand(sql, connect.GetConnect());

            int id = Convert.ToInt32(com.ExecuteScalar());

            connect.CloseConnect();

            return id;
        }

        public int get_cmMan()
        {
            db_connect connect = new db_connect();
            connect.OpenConnect();

            string sql = "SELECT idManufacturer FROM productmanufacturer WHERE Manufacturer = '" + cmMan.Text + "';";

            MySqlCommand com = new MySqlCommand(sql, connect.GetConnect());

            int id = Convert.ToInt32(com.ExecuteScalar());

            connect.CloseConnect();

            return id;
        }

        public int get_cmSup()
        {
            db_connect connect = new db_connect();
            connect.OpenConnect();

            string sql = "SELECT idSupplier FROM productsupplier WHERE Supplier = '" + cmSupplier.Text + "';";

            MySqlCommand com = new MySqlCommand(sql, connect.GetConnect());

            int id = Convert.ToInt32(com.ExecuteScalar());

            connect.CloseConnect();

            return id;
        }

        public int get_cmUnit()
        {
            db_connect connect = new db_connect();
            connect.OpenConnect();

            string sql = "SELECT idUnit FROM productunit WHERE Unit = '" + cmUnit.Text + "';";

            MySqlCommand com = new MySqlCommand(sql, connect.GetConnect());

            int id = Convert.ToInt32(com.ExecuteScalar());

            connect.CloseConnect();

            return id;
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbDesc.Text == "" || cmMan.Text == "" || tbPrice.Text == "" || tbQuantly.Text == "" || cmCategory.Text == "" || tbPhoto.Text == "" || tbDiscMax.Text == "" || tbDisc.Text == "" || cmUnit.Text == "" || cmSupplier.Text == "")
            {
                MessageBox.Show("Ошибка! Сначала заполните все поля!", "Редактирование", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (Convert.ToInt32(tbDiscMax.Text) < Convert.ToInt32(tbDisc.Text))
            {
                MessageBox.Show("Ошибка! Максимальная скидка не должна быть меньше действующей!", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                int cat = get_cmCat();
                int man = get_cmMan();
                int sup = get_cmSup();
                int unit = get_cmUnit();

                string name = tbName.Text;
                string desc = tbDesc.Text;
                string price = tbPrice.Text.Replace(",", ".");
                string quan = tbQuantly.Text;
                string mdisc = tbDiscMax.Text;
                string disc = tbDisc.Text;

                db_connect connection = new db_connect();
                connection.OpenConnect();

                string sql = String.Format(@"UPDATE `product` SET ProductName = '{0}', ProductDescription = '{1}', ProductCategory = {2}, ProductPhoto = '{3}', ProductManufacturer = {4}, ProductCost = {5}, ProductDiscountAmount = {6}, ProductQuantityInStock = {7}, ProductUnit = {8}, ProductSupplier = {9}, ProductMaxDiscount = {10} WHERE ProductArticleNumber = '{11}';", name, desc, cat, tbPhoto.Text, man, price, disc, quan, unit, sup, mdisc, id);

                MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
                com.ExecuteNonQuery();

                connection.CloseConnect();

                MessageBox.Show("Успешно! Запись обновлена.", "Редактирование", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearInfo();
                ProductFillNew();
                Count();
            }
        }

        private void bPhoto_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog upload = new OpenFileDialog())
                {
                    upload.Filter = ".jpg, .png, .jpeg|*.jpg;*.png;*.jpeg";

                    if (upload.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }

                    string path1 = upload.FileName;
                    string Filename = System.IO.Path.GetFileName(path1);
                    string path2 = Environment.CurrentDirectory + "\\Photo\\" + Filename;
                    File.Copy(path1, path2, true);
                    tbPhoto.Text = Filename;
                    pbPhoto.ImageLocation = Environment.CurrentDirectory + "\\Photo\\" + Filename;
                }
            }

            catch (Exception msg)
            {
                MessageBox.Show("Ошибка! " + msg.Message, "Возникла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CheckProduct()
        {
            try
            {
                string name = tbName.Text;
                string temp = "";

                db_connect connect = new db_connect();
                connect.OpenConnect();

                string sql = "SELECT ProductArticleNumber FROM product WHERE ProductName ='" + name + "';";

                MySqlCommand com = new MySqlCommand(sql, connect.GetConnect());

                try
                {
                    temp = com.ExecuteScalar().ToString();
                    flag_product = false;
                }

                catch
                {
                    flag_product = true;
                }
            }

            catch (Exception msg)
            {
                MessageBox.Show("Ошибка! " + msg.Message, "Возникла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'а' && e.KeyChar <= 'я' || e.KeyChar >= 'А' && e.KeyChar <= 'Я' || e.KeyChar == 8 || e.KeyChar == ' ')
            {
                return;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void tbMan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'а' && e.KeyChar <= 'я' || e.KeyChar >= 'А' && e.KeyChar <= 'Я' || e.KeyChar == 8 || e.KeyChar == ' ')
            {
                return;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8 || e.KeyChar == ' ' || e.KeyChar == ',')
            {
                return;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void tbQuantly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8 || e.KeyChar == ' ')
            {
                return;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void FillCell()
        {
            for (int i = 0; i < dgvProduct.Rows.Count; i++)
            {
                if (Convert.ToInt32(dgvProduct.Rows[i].Cells[7].Value) == 0)
                {
                    dgvProduct.Rows[i].Cells[7].Style.BackColor = Color.DarkRed;
                }
            }
        }

        private void tbDiscMax_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(tbDiscMax.Text) > 100 && tbDiscMax.Text.Length > 1)
                {
                    tbDiscMax.Text = "100";
                }
            }

            catch
            {

            }
        }

        private void tbDisc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(tbDisc.Text) > 100 && tbDisc.Text.Length > 1)
                {
                    tbDisc.Text = "100";
                }
            }

            catch
            {

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

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
