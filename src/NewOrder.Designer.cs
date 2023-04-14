namespace BeautyGlory
{
    partial class NewOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewOrder));
            this.bBack = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lFIO = new System.Windows.Forms.Label();
            this.bDel = new System.Windows.Forms.Button();
            this.bOrder = new System.Windows.Forms.Button();
            this.tbCount = new System.Windows.Forms.NumericUpDown();
            this.bClear = new System.Windows.Forms.Button();
            this.lCount = new System.Windows.Forms.Label();
            this.bAdd = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.lPrice = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lDate = new System.Windows.Forms.Label();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // bBack
            // 
            this.bBack.Location = new System.Drawing.Point(735, 614);
            this.bBack.Margin = new System.Windows.Forms.Padding(4);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(325, 70);
            this.bBack.TabIndex = 23;
            this.bBack.Text = "В меню";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lFIO);
            this.groupBox2.Controls.Add(this.bDel);
            this.groupBox2.Controls.Add(this.bBack);
            this.groupBox2.Controls.Add(this.bOrder);
            this.groupBox2.Controls.Add(this.tbCount);
            this.groupBox2.Controls.Add(this.bClear);
            this.groupBox2.Controls.Add(this.lCount);
            this.groupBox2.Controls.Add(this.bAdd);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.lPrice);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lDate);
            this.groupBox2.Controls.Add(this.dgvCart);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1068, 716);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Корзина";
            // 
            // lFIO
            // 
            this.lFIO.Location = new System.Drawing.Point(369, 44);
            this.lFIO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lFIO.Name = "lFIO";
            this.lFIO.Size = new System.Drawing.Size(691, 43);
            this.lFIO.TabIndex = 36;
            this.lFIO.Text = "Date";
            this.lFIO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bDel
            // 
            this.bDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bDel.Location = new System.Drawing.Point(1013, 469);
            this.bDel.Margin = new System.Windows.Forms.Padding(4);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(47, 40);
            this.bDel.TabIndex = 28;
            this.bDel.Text = "-";
            this.bDel.UseVisualStyleBackColor = true;
            this.bDel.Click += new System.EventHandler(this.bDel_Click);
            // 
            // bOrder
            // 
            this.bOrder.Location = new System.Drawing.Point(15, 614);
            this.bOrder.Margin = new System.Windows.Forms.Padding(4);
            this.bOrder.Name = "bOrder";
            this.bOrder.Size = new System.Drawing.Size(325, 70);
            this.bOrder.TabIndex = 35;
            this.bOrder.Text = "Оформить заказ";
            this.bOrder.UseVisualStyleBackColor = true;
            this.bOrder.Click += new System.EventHandler(this.bOrder_Click);
            // 
            // tbCount
            // 
            this.tbCount.Location = new System.Drawing.Point(879, 469);
            this.tbCount.Margin = new System.Windows.Forms.Padding(4);
            this.tbCount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.tbCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(71, 40);
            this.tbCount.TabIndex = 26;
            this.tbCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(375, 614);
            this.bClear.Margin = new System.Windows.Forms.Padding(4);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(325, 70);
            this.bClear.TabIndex = 29;
            this.bClear.Text = "Очистить корзину";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // lCount
            // 
            this.lCount.Location = new System.Drawing.Point(263, 469);
            this.lCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCount.Name = "lCount";
            this.lCount.Size = new System.Drawing.Size(316, 43);
            this.lCount.TabIndex = 34;
            this.lCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bAdd
            // 
            this.bAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bAdd.Location = new System.Drawing.Point(958, 469);
            this.bAdd.Margin = new System.Windows.Forms.Padding(4);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(47, 41);
            this.bAdd.TabIndex = 27;
            this.bAdd.Text = "+";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(9, 469);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(268, 43);
            this.label14.TabIndex = 33;
            this.label14.Text = "Итоговое количество:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lPrice
            // 
            this.lPrice.Location = new System.Drawing.Point(188, 512);
            this.lPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPrice.Name = "lPrice";
            this.lPrice.Size = new System.Drawing.Size(364, 43);
            this.lPrice.TabIndex = 32;
            this.lPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(9, 513);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(188, 43);
            this.label12.TabIndex = 31;
            this.label12.Text = "Итоговая цена:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lDate
            // 
            this.lDate.Location = new System.Drawing.Point(9, 41);
            this.lDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(241, 43);
            this.lDate.TabIndex = 31;
            this.lDate.Text = "Date";
            this.lDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.AllowUserToResizeColumns = false;
            this.dgvCart.AllowUserToResizeRows = false;
            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCart.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCart.BackgroundColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCart.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCart.Location = new System.Drawing.Point(9, 91);
            this.dgvCart.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCart.MultiSelect = false;
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCart.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCart.RowHeadersVisible = false;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(1051, 360);
            this.dgvCart.TabIndex = 19;
            this.dgvCart.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCart_CellMouseClick);
            // 
            // NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1090, 737);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Comic Sans MS", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "NewOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказ товара | ООО \"Красотка\"";
            this.Load += new System.EventHandler(this.NewOrder_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lDate;
        public System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.NumericUpDown tbCount;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bDel;
        private System.Windows.Forms.Label lCount;
        private System.Windows.Forms.Label lPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bOrder;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lFIO;
    }
}