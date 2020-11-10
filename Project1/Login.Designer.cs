namespace Project1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.username_text = new System.Windows.Forms.TextBox();
            this.username_label = new System.Windows.Forms.Label();
            this.pass_text = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.login_butt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username_text
            // 
            this.username_text.Location = new System.Drawing.Point(83, 111);
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(100, 20);
            this.username_text.TabIndex = 0;
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.Location = new System.Drawing.Point(223, 110);
            this.username_label.Name = "username_label";
            this.username_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.username_label.Size = new System.Drawing.Size(91, 19);
            this.username_label.TabIndex = 1;
            this.username_label.Text = "שם משתמש: ";
            // 
            // pass_text
            // 
            this.pass_text.Location = new System.Drawing.Point(83, 165);
            this.pass_text.MaxLength = 14;
            this.pass_text.Name = "pass_text";
            this.pass_text.PasswordChar = '*';
            this.pass_text.Size = new System.Drawing.Size(100, 20);
            this.pass_text.TabIndex = 2;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.Location = new System.Drawing.Point(261, 164);
            this.password_label.Name = "password_label";
            this.password_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.password_label.Size = new System.Drawing.Size(53, 19);
            this.password_label.TabIndex = 3;
            this.password_label.Text = "סיסמא:";
            // 
            // login_butt
            // 
            this.login_butt.FlatAppearance.BorderSize = 0;
            this.login_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_butt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_butt.Location = new System.Drawing.Point(138, 229);
            this.login_butt.Name = "login_butt";
            this.login_butt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.login_butt.Size = new System.Drawing.Size(100, 30);
            this.login_butt.TabIndex = 4;
            this.login_butt.Text = "התחברות";
            this.login_butt.UseVisualStyleBackColor = true;
            this.login_butt.Click += new System.EventHandler(this.login_butt_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.login_butt);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.pass_text);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.username_text);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "התחברות";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox username_text;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.TextBox pass_text;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Button login_butt;
    }
}