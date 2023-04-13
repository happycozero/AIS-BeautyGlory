using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautyGlory
{
    public partial class Captch : Form
    {
        bool flag = false; 

        public Captch()
        {
            InitializeComponent();
            GenCaptch();
        }

        private void bInput_Click(object sender, EventArgs e)
        {
            if (tbCaptch.Text == "")
            {
                MessageBox.Show("Ошибка. Введите капчу!", "Возникла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (lCaptch.Text == tbCaptch.Text)
                {
                    tbCaptch.Clear();
                    flag = true;
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Ошибка! Капча неверная.\n Повторите попытку через 10 секунд.", "Возникла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    bInput.Enabled = false;
                    bReload.Enabled = false;

                    Task.Delay(10000).ContinueWith(_ =>
                    {
                        bInput.Invoke((MethodInvoker)(() => bInput.Enabled = true));
                        bReload.Invoke((MethodInvoker)(() => bReload.Enabled = true));
                    });

                    GenCaptch();
                    tbCaptch.Clear();
                }
            }
        }

        public void GenCaptch()
        {
            string text = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm0123456789";
            string captch = "";
            int len = text.Length;

            Random rnd = new Random();

            for (int i = 0; i < 8; i++)
            {
                captch += text[rnd.Next(1, len)];
            }

            lCaptch.Text = captch;
        }

        private void bReload_Click(object sender, EventArgs e)
        {
            tbCaptch.Clear();
            GenCaptch();
        }

        private void Captch_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag == true)
            {
                e.Cancel = false;
            }

            else
            {
                e.Cancel = true;
            }
        }

        private void Captch_Load(object sender, EventArgs e)
        {
            GenCaptch();
        }
    }
}
