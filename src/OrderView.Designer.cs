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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderView));
            this.bBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lDateD = new System.Windows.Forms.Label();
            this.lFIO = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmPP = new System.Windows.Forms.ComboBox();
            this.lDateDP = new System.Windows.Forms.Label();
            this.lPrice = new System.Windows.Forms.Label();
            this.lCount = new System.Windows.Forms.Label();
            this.lDate = new System.Windows.Forms.Label();
            this.bAddOrder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bBack
            // 
            this.bBack.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bBack.Location = new System.Drawing.Point(375, 364);
            this.bBack.Margin = new System.Windows.Forms.Padding(4);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(306, 48);
            this.bBack.TabIndex = 23;
            this.bBack.Text = "Закрыть";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lDateD);
            this.groupBox1.Controls.Add(this.lFIO);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmPP);
            this.groupBox1.Controls.Add(this.lDateDP);
            this.groupBox1.Controls.Add(this.lPrice);
            this.groupBox1.Controls.Add(this.lCount);
            this.groupBox1.Controls.Add(this.lDate);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(667, 341);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Заказ №";
            // 
            // lDateD
            // 
            this.lDateD.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lDateD.Location = new System.Drawing.Point(236, 169);
            this.lDateD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDateD.Name = "lDateD";
            this.lDateD.Size = new System.Drawing.Size(222, 40);
            this.lDateD.TabIndex = 46;
            this.lDateD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lFIO
            // 
            this.lFIO.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lFIO.Location = new System.Drawing.Point(8, 30);
            this.lFIO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lFIO.Name = "lFIO";
            this.lFIO.Size = new System.Drawing.Size(496, 40);
            this.lFIO.TabIndex = 45;
            this.lFIO.Text = "Date";
            this.lFIO.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 40);
            this.label1.TabIndex = 44;
            this.label1.Text = "Выберите пункт выдачи: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmPP
            // 
            this.cmPP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmPP.FormattingEnabled = true;
            this.cmPP.Location = new System.Drawing.Point(13, 129);
            this.cmPP.Name = "cmPP";
            this.cmPP.Size = new System.Drawing.Size(646, 37);
            this.cmPP.TabIndex = 43;
            this.cmPP.SelectedIndexChanged += new System.EventHandler(this.cmPP_SelectedIndexChanged);
            // 
            // lDateDP
            // 
            this.lDateDP.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lDateDP.Location = new System.Drawing.Point(8, 169);
            this.lDateDP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDateDP.Name = "lDateDP";
            this.lDateDP.Size = new System.Drawing.Size(231, 40);
            this.lDateDP.TabIndex = 42;
            this.lDateDP.Text = "Дата доставки заказа:";
            this.lDateDP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lPrice
            // 
            this.lPrice.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lPrice.Location = new System.Drawing.Point(8, 209);
            this.lPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPrice.Name = "lPrice";
            this.lPrice.Size = new System.Drawing.Size(651, 40);
            this.lPrice.TabIndex = 36;
            this.lPrice.Text = "Итоговая стоимость:";
            this.lPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lCount
            // 
            this.lCount.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCount.Location = new System.Drawing.Point(8, 249);
            this.lCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCount.Name = "lCount";
            this.lCount.Size = new System.Drawing.Size(651, 40);
            this.lCount.TabIndex = 34;
            this.lCount.Text = "Количество товара: ";
            this.lCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lDate
            // 
            this.lDate.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lDate.Location = new System.Drawing.Point(512, 34);
            this.lDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(147, 40);
            this.lDate.TabIndex = 32;
            this.lDate.Text = "Date";
            this.lDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bAddOrder
            // 
            this.bAddOrder.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAddOrder.Location = new System.Drawing.Point(14, 364);
            this.bAddOrder.Margin = new System.Windows.Forms.Padding(4);
            this.bAddOrder.Name = "bAddOrder";
            this.bAddOrder.Size = new System.Drawing.Size(306, 48);
            this.bAddOrder.TabIndex = 25;
            this.bAddOrder.Text = "Оформить";
            this.bAddOrder.UseVisualStyleBackColor = true;
            this.bAddOrder.Click += new System.EventHandler(this.bAddOrder_Click);
            // 
            // OrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(696, 439);
            this.Controls.Add(this.bAddOrder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bBack);
            this.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.Name = "OrderView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оформление заказа | ООО \"Красотка\"";
            this.Load += new System.EventHandler(this.OrderView_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.Label lPrice;
        private System.Windows.Forms.Label lCount;
        private System.Windows.Forms.Button bAddOrder;
        private System.Windows.Forms.Label lDateDP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmPP;
        private System.Windows.Forms.Label lFIO;
        private System.Windows.Forms.Label lDateD;
    }
}