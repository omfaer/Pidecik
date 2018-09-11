namespace Pidecik
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
            this.login_btn = new MetroFramework.Controls.MetroButton();
            this.user_name_tbx = new MetroFramework.Controls.MetroTextBox();
            this.password_tbx = new MetroFramework.Controls.MetroTextBox();
            this.username_lbl = new MetroFramework.Controls.MetroLabel();
            this.password_lbl = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // login_btn
            // 
            this.login_btn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.login_btn.Location = new System.Drawing.Point(203, 284);
            this.login_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(240, 42);
            this.login_btn.TabIndex = 5;
            this.login_btn.Text = "Giriş Yap";
            this.login_btn.UseSelectable = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            this.login_btn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_tbx_KeyDown);
            // 
            // user_name_tbx
            // 
            // 
            // 
            // 
            this.user_name_tbx.CustomButton.Image = null;
            this.user_name_tbx.CustomButton.Location = new System.Drawing.Point(208, 2);
            this.user_name_tbx.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user_name_tbx.CustomButton.Name = "";
            this.user_name_tbx.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.user_name_tbx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.user_name_tbx.CustomButton.TabIndex = 1;
            this.user_name_tbx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.user_name_tbx.CustomButton.UseSelectable = true;
            this.user_name_tbx.CustomButton.Visible = false;
            this.user_name_tbx.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.user_name_tbx.Lines = new string[0];
            this.user_name_tbx.Location = new System.Drawing.Point(203, 160);
            this.user_name_tbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user_name_tbx.MaxLength = 32767;
            this.user_name_tbx.Name = "user_name_tbx";
            this.user_name_tbx.PasswordChar = '\0';
            this.user_name_tbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.user_name_tbx.SelectedText = "";
            this.user_name_tbx.SelectionLength = 0;
            this.user_name_tbx.SelectionStart = 0;
            this.user_name_tbx.ShortcutsEnabled = true;
            this.user_name_tbx.Size = new System.Drawing.Size(240, 34);
            this.user_name_tbx.TabIndex = 6;
            this.user_name_tbx.UseSelectable = true;
            this.user_name_tbx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.user_name_tbx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // password_tbx
            // 
            // 
            // 
            // 
            this.password_tbx.CustomButton.Image = null;
            this.password_tbx.CustomButton.Location = new System.Drawing.Point(208, 2);
            this.password_tbx.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password_tbx.CustomButton.Name = "";
            this.password_tbx.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.password_tbx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.password_tbx.CustomButton.TabIndex = 1;
            this.password_tbx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.password_tbx.CustomButton.UseSelectable = true;
            this.password_tbx.CustomButton.Visible = false;
            this.password_tbx.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.password_tbx.Lines = new string[0];
            this.password_tbx.Location = new System.Drawing.Point(203, 222);
            this.password_tbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password_tbx.MaxLength = 32767;
            this.password_tbx.Name = "password_tbx";
            this.password_tbx.PasswordChar = '*';
            this.password_tbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.password_tbx.SelectedText = "";
            this.password_tbx.SelectionLength = 0;
            this.password_tbx.SelectionStart = 0;
            this.password_tbx.ShortcutsEnabled = true;
            this.password_tbx.Size = new System.Drawing.Size(240, 34);
            this.password_tbx.TabIndex = 7;
            this.password_tbx.UseSelectable = true;
            this.password_tbx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.password_tbx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.password_tbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_tbx_KeyDown);
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.username_lbl.Location = new System.Drawing.Point(45, 164);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(111, 25);
            this.username_lbl.TabIndex = 8;
            this.username_lbl.Text = "Kullanıcı Adı:";
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.password_lbl.Location = new System.Drawing.Point(107, 223);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(50, 25);
            this.password_lbl.TabIndex = 9;
            this.password_lbl.Text = "Şifre:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 641);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.username_lbl);
            this.Controls.Add(this.password_tbx);
            this.Controls.Add(this.user_name_tbx);
            this.Controls.Add(this.login_btn);
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Resizable = false;
            this.Text = "Kullanıcı Girişi";
            this.TransparencyKey = System.Drawing.Color.DodgerBlue;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_tbx_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton login_btn;
        private MetroFramework.Controls.MetroTextBox user_name_tbx;
        private MetroFramework.Controls.MetroTextBox password_tbx;
        private MetroFramework.Controls.MetroLabel username_lbl;
        private MetroFramework.Controls.MetroLabel password_lbl;
    }
}

