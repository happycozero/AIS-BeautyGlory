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
using System.Runtime.InteropServices;

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

        int[] idUser;
        public static string id_order = "";

        public ViewOrders()
        {
            InitializeComponent();
            bDateOrderNew.Enabled = false;

            var date = DateTime.Now.AddDays(5);
            dtpDateUpd.MinDate = date;
        }

        private void ViewOrders_Load(object sender, EventArgs e)
        {
            try
            {
                lDate.Text = DateTime.Now.ToString("dd.MM.yyyy");

                if (AuthForm.checkform == 14741)
                {
                    bExcels.Visible = true;
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

                string sql = @"SELECT `order`.OrderID AS 'OPD', orderproduct.ProductArticleNumber AS 'Артикул', orderproduct.OrderCount AS 'Количество', `order`.OrderCode AS 'Код получения', 
                            `order`.OrderDeliveryDate AS 'Дата доставки', orderpickuppoint.PickupPoint AS 'Адрес доставки',  `order`.OrderDate AS 'Дата заказа', 
                            CONCAT(user.UserSurname, ' ', user.UserName, ' ', user.UserPatronymic) AS 'Заказчик', orderstatus.Status AS 'Статус заказа' FROM `order`
                            INNER JOIN orderproduct ON `order`.OrderProductID = orderproduct.OrderID INNER JOIN orderpickuppoint ON orderpickuppoint.idPickupPoint = `order`.OrderPickupPoint
                            INNER JOIN user ON user.UserID = `order`.OrderClient INNER JOIN orderstatus ON orderstatus.idStatus = `order`.OrderStatus;";

                MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
                com.ExecuteNonQuery();

                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvOrderAll.DataSource = dt;

                connection.CloseConnect();

                dgvOrderAll.Columns[0].Visible = false;
                dgvOrderAll.Columns[3].Visible = false;
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
                if (Convert.ToString(dgvOrderAll.Rows[i].Cells[8].Value) == "Новый")
                {
                    dgvOrderAll.Rows[i].Cells[8].Style.BackColor = Color.PaleGreen;
                }

                else
                {
                    dgvOrderAll.Rows[i].Cells[8].Style.BackColor = Color.IndianRed;
                }
            }
        }

        private void cbYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNew.Checked == true)
            {
                cmUser.Enabled = false;
                bSort.Enabled = false;

                db_connect connection = new db_connect();
                connection.OpenConnect();

                string sql = @"SELECT `order`.OrderID AS 'OPD', orderproduct.ProductArticleNumber AS 'Артикул', orderproduct.OrderCount AS 'Количество', `order`.OrderCode AS 'Код получения', 
                            `order`.OrderDeliveryDate AS 'Дата доставки', orderpickuppoint.PickupPoint AS 'Адрес доставки',  `order`.OrderDate AS 'Дата заказа', 
                            CONCAT(user.UserSurname, ' ', user.UserName, ' ', user.UserPatronymic) AS 'Заказчик', orderstatus.Status AS 'Статус заказа' FROM `order`
                            INNER JOIN orderproduct ON `order`.OrderProductID = orderproduct.OrderID INNER JOIN orderpickuppoint ON orderpickuppoint.idPickupPoint = `order`.OrderPickupPoint
                            INNER JOIN user ON user.UserID = `order`.OrderClient INNER JOIN orderstatus ON orderstatus.idStatus = `order`.OrderStatus WHERE orderstatus.Status = 'Новый';";

                MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
                com.ExecuteNonQuery();

                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvOrderAll.DataSource = dt;

                connection.CloseConnect();
                dgvOrderAll.Columns[0].Visible = false;
                dgvOrderAll.Columns[3].Visible = false;
                FillCell();
                lCountOrder.Text = "Всего заказов: " + dgvOrderAll.Rows.Count;
            }

            else
            {
                cmUser.Enabled = true;
                bSort.Enabled = true;

                dgvFillOrder();
                FillCell();
                lCountOrder.Text = "Всего заказов: " + dgvOrderAll.Rows.Count;
            }
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            rbNew.Checked = false;
            rbFinish.Checked = false;
            bSort.Enabled = false;

            this.Close();
        }

        private void cmFillEmp()
        {
            cmUser.Items.Clear();
            cmUser.Items.Add("");

            for (int i = 0; i < idUser.Length; i++)
            {
                db_connect connection = new db_connect();
                connection.OpenConnect();

                string sql = @"SELECT * FROM user WHERE UserID = " + idUser[i] + ";";
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
                bSort.Enabled = true;

                dgvFillOrder();
                FillCell();
                lCountOrder.Text = "Всего заказов: " + dgvOrderAll.Rows.Count;
            }

            else
            {
                string n = cmUser.Text[0].ToString();
                rbNew.Checked = false;
                rbFinish.Checked = false;
                bSort.Enabled = false;

                db_connect connection = new db_connect();
                connection.OpenConnect();

                string sql = String.Format(@"SELECT `order`.OrderID AS 'OPD', orderproduct.ProductArticleNumber AS 'Артикул', orderproduct.OrderCount AS 'Количество', `order`.OrderCode AS 'Код получения', 
                            `order`.OrderDeliveryDate AS 'Дата доставки', orderpickuppoint.PickupPoint AS 'Адрес доставки',  `order`.OrderDate AS 'Дата заказа', 
                            CONCAT(user.UserSurname, ' ', user.UserName, ' ', user.UserPatronymic) AS 'Заказчик', orderstatus.Status AS 'Статус заказа' FROM `order`
                            INNER JOIN orderproduct ON `order`.OrderProductID = orderproduct.OrderID INNER JOIN orderpickuppoint ON orderpickuppoint.idPickupPoint = `order`.OrderPickupPoint
                            INNER JOIN user ON user.UserID = `order`.OrderClient INNER JOIN orderstatus ON orderstatus.idStatus = `order`.OrderStatus WHERE user.UserID = {0};", n);

                MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
                com.ExecuteNonQuery();

                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvOrderAll.DataSource = dt;

                connection.CloseConnect();
                dgvOrderAll.Columns[0].Visible = false;
                dgvOrderAll.Columns[3].Visible = false;
                FillCell();
                lCountOrder.Text = "Всего заказов: " + dgvOrderAll.Rows.Count;
            }
        }

        private void GetRole()
        {

            db_connect connection = new db_connect();
            connection.OpenConnect();

            string sql_count = @"SELECT COUNT(*) FROM user WHERE UserRole = 2 OR UserRole = 1;";
            MySqlCommand com_count = new MySqlCommand(sql_count, connection.GetConnect());
            int N = Convert.ToInt32(com_count.ExecuteScalar());
            idUser = new int[N];

            string sql_id = @"SELECT UserID FROM user WHERE UserRole = 2 OR UserRole = 1;";
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
                if (dgvOrderAll.Rows[e.RowIndex].Cells[8].Value.ToString() == "Новый")
                {
                    DialogResult dg = MessageBox.Show("Вы действительно хотите завершить данный заказ?\n", "Завершение заказа", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dg == DialogResult.Yes)
                    {
                        dgvFillOrder();
                        FillCell();
                        lCountOrder.Text = "Всего заказов: " + dgvOrderAll.Rows.Count;
                    }
                }
            }

            catch (Exception msg)
            {
                MessageBox.Show("Ошибка! " + msg.Message, "Возникла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bSort.Text == "Сортировать")
            {
                rbNew.Checked = false;
                rbFinish.Checked = false;
                cmUser.Enabled = false;

                bSort.Text = "Отменить";

                string date = dtpDateSort.Value.ToString();
                string[] date_split = date.Split(' ');

                var newdate = Convert.ToDateTime(date_split[0]).ToString("yyyy.MM.dd");

                db_connect connection = new db_connect();
                connection.OpenConnect();

                string sql = String.Format(@"SELECT `order`.OrderID AS 'OPD', orderproduct.ProductArticleNumber AS 'Артикул', orderproduct.OrderCount AS 'Количество', `order`.OrderCode AS 'Код получения', 
                                            `order`.OrderDeliveryDate AS 'Дата доставки', orderpickuppoint.PickupPoint AS 'Адрес доставки',  `order`.OrderDate AS 'Дата заказа', 
                                            CONCAT(user.UserSurname, ' ', user.UserName, ' ', user.UserPatronymic) AS 'Заказчик', orderstatus.Status AS 'Статус заказа' FROM `order`
                                            INNER JOIN orderproduct ON `order`.OrderProductID = orderproduct.OrderID INNER JOIN orderpickuppoint ON orderpickuppoint.idPickupPoint = `order`.OrderPickupPoint
                                            INNER JOIN user ON user.UserID = `order`.OrderClient INNER JOIN orderstatus ON orderstatus.idStatus = `order`.OrderStatus WHERE `order`.OrderDate = '{0}' ORDER BY `order`.OrderID;", newdate);

                MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
                com.ExecuteNonQuery();

                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvOrderAll.DataSource = dt;

                connection.CloseConnect();
                dgvOrderAll.Columns[0].Visible = false;
                dgvOrderAll.Columns[3].Visible = false;
                FillCell();
                lCountOrder.Text = "Всего заказов: " + dgvOrderAll.Rows.Count;
            }

            else
            {
                cmUser.Enabled = true;

                bSort.Text = "Сортировать";

                dgvFillOrder();
                FillCell();
                lCountOrder.Text = "Всего заказов: " + dgvOrderAll.Rows.Count;
            }
        }

        private void dgvOrderAll_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvOrderAll.Rows.Count)
                {
                    bDateOrderNew.Enabled = true;

                    id_order = dgvOrderAll.Rows[e.RowIndex].Cells[0].Value.ToString();
                }
            }

            catch (Exception)
            {
                ;
            }

            bDateOrderNew.Enabled = true;


        }

        private void bDateOrderNew_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Вы действительно хотите изменить дату доставки?", "Информация о доставке", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dg == DialogResult.Yes)
            {
                string date =  dtpDateUpd.Value.ToString();
                string[] date_split = date.Split(' ');

                var newdate = Convert.ToDateTime(date_split[0]).ToString("yyyy.MM.dd");

                db_connect connection = new db_connect();

                connection.OpenConnect();

                string sql = String.Format("UPDATE `order` SET OrderDeliveryDate = '{0}' WHERE OrderID = {1}", newdate, id_order);

                MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
                com.ExecuteNonQuery();

                connection.CloseConnect();
                dgvFillOrderNew();
                FillCell();
                lCountOrder.Text = "Всего заказов: " + dgvOrderAll.Rows.Count;

                bDateOrderNew.Enabled = false;

                MessageBox.Show("Успешно! Дата доставки заказа перенесена на выбранную дату.", "Информация о доставке", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvFillOrderNew()
        {
            db_connect connection = new db_connect();
            connection.OpenConnect();

            string sql =String.Format(@"SELECT `order`.OrderID AS 'OPD', orderproduct.ProductArticleNumber AS 'Артикул', orderproduct.OrderCount AS 'Количество', `order`.OrderCode AS 'Код получения', 
                            `order`.OrderDeliveryDate AS 'Дата доставки', orderpickuppoint.PickupPoint AS 'Адрес доставки',  `order`.OrderDate AS 'Дата заказа', 
                            CONCAT(user.UserSurname, ' ', user.UserName, ' ', user.UserPatronymic) AS 'Заказчик', orderstatus.Status AS 'Статус заказа' FROM `order`
                            INNER JOIN orderproduct ON `order`.OrderProductID = orderproduct.OrderID INNER JOIN orderpickuppoint ON orderpickuppoint.idPickupPoint = `order`.OrderPickupPoint
                            INNER JOIN user ON user.UserID = `order`.OrderClient INNER JOIN orderstatus ON orderstatus.idStatus = `order`.OrderStatus
                            ORDER BY CASE WHEN `order`.OrderID = {0} THEN 0 ELSE 1 END, `order`.OrderID;", id_order);

            MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
            com.ExecuteNonQuery();

            MySqlDataAdapter adapter = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgvOrderAll.DataSource = dt;

            connection.CloseConnect();

            dgvOrderAll.Columns[0].Visible = false;
            dgvOrderAll.Columns[3].Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNew.Checked == true)
            {
                cmUser.Enabled = false;
                bSort.Enabled = false;

                db_connect connection = new db_connect();
                connection.OpenConnect();

                string sql = @"SELECT `order`.OrderID AS 'OPD', orderproduct.ProductArticleNumber AS 'Артикул', orderproduct.OrderCount AS 'Количество', `order`.OrderCode AS 'Код получения', 
                            `order`.OrderDeliveryDate AS 'Дата доставки', orderpickuppoint.PickupPoint AS 'Адрес доставки',  `order`.OrderDate AS 'Дата заказа', 
                            CONCAT(user.UserSurname, ' ', user.UserName, ' ', user.UserPatronymic) AS 'Заказчик', orderstatus.Status AS 'Статус заказа' FROM `order`
                            INNER JOIN orderproduct ON `order`.OrderProductID = orderproduct.OrderID INNER JOIN orderpickuppoint ON orderpickuppoint.idPickupPoint = `order`.OrderPickupPoint
                            INNER JOIN user ON user.UserID = `order`.OrderClient INNER JOIN orderstatus ON orderstatus.idStatus = `order`.OrderStatus WHERE orderstatus.Status = 'Новый';";

                MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
                com.ExecuteNonQuery();

                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvOrderAll.DataSource = dt;

                connection.CloseConnect();
                dgvOrderAll.Columns[0].Visible = false;
                dgvOrderAll.Columns[3].Visible = false;
                FillCell();
                lCountOrder.Text = "Всего заказов: " + dgvOrderAll.Rows.Count;
            }

            else
            {
                cmUser.Enabled = true;
                bSort.Enabled = true;

                dgvFillOrder();
                FillCell();
                lCountOrder.Text = "Всего заказов: " + dgvOrderAll.Rows.Count;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFinish.Checked == true)
            {
                cmUser.Enabled = false;
                bSort.Enabled = false;

                db_connect connection = new db_connect();
                connection.OpenConnect();

                string sql = @"SELECT `order`.OrderID AS 'OPD', orderproduct.ProductArticleNumber AS 'Артикул', orderproduct.OrderCount AS 'Количество', `order`.OrderCode AS 'Код получения', 
                            `order`.OrderDeliveryDate AS 'Дата доставки', orderpickuppoint.PickupPoint AS 'Адрес доставки',  `order`.OrderDate AS 'Дата заказа', 
                            CONCAT(user.UserSurname, ' ', user.UserName, ' ', user.UserPatronymic) AS 'Заказчик', orderstatus.Status AS 'Статус заказа' FROM `order`
                            INNER JOIN orderproduct ON `order`.OrderProductID = orderproduct.OrderID INNER JOIN orderpickuppoint ON orderpickuppoint.idPickupPoint = `order`.OrderPickupPoint
                            INNER JOIN user ON user.UserID = `order`.OrderClient INNER JOIN orderstatus ON orderstatus.idStatus = `order`.OrderStatus WHERE orderstatus.Status = 'Завершен';";

                MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
                com.ExecuteNonQuery();

                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvOrderAll.DataSource = dt;

                connection.CloseConnect();
                FillCell();
                dgvOrderAll.Columns[0].Visible = false;
                dgvOrderAll.Columns[3].Visible = false;
                lCountOrder.Text = "Всего заказов: " + dgvOrderAll.Rows.Count;
            }

            else
            {
                cmUser.Enabled = true;
                bSort.Enabled = true;

                dgvFillOrder();
                FillCell();
                lCountOrder.Text = "Всего заказов: " + dgvOrderAll.Rows.Count;
            }
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAll.Checked == true)
            {
                cmUser.Enabled = false;
                bSort.Enabled = false;

                db_connect connection = new db_connect();
                connection.OpenConnect();

                string sql = @"SELECT `order`.OrderID AS 'OPD', orderproduct.ProductArticleNumber AS 'Артикул', orderproduct.OrderCount AS 'Количество', `order`.OrderCode AS 'Код получения', 
                            `order`.OrderDeliveryDate AS 'Дата доставки', orderpickuppoint.PickupPoint AS 'Адрес доставки',  `order`.OrderDate AS 'Дата заказа', 
                            CONCAT(user.UserSurname, ' ', user.UserName, ' ', user.UserPatronymic) AS 'Заказчик', orderstatus.Status AS 'Статус заказа' FROM `order`
                            INNER JOIN orderproduct ON `order`.OrderProductID = orderproduct.OrderID INNER JOIN orderpickuppoint ON orderpickuppoint.idPickupPoint = `order`.OrderPickupPoint
                            INNER JOIN user ON user.UserID = `order`.OrderClient INNER JOIN orderstatus ON orderstatus.idStatus = `order`.OrderStatus WHERE orderstatus.Status IN ('Завершен', 'Новый');";


                MySqlCommand com = new MySqlCommand(sql, connection.GetConnect());
                com.ExecuteNonQuery();

                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvOrderAll.DataSource = dt;

                connection.CloseConnect();
                FillCell();
                dgvOrderAll.Columns[0].Visible = false;
                dgvOrderAll.Columns[3].Visible = false;
                lCountOrder.Text = "Всего заказов: " + dgvOrderAll.Rows.Count;
            }

            else
            {
                cmUser.Enabled = true;
                bSort.Enabled = true;

                dgvFillOrder();
                FillCell();
                lCountOrder.Text = "Всего заказов: " + dgvOrderAll.Rows.Count;
            }
        }

        private void bExcels_Click(object sender, EventArgs e)
        {
            db_connect connection = new db_connect();
            connection.OpenConnect();

            string sql = @"SELECT `order`.OrderID AS 'Номер заказа', orderproduct.ProductArticleNumber AS 'Артикул', orderproduct.OrderCount AS 'Количество', 
                            CONCAT(EXTRACT(DAY FROM `order`.OrderDeliveryDate), '.', EXTRACT(MONTH FROM `order`.OrderDeliveryDate), '.', EXTRACT(YEAR FROM `order`.OrderDeliveryDate)) AS 'Дата доставки',
                            orderpickuppoint.PickupPoint AS 'Адрес доставки', CONCAT(EXTRACT(DAY FROM `order`.OrderDate), '.', EXTRACT(MONTH FROM `order`.OrderDate), '.', EXTRACT(YEAR FROM `order`.OrderDate)) AS 'Дата заказа', 
                            CONCAT(user.UserSurname, ' ', user.UserName, ' ', user.UserPatronymic) AS 'Заказчик', orderstatus.Status AS 'Статус заказа' FROM `order`
                            INNER JOIN orderproduct ON `order`.OrderProductID = orderproduct.OrderID INNER JOIN orderpickuppoint ON orderpickuppoint.idPickupPoint = `order`.OrderPickupPoint
                            INNER JOIN user ON user.UserID = `order`.OrderClient INNER JOIN orderstatus ON orderstatus.idStatus = `order`.OrderStatus;";
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

            Microsoft.Office.Interop.Excel.Range _excelCells1 = (Microsoft.Office.Interop.Excel.Range)ExcelWorkSheet.get_Range("A1", "H1").Cells;
            _excelCells1.Merge(Type.Missing);

            ExcelApp.Cells[1, 1].EntireRow.Font.Size = 16;
            ExcelApp.Cells[1, 1].EntireRow.Font.Bold = true;
            ExcelApp.Cells[1, 1] = "Отчет по всем заказам товаров";
            ExcelApp.Cells[1, 1].HorizontalAlignment = -4108;
            ExcelApp.Cells[1, 1].VerticalAlignment = -4108;

            Microsoft.Office.Interop.Excel.Range _excelCells2 = (Microsoft.Office.Interop.Excel.Range)ExcelWorkSheet.get_Range("A2", "H2").Cells;
            _excelCells2.Merge(Type.Missing);

            ExcelApp.Cells[2, 1].EntireRow.Font.Bold = true;
            ExcelApp.Cells[2, 1].EntireRow.Font.Size = 16;
            ExcelApp.Cells[2, 1] = "от " + DateTime.Now.ToString("dd.MM.yyyy");
            ExcelApp.Cells[2, 1].HorizontalAlignment = -4108;
            ExcelApp.Cells[2, 1].VerticalAlignment = -4108;

            ExcelApp.Range["A3:H3"].EntireRow.Font.Bold = true;

            ExcelApp.Cells[3, 1] = "Номер заказа";
            ExcelApp.Cells[3, 2] = "Артикул";
            ExcelApp.Cells[3, 3] = "Количество";
            ExcelApp.Cells[3, 4] = "Дата доставки заказа";
            ExcelApp.Cells[3, 5] = "Адрес доставки";
            ExcelApp.Cells[3, 6] = "Дата заказа";
            ExcelApp.Cells[3, 7] = "Заказчик";
            ExcelApp.Cells[3, 8] = "Статус";

            ExcelApp.Range["A1:H100" + (dt.Rows.Count + 2)].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            ExcelApp.Range["A1:H100" + (dt.Rows.Count + 2)].Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;


            ExcelApp.Range["A1:H100"].Font.Size = 14;

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
            ExcelApp.UserControl = true;

        }

        private void dgvOrderAll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
