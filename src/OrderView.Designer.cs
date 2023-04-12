namespace BeautyGlory
{
    partial class OrderView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderView));
            this.bBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.lNum = new System.Windows.Forms.Label();
            this.lDiscPrice = new System.Windows.Forms.Label();
            this.lDisc = new System.Windows.Forms.Label();
            this.lPrice = new System.Windows.Forms.Label();
            this.lCount = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.cbPens = new System.Windows.Forms.CheckBox();
            this.cbStud = new System.Windows.Forms.CheckBox();
            this.lDate = new System.Windows.Forms.Label();
            this.bAddOrder = new System.Windows.Forms.Button();
            this.bCheck = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bBack
            // 
            this.bBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bBack.Location = new System.Drawing.Point(912, 665);
            this.bBack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(282, 52);
            this.bBack.TabIndex = 23;
            this.bBack.Text = "Закрыть";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCart);
            this.groupBox1.Controls.Add(this.lNum);
            this.groupBox1.Controls.Add(this.lDiscPrice);
            this.groupBox1.Controls.Add(this.lDisc);
            this.groupBox1.Controls.Add(this.lPrice);
            this.groupBox1.Controls.Add(this.lCount);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lDate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(1181, 604);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Корзина";
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.AllowUserToResizeColumns = false;
            this.dgvCart.AllowUserToResizeRows = false;
            this.dgvCart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCart.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCart.BackgroundColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCart.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCart.Location = new System.Drawing.Point(8, 217);
            this.dgvCart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvCart.MultiSelect = false;
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCart.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCart.RowHeadersVisible = false;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(1165, 381);
            this.dgvCart.TabIndex = 44;
            // 
            // lNum
            // 
            this.lNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lNum.Location = new System.Drawing.Point(803, 26);
            this.lNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNum.Name = "lNum";
            this.lNum.Size = new System.Drawing.Size(370, 32);
            this.lNum.TabIndex = 42;
            this.lNum.Text = "Номер заказа: ";
            this.lNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lDiscPrice
            // 
            this.lDiscPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lDiscPrice.Location = new System.Drawing.Point(803, 159);
            this.lDiscPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDiscPrice.Name = "lDiscPrice";
            this.lDiscPrice.Size = new System.Drawing.Size(370, 32);
            this.lDiscPrice.TabIndex = 38;
            this.lDiscPrice.Text = "Стоимость со скидкой:";
            this.lDiscPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lDisc
            // 
            this.lDisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lDisc.Location = new System.Drawing.Point(803, 123);
            this.lDisc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDisc.Name = "lDisc";
            this.lDisc.Size = new System.Drawing.Size(370, 32);
            this.lDisc.TabIndex = 37;
            this.lDisc.Text = "Скидка:";
            this.lDisc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lPrice
            // 
            this.lPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lPrice.Location = new System.Drawing.Point(803, 90);
            this.lPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPrice.Name = "lPrice";
            this.lPrice.Size = new System.Drawing.Size(370, 32);
            this.lPrice.TabIndex = 36;
            this.lPrice.Text = "Стоимость:";
            this.lPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lCount
            // 
            this.lCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCount.Location = new System.Drawing.Point(803, 58);
            this.lCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCount.Name = "lCount";
            this.lCount.Size = new System.Drawing.Size(370, 32);
            this.lCount.TabIndex = 34;
            this.lCount.Text = "Количество товара: ";
            this.lCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.cbPens);
            this.groupBox2.Controls.Add(this.cbStud);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(8, 63);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(308, 142);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Скидки:";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(7, 97);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(205, 29);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Скидка VIP - 15%";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // cbPens
            // 
            this.cbPens.AutoSize = true;
            this.cbPens.Location = new System.Drawing.Point(7, 64);
            this.cbPens.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbPens.Name = "cbPens";
            this.cbPens.Size = new System.Drawing.Size(289, 29);
            this.cbPens.TabIndex = 1;
            this.cbPens.Text = "Пенсионная скидка - 10%";
            this.cbPens.UseVisualStyleBackColor = true;
            this.cbPens.CheckedChanged += new System.EventHandler(this.cbPens_CheckedChanged);
            // 
            // cbStud
            // 
            this.cbStud.AutoSize = true;
            this.cbStud.Location = new System.Drawing.Point(8, 31);
            this.cbStud.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbStud.Name = "cbStud";
            this.cbStud.Size = new System.Drawing.Size(296, 29);
            this.cbStud.TabIndex = 0;
            this.cbStud.Text = "Студенческая скидка - 5%";
            this.cbStud.UseVisualStyleBackColor = true;
            this.cbStud.CheckedChanged += new System.EventHandler(this.cbStud_CheckedChanged);
            // 
            // lDate
            // 
            this.lDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lDate.Location = new System.Drawing.Point(8, 28);
            this.lDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(206, 32);
            this.lDate.TabIndex = 32;
            this.lDate.Text = "Date";
            this.lDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bAddOrder
            // 
            this.bAddOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAddOrder.Location = new System.Drawing.Point(14, 665);
            this.bAddOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bAddOrder.Name = "bAddOrder";
            this.bAddOrder.Size = new System.Drawing.Size(282, 52);
            this.bAddOrder.TabIndex = 25;
            this.bAddOrder.Text = "Оформить";
            this.bAddOrder.UseVisualStyleBackColor = true;
            this.bAddOrder.Click += new System.EventHandler(this.bAddOrder_Click);
            // 
            // bCheck
            // 
            this.bCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCheck.Location = new System.Drawing.Point(320, 665);
            this.bCheck.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bCheck.Name = "bCheck";
            this.bCheck.Size = new System.Drawing.Size(282, 52);
            this.bCheck.TabIndex = 26;
            this.bCheck.Text = "Сформировать чек";
            this.bCheck.UseVisualStyleBackColor = true;
            this.bCheck.Click += new System.EventHandler(this.bCheck_Click);
            // 
            // OrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1210, 729);
            this.Controls.Add(this.bCheck);
            this.Controls.Add(this.bAddOrder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bBack);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "OrderView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оформление заказа";
            this.Load += new System.EventHandler(this.OrderView_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox cbPens;
        private System.Windows.Forms.CheckBox cbStud;
        private System.Windows.Forms.Label lDiscPrice;
        private System.Windows.Forms.Label lDisc;
        private System.Windows.Forms.Label lPrice;
        private System.Windows.Forms.Label lCount;
        private System.Windows.Forms.Button bAddOrder;
        private System.Windows.Forms.Button bCheck;
        private System.Windows.Forms.Label lNum;
        private System.Windows.Forms.DataGridView dgvCart;
    }
}