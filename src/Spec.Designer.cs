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
            this.cmImport = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbImport = new System.Windows.Forms.TextBox();
            this.bFile = new System.Windows.Forms.Button();
            this.bImport = new System.Windows.Forms.Button();
            this.tabExport = new System.Windows.Forms.TabPage();
            this.cmExport = new System.Windows.Forms.ComboBox();
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
            this.tabDB.Location = new System.Drawing.Point(16, 15);
            this.tabDB.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tabDB.Name = "tabDB";
            this.tabDB.SelectedIndex = 0;
            this.tabDB.Size = new System.Drawing.Size(287, 315);
            this.tabDB.TabIndex = 16;
            // 
            // tabImport
            // 
            this.tabImport.Controls.Add(this.cmImport);
            this.tabImport.Controls.Add(this.label1);
            this.tabImport.Controls.Add(this.tbImport);
            this.tabImport.Controls.Add(this.bFile);
            this.tabImport.Controls.Add(this.bImport);
            this.tabImport.Location = new System.Drawing.Point(4, 35);
            this.tabImport.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tabImport.Name = "tabImport";
            this.tabImport.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tabImport.Size = new System.Drawing.Size(279, 276);
            this.tabImport.TabIndex = 0;
            this.tabImport.Text = "Импорт БД";
            this.tabImport.UseVisualStyleBackColor = true;
            // 
            // cmImport
            // 
            this.cmImport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmImport.FormattingEnabled = true;
            this.cmImport.Location = new System.Drawing.Point(10, 57);
            this.cmImport.Name = "cmImport";
            this.cmImport.Size = new System.Drawing.Size(259, 34);
            this.cmImport.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 26);
            this.label1.TabIndex = 26;
            this.label1.Text = "Выберите таблицу:";
            // 
            // tbImport
            // 
            this.tbImport.Location = new System.Drawing.Point(10, 168);
            this.tbImport.Name = "tbImport";
            this.tbImport.ReadOnly = true;
            this.tbImport.Size = new System.Drawing.Size(259, 32);
            this.tbImport.TabIndex = 25;
            // 
            // bFile
            // 
            this.bFile.Location = new System.Drawing.Point(10, 122);
            this.bFile.Name = "bFile";
            this.bFile.Size = new System.Drawing.Size(259, 40);
            this.bFile.TabIndex = 18;
            this.bFile.Text = "Выберите файл";
            this.bFile.UseVisualStyleBackColor = true;
            this.bFile.Click += new System.EventHandler(this.bFile_Click);
            // 
            // bImport
            // 
            this.bImport.Location = new System.Drawing.Point(10, 227);
            this.bImport.Name = "bImport";
            this.bImport.Size = new System.Drawing.Size(259, 40);
            this.bImport.TabIndex = 17;
            this.bImport.Text = "Импорт";
            this.bImport.UseVisualStyleBackColor = true;
            this.bImport.Click += new System.EventHandler(this.bImport_Click);
            // 
            // tabExport
            // 
            this.tabExport.Controls.Add(this.cmExport);
            this.tabExport.Controls.Add(this.label2);
            this.tabExport.Controls.Add(this.tbExport);
            this.tabExport.Controls.Add(this.bExport);
            this.tabExport.Controls.Add(this.bPath);
            this.tabExport.Location = new System.Drawing.Point(4, 35);
            this.tabExport.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tabExport.Name = "tabExport";
            this.tabExport.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tabExport.Size = new System.Drawing.Size(279, 276);
            this.tabExport.TabIndex = 1;
            this.tabExport.Text = "Экспорт БД";
            this.tabExport.UseVisualStyleBackColor = true;
            // 
            // cmExport
            // 
            this.cmExport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmExport.FormattingEnabled = true;
            this.cmExport.Location = new System.Drawing.Point(10, 57);
            this.cmExport.Name = "cmExport";
            this.cmExport.Size = new System.Drawing.Size(259, 34);
            this.cmExport.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 26);
            this.label2.TabIndex = 28;
            this.label2.Text = "Выберите таблицу:";
            // 
            // tbExport
            // 
            this.tbExport.Location = new System.Drawing.Point(10, 168);
            this.tbExport.Name = "tbExport";
            this.tbExport.ReadOnly = true;
            this.tbExport.Size = new System.Drawing.Size(259, 32);
            this.tbExport.TabIndex = 24;
            // 
            // bExport
            // 
            this.bExport.Location = new System.Drawing.Point(10, 227);
            this.bExport.Name = "bExport";
            this.bExport.Size = new System.Drawing.Size(259, 40);
            this.bExport.TabIndex = 22;
            this.bExport.Text = "Экспорт";
            this.bExport.UseVisualStyleBackColor = true;
            this.bExport.Click += new System.EventHandler(this.bExport_Click);
            // 
            // bPath
            // 
            this.bPath.Location = new System.Drawing.Point(10, 122);
            this.bPath.Name = "bPath";
            this.bPath.Size = new System.Drawing.Size(259, 40);
            this.bPath.TabIndex = 21;
            this.bPath.Text = "Выберите путь";
            this.bPath.UseVisualStyleBackColor = true;
            this.bPath.Click += new System.EventHandler(this.bPath_Click);
            // 
            // bBack
            // 
            this.bBack.Location = new System.Drawing.Point(24, 353);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(279, 40);
            this.bBack.TabIndex = 24;
            this.bBack.Text = "Назад в меню";
            this.bBack.UseVisualStyleBackColor = true;
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
            this.ClientSize = new System.Drawing.Size(327, 405);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.tabDB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.Name = "Spec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спец.возможности";
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
    }
}