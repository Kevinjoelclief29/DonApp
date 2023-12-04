namespace Dondon_App
{
    partial class Menu
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
            this.DagingBtn = new System.Windows.Forms.Button();
            this.MinumBtn = new System.Windows.Forms.Button();
            this.PromoBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.AyamBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DagingBtn
            // 
            this.DagingBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.DagingBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DagingBtn.FlatAppearance.BorderSize = 0;
            this.DagingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DagingBtn.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DagingBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DagingBtn.Location = new System.Drawing.Point(131, 65);
            this.DagingBtn.Name = "DagingBtn";
            this.DagingBtn.Size = new System.Drawing.Size(89, 33);
            this.DagingBtn.TabIndex = 22;
            this.DagingBtn.Text = "Daging";
            this.DagingBtn.UseVisualStyleBackColor = false;
            this.DagingBtn.Click += new System.EventHandler(this.DagingBtn_Click);
            // 
            // MinumBtn
            // 
            this.MinumBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.MinumBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MinumBtn.FlatAppearance.BorderSize = 0;
            this.MinumBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinumBtn.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinumBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MinumBtn.Location = new System.Drawing.Point(243, 65);
            this.MinumBtn.Name = "MinumBtn";
            this.MinumBtn.Size = new System.Drawing.Size(89, 33);
            this.MinumBtn.TabIndex = 22;
            this.MinumBtn.Text = "Minum";
            this.MinumBtn.UseVisualStyleBackColor = false;
            this.MinumBtn.Click += new System.EventHandler(this.MinumBtn_Click);
            // 
            // PromoBtn
            // 
            this.PromoBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.PromoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PromoBtn.FlatAppearance.BorderSize = 0;
            this.PromoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PromoBtn.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromoBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PromoBtn.Location = new System.Drawing.Point(357, 65);
            this.PromoBtn.Name = "PromoBtn";
            this.PromoBtn.Size = new System.Drawing.Size(89, 33);
            this.PromoBtn.TabIndex = 22;
            this.PromoBtn.Text = "Promo";
            this.PromoBtn.UseVisualStyleBackColor = false;
            this.PromoBtn.Click += new System.EventHandler(this.PromoBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Menu";
            // 
            // Panel1
            // 
            this.Panel1.Location = new System.Drawing.Point(12, 125);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(434, 461);
            this.Panel1.TabIndex = 25;
            // 
            // AyamBtn
            // 
            this.AyamBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.AyamBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AyamBtn.FlatAppearance.BorderSize = 0;
            this.AyamBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AyamBtn.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AyamBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AyamBtn.Location = new System.Drawing.Point(17, 65);
            this.AyamBtn.Name = "AyamBtn";
            this.AyamBtn.Size = new System.Drawing.Size(89, 33);
            this.AyamBtn.TabIndex = 22;
            this.AyamBtn.Text = "Ayam";
            this.AyamBtn.UseVisualStyleBackColor = false;
            this.AyamBtn.Click += new System.EventHandler(this.AyamBtn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 598);
            this.Controls.Add(this.PromoBtn);
            this.Controls.Add(this.MinumBtn);
            this.Controls.Add(this.DagingBtn);
            this.Controls.Add(this.AyamBtn);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DagingBtn;
        private System.Windows.Forms.Button MinumBtn;
        private System.Windows.Forms.Button PromoBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Button AyamBtn;
    }
}