﻿namespace BeautyGlory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewOrders));
            this.bBack = new System.Windows.Forms.Button();
            this.lCountOrder = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bDateOrderNew = new System.Windows.Forms.Button();
            this.dtpDateUpd = new System.Windows.Forms.DateTimePicker();
            this.lDate = new System.Windows.Forms.Label();
            this.dgvOrderAll = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmUser = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbFinish = new System.Windows.Forms.RadioButton();
            this.rbNew = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bSort = new System.Windows.Forms.Button();
            this.dtpDateSort = new System.Windows.Forms.DateTimePicker();
            this.bExcels = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderAll)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bBack
            // 
            this.bBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBack.Font = new System.Drawing.Font("Comic Sans MS", 15.25F);
            this.bBack.Location = new System.Drawing.Point(1086, 800);
            this.bBack.Margin = new System.Windows.Forms.Padding(4);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(207, 45);
            this.bBack.TabIndex = 23;
            this.bBack.Text = "Назад в меню";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // lCountOrder
            // 
            this.lCountOrder.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCountOrder.Location = new System.Drawing.Point(9, 722);
            this.lCountOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCountOrder.Name = "lCountOrder";
            this.lCountOrder.Size = new System.Drawing.Size(293, 40);
            this.lCountOrder.TabIndex = 41;
            this.lCountOrder.Text = "Всего заказов: 0";
            this.lCountOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.lDate);
            this.groupBox1.Controls.Add(this.dgvOrderAll);
            this.groupBox1.Controls.Add(this.lCountOrder);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmUser);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1279, 773);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bDateOrderNew);
            this.groupBox3.Controls.Add(this.dtpDateUpd);
            this.groupBox3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(446, 93);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(557, 129);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Изменить дату доставки";
            // 
            // bDateOrderNew
            // 
            this.bDateOrderNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bDateOrderNew.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bDateOrderNew.Location = new System.Drawing.Point(259, 50);
            this.bDateOrderNew.Margin = new System.Windows.Forms.Padding(4);
            this.bDateOrderNew.Name = "bDateOrderNew";
            this.bDateOrderNew.Size = new System.Drawing.Size(290, 37);
            this.bDateOrderNew.TabIndex = 49;
            this.bDateOrderNew.Text = "Изменить дату";
            this.bDateOrderNew.UseVisualStyleBackColor = true;
            this.bDateOrderNew.Click += new System.EventHandler(this.bDateOrderNew_Click);
            // 
            // dtpDateUpd
            // 
            this.dtpDateUpd.Location = new System.Drawing.Point(15, 50);
            this.dtpDateUpd.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.dtpDateUpd.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dtpDateUpd.Name = "dtpDateUpd";
            this.dtpDateUpd.Size = new System.Drawing.Size(236, 37);
            this.dtpDateUpd.TabIndex = 33;
            this.dtpDateUpd.Value = new System.DateTime(2023, 4, 14, 0, 0, 0, 0);
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lDate.Location = new System.Drawing.Point(16, 38);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(61, 29);
            this.lDate.TabIndex = 42;
            this.lDate.Text = "Дата";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderAll.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrderAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderAll.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrderAll.Location = new System.Drawing.Point(12, 229);
            this.dgvOrderAll.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOrderAll.MultiSelect = false;
            this.dgvOrderAll.Name = "dgvOrderAll";
            this.dgvOrderAll.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderAll.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrderAll.RowHeadersVisible = false;
            this.dgvOrderAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderAll.ShowCellErrors = false;
            this.dgvOrderAll.ShowCellToolTips = false;
            this.dgvOrderAll.ShowEditingIcon = false;
            this.dgvOrderAll.ShowRowErrors = false;
            this.dgvOrderAll.Size = new System.Drawing.Size(1259, 489);
            this.dgvOrderAll.TabIndex = 36;
            this.dgvOrderAll.TabStop = false;
            this.dgvOrderAll.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderAll_CellContentClick);
            this.dgvOrderAll.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOrderAll_CellMouseClick);
            this.dgvOrderAll.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOrderAll_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(589, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 40);
            this.label1.TabIndex = 33;
            this.label1.Text = "Заказчик:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmUser
            // 
            this.cmUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmUser.FormattingEnabled = true;
            this.cmUser.Location = new System.Drawing.Point(705, 38);
            this.cmUser.Margin = new System.Windows.Forms.Padding(4);
            this.cmUser.Name = "cmUser";
            this.cmUser.Size = new System.Drawing.Size(566, 37);
            this.cmUser.TabIndex = 32;
            this.cmUser.SelectedIndexChanged += new System.EventHandler(this.cmUser_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbAll);
            this.groupBox4.Controls.Add(this.rbFinish);
            this.groupBox4.Controls.Add(this.rbNew);
            this.groupBox4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(1011, 93);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(260, 129);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Статус";
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(160, 48);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(66, 33);
            this.rbAll.TabIndex = 33;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "Все";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // rbFinish
            // 
            this.rbFinish.AutoSize = true;
            this.rbFinish.Location = new System.Drawing.Point(8, 76);
            this.rbFinish.Name = "rbFinish";
            this.rbFinish.Size = new System.Drawing.Size(127, 33);
            this.rbFinish.TabIndex = 33;
            this.rbFinish.TabStop = true;
            this.rbFinish.Text = "Завершен";
            this.rbFinish.UseVisualStyleBackColor = true;
            this.rbFinish.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbNew
            // 
            this.rbNew.AutoSize = true;
            this.rbNew.Location = new System.Drawing.Point(8, 37);
            this.rbNew.Name = "rbNew";
            this.rbNew.Size = new System.Drawing.Size(100, 33);
            this.rbNew.TabIndex = 33;
            this.rbNew.TabStop = true;
            this.rbNew.Text = "Новый";
            this.rbNew.UseVisualStyleBackColor = true;
            this.rbNew.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bSort);
            this.groupBox2.Controls.Add(this.dtpDateSort);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(13, 93);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(425, 129);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сортировка по дате заказа:";
            // 
            // bSort
            // 
            this.bSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bSort.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSort.Location = new System.Drawing.Point(268, 50);
            this.bSort.Margin = new System.Windows.Forms.Padding(4);
            this.bSort.Name = "bSort";
            this.bSort.Size = new System.Drawing.Size(149, 37);
            this.bSort.TabIndex = 48;
            this.bSort.Text = "Сортировать";
            this.bSort.UseVisualStyleBackColor = true;
            this.bSort.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpDateSort
            // 
            this.dtpDateSort.CustomFormat = "dd/MM/yyyy";
            this.dtpDateSort.Location = new System.Drawing.Point(8, 50);
            this.dtpDateSort.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.dtpDateSort.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dtpDateSort.Name = "dtpDateSort";
            this.dtpDateSort.Size = new System.Drawing.Size(236, 37);
            this.dtpDateSort.TabIndex = 0;
            this.dtpDateSort.Value = new System.DateTime(2023, 4, 14, 0, 0, 0, 0);
            // 
            // bExcels
            // 
            this.bExcels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.bExcels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExcels.Location = new System.Drawing.Point(14, 800);
            this.bExcels.Name = "bExcels";
            this.bExcels.Size = new System.Drawing.Size(314, 45);
            this.bExcels.TabIndex = 48;
            this.bExcels.Text = "Сформировать отчет";
            this.bExcels.UseVisualStyleBackColor = false;
            this.bExcels.Click += new System.EventHandler(this.bExcels_Click);
            // 
            // ViewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1311, 857);
            this.Controls.Add(this.bExcels);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bBack);
            this.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.Name = "ViewOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет заказов | ООО \"Красотка\"";
            this.Load += new System.EventHandler(this.ViewOrders_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderAll)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Label lCountOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmUser;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvOrderAll;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpDateUpd;
        private System.Windows.Forms.DateTimePicker dtpDateSort;
        private System.Windows.Forms.Button bSort;
        private System.Windows.Forms.Button bDateOrderNew;
        private System.Windows.Forms.RadioButton rbFinish;
        private System.Windows.Forms.RadioButton rbNew;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.Button bExcels;
    }
}