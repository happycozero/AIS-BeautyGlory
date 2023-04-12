namespace BeautyGlory
{
    partial class MenuManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuManager));
            this.bProducts = new System.Windows.Forms.Button();
            this.bOrder = new System.Windows.Forms.Button();
            this.bSpec = new System.Windows.Forms.Button();
            this.bBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.lFIO = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bProducts
            // 
            this.bProducts.Location = new System.Drawing.Point(12, 129);
            this.bProducts.Name = "bProducts";
            this.bProducts.Size = new System.Drawing.Size(297, 50);
            this.bProducts.TabIndex = 0;
            this.bProducts.Text = "Просмотр товаров";
            this.bProducts.UseVisualStyleBackColor = true;
            this.bProducts.Click += new System.EventHandler(this.bProducts_Click);
            // 
            // bOrder
            // 
            this.bOrder.Location = new System.Drawing.Point(12, 241);
            this.bOrder.Name = "bOrder";
            this.bOrder.Size = new System.Drawing.Size(297, 50);
            this.bOrder.TabIndex = 3;
            this.bOrder.Text = "Учет заказов";
            this.bOrder.UseVisualStyleBackColor = true;
            this.bOrder.Click += new System.EventHandler(this.bOrder_Click);
            // 
            // bSpec
            // 
            this.bSpec.Location = new System.Drawing.Point(12, 185);
            this.bSpec.Name = "bSpec";
            this.bSpec.Size = new System.Drawing.Size(297, 50);
            this.bSpec.TabIndex = 4;
            this.bSpec.Text = "Новый заказ";
            this.bSpec.UseVisualStyleBackColor = true;
            this.bSpec.Click += new System.EventHandler(this.bSpec_Click);
            // 
            // bBack
            // 
            this.bBack.Location = new System.Drawing.Point(81, 375);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(479, 50);
            this.bBack.TabIndex = 5;
            this.bBack.Text = "Выйти из учетной записи";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Пользователь:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Доступ: Менеджер";
            // 
            // lFIO
            // 
            this.lFIO.AutoSize = true;
            this.lFIO.Location = new System.Drawing.Point(166, 22);
            this.lFIO.Name = "lFIO";
            this.lFIO.Size = new System.Drawing.Size(64, 26);
            this.lFIO.TabIndex = 9;
            this.lFIO.Text = "ФИО";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BeautyGlory.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(344, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // MenuManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(652, 450);
            this.Controls.Add(this.lFIO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.bSpec);
            this.Controls.Add(this.bOrder);
            this.Controls.Add(this.bProducts);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.Name = "MenuManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.MenuManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bProducts;
        private System.Windows.Forms.Button bOrder;
        private System.Windows.Forms.Button bSpec;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lFIO;
    }
}