namespace BeautyGlory
{
    partial class Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bEdit = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bDel = new System.Windows.Forms.Button();
            this.bBack = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lCount = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbQuantly = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmCategory = new System.Windows.Forms.ComboBox();
            this.bPhoto = new System.Windows.Forms.Button();
            this.folderPhoto = new System.Windows.Forms.FolderBrowserDialog();
            this.openPhoto = new System.Windows.Forms.OpenFileDialog();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDisc = new System.Windows.Forms.TextBox();
            this.tbDiscMax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmMan = new System.Windows.Forms.ComboBox();
            this.cmSupplier = new System.Windows.Forms.ComboBox();
            this.tbPhoto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmUnit = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDesc
            // 
            this.tbDesc.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDesc.Location = new System.Drawing.Point(134, 18);
            this.tbDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDesc.Multiline = true;
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(248, 242);
            this.tbDesc.TabIndex = 0;
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.AllowUserToResizeColumns = false;
            this.dgvProduct.AllowUserToResizeRows = false;
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProduct.EnableHeadersVisualStyles = false;
            this.dgvProduct.GridColor = System.Drawing.Color.Gray;
            this.dgvProduct.Location = new System.Drawing.Point(5, 313);
            this.dgvProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvProduct.MultiSelect = false;
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProduct.RowHeadersVisible = false;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(1409, 392);
            this.dgvProduct.TabIndex = 1;
            this.dgvProduct.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProduct_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Описание:";
            // 
            // bEdit
            // 
            this.bEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.bEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEdit.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bEdit.Location = new System.Drawing.Point(218, 760);
            this.bEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(207, 44);
            this.bEdit.TabIndex = 3;
            this.bEdit.Text = "Редактировать";
            this.bEdit.UseVisualStyleBackColor = false;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.bAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAdd.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAdd.Location = new System.Drawing.Point(5, 760);
            this.bAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(207, 44);
            this.bAdd.TabIndex = 4;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bDel
            // 
            this.bDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.bDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bDel.Location = new System.Drawing.Point(431, 760);
            this.bDel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(207, 44);
            this.bDel.TabIndex = 5;
            this.bDel.Text = "Удалить";
            this.bDel.UseVisualStyleBackColor = false;
            this.bDel.Click += new System.EventHandler(this.bDel_Click);
            // 
            // bBack
            // 
            this.bBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBack.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bBack.Location = new System.Drawing.Point(1246, 760);
            this.bBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(169, 44);
            this.bBack.TabIndex = 6;
            this.bBack.Text = "Назад в меню";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(396, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Наименование:";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(402, 45);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(298, 37);
            this.tbName.TabIndex = 11;
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // lCount
            // 
            this.lCount.AutoSize = true;
            this.lCount.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCount.Location = new System.Drawing.Point(0, 711);
            this.lCount.Name = "lCount";
            this.lCount.Size = new System.Drawing.Size(231, 29);
            this.lCount.TabIndex = 12;
            this.lCount.Text = "Количество записей: ";
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPrice.Location = new System.Drawing.Point(732, 128);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPrice.MaxLength = 11;
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(228, 37);
            this.tbPrice.TabIndex = 14;
            this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrice_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(727, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "Цена:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(396, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "Производитель:";
            // 
            // tbQuantly
            // 
            this.tbQuantly.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbQuantly.Location = new System.Drawing.Point(732, 223);
            this.tbQuantly.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbQuantly.MaxLength = 6;
            this.tbQuantly.Name = "tbQuantly";
            this.tbQuantly.Size = new System.Drawing.Size(228, 37);
            this.tbQuantly.TabIndex = 18;
            this.tbQuantly.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQuantly_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(727, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 29);
            this.label8.TabIndex = 17;
            this.label8.Text = "Количество:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(396, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 29);
            this.label9.TabIndex = 19;
            this.label9.Text = "Категория:";
            // 
            // cmCategory
            // 
            this.cmCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmCategory.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmCategory.FormattingEnabled = true;
            this.cmCategory.Location = new System.Drawing.Point(402, 223);
            this.cmCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmCategory.Name = "cmCategory";
            this.cmCategory.Size = new System.Drawing.Size(298, 37);
            this.cmCategory.TabIndex = 20;
            // 
            // bPhoto
            // 
            this.bPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPhoto.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bPhoto.Location = new System.Drawing.Point(1208, 216);
            this.bPhoto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bPhoto.Name = "bPhoto";
            this.bPhoto.Size = new System.Drawing.Size(207, 40);
            this.bPhoto.TabIndex = 23;
            this.bPhoto.Text = "Выбрать фото";
            this.bPhoto.UseVisualStyleBackColor = true;
            this.bPhoto.Click += new System.EventHandler(this.bPhoto_Click);
            // 
            // pbPhoto
            // 
            this.pbPhoto.ErrorImage = global::BeautyGlory.Properties.Resources.img_holder;
            this.pbPhoto.Location = new System.Drawing.Point(1207, 18);
            this.pbPhoto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(207, 190);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPhoto.TabIndex = 21;
            this.pbPhoto.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(727, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 29);
            this.label2.TabIndex = 26;
            this.label2.Text = "Поставщик:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1000, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 29);
            this.label3.TabIndex = 28;
            this.label3.Text = "Текущая скидка:";
            // 
            // tbDisc
            // 
            this.tbDisc.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDisc.Location = new System.Drawing.Point(1008, 48);
            this.tbDisc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDisc.MaxLength = 3;
            this.tbDisc.Name = "tbDisc";
            this.tbDisc.Size = new System.Drawing.Size(72, 37);
            this.tbDisc.TabIndex = 29;
            this.tbDisc.TextChanged += new System.EventHandler(this.tbDisc_TextChanged);
            this.tbDisc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQuantly_KeyPress);
            // 
            // tbDiscMax
            // 
            this.tbDiscMax.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDiscMax.Location = new System.Drawing.Point(1008, 128);
            this.tbDiscMax.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDiscMax.MaxLength = 3;
            this.tbDiscMax.Name = "tbDiscMax";
            this.tbDiscMax.Size = new System.Drawing.Size(72, 37);
            this.tbDiscMax.TabIndex = 31;
            this.tbDiscMax.TextChanged += new System.EventHandler(this.tbDiscMax_TextChanged);
            this.tbDiscMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQuantly_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(1002, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 29);
            this.label5.TabIndex = 30;
            this.label5.Text = "Макс. скидка:";
            // 
            // cmMan
            // 
            this.cmMan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmMan.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmMan.FormattingEnabled = true;
            this.cmMan.Location = new System.Drawing.Point(400, 128);
            this.cmMan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmMan.Name = "cmMan";
            this.cmMan.Size = new System.Drawing.Size(298, 37);
            this.cmMan.TabIndex = 32;
            // 
            // cmSupplier
            // 
            this.cmSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmSupplier.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmSupplier.FormattingEnabled = true;
            this.cmSupplier.Location = new System.Drawing.Point(732, 45);
            this.cmSupplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmSupplier.Name = "cmSupplier";
            this.cmSupplier.Size = new System.Drawing.Size(228, 37);
            this.cmSupplier.TabIndex = 33;
            // 
            // tbPhoto
            // 
            this.tbPhoto.Location = new System.Drawing.Point(644, 764);
            this.tbPhoto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPhoto.Multiline = true;
            this.tbPhoto.Name = "tbPhoto";
            this.tbPhoto.Size = new System.Drawing.Size(178, 40);
            this.tbPhoto.TabIndex = 34;
            this.tbPhoto.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(1080, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 29);
            this.label10.TabIndex = 35;
            this.label10.Text = "%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(1080, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 29);
            this.label11.TabIndex = 36;
            this.label11.Text = "%";
            // 
            // cmUnit
            // 
            this.cmUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmUnit.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmUnit.FormattingEnabled = true;
            this.cmUnit.Location = new System.Drawing.Point(1008, 224);
            this.cmUnit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmUnit.Name = "cmUnit";
            this.cmUnit.Size = new System.Drawing.Size(71, 37);
            this.cmUnit.TabIndex = 37;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(960, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 29);
            this.label12.TabIndex = 38;
            this.label12.Text = "р.";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(1002, 192);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 29);
            this.label13.TabIndex = 39;
            this.label13.Text = "Ед. изм.";
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1424, 817);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmUnit);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbPhoto);
            this.Controls.Add(this.cmSupplier);
            this.Controls.Add(this.cmMan);
            this.Controls.Add(this.tbDiscMax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbDisc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bPhoto);
            this.Controls.Add(this.pbPhoto);
            this.Controls.Add(this.cmCategory);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbQuantly);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lCount);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.bDel);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.tbDesc);
            this.Font = new System.Drawing.Font("Comic Sans MS", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товары | ООО \"Красотка\"";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bDel;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lCount;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbQuantly;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmCategory;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.Button bPhoto;
        private System.Windows.Forms.FolderBrowserDialog folderPhoto;
        private System.Windows.Forms.OpenFileDialog openPhoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDisc;
        private System.Windows.Forms.TextBox tbDiscMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmMan;
        private System.Windows.Forms.ComboBox cmSupplier;
        private System.Windows.Forms.TextBox tbPhoto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmUnit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}