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
using Word = Microsoft.Office.Interop.Word;

namespace BeautyGlory
{
    public partial class OrderView : Form
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

        private readonly string FileName = Directory.GetCurrentDirectory() + @"\check.docx";

        int num_order;
        double disc = 0.0;
        bool flag = false; 

        public OrderView()
        {
            InitializeComponent();
        }

        private void OrderView_Load(object sender, EventArgs e)
        {
            lDate.Text = DateTime.Now.ToString("dd.MM.yyyy");
            bCheck.Enabled = false; 

            FillLabels();
            CartFill();
            
        }

        private void CartFill()
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

        private void bBack_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                for (int i = 0; i < dgvCart.Rows.Count; i++)
                {
                    string id = dgvCart.Rows[i].Cells[0].Value.ToString();

                    db_connect connection = new db_connect();
                    connection.OpenConnect();

                    string sql = "DELETE FROM cart WHERE id = " + id + ";";

                    MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
                    com.ExecuteNonQuery();

                    connection.CloseConnect();
                }
            }

            bCheck.Enabled = false;
            bAddOrder.Enabled = true;
            cbPens.Checked = false;
            cbStud.Checked = false;
            checkBox3.Checked = false;

            this.Close();
        }

        private void FillLabels()
        {
            #region NumOrder

            db_connect connection = new db_connect();
            connection.OpenConnect();

            string sql = @"SELECT MAX(id) FROM orders;";

            MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
            string num = com.ExecuteScalar().ToString();

            connection.CloseConnect();

            if (num == "")
            {
                num_order = 1;
            }

            else
            {
                num_order = Convert.ToInt32(num) + 1;
            }

            #endregion

            lNum.Text = "Номер заказа: " + num_order;
            lPrice.Text = "Стоимость: " +  NewOrder.Price() + " руб.";
            lCount.Text = "Количество товара: " + NewOrder.Count() + " шт.";
            lDiscPrice.Text = "Стоимость со скидкой: Скидки нет";
            lDisc.Text = "Скидка: Скидки нет";
        }

        private void cbStud_CheckedChanged(object sender, EventArgs e)
        {
            if (cbStud.Checked == true)
            {
                cbPens.Enabled = false;
                checkBox3.Enabled = false;

                disc = 0.05;
                string temp = NewOrder.Price();

                double itog_price = Convert.ToInt32(temp) - (Convert.ToInt32(temp) * disc);

                lDiscPrice.Text = "Стоимость со скидкой: " + itog_price + " руб.";
                lDisc.Text = "Скидка: 5%";
            }

            else
            {
                lDiscPrice.Text = "Стоимость со скидкой: Скидки нет";
                lDisc.Text = "Скидка: Скидки нет";
                cbPens.Enabled = true;
                checkBox3.Enabled = true;
            }
        }

        private void cbPens_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPens.Checked == true)
            {
                cbStud.Enabled = false;
                checkBox3.Enabled = false;

                disc = 0.1;
                string temp = NewOrder.Price();

                double itog_price = Convert.ToInt32(temp) - (Convert.ToInt32(temp) * disc);

                lDiscPrice.Text = "Стоимость со скидкой: " + itog_price + " руб.";
                lDisc.Text = "Скидка: 10%";
            }

            else
            {
                lDiscPrice.Text = "Стоимость со скидкой: Скидки нет";
                lDisc.Text = "Скидка: Скидки нет";
                cbStud.Enabled = true;
                checkBox3.Enabled = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                cbStud.Enabled = false;
                cbPens.Enabled = false;

                disc = 0.15;
                string temp = NewOrder.Price();

                double itog_price = Convert.ToInt32(temp) - (Convert.ToInt32(temp) * disc);

                lDiscPrice.Text = "Стоимость со скидкой: " + itog_price + " руб.";
                lDisc.Text = "Скидка: 15%";
            }

            else
            {
                lDiscPrice.Text = "Стоимость со скидкой: Скидки нет";
                lDisc.Text = "Скидка: Скидки нет";
                cbPens.Enabled = true;
                cbStud.Enabled = true;
            }
        }

        private void bAddOrder_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dg = MessageBox.Show("Вы действительно хотите оформить заказ номер - " + num_order + "?", "Оформление заказа", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dg == DialogResult.Yes)
                {
                    for (int i = 0; i < dgvCart.Rows.Count; i++)
                    {
                        string sum_itog_disc = "0";

                        if (lDiscPrice.Text == "Стоимость со скидкой: Скидки нет")
                        {
                            string[] temp = lPrice.Text.Split(' ');
                            sum_itog_disc = temp[1];
                        }

                        else
                        {
                            string[] temp = lDiscPrice.Text.Split(' ');
                            string[] okrug = temp[3].Split(',');
                            sum_itog_disc = okrug[0];

                        }

                        string art = dgvCart.Rows[i].Cells[2].Value.ToString();
                        string count = dgvCart.Rows[i].Cells[4].Value.ToString();
                        int discount = Convert.ToInt32(disc * 100);
                        string price = dgvCart.Rows[i].Cells[5].Value.ToString();

                        db_connect connection = new db_connect();
                        connection.OpenConnect();

                        string sql = String.Format("INSERT INTO orders VALUES ({0}, {1}, {2}, {3}, {4}, {5}, '{6}', 'Выполнен', {7})", num_order, Auth.id_user, art, count, discount, price, lDate.Text, sum_itog_disc);

                        MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
                        com.ExecuteNonQuery();

                        connection.CloseConnect();
                    }

                    MessageBox.Show("Заказ успешно оформлен!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    flag = true;
                    bCheck.Enabled = true;
                    bAddOrder.Enabled = false;
                }
            }

            catch (Exception msg)
            {
                MessageBox.Show("Ошибка! " + msg.Message, "Возникла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bCheck_Click(object sender, EventArgs e)
        {
            try
            {
                #region Word

                var wordApp = new Word.Application();
                wordApp.Visible = false;
                var wordd = wordApp.Documents.Open(FileName);

                ReplaceWordStub("{num}", num_order.ToString(), wordd);
                ReplaceWordStub("{date}", lDate.Text, wordd);

                for (int i = 0; i < dgvCart.Rows.Count; i++)
                {
                    string name = dgvCart.Rows[i].Cells[3].Value.ToString();
                    string art = dgvCart.Rows[i].Cells[2].Value.ToString();
                    string count = dgvCart.Rows[i].Cells[4].Value.ToString();
                    string price = dgvCart.Rows[i].Cells[5].Value.ToString();

                    wordd.Bookmarks["order_inf"].Range.Text = name + "; " + art + "; " + count + "; " + price + "\n";
             
                }

                string discount = "";
                string FIO = MenuManager.globalFIO;
                string[] sum_itog = lPrice.Text.Split(' ');
                string[] count_itog = lCount.Text.Split(' ');

                if (lDisc.Text == "Скидка: Скидки нет")
                {
                    discount = "0";
                    ReplaceWordStub("{sum_itog_disc}", sum_itog[1], wordd);
                }

                else
                {
                    string[] sum_itog_disc = lDiscPrice.Text.Split(' ');
                    ReplaceWordStub("{sum_itog_disc}", sum_itog_disc[3], wordd);
                    discount = Convert.ToString(Convert.ToInt32(disc * 100));
                }

                ReplaceWordStub("{FIO}", FIO, wordd);
                ReplaceWordStub("{sum_itog}", sum_itog[1], wordd);
                ReplaceWordStub("{count_itog}", count_itog[2], wordd);
                ReplaceWordStub("{disc}", discount, wordd);

                wordApp.Visible = true;
                #endregion
            }

            catch (Exception msg)
            {
                MessageBox.Show("Ошибка! " + msg.Message, "Возникла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReplaceWordStub(string stubToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }

    }
}
