namespace LoginDatabase
{
    partial class F_Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Register));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.reset = new System.Windows.Forms.Button();
            this.daftar = new System.Windows.Forms.Button();
            this.text_pass = new System.Windows.Forms.TextBox();
            this.text_user = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(105, 40);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(149, 29);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Form Register";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Navy;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Navy;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(-1, -19);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(357, 93);
            this.bunifuGradientPanel1.TabIndex = 14;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(192, 192);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 29);
            this.reset.TabIndex = 13;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            // 
            // daftar
            // 
            this.daftar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daftar.Location = new System.Drawing.Point(95, 192);
            this.daftar.Name = "daftar";
            this.daftar.Size = new System.Drawing.Size(75, 29);
            this.daftar.TabIndex = 12;
            this.daftar.Text = "Daftar";
            this.daftar.UseVisualStyleBackColor = true;
            this.daftar.Click += new System.EventHandler(this.daftar_Click);
            // 
            // text_pass
            // 
            this.text_pass.Location = new System.Drawing.Point(127, 135);
            this.text_pass.Multiline = true;
            this.text_pass.Name = "text_pass";
            this.text_pass.Size = new System.Drawing.Size(199, 24);
            this.text_pass.TabIndex = 11;
            // 
            // text_user
            // 
            this.text_user.Location = new System.Drawing.Point(127, 97);
            this.text_user.Multiline = true;
            this.text_user.Name = "text_user";
            this.text_user.Size = new System.Drawing.Size(199, 24);
            this.text_user.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username";
            // 
            // F_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(357, 277);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.daftar);
            this.Controls.Add(this.text_pass);
            this.Controls.Add(this.text_user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Register";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button daftar;
        private System.Windows.Forms.TextBox text_pass;
        private System.Windows.Forms.TextBox text_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}