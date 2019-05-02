namespace LoginDatabase
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_user = new System.Windows.Forms.TextBox();
            this.text_pass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // text_user
            // 
            this.text_user.Location = new System.Drawing.Point(118, 122);
            this.text_user.Multiline = true;
            this.text_user.Name = "text_user";
            this.text_user.Size = new System.Drawing.Size(140, 24);
            this.text_user.TabIndex = 2;
            // 
            // text_pass
            // 
            this.text_pass.Location = new System.Drawing.Point(118, 160);
            this.text_pass.Multiline = true;
            this.text_pass.Name = "text_pass";
            this.text_pass.Size = new System.Drawing.Size(140, 24);
            this.text_pass.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(56, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(153, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Fuchsia;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Magenta;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(-3, -2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(285, 93);
            this.bunifuGradientPanel1.TabIndex = 6;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(97, 23);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(97, 29);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Login C#";
            // 
            // bunifuCircleProgressbar1
            // 
            this.bunifuCircleProgressbar1.animated = false;
            this.bunifuCircleProgressbar1.animationIterval = 5;
            this.bunifuCircleProgressbar1.animationSpeed = 300;
            this.bunifuCircleProgressbar1.BackColor = System.Drawing.Color.White;
            this.bunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar1.BackgroundImage")));
            this.bunifuCircleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar1.LabelVisible = true;
            this.bunifuCircleProgressbar1.LineProgressThickness = 8;
            this.bunifuCircleProgressbar1.LineThickness = 5;
            this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(109, 250);
            this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuCircleProgressbar1.MaxValue = 100;
            this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
            this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(63, 63);
            this.bunifuCircleProgressbar1.TabIndex = 7;
            this.bunifuCircleProgressbar1.Value = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(284, 338);
            this.Controls.Add(this.bunifuCircleProgressbar1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text_pass);
            this.Controls.Add(this.text_user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_user;
        private System.Windows.Forms.TextBox text_pass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar1;
    }
}

