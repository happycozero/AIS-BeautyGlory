namespace BeautyGlory
{
    partial class Special
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Special));
            this.tabDB = new System.Windows.Forms.TabControl();
            this.tabImport = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.cm2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmImport = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbImport = new System.Windows.Forms.TextBox();
            this.bFile = new System.Windows.Forms.Button();
            this.bImport = new System.Windows.Forms.Button();
            this.tabExport = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.cm1 = new System.Windows.Forms.ComboBox();
            this.cmExport = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbExport = new System.Windows.Forms.TextBox();
            this.bExport = new System.Windows.Forms.Button();
            this.bPath = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bBack = new System.Windows.Forms.Button();
            this.tabDB.SuspendLayout();
            this.tabImport.SuspendLayout();
            this.tabExport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDB
            // 
            this.tabDB.Controls.Add(this.tabImport);
            this.tabDB.Controls.Add(this.tabExport);
            this.tabDB.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabDB.Location = new System.Drawing.Point(45, 16);
            this.tabDB.Margin = new System.Windows.Forms.Padding(7);
            this.tabDB.Name = "tabDB";
            this.tabDB.SelectedIndex = 0;
            this.tabDB.Size = new System.Drawing.Size(336, 429);
            this.tabDB.TabIndex = 16;
            // 
            // tabImport
            // 
            this.tabImport.Controls.Add(this.label4);
            this.tabImport.Controls.Add(this.cm2);
            this.tabImport.Controls.Add(this.textBox1);
            this.tabImport.Controls.Add(this.cmImport);
            this.tabImport.Controls.Add(this.label1);
            this.tabImport.Controls.Add(this.tbImport);
            this.tabImport.Controls.Add(this.bFile);
            this.tabImport.Controls.Add(this.bImport);
            this.tabImport.Location = new System.Drawing.Point(4, 42);
            this.tabImport.Margin = new System.Windows.Forms.Padding(7);
            this.tabImport.Name = "tabImport";
            this.tabImport.Padding = new System.Windows.Forms.Padding(7);
            this.tabImport.Size = new System.Drawing.Size(328, 383);
            this.tabImport.TabIndex = 0;
            this.tabImport.Text = "Импорт БД";
            this.tabImport.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 33);
            this.label4.TabIndex = 34;
            this.label4.Text = "Выберите разделитель:";
            // 
            // cm2
            // 
            this.cm2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cm2.FormattingEnabled = true;
            this.cm2.Items.AddRange(new object[] {
            "#",
            ";",
            ",",
            "|"});
            this.cm2.Location = new System.Drawing.Point(32, 223);
            this.cm2.Name = "cm2";
            this.cm2.Size = new System.Drawing.Size(257, 41);
            this.cm2.TabIndex = 33;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 223);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(259, 41);
            this.textBox1.TabIndex = 32;
            this.textBox1.Visible = false;
            // 
            // cmImport
            // 
            this.cmImport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmImport.FormattingEnabled = true;
            this.cmImport.Location = new System.Drawing.Point(32, 62);
            this.cmImport.Name = "cmImport";
            this.cmImport.Size = new System.Drawing.Size(259, 41);
            this.cmImport.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 33);
            this.label1.TabIndex = 26;
            this.label1.Text = "Выберите таблицу:";
            // 
            // tbImport
            // 
            this.tbImport.Location = new System.Drawing.Point(32, 223);
            this.tbImport.Name = "tbImport";
            this.tbImport.ReadOnly = true;
            this.tbImport.Size = new System.Drawing.Size(259, 41);
            this.tbImport.TabIndex = 25;
            this.tbImport.Visible = false;
            // 
            // bFile
            // 
            this.bFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.bFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bFile.Location = new System.Drawing.Point(32, 116);
            this.bFile.Name = "bFile";
            this.bFile.Size = new System.Drawing.Size(259, 45);
            this.bFile.TabIndex = 18;
            this.bFile.Text = "Выберите файл";
            this.bFile.UseVisualStyleBackColor = false;
            this.bFile.Click += new System.EventHandler(this.bFile_Click);
            // 
            // bImport
            // 
            this.bImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.bImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bImport.Location = new System.Drawing.Point(32, 321);
            this.bImport.Name = "bImport";
            this.bImport.Size = new System.Drawing.Size(259, 45);
            this.bImport.TabIndex = 17;
            this.bImport.Text = "Импорт";
            this.bImport.UseVisualStyleBackColor = false;
            this.bImport.Click += new System.EventHandler(this.bImport_Click);
            // 
            // tabExport
            // 
            this.tabExport.Controls.Add(this.label3);
            this.tabExport.Controls.Add(this.cm1);
            this.tabExport.Controls.Add(this.cmExport);
            this.tabExport.Controls.Add(this.label2);
            this.tabExport.Controls.Add(this.tbExport);
            this.tabExport.Controls.Add(this.bExport);
            this.tabExport.Controls.Add(this.bPath);
            this.tabExport.Location = new System.Drawing.Point(4, 42);
            this.tabExport.Margin = new System.Windows.Forms.Padding(7);
            this.tabExport.Name = "tabExport";
            this.tabExport.Padding = new System.Windows.Forms.Padding(7);
            this.tabExport.Size = new System.Drawing.Size(328, 383);
            this.tabExport.TabIndex = 1;
            this.tabExport.Text = "Экспорт БД";
            this.tabExport.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 33);
            this.label3.TabIndex = 31;
            this.label3.Text = "Выберите разделитель:";
            // 
            // cm1
            // 
            this.cm1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cm1.FormattingEnabled = true;
            this.cm1.Items.AddRange(new object[] {
            "#",
            ";",
            ",",
            "|"});
            this.cm1.Location = new System.Drawing.Point(32, 223);
            this.cm1.Name = "cm1";
            this.cm1.Size = new System.Drawing.Size(257, 41);
            this.cm1.TabIndex = 30;
            // 
            // cmExport
            // 
            this.cmExport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmExport.FormattingEnabled = true;
            this.cmExport.Location = new System.Drawing.Point(32, 62);
            this.cmExport.Name = "cmExport";
            this.cmExport.Size = new System.Drawing.Size(259, 41);
            this.cmExport.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 33);
            this.label2.TabIndex = 28;
            this.label2.Text = "Выберите таблицу:";
            // 
            // tbExport
            // 
            this.tbExport.Location = new System.Drawing.Point(32, 223);
            this.tbExport.Name = "tbExport";
            this.tbExport.ReadOnly = true;
            this.tbExport.Size = new System.Drawing.Size(256, 41);
            this.tbExport.TabIndex = 24;
            this.tbExport.Visible = false;
            // 
            // bExport
            // 
            this.bExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.bExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExport.Location = new System.Drawing.Point(32, 321);
            this.bExport.Name = "bExport";
            this.bExport.Size = new System.Drawing.Size(259, 45);
            this.bExport.TabIndex = 22;
            this.bExport.Text = "Экспорт";
            this.bExport.UseVisualStyleBackColor = false;
            this.bExport.Click += new System.EventHandler(this.bExport_Click);
            // 
            // bPath
            // 
            this.bPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.bPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPath.Location = new System.Drawing.Point(32, 116);
            this.bPath.Name = "bPath";
            this.bPath.Size = new System.Drawing.Size(259, 45);
            this.bPath.TabIndex = 21;
            this.bPath.Text = "Выберите путь";
            this.bPath.UseVisualStyleBackColor = false;
            this.bPath.Click += new System.EventHandler(this.bPath_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bBack
            // 
            this.bBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bBack.BackColor = System.Drawing.Color.White;
            this.bBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBack.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bBack.Location = new System.Drawing.Point(49, 460);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(332, 50);
            this.bBack.TabIndex = 17;
            this.bBack.Text = "В меню";
            this.bBack.UseVisualStyleBackColor = false;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // Special
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 522);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.tabDB);
            this.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "Special";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Специальные возможности | ООО \"Красотка\" ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabDB.ResumeLayout(false);
            this.tabImport.ResumeLayout(false);
            this.tabImport.PerformLayout();
            this.tabExport.ResumeLayout(false);
            this.tabExport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TabControl tabDB;
        private System.Windows.Forms.TabPage tabImport;
        private System.Windows.Forms.TextBox tbImport;
        private System.Windows.Forms.Button bFile;
        private System.Windows.Forms.Button bImport;
        private System.Windows.Forms.TabPage tabExport;
        private System.Windows.Forms.Button bExport;
        private System.Windows.Forms.ComboBox cmImport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmExport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox tbExport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cm1;
        private System.Windows.Forms.Button bPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cm2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bBack;
    }
}

