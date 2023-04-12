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
    public partial class OrderInf : Form
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
        string idEmp;
        string FIO;
 
        public OrderInf()
        {
            InitializeComponent();
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OrderInf_Load(object sender, EventArgs e)
        {
            try
            {
                bCancel.Enabled = true;

                FillDgv();
                lNum.Text = "Номер заказа: " + ViewOrders.id_order;
                FillInfo();

                if (lStatus.Text == "Статус заказа: Отменен")
                {
                    bCancel.Enabled = false;
                }

                CountandPrice();
            }

            catch (Exception msg)
            {
                MessageBox.Show("Ошибка! " + msg.Message, "Возникла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillDgv()
        {
            try
            {
                db_connect connection = new db_connect();
                connection.OpenConnect();

                string sql = @"SELECT orders.id_product AS 'Артикул', products.name AS 'Название', orders.quantity AS 'Количество', 
                           orders.price AS 'Цена' FROM orders INNER JOIN products ON products.article = orders.id_product WHERE id = " + ViewOrders.id_order + ";";

                MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
                com.ExecuteNonQuery();

                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvOrder.DataSource = dt;

                connection.CloseConnect();
            }

            catch (Exception msg)
            {
                MessageBox.Show("Ошибка! " + msg.Message, "Возникла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillInfo()
        {
            try
            {
                db_connect connection = new db_connect();
                connection.OpenConnect();

                string sql = @"SELECT * FROM orders WHERE id = " + ViewOrders.id_order + ";";

                MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());

                MySqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    lStatus.Text = "Статус заказа: " + reader[7].ToString();
                    lPriceDisc.Text = "Стоимость со скидкой: " + reader[8].ToString() + " руб.";
                    lDisc.Text = "Скидка: " + reader[4].ToString() + " %";
                    lDate.Text = reader[6].ToString();
                    idEmp = reader[1].ToString();

                }

                connection.CloseConnect();
            }

            catch (Exception msg)
            {
                MessageBox.Show("Ошибка! " + msg.Message, "Возникла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetFIO()
        {
            db_connect connection = new db_connect();
            connection.OpenConnect();

            string sql = @"SELECT * FROM emp WHERE id = " + idEmp + ";";

            MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());

            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                string name = reader[2].ToString();
                string name_two = reader[3].ToString();
                FIO = reader[1].ToString() + " " + name[0] + ". " + name_two[0] + ".";
            }

            connection.CloseConnect();
        }

        private void CountandPrice()
        {
            db_connect connection = new db_connect();
            connection.OpenConnect();

            string sql_count = @"SELECT SUM(quantity) FROM orders WHERE id = " + ViewOrders.id_order + ";";

            MySqlCommand com_count = new MySqlCommand(sql_count, connection.GetConnect());

            lCountProd.Text = "Количество: " + Convert.ToString(com_count.ExecuteScalar()) + " шт.";

            string sql_price = @"SELECT SUM(quantity * price) FROM orders WHERE id = " + ViewOrders.id_order + ";";

            MySqlCommand com_price = new MySqlCommand(sql_price, connection.GetConnect());

            lPrice.Text = "Стоимость: " + Convert.ToString(com_price.ExecuteScalar()) + " руб.";

            connection.CloseConnect();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Вы действительно хотите отменить заказ № " + ViewOrders.id_order + "?", "Отмена", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dg == DialogResult.Yes)
            {

                db_connect connection = new db_connect();
                connection.OpenConnect();

                string sql = @"UPDATE orders SET status = 'Отменен' WHERE id = " + ViewOrders.id_order;

                MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
                com.ExecuteNonQuery();

                connection.CloseConnect();
                FillInfo();
                bCancel.Enabled = false;

                MessageBox.Show("Заказ № " + ViewOrders.id_order + " отменен успешно.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                ReplaceWordStub("{num}", ViewOrders.id_order, wordd);
                ReplaceWordStub("{date}", lDate.Text, wordd);

                for (int i = 0; i < dgvOrder.Rows.Count; i++)
                {
                    string name = dgvOrder.Rows[i].Cells[1].Value.ToString();
                    string art = dgvOrder.Rows[i].Cells[0].Value.ToString();
                    string count = dgvOrder.Rows[i].Cells[2].Value.ToString();
                    string price = dgvOrder.Rows[i].Cells[3].Value.ToString();

                    wordd.Bookmarks["order_inf"].Range.Text = name + "; " + art + "; " + count + "; " + price + "\n";

                }

                GetFIO();
                string[] sum_itog_disc = lPriceDisc.Text.Split(' ');
                string[] sum_itog = lPrice.Text.Split(' ');
                string[] count_itog = lCountProd.Text.Split(' ');
                string[] discount = lDisc.Text.Split(' ');

                ReplaceWordStub("{sum_itog_disc}", sum_itog_disc[3], wordd);
                ReplaceWordStub("{FIO}", FIO, wordd);
                ReplaceWordStub("{sum_itog}", sum_itog[1], wordd);
                ReplaceWordStub("{count_itog}", count_itog[1], wordd);
                ReplaceWordStub("{disc}", discount[1], wordd);

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
