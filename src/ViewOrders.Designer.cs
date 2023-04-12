namespace BeautyGlory
{
    partial class ViewOrders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewOrders));
            this.bBack = new System.Windows.Forms.Button();
            this.lCountOrder = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lDate = new System.Windows.Forms.Label();
            this.dgvOrderAll = new System.Windows.Forms.DataGridView();
            this.lProf = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmUser = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbNo = new System.Windows.Forms.CheckBox();
            this.cbYes = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbPrice = new System.Windows.Forms.CheckBox();
            this.cbCount = new System.Windows.Forms.CheckBox();
            this.bExcel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderAll)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bBack
            // 
            this.bBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bBack.Location = new System.Drawing.Point(931, 665);
            this.bBack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(263, 52);
            this.bBack.TabIndex = 23;
            this.bBack.Text = "Назад в меню";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // lCountOrder
            // 
            this.lCountOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCountOrder.Location = new System.Drawing.Point(8, 573);
            this.lCountOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCountOrder.Name = "lCountOrder";
            this.lCountOrder.Size = new System.Drawing.Size(270, 32);
            this.lCountOrder.TabIndex = 41;
            this.lCountOrder.Text = "Всего заказов: 0";
            this.lCountOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lDate);
            this.groupBox1.Controls.Add(this.dgvOrderAll);
            this.groupBox1.Controls.Add(this.lProf);
            this.groupBox1.Controls.Add(this.lCountOrder);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmUser);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(1181, 613);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lDate.Location = new System.Drawing.Point(15, 30);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(70, 25);
            this.lDate.TabIndex = 42;
            this.lDate.Text = "label2";
            // 
            // dgvOrderAll
            // 
            this.dgvOrderAll.AllowUserToAddRows = false;
            this.dgvOrderAll.AllowUserToDeleteRows = false;
            this.dgvOrderAll.AllowUserToResizeColumns = false;
            this.dgvOrderAll.AllowUserToResizeRows = false;
            this.dgvOrderAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrderAll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderAll.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOrderAll.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvOrderAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderAll.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrderAll.Location = new System.Drawing.Point(11, 182);
            this.dgvOrderAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvOrderAll.MultiSelect = false;
            this.dgvOrderAll.Name = "dgvOrderAll";
            this.dgvOrderAll.ReadOnly = true;
            this.dgvOrderAll.RowHeadersVisible = false;
            this.dgvOrderAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderAll.ShowCellErrors = false;
            this.dgvOrderAll.ShowCellToolTips = false;
            this.dgvOrderAll.ShowEditingIcon = false;
            this.dgvOrderAll.ShowRowErrors = false;
            this.dgvOrderAll.Size = new System.Drawing.Size(1162, 388);
            this.dgvOrderAll.TabIndex = 36;
            this.dgvOrderAll.TabStop = false;
            this.dgvOrderAll.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOrderAll_CellMouseDoubleClick);
            // 
            // lProf
            // 
            this.lProf.Location = new System.Drawing.Point(577, 573);
            this.lProf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lProf.Name = "lProf";
            this.lProf.Size = new System.Drawing.Size(597, 32);
            this.lProf.TabIndex = 35;
            this.lProf.Text = "0";
            this.lProf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(544, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 32);
            this.label1.TabIndex = 33;
            this.label1.Text = "Сотрудник:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmUser
            // 
            this.cmUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmUser.FormattingEnabled = true;
            this.cmUser.Location = new System.Drawing.Point(690, 29);
            this.cmUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmUser.Name = "cmUser";
            this.cmUser.Size = new System.Drawing.Size(483, 31);
            this.cmUser.TabIndex = 32;
            this.cmUser.SelectedIndexChanged += new System.EventHandler(this.cmUser_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbNo);
            this.groupBox4.Controls.Add(this.cbYes);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(933, 74);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(240, 102);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Статус";
            // 
            // cbNo
            // 
            this.cbNo.AutoSize = true;
            this.cbNo.Location = new System.Drawing.Point(7, 63);
            this.cbNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbNo.Name = "cbNo";
            this.cbNo.Size = new System.Drawing.Size(120, 29);
            this.cbNo.TabIndex = 32;
            this.cbNo.Text = "Отменен";
            this.cbNo.UseVisualStyleBackColor = true;
            this.cbNo.CheckedChanged += new System.EventHandler(this.cbNo_CheckedChanged);
            // 
            // cbYes
            // 
            this.cbYes.AutoSize = true;
            this.cbYes.Location = new System.Drawing.Point(7, 30);
            this.cbYes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbYes.Name = "cbYes";
            this.cbYes.Size = new System.Drawing.Size(132, 29);
            this.cbYes.TabIndex = 2;
            this.cbYes.Text = "Выполнен";
            this.cbYes.UseVisualStyleBackColor = true;
            this.cbYes.CheckedChanged += new System.EventHandler(this.cbYes_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbPrice);
            this.groupBox2.Controls.Add(this.cbCount);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 74);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(392, 102);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сортировка по возрастанию";
            // 
            // cbPrice
            // 
            this.cbPrice.AutoSize = true;
            this.cbPrice.Location = new System.Drawing.Point(7, 63);
            this.cbPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbPrice.Name = "cbPrice";
            this.cbPrice.Size = new System.Drawing.Size(174, 29);
            this.cbPrice.TabIndex = 1;
            this.cbPrice.Text = "Сумма заказа";
            this.cbPrice.UseVisualStyleBackColor = true;
            this.cbPrice.CheckedChanged += new System.EventHandler(this.cbPrice_CheckedChanged);
            // 
            // cbCount
            // 
            this.cbCount.AutoSize = true;
            this.cbCount.Location = new System.Drawing.Point(7, 30);
            this.cbCount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbCount.Name = "cbCount";
            this.cbCount.Size = new System.Drawing.Size(104, 29);
            this.cbCount.TabIndex = 0;
            this.cbCount.Text = "Скидка";
            this.cbCount.UseVisualStyleBackColor = true;
            this.cbCount.CheckedChanged += new System.EventHandler(this.cbCount_CheckedChanged);
            // 
            // bExcel
            // 
            this.bExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bExcel.Location = new System.Drawing.Point(13, 665);
            this.bExcel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bExcel.Name = "bExcel";
            this.bExcel.Size = new System.Drawing.Size(263, 52);
            this.bExcel.TabIndex = 47;
            this.bExcel.Text = "Сформировать отчет";
            this.bExcel.UseVisualStyleBackColor = true;
            this.bExcel.Click += new System.EventHandler(this.bExcel_Click);
            // 
            // ViewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1210, 729);
            this.Controls.Add(this.bExcel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bBack);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "ViewOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учёт продаж";
            this.Load += new System.EventHandler(this.ViewOrders_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderAll)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Label lCountOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmUser;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cbNo;
        private System.Windows.Forms.CheckBox cbYes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbPrice;
        private System.Windows.Forms.CheckBox cbCount;
        private System.Windows.Forms.Label lProf;
        private System.Windows.Forms.Button bExcel;
        private System.Windows.Forms.DataGridView dgvOrderAll;
        private System.Windows.Forms.Label lDate;
    }
}