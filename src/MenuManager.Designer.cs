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
            this.bBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.lFIO = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bNewOrder = new System.Windows.Forms.Button();
            this.bOrders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bProducts
            // 
            this.bProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.bProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bProducts.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bProducts.Location = new System.Drawing.Point(12, 160);
            this.bProducts.Name = "bProducts";
            this.bProducts.Size = new System.Drawing.Size(725, 50);
            this.bProducts.TabIndex = 0;
            this.bProducts.Text = "Просмотр товаров";
            this.bProducts.UseVisualStyleBackColor = false;
            this.bProducts.Click += new System.EventHandler(this.bProducts_Click);
            // 
            // bBack
            // 
            this.bBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBack.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bBack.Location = new System.Drawing.Point(13, 388);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(724, 50);
            this.bBack.TabIndex = 5;
            this.bBack.Text = "Выйти из учетной записи";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 17.25F);
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Пользователь:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 17.25F);
            this.label2.Location = new System.Drawing.Point(7, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Доступ: Менеджер";
            // 
            // lFIO
            // 
            this.lFIO.AutoSize = true;
            this.lFIO.Font = new System.Drawing.Font("Comic Sans MS", 17.25F);
            this.lFIO.Location = new System.Drawing.Point(7, 69);
            this.lFIO.Name = "lFIO";
            this.lFIO.Size = new System.Drawing.Size(64, 31);
            this.lFIO.TabIndex = 9;
            this.lFIO.Text = "ФИО";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BeautyGlory.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(627, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // bNewOrder
            // 
            this.bNewOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.bNewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNewOrder.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bNewOrder.Location = new System.Drawing.Point(12, 224);
            this.bNewOrder.Name = "bNewOrder";
            this.bNewOrder.Size = new System.Drawing.Size(725, 50);
            this.bNewOrder.TabIndex = 0;
            this.bNewOrder.Text = "Корзина";
            this.bNewOrder.UseVisualStyleBackColor = false;
            this.bNewOrder.Click += new System.EventHandler(this.bNewOrder_Click);
            // 
            // bOrders
            // 
            this.bOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.bOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOrders.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bOrders.Location = new System.Drawing.Point(13, 291);
            this.bOrders.Name = "bOrders";
            this.bOrders.Size = new System.Drawing.Size(725, 50);
            this.bOrders.TabIndex = 0;
            this.bOrders.Text = "Учет заказов";
            this.bOrders.UseVisualStyleBackColor = false;
            this.bOrders.Click += new System.EventHandler(this.bOrders_Click);
            // 
            // MenuManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(749, 450);
            this.Controls.Add(this.lFIO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.bOrders);
            this.Controls.Add(this.bNewOrder);
            this.Controls.Add(this.bProducts);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.Name = "MenuManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню менеджера | ООО \"Красотка\"";
            this.Load += new System.EventHandler(this.MenuManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bProducts;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lFIO;
        private System.Windows.Forms.Button bNewOrder;
        private System.Windows.Forms.Button bOrders;
    }
}