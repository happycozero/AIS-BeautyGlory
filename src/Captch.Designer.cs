namespace BeautyGlory
{
    partial class Captch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Captch));
            this.tbCaptch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bInput = new System.Windows.Forms.Button();
            this.lCaptch = new System.Windows.Forms.Label();
            this.bReload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCaptch
            // 
            this.tbCaptch.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCaptch.Location = new System.Drawing.Point(30, 170);
            this.tbCaptch.Name = "tbCaptch";
            this.tbCaptch.Size = new System.Drawing.Size(298, 37);
            this.tbCaptch.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите текст с картинки:";
            // 
            // bInput
            // 
            this.bInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.bInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bInput.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bInput.Location = new System.Drawing.Point(30, 221);
            this.bInput.Name = "bInput";
            this.bInput.Size = new System.Drawing.Size(383, 38);
            this.bInput.TabIndex = 4;
            this.bInput.Text = "Ввести капчу";
            this.bInput.UseVisualStyleBackColor = false;
            this.bInput.Click += new System.EventHandler(this.bInput_Click);
            // 
            // lCaptch
            // 
            this.lCaptch.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCaptch.ForeColor = System.Drawing.Color.Lime;
            this.lCaptch.Image = global::BeautyGlory.Properties.Resources.captch;
            this.lCaptch.Location = new System.Drawing.Point(69, 12);
            this.lCaptch.Name = "lCaptch";
            this.lCaptch.Size = new System.Drawing.Size(296, 105);
            this.lCaptch.TabIndex = 6;
            this.lCaptch.Text = "captch";
            this.lCaptch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bReload
            // 
            this.bReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bReload.Image = global::BeautyGlory.Properties.Resources.refresh;
            this.bReload.Location = new System.Drawing.Point(335, 145);
            this.bReload.Name = "bReload";
            this.bReload.Size = new System.Drawing.Size(78, 62);
            this.bReload.TabIndex = 5;
            // 
            // Captch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(449, 284);
            this.Controls.Add(this.bInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bReload);
            this.Controls.Add(this.tbCaptch);
            this.Controls.Add(this.lCaptch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Captch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Captch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Captch_FormClosing);
            this.Load += new System.EventHandler(this.Captch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lCaptch;
        private System.Windows.Forms.TextBox tbCaptch;
        private System.Windows.Forms.Button bReload;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bInput;
    }
}