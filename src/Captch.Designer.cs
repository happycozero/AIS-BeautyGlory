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
            this.bReload = new System.Windows.Forms.Button();
            this.lCaptch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbCaptch
            // 
            this.tbCaptch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.tbCaptch.Location = new System.Drawing.Point(17, 158);
            this.tbCaptch.Name = "tbCaptch";
            this.tbCaptch.Size = new System.Drawing.Size(303, 32);
            this.tbCaptch.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите текст с картинки:";
            // 
            // bInput
            // 
            this.bInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.bInput.Location = new System.Drawing.Point(17, 208);
            this.bInput.Name = "bInput";
            this.bInput.Size = new System.Drawing.Size(365, 38);
            this.bInput.TabIndex = 4;
            this.bInput.Text = "Ввести";
            this.bInput.UseVisualStyleBackColor = true;
            this.bInput.Click += new System.EventHandler(this.bInput_Click);
            // 
            // bReload
            // 
            this.bReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.bReload.Location = new System.Drawing.Point(326, 153);
            this.bReload.Name = "bReload";
            this.bReload.Size = new System.Drawing.Size(53, 42);
            this.bReload.TabIndex = 2;
            this.bReload.UseVisualStyleBackColor = true;
            this.bReload.Click += new System.EventHandler(this.bReload_Click);
            // 
            // lCaptch
            // 
            this.lCaptch.AutoSize = true;
            this.lCaptch.Font = new System.Drawing.Font("Microsoft Sans Serif", 55.25F);
            this.lCaptch.ForeColor = System.Drawing.Color.DarkCyan;
            this.lCaptch.Location = new System.Drawing.Point(12, 24);
            this.lCaptch.Name = "lCaptch";
            this.lCaptch.Size = new System.Drawing.Size(353, 85);
            this.lCaptch.TabIndex = 0;
            this.lCaptch.Text = "Captch78";
            // 
            // Captch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(389, 258);
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