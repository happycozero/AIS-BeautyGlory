namespace BeautyGlory
{
    partial class OrderInf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderInf));
            this.bBack = new System.Windows.Forms.Button();
            this.bCheck = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.lDate = new System.Windows.Forms.Label();
            this.lCountProd = new System.Windows.Forms.Label();
            this.lPrice = new System.Windows.Forms.Label();
            this.lDisc = new System.Windows.Forms.Label();
            this.lPriceDisc = new System.Windows.Forms.Label();
            this.lNum = new System.Windows.Forms.Label();
            this.lStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // bBack
            // 
            this.bBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bBack.Location = new System.Drawing.Point(914, 665);
            this.bBack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(282, 52);
            this.bBack.TabIndex = 23;
            this.bBack.Text = "Закрыть";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // bCheck
            // 
            this.bCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCheck.Location = new System.Drawing.Point(316, 665);
            this.bCheck.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bCheck.Name = "bCheck";
            this.bCheck.Size = new System.Drawing.Size(282, 52);
            this.bCheck.TabIndex = 26;
            this.bCheck.Text = "Сформировать чек";
            this.bCheck.UseVisualStyleBackColor = true;
            this.bCheck.Click += new System.EventHandler(this.bCheck_Click);
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCancel.Location = new System.Drawing.Point(13, 665);
            this.bCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(282, 52);
            this.bCancel.TabIndex = 27;
            this.bCancel.Text = "Отменить заказ";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // lDate
            // 
            this.lDate.Location = new System.Drawing.Point(11, 27);
            this.lDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(206, 32);
            this.lDate.TabIndex = 32;
            this.lDate.Text = "Date";
            this.lDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lCountProd
            // 
            this.lCountProd.Location = new System.Drawing.Point(8, 123);
            this.lCountProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCountProd.Name = "lCountProd";
            this.lCountProd.Size = new System.Drawing.Size(350, 32);
            this.lCountProd.TabIndex = 34;
            this.lCountProd.Text = "Кол-во товара";
            this.lCountProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lPrice
            // 
            this.lPrice.Location = new System.Drawing.Point(735, 59);
            this.lPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPrice.Name = "lPrice";
            this.lPrice.Size = new System.Drawing.Size(406, 32);
            this.lPrice.TabIndex = 36;
            this.lPrice.Text = "Стоимость";
            this.lPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lDisc
            // 
            this.lDisc.Location = new System.Drawing.Point(735, 91);
            this.lDisc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDisc.Name = "lDisc";
            this.lDisc.Size = new System.Drawing.Size(406, 32);
            this.lDisc.TabIndex = 37;
            this.lDisc.Text = "Скидка";
            this.lDisc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lPriceDisc
            // 
            this.lPriceDisc.Location = new System.Drawing.Point(735, 123);
            this.lPriceDisc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPriceDisc.Name = "lPriceDisc";
            this.lPriceDisc.Size = new System.Drawing.Size(406, 32);
            this.lPriceDisc.TabIndex = 38;
            this.lPriceDisc.Text = "Стоимость со скидкой";
            this.lPriceDisc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lNum
            // 
            this.lNum.Location = new System.Drawing.Point(8, 59);
            this.lNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNum.Name = "lNum";
            this.lNum.Size = new System.Drawing.Size(350, 32);
            this.lNum.TabIndex = 42;
            this.lNum.Text = "Номер заказа";
            this.lNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lStatus
            // 
            this.lStatus.Location = new System.Drawing.Point(8, 91);
            this.lStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(350, 32);
            this.lStatus.TabIndex = 45;
            this.lStatus.Text = "Статус заказа";
            this.lStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvOrder);
            this.groupBox1.Controls.Add(this.lStatus);
            this.groupBox1.Controls.Add(this.lNum);
            this.groupBox1.Controls.Add(this.lPriceDisc);
            this.groupBox1.Controls.Add(this.lDisc);
            this.groupBox1.Controls.Add(this.lPrice);
            this.groupBox1.Controls.Add(this.lCountProd);
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
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.AllowUserToResizeColumns = false;
            this.dgvOrder.AllowUserToResizeRows = false;
            this.dgvOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOrder.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrder.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrder.Location = new System.Drawing.Point(12, 168);
            this.dgvOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvOrder.MultiSelect = false;
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowHeadersVisible = false;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new System.Drawing.Size(1161, 430);
            this.dgvOrder.TabIndex = 46;
            this.dgvOrder.TabStop = false;
            // 
            // OrderInf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1210, 729);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bCheck);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bBack);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "OrderInf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр заказа";
            this.Load += new System.EventHandler(this.OrderInf_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Button bCheck;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.Label lCountProd;
        private System.Windows.Forms.Label lPrice;
        private System.Windows.Forms.Label lDisc;
        private System.Windows.Forms.Label lPriceDisc;
        private System.Windows.Forms.Label lNum;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvOrder;
    }
}