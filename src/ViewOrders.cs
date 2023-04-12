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
    public partial class ViewOrders : Form
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

        OrderInf orderinf = new OrderInf();
        int[] idUser;
        public static string id_order = ""; 

        public ViewOrders()
        {
            InitializeComponent();
        }

        private void ViewOrders_Load(object sender, EventArgs e)
        {
            try
            {
                lDate.Text = DateTime.Now.ToString("dd.MM.yyyy");

                if (Auth.checkform == 14741)
                {
                    bExcel.Visible = false;
                    lProf.Visible = false;
                }
                GetRole();
                dgvFillOrder();
                lCountOrder.Text = "Всего заказов: " + dgvOrderAll.Rows.Count;
                cmFillEmp();
                FillCell();
            }

            catch (Exception msg)
            {
                MessageBox.Show("Ошибка! " + msg.Message, "Возникла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvFillOrder()
        {
            try
            {
                db_connect connection = new db_connect();
                connection.OpenConnect();

                string sql = "SELECT DISTINCT order.OrderID AS 'Номер заказа', CONCAT(user.UserSurname, ' ', user.UserName, ' ', user.UserPatronymic) AS 'Сотрудник', order.OrderDate AS 'Дата заказа', order.OrderCode AS 'Код получения', order.OrderStatus AS 'Статус' FROM trade1.order INNER JOIN user ON order.OrderClient = user.UserID ORDER BY order.OrderID;";

                MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
                com.ExecuteNonQuery();

                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvOrderAll.DataSource = dt;

                connection.CloseConnect();
                FullSum();
            }

            catch (Exception msg)
            {
                MessageBox.Show("Ошибка! " + msg.Message, "Возникла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillCell()
        {
            for (int i = 0; i < dgvOrderAll.Rows.Count; i++)
            {
                if (Convert.ToString(dgvOrderAll.Rows[i].Cells[5].Value) == "Выполнен")
                {
                    dgvOrderAll.Rows[i].Cells[5].Style.BackColor = Color.DarkGreen;
                }

                else
                {
                    dgvOrderAll.Rows[i].Cells[5].Style.BackColor = Color.DarkRed;
                }
            }
        }

        private void cbYes_CheckedChanged(object sender, EventArgs e)
        {
            if (cbYes.Checked == true)
            {
                cbPrice.Enabled = false;
                cbNo.Enabled = false;
                cbCount.Enabled = false;
                cmUser.Enabled = false;

                db_connect connection = new db_connect();
                connection.OpenConnect();

                string sql = "SELECT DISTINCT order.OrderID AS 'Номер заказа', CONCAT(user.UserSurname, ' ', user.UserName, ' ', user.UserPatronymic) AS 'Сотрудник', order.OrderDate AS 'Дата заказа', order.OrderCode AS 'Код получения', order.OrderStatus AS 'Статус' FROM trade1.order INNER JOIN user ON order.OrderClient = user.UserID WHERE order.OrderStatus = 'Выполнен' ORDER BY order.OrderID;";

                MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
                com.ExecuteNonQuery();

                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvOrderAll.DataSource = dt;

                connection.CloseConnect();
                FillCell();
                lCountOrder.Text = "Всего заказов: " + dgvOrderAll.Rows.Count;
            }

            else
            {
                cbPrice.Enabled = true;
                cbNo.Enabled = true;
                cbCount.Enabled = true;
                cmUser.Enabled = true;

                dgvFillOrder();
                lCountOrder.Text = "Всего заказов: " + dgvOrderAll.Rows.Count;
            }
        }

        private void cbNo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNo.Checked == true)
            {
                cbPrice.Enabled = false;
                cbYes.Enabled = false;
                cbCount.Enabled = false;
                cmUser.Enabled = false;

                db_connect connection = new db_connect();
                connection.OpenConnect();

                string sql = "SELECT DISTINCT order.OrderID AS 'Номер заказа', CONCAT(user.UserSurname, ' ', user.UserName, ' ', user.UserPatronymic) AS 'Сотрудник', order.OrderDate AS 'Дата заказа', order.OrderCode AS 'Код получения', order.OrderStatus AS 'Статус' FROM trade1.order INNER JOIN user ON order.OrderClient = user.UserID WHERE order.OrderStatus = 'Отменен' ORDER BY order.OrderID;";

                MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
                com.ExecuteNonQuery();

                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvOrderAll.DataSource = dt;

                connection.CloseConnect();
                FillCell();
                lCountOrder.Text = "Всего заказов: " + dgvOrderAll.Rows.Count;
            }

            else
            {
                cbPrice.Enabled = true;
                cbYes.Enabled = true;
                cbCount.Enabled = true;
                cmUser.Enabled = true;

                dgvFillOrder();
                lCountOrder.Text = "Всего заказов: " + dgvOrderAll.Rows.Count;
            }
        }

        private void cbCount_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCount.Checked == true)
            {
                cbPrice.Enabled = false;
                cbYes.Enabled = false;
                cbNo.Enabled = false;
                cmUser.Enabled = false;

                db_connect connection = new db_connect();
                connection.OpenConnect();

                string sql = "SELECT DISTINCT order.OrderID AS 'Номер заказа', CONCAT(user.UserSurname, ' ', user.UserName, ' ', user.UserPatronymic) AS 'Сотрудник', order.OrderDate AS 'Дата заказа', order.OrderCode AS 'Код получения', order.OrderStatus AS 'Статус' FROM trade1.order INNER JOIN user ON order.OrderClient = user.UserID ORDER BY order.OrderStatus;";

                MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
                com.ExecuteNonQuery();

                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvOrderAll.DataSource = dt;

                connection.CloseConnect();
                FillCell();
                lCountOrder.Text = "Всего заказов: " + dgvOrderAll.Rows.Count;
            }

            else
            {
                cbPrice.Enabled = true;
                cbYes.Enabled = true;
                cbNo.Enabled = true;
                cmUser.Enabled = true;

                dgvFillOrder();
                lCountOrder.Text = "Всего заказов: " + dgvOrderAll.Rows.Count;
            }
        }

        private void cbPrice_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPrice.Checked == true)
            {
                cbCount.Enabled = false;
                cbYes.Enabled = false;
                cbNo.Enabled = false;
                cmUser.Enabled = false;

                db_connect connection = new db_connect();
                connection.OpenConnect();

                string sql = "SELECT DISTINCT order.OrderID AS 'Номер заказа', CONCAT(user.UserSurname, ' ', user.UserName, ' ', user.UserPatronymic) AS 'Сотрудник', order.OrderDate AS 'Дата заказа', order.OrderCode AS 'Код получения', order.OrderStatus AS 'Статус' FROM trade1.order INNER JOIN user ON order.OrderClient = user.UserID ORDER BY order.OrderStatus;";

                MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
                com.ExecuteNonQuery();

                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvOrderAll.DataSource = dt;

                connection.CloseConnect();
                FillCell();
                lCountOrder.Text = "Всего заказов: " + dgvOrderAll.Rows.Count;
            }

            else
            {
                cbCount.Enabled = true;
                cbYes.Enabled = true;
                cbNo.Enabled = true;
                cmUser.Enabled = true;

                dgvFillOrder();
                lCountOrder.Text = "Всего заказов: " + dgvOrderAll.Rows.Count;
            }
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            cbCount.Checked = false;
            cbPrice.Checked = false;
            cbYes.Checked = false;
            cbNo.Checked = false;

            this.Close();
        }

        private void FullSum()
        {
            db_connect connection = new db_connect();
            connection.OpenConnect();

            string sql = "SELECT DISTINCT SUM(ProductCost) FROM order WHERE OrderStatus = 'Выполнен'";

            MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
            lProf.Text = "Вся прибыль: " + com.ExecuteScalar().ToString() + " руб.";
            connection.CloseConnect();
        }

        private void cmFillEmp()
        {
            cmUser.Items.Clear();
            cmUser.Items.Add("");

            for (int i = 0; i < idUser.Length; i++)
            {
                db_connect connection = new db_connect();
                connection.OpenConnect();

                string sql = @"SELECT * FROM user WHERE UserID = " + idUser[i];
                MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());

                MySqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    string s = reader[0].ToString() + " - " + reader[1].ToString() + " " + reader[2].ToString() + " " + reader[3].ToString() + " ";

                    cmUser.Items.Add(s);
                }

                connection.CloseConnect();
            }
        }

        private void cmUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmUser.SelectedIndex == 0)
            {
                cbCount.Enabled = true;
                cbYes.Enabled = true;
                cbNo.Enabled = true;
                cbPrice.Enabled = true;

                dgvFillOrder();
                FillCell();
                lCountOrder.Text = "Всего заказов: " + dgvOrderAll.Rows.Count;
            }

            else
            {
                string n = cmUser.Text[0].ToString();
                cbCount.Enabled = false;
                cbYes.Enabled = false;
                cbNo.Enabled = false;
                cbPrice.Enabled = false;

                db_connect connection = new db_connect();
                connection.OpenConnect();

                string sql = String.Format("SELECT DISTINCT order.OrderID AS 'Номер заказа', CONCAT(user.UserSurname, ' ', user.UserName, ' ', user.UserPatronymic) AS 'Сотрудник', order.OrderDate AS 'Дата заказа', order.OrderCode AS 'Код получения', order.OrderStatus AS 'Статус', order.OrderStatus AS 'Статус' FROM trade1.order INNER JOIN user ON order.OrderClient = user.UserID WHERE order.OrderClient = {0} ORDER BY order.OrderID;", n);

                MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
                com.ExecuteNonQuery();

                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvOrderAll.DataSource = dt;

                connection.CloseConnect();
                FillCell();
                lCountOrder.Text = "Всего заказов: " + dgvOrderAll.Rows.Count;
            }
        }

        private void GetRole()
        {

            db_connect connection = new db_connect();
            connection.OpenConnect();

            string sql_count = @"SELECT COUNT(*) FROM user WHERE UserRole = 2;";
            MySqlCommand com_count = new MySqlCommand(sql_count, connection.GetConnect());
            int N = Convert.ToInt32(com_count.ExecuteScalar());
            idUser = new int [N];

            string sql_id = @"SELECT UserID FROM user WHERE UserRole = 2;";
            MySqlCommand com_id = new MySqlCommand(sql_id, connection.GetConnect());
            MySqlDataReader reader = com_id.ExecuteReader();
            
            int i = 0;
 
            while (reader.Read())
            {
                idUser[i] = Convert.ToInt32(reader[0].ToString());
                i++;
            }

            connection.CloseConnect();
        }

        private void dgvOrderAll_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (Auth.checkform != 14741)
                {
                    id_order = dgvOrderAll.Rows[e.RowIndex].Cells[0].Value.ToString();
                    orderinf.ShowDialog();
                    dgvFillOrder();
                    FillCell();
                    FullSum();
                }
            }

            catch (Exception msg)
            {
                MessageBox.Show("Ошибка! " + msg.Message, "Возникла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bExcel_Click(object sender, EventArgs e)
        {
            db_connect connection = new db_connect();
            connection.OpenConnect();

            string sql = "SELECT DISTINCT order.OrderID AS 'Номер заказа', CONCAT(user.UserSurname, ' ', user.UserName, ' ', user.UserPatronymic) AS 'Сотрудник', order.OrderDate AS 'Дата заказа', order.OrderCode AS 'Код получения', order.OrderStatus AS 'Статус', FROM trade1.order INNER JOIN user ON order.UserClient = user.UserID ORDER BY order.OrderID;";
            MySqlCommand cmd = new MySqlCommand(sql, connection.GetConnect());

            cmd.ExecuteNonQuery();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

            Microsoft.Office.Interop.Excel.Range _excelCells1 = (Microsoft.Office.Interop.Excel.Range)ExcelWorkSheet.get_Range("A1", "G1").Cells;
            _excelCells1.Merge(Type.Missing);

            ExcelApp.Cells[1, 1].EntireRow.Font.Size = 16;
            ExcelApp.Cells[1, 1].EntireRow.Font.Bold = true;
            ExcelApp.Cells[1, 1] = "Отчет по всем продажам товаров";
            ExcelApp.Cells[1, 1].HorizontalAlignment = -4108;
            ExcelApp.Cells[1, 1].VerticalAlignment = -4108;

            Microsoft.Office.Interop.Excel.Range _excelCells2 = (Microsoft.Office.Interop.Excel.Range)ExcelWorkSheet.get_Range("A2", "G2").Cells;
            _excelCells2.Merge(Type.Missing);

            ExcelApp.Cells[2, 1].EntireRow.Font.Bold = true;
            ExcelApp.Cells[2, 1].EntireRow.Font.Size = 16;
            ExcelApp.Cells[2, 1] = "от " + DateTime.Now.ToString("dd.MM.yyyy");
            ExcelApp.Cells[2, 1].HorizontalAlignment = -4108;
            ExcelApp.Cells[2, 1].VerticalAlignment = -4108;

            ExcelApp.Cells[3, 1] = "Номер заказа";
            ExcelApp.Cells[3, 2] = "Сотрудник";
            ExcelApp.Cells[3, 3] = "Дата заказа";
            ExcelApp.Cells[3, 4] = "Скидка";
            ExcelApp.Cells[3, 5] = "Сумма заказа";
            ExcelApp.Cells[3, 6] = "Статус";

            ExcelApp.Range["A3:F100"].Font.Size = 14;

            for (int i = 3; i < dt.Rows.Count + 1; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    if (i == 0)
                    {
                        ExcelApp.Cells[i + 1, j + 1] = dt.Rows[0].ItemArray[j].ToString();
                    }
                    else
                    {
                        ExcelApp.Cells[i + 1, j + 1] = dt.Rows[i - 1].ItemArray[j].ToString();
                    }
                }
            }

            ExcelWorkSheet.Columns.AutoFit();
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }
    }
}
