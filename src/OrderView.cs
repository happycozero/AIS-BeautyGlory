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
        public bool flagorder = false;

        public OrderView()
        {
            InitializeComponent();
            bAddOrder.Enabled = false;
        }

        private void OrderView_Load(object sender, EventArgs e)
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
            FillLabels();
            
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillLabels()
        {

            #region cmPPFill

            cmPP.Items.Clear();

            db_connect connect = new db_connect();
            connect.OpenConnect();

            string sql = "SELECT * FROM `orderpickuppoint`;";

            MySqlCommand com = new MySqlCommand(sql, connect.GetConnect());

            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                cmPP.Items.Add(reader[1].ToString());
            }

            connect.CloseConnect();

            #endregion 
    
            #region NumOrder

            db_connect connection = new db_connect();
            connection.OpenConnect();

            string sql2 = @"SELECT MAX(OrderID) FROM orderproduct;";

            MySqlCommand com2 = new MySqlCommand(sql2, connection.GetConnect());
            string num = com2.ExecuteScalar().ToString();

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

            groupBox1.Text = "Заказ № " + num_order;
            lDateD.Text = DateTime.Now.AddDays(5).ToString("dd.MM.yyyy");
            lPrice.Text = "Итоговая стоимость: " +  NewOrder.Price() + " руб.";
            lCount.Text = "Количество товара: " + NewOrder.Count() + " шт.";
        }


        private void bAddOrder_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dg = MessageBox.Show("Вы действительно хотите оформить заказ номер - " + num_order + "?", "Оформление заказа", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dg == DialogResult.Yes)
                {
                    flagorder = true;
                    NewOrder fillorder = new NewOrder();
                    fillorder.AddProductOrder();

                    string date = DateTime.Now.ToString("yyyy-MM-dd");
                    string dated = DateTime.Now.AddDays(5).ToString("yyyy-MM-dd");

                    db_connect connection = new db_connect();
                    connection.OpenConnect();

                    string sql = String.Format("INSERT INTO `order` VALUES(null, {0}, {1}, '{2}', {3}, '{4}', {5}, 1);", num_order, GetCode(), dated, GetPP(), date, AuthForm.id_user);
                    MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
                    com.ExecuteNonQuery();

                    MessageBox.Show("Успешно заказ оформлен!\nКод для получения заказа: " + Convert.ToString(GetCode() - 1) + "\nЗаказ будет доставлен - " + DateTime.Now.AddDays(5).ToString("dd.MM.yyyy г.") + "\nПо адресу: " + cmPP.Text, "Оформление заказа", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DialogResult result = MessageBox.Show("Желаете распечатать чек? Для заказа №" + num_order + "?", "Оформление заказа", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (DialogResult.Yes == result)
                    {
                        CheckPrint();
                        this.Close();
                    }

                    else
                    {
                        this.Close();
                    }
                }
            }

            catch (Exception msg)
            {
                MessageBox.Show("Ошибка! " + msg.Message, "Возникла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckPrint()
        {
            try
            {
                #region Word

                var wordApp = new Word.Application();
                wordApp.Visible = false;
                var wordd = wordApp.Documents.Open(FileName);

                ReplaceWordStub("{num}", num_order.ToString(), wordd);
                ReplaceWordStub("{date}", DateTime.Now.ToString("dd.MM.yyyy"), wordd);
                ReplaceWordStub("{date_d}", DateTime.Now.AddDays(5).ToString("dd.MM.yyyy"), wordd);

                for (int i = 0; i < NewOrder.N_global; i++)
                {
                    wordd.Bookmarks["info"].Range.Text = NewOrder.art_global[i] + "; " + NewOrder.quan_global[i] + "; " + NewOrder.price_global[i] + "\n";
                }

                #region FIO
                
                string FIO = "";

                db_connect connection = new db_connect();
                connection.OpenConnect();

                string sql = "SELECT UserSurname, UserName, UserPatronymic FROM user WHERE UserID = " + AuthForm.id_user + ";";

                MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());

                MySqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    FIO = reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString();
                }

                #endregion 

                string[] sum_itog = lPrice.Text.Split(' ');
                string[] count_itog = lCount.Text.Split(' ');

                ReplaceWordStub("{sum_itog}", sum_itog[2], wordd);
                ReplaceWordStub("{count_itog}", count_itog[2], wordd);
                ReplaceWordStub("{address}", cmPP.Text, wordd);
                ReplaceWordStub("{code}", Convert.ToString(GetCode() - 1), wordd);
                ReplaceWordStub("{FIO}", FIO, wordd);
                
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

        private void cmPP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmPP.SelectedIndex > -1)
            {
                bAddOrder.Enabled = true;
            }
        }

        private int GetCode()
        {
            db_connect connection = new db_connect();
            connection.OpenConnect();

            string sql2 = @"SELECT MAX(OrderCode) FROM `order`;";

            MySqlCommand com2 = new MySqlCommand(sql2, connection.GetConnect());
            int code = Convert.ToInt32(com2.ExecuteScalar()) + 1;

            connection.CloseConnect();

            return code;
        }

        private int GetPP()
        {
            db_connect connection = new db_connect();
            connection.OpenConnect();

            string sql2 = @"SELECT idPickupPoint FROM `orderpickuppoint` WHERE PickupPoint = '" + cmPP.Text + "';";

            MySqlCommand com2 = new MySqlCommand(sql2, connection.GetConnect());
            int idpp = Convert.ToInt32(com2.ExecuteScalar());

            connection.CloseConnect();

            return idpp;
        }
    }
}
