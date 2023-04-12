namespace BeautyGlory
{
    partial class Spec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spec));
            this.tabDB = new System.Windows.Forms.TabControl();
            this.tabImport = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.cbrazdel = new System.Windows.Forms.ComboBox();
            this.cmImport = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbImport = new System.Windows.Forms.TextBox();
            this.bFile = new System.Windows.Forms.Button();
            this.bImport = new System.Windows.Forms.Button();
            this.tabExport = new System.Windows.Forms.TabPage();
            this.cbrazdel2 = new System.Windows.Forms.ComboBox();
            this.cmExport = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbExport = new System.Windows.Forms.TextBox();
            this.bExport = new System.Windows.Forms.Button();
            this.bPath = new System.Windows.Forms.Button();
            this.bBack = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
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
            this.tabDB.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabDB.Location = new System.Drawing.Point(16, 15);
            this.tabDB.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tabDB.Multiline = true;
            this.tabDB.Name = "tabDB";
            this.tabDB.SelectedIndex = 0;
            this.tabDB.Size = new System.Drawing.Size(364, 380);
            this.tabDB.TabIndex = 16;
            // 
            // tabImport
            // 
            this.tabImport.Controls.Add(this.label3);
            this.tabImport.Controls.Add(this.cbrazdel);
            this.tabImport.Controls.Add(this.cmImport);
            this.tabImport.Controls.Add(this.label1);
            this.tabImport.Controls.Add(this.tbImport);
            this.tabImport.Controls.Add(this.bFile);
            this.tabImport.Controls.Add(this.bImport);
            this.tabImport.Location = new System.Drawing.Point(4, 38);
            this.tabImport.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tabImport.Name = "tabImport";
            this.tabImport.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tabImport.Size = new System.Drawing.Size(356, 338);
            this.tabImport.TabIndex = 0;
            this.tabImport.Text = "Импорт БД";
            this.tabImport.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 29);
            this.label3.TabIndex = 29;
            this.label3.Text = "Выберите разделитель:";
            // 
            // cbrazdel
            // 
            this.cbrazdel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbrazdel.FormattingEnabled = true;
            this.cbrazdel.Items.AddRange(new object[] {
            ";",
            ",",
            "|"});
            this.cbrazdel.Location = new System.Drawing.Point(48, 123);
            this.cbrazdel.Name = "cbrazdel";
            this.cbrazdel.Size = new System.Drawing.Size(258, 37);
            this.cbrazdel.TabIndex = 28;
            // 
            // cmImport
            // 
            this.cmImport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmImport.FormattingEnabled = true;
            this.cmImport.Location = new System.Drawing.Point(48, 49);
            this.cmImport.Name = "cmImport";
            this.cmImport.Size = new System.Drawing.Size(258, 37);
            this.cmImport.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "Выберите таблицу:";
            // 
            // tbImport
            // 
            this.tbImport.Location = new System.Drawing.Point(48, 238);
            this.tbImport.Name = "tbImport";
            this.tbImport.ReadOnly = true;
            this.tbImport.Size = new System.Drawing.Size(258, 37);
            this.tbImport.TabIndex = 25;
            // 
            // bFile
            // 
            this.bFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.bFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bFile.Location = new System.Drawing.Point(47, 192);
            this.bFile.Name = "bFile";
            this.bFile.Size = new System.Drawing.Size(259, 40);
            this.bFile.TabIndex = 18;
            this.bFile.Text = "Выберите файл";
            this.bFile.UseVisualStyleBackColor = false;
            this.bFile.Click += new System.EventHandler(this.bFile_Click);
            // 
            // bImport
            // 
            this.bImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.bImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bImport.Location = new System.Drawing.Point(47, 290);
            this.bImport.Name = "bImport";
            this.bImport.Size = new System.Drawing.Size(259, 40);
            this.bImport.TabIndex = 17;
            this.bImport.Text = "Импорт";
            this.bImport.UseVisualStyleBackColor = false;
            this.bImport.Click += new System.EventHandler(this.bImport_Click);
            // 
            // tabExport
            // 
            this.tabExport.Controls.Add(this.cbrazdel2);
            this.tabExport.Controls.Add(this.cmExport);
            this.tabExport.Controls.Add(this.label4);
            this.tabExport.Controls.Add(this.label2);
            this.tabExport.Controls.Add(this.tbExport);
            this.tabExport.Controls.Add(this.bExport);
            this.tabExport.Controls.Add(this.bPath);
            this.tabExport.Location = new System.Drawing.Point(4, 38);
            this.tabExport.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tabExport.Name = "tabExport";
            this.tabExport.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tabExport.Size = new System.Drawing.Size(356, 338);
            this.tabExport.TabIndex = 1;
            this.tabExport.Text = "Экспорт БД";
            this.tabExport.UseVisualStyleBackColor = true;
            // 
            // cbrazdel2
            // 
            this.cbrazdel2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbrazdel2.FormattingEnabled = true;
            this.cbrazdel2.Items.AddRange(new object[] {
            ";",
            ",",
            "|"});
            this.cbrazdel2.Location = new System.Drawing.Point(48, 123);
            this.cbrazdel2.Name = "cbrazdel2";
            this.cbrazdel2.Size = new System.Drawing.Size(257, 37);
            this.cbrazdel2.TabIndex = 30;
            // 
            // cmExport
            // 
            this.cmExport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmExport.FormattingEnabled = true;
            this.cmExport.Location = new System.Drawing.Point(48, 49);
            this.cmExport.Name = "cmExport";
            this.cmExport.Size = new System.Drawing.Size(257, 37);
            this.cmExport.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 29);
            this.label4.TabIndex = 28;
            this.label4.Text = "Выберите разделитель:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 29);
            this.label2.TabIndex = 28;
            this.label2.Text = "Выберите таблицу:";
            // 
            // tbExport
            // 
            this.tbExport.Location = new System.Drawing.Point(48, 238);
            this.tbExport.Name = "tbExport";
            this.tbExport.ReadOnly = true;
            this.tbExport.Size = new System.Drawing.Size(258, 37);
            this.tbExport.TabIndex = 24;
            // 
            // bExport
            // 
            this.bExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.bExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExport.Location = new System.Drawing.Point(47, 290);
            this.bExport.Name = "bExport";
            this.bExport.Size = new System.Drawing.Size(259, 40);
            this.bExport.TabIndex = 22;
            this.bExport.Text = "Экспорт";
            this.bExport.UseVisualStyleBackColor = false;
            this.bExport.Click += new System.EventHandler(this.bExport_Click);
            // 
            // bPath
            // 
            this.bPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.bPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPath.Location = new System.Drawing.Point(47, 192);
            this.bPath.Name = "bPath";
            this.bPath.Size = new System.Drawing.Size(259, 40);
            this.bPath.TabIndex = 21;
            this.bPath.Text = "Выберите путь";
            this.bPath.UseVisualStyleBackColor = false;
            this.bPath.Click += new System.EventHandler(this.bPath_Click);
            // 
            // bBack
            // 
            this.bBack.BackColor = System.Drawing.Color.White;
            this.bBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBack.Location = new System.Drawing.Point(16, 447);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(360, 40);
            this.bBack.TabIndex = 24;
            this.bBack.Text = "Назад в меню";
            this.bBack.UseVisualStyleBackColor = false;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Spec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 499);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.tabDB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.Name = "Spec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Специальные возможности | ООО \"Красотка\"";
            this.Load += new System.EventHandler(this.Spec_Load);
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
        private System.Windows.Forms.TextBox tbExport;
        private System.Windows.Forms.Button bExport;
        private System.Windows.Forms.Button bPath;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.ComboBox cmImport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmExport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbrazdel;
        private System.Windows.Forms.ComboBox cbrazdel2;
        private System.Windows.Forms.Label label4;
    }
}