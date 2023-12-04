namespace Dondon_App
{
    partial class Home
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MeBtn = new System.Windows.Forms.Button();
            this.ReedemBtn = new System.Windows.Forms.Button();
            this.MenuBtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Location = new System.Drawing.Point(0, 1);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(467, 598);
            this.Panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(214, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Controls.Add(this.MeBtn);
            this.panel2.Controls.Add(this.ReedemBtn);
            this.panel2.Controls.Add(this.MenuBtn);
            this.panel2.Controls.Add(this.HomeBtn);
            this.panel2.Location = new System.Drawing.Point(0, 605);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(524, 51);
            this.panel2.TabIndex = 19;
            // 
            // MeBtn
            // 
            this.MeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MeBtn.FlatAppearance.BorderSize = 0;
            this.MeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MeBtn.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MeBtn.Location = new System.Drawing.Point(400, 10);
            this.MeBtn.Name = "MeBtn";
            this.MeBtn.Size = new System.Drawing.Size(67, 28);
            this.MeBtn.TabIndex = 21;
            this.MeBtn.Text = "Me";
            this.MeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MeBtn.UseVisualStyleBackColor = true;
            this.MeBtn.Click += new System.EventHandler(this.MeBtn_Click);
            // 
            // ReedemBtn
            // 
            this.ReedemBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ReedemBtn.FlatAppearance.BorderSize = 0;
            this.ReedemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReedemBtn.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReedemBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ReedemBtn.Location = new System.Drawing.Point(251, 10);
            this.ReedemBtn.Name = "ReedemBtn";
            this.ReedemBtn.Size = new System.Drawing.Size(95, 28);
            this.ReedemBtn.TabIndex = 20;
            this.ReedemBtn.Text = "Reedem";
            this.ReedemBtn.UseVisualStyleBackColor = true;
            this.ReedemBtn.Click += new System.EventHandler(this.ReedemBtn_Click);
            // 
            // MenuBtn
            // 
            this.MenuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MenuBtn.FlatAppearance.BorderSize = 0;
            this.MenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuBtn.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MenuBtn.Location = new System.Drawing.Point(140, 10);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(67, 28);
            this.MenuBtn.TabIndex = 19;
            this.MenuBtn.Text = "Menu";
            this.MenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuBtn.UseVisualStyleBackColor = true;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.HomeBtn.Location = new System.Drawing.Point(14, 10);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(67, 28);
            this.HomeBtn.TabIndex = 18;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeBtn.UseVisualStyleBackColor = true;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 655);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Panel1);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button MeBtn;
        private System.Windows.Forms.Button ReedemBtn;
        private System.Windows.Forms.Button MenuBtn;
        private System.Windows.Forms.Button HomeBtn;
    }
}