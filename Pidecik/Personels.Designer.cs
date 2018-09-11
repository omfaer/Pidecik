namespace Pidecik
{
    partial class Personels
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
            this.personels_dgw = new System.Windows.Forms.DataGridView();
            this.personel_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personel_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enddate_cbx = new System.Windows.Forms.CheckBox();
            this.personel_search_tbx = new MetroFramework.Controls.MetroTextBox();
            this.personelsearch_lbl = new MetroFramework.Controls.MetroLabel();
            this.id_number_tbx = new MetroFramework.Controls.MetroTextBox();
            this.first_name_tbx = new MetroFramework.Controls.MetroTextBox();
            this.last_name_tbx = new MetroFramework.Controls.MetroTextBox();
            this.age_tbx = new MetroFramework.Controls.MetroTextBox();
            this.phone_tbx = new MetroFramework.Controls.MetroTextBox();
            this.gender_cbx = new MetroFramework.Controls.MetroComboBox();
            this.address_tbx = new MetroFramework.Controls.MetroTextBox();
            this.role_tbx = new MetroFramework.Controls.MetroTextBox();
            this.startdate_dtp = new MetroFramework.Controls.MetroDateTime();
            this.enddate_dtp = new MetroFramework.Controls.MetroDateTime();
            this.update_personel_btn = new MetroFramework.Controls.MetroButton();
            this.id_number_lbl = new MetroFramework.Controls.MetroLabel();
            this.first_name_lbl = new MetroFramework.Controls.MetroLabel();
            this.last_name_lbl = new MetroFramework.Controls.MetroLabel();
            this.age_lbl = new MetroFramework.Controls.MetroLabel();
            this.gender_lbl = new MetroFramework.Controls.MetroLabel();
            this.phone_lbl = new MetroFramework.Controls.MetroLabel();
            this.address_lbl = new MetroFramework.Controls.MetroLabel();
            this.ending_lbl = new MetroFramework.Controls.MetroLabel();
            this.role_lbl = new MetroFramework.Controls.MetroLabel();
            this.starting_lbl = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.personels_dgw)).BeginInit();
            this.SuspendLayout();
            // 
            // personels_dgw
            // 
            this.personels_dgw.AllowUserToAddRows = false;
            this.personels_dgw.AllowUserToDeleteRows = false;
            this.personels_dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personels_dgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personel_id,
            this.id_number,
            this.first_name,
            this.last_name,
            this.age,
            this.gender,
            this.phone,
            this.role,
            this.personel_address,
            this.start_date,
            this.end_date});
            this.personels_dgw.Location = new System.Drawing.Point(104, 204);
            this.personels_dgw.MultiSelect = false;
            this.personels_dgw.Name = "personels_dgw";
            this.personels_dgw.ReadOnly = true;
            this.personels_dgw.RowTemplate.Height = 24;
            this.personels_dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.personels_dgw.Size = new System.Drawing.Size(853, 262);
            this.personels_dgw.TabIndex = 0;
            this.personels_dgw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.personels_dgw_MouseClick);
            // 
            // personel_id
            // 
            this.personel_id.DataPropertyName = "personel_id";
            this.personel_id.HeaderText = "ID";
            this.personel_id.Name = "personel_id";
            this.personel_id.ReadOnly = true;
            this.personel_id.Width = 35;
            // 
            // id_number
            // 
            this.id_number.DataPropertyName = "personel_id_number";
            this.id_number.HeaderText = "Kimlik No";
            this.id_number.Name = "id_number";
            this.id_number.ReadOnly = true;
            // 
            // first_name
            // 
            this.first_name.DataPropertyName = "personel_first_name";
            this.first_name.HeaderText = "Ad";
            this.first_name.Name = "first_name";
            this.first_name.ReadOnly = true;
            // 
            // last_name
            // 
            this.last_name.DataPropertyName = "personel_last_name";
            this.last_name.HeaderText = "Soyad";
            this.last_name.Name = "last_name";
            this.last_name.ReadOnly = true;
            // 
            // age
            // 
            this.age.DataPropertyName = "personel_age";
            this.age.HeaderText = "Yaş";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            this.age.Width = 50;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "personel_gender";
            this.gender.HeaderText = "Cinsiyet";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Width = 55;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "personel_phone";
            this.phone.HeaderText = "Telefon";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Width = 90;
            // 
            // role
            // 
            this.role.DataPropertyName = "personel_role";
            this.role.HeaderText = "Görev";
            this.role.Name = "role";
            this.role.ReadOnly = true;
            this.role.Width = 65;
            // 
            // personel_address
            // 
            this.personel_address.DataPropertyName = "personel_address";
            this.personel_address.HeaderText = "Adres";
            this.personel_address.Name = "personel_address";
            this.personel_address.ReadOnly = true;
            this.personel_address.Visible = false;
            // 
            // start_date
            // 
            this.start_date.DataPropertyName = "start_date";
            this.start_date.HeaderText = "Katılış Tarihi";
            this.start_date.Name = "start_date";
            this.start_date.ReadOnly = true;
            this.start_date.Visible = false;
            // 
            // end_date
            // 
            this.end_date.DataPropertyName = "end_date";
            this.end_date.HeaderText = "Ayrılış Tarihi";
            this.end_date.Name = "end_date";
            this.end_date.ReadOnly = true;
            this.end_date.Visible = false;
            // 
            // enddate_cbx
            // 
            this.enddate_cbx.AutoSize = true;
            this.enddate_cbx.Checked = true;
            this.enddate_cbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enddate_cbx.Location = new System.Drawing.Point(856, 682);
            this.enddate_cbx.Name = "enddate_cbx";
            this.enddate_cbx.Size = new System.Drawing.Size(145, 21);
            this.enddate_cbx.TabIndex = 26;
            this.enddate_cbx.Text = "Hala çalışıyor mu?";
            this.enddate_cbx.UseVisualStyleBackColor = true;
            this.enddate_cbx.CheckedChanged += new System.EventHandler(this.enddate_cbx_CheckedChanged);
            // 
            // personel_search_tbx
            // 
            // 
            // 
            // 
            this.personel_search_tbx.CustomButton.Image = null;
            this.personel_search_tbx.CustomButton.Location = new System.Drawing.Point(687, 2);
            this.personel_search_tbx.CustomButton.Name = "";
            this.personel_search_tbx.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.personel_search_tbx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.personel_search_tbx.CustomButton.TabIndex = 1;
            this.personel_search_tbx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.personel_search_tbx.CustomButton.UseSelectable = true;
            this.personel_search_tbx.CustomButton.Visible = false;
            this.personel_search_tbx.Lines = new string[0];
            this.personel_search_tbx.Location = new System.Drawing.Point(242, 150);
            this.personel_search_tbx.MaxLength = 32767;
            this.personel_search_tbx.Multiline = true;
            this.personel_search_tbx.Name = "personel_search_tbx";
            this.personel_search_tbx.PasswordChar = '\0';
            this.personel_search_tbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.personel_search_tbx.SelectedText = "";
            this.personel_search_tbx.SelectionLength = 0;
            this.personel_search_tbx.SelectionStart = 0;
            this.personel_search_tbx.ShortcutsEnabled = true;
            this.personel_search_tbx.Size = new System.Drawing.Size(715, 30);
            this.personel_search_tbx.TabIndex = 28;
            this.personel_search_tbx.UseSelectable = true;
            this.personel_search_tbx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.personel_search_tbx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.personel_search_tbx.TextChanged += new System.EventHandler(this.personel_search_tbx_TextChanged);
            // 
            // personelsearch_lbl
            // 
            this.personelsearch_lbl.AutoSize = true;
            this.personelsearch_lbl.Location = new System.Drawing.Point(104, 157);
            this.personelsearch_lbl.Name = "personelsearch_lbl";
            this.personelsearch_lbl.Size = new System.Drawing.Size(90, 20);
            this.personelsearch_lbl.TabIndex = 29;
            this.personelsearch_lbl.Text = "Personel Ara:";
            // 
            // id_number_tbx
            // 
            // 
            // 
            // 
            this.id_number_tbx.CustomButton.Image = null;
            this.id_number_tbx.CustomButton.Location = new System.Drawing.Point(174, 2);
            this.id_number_tbx.CustomButton.Name = "";
            this.id_number_tbx.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.id_number_tbx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.id_number_tbx.CustomButton.TabIndex = 1;
            this.id_number_tbx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.id_number_tbx.CustomButton.UseSelectable = true;
            this.id_number_tbx.CustomButton.Visible = false;
            this.id_number_tbx.Lines = new string[0];
            this.id_number_tbx.Location = new System.Drawing.Point(203, 502);
            this.id_number_tbx.MaxLength = 32767;
            this.id_number_tbx.Multiline = true;
            this.id_number_tbx.Name = "id_number_tbx";
            this.id_number_tbx.PasswordChar = '\0';
            this.id_number_tbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.id_number_tbx.SelectedText = "";
            this.id_number_tbx.SelectionLength = 0;
            this.id_number_tbx.SelectionStart = 0;
            this.id_number_tbx.ShortcutsEnabled = true;
            this.id_number_tbx.Size = new System.Drawing.Size(224, 30);
            this.id_number_tbx.TabIndex = 30;
            this.id_number_tbx.UseSelectable = true;
            this.id_number_tbx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.id_number_tbx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // first_name_tbx
            // 
            // 
            // 
            // 
            this.first_name_tbx.CustomButton.Image = null;
            this.first_name_tbx.CustomButton.Location = new System.Drawing.Point(174, 2);
            this.first_name_tbx.CustomButton.Name = "";
            this.first_name_tbx.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.first_name_tbx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.first_name_tbx.CustomButton.TabIndex = 1;
            this.first_name_tbx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.first_name_tbx.CustomButton.UseSelectable = true;
            this.first_name_tbx.CustomButton.Visible = false;
            this.first_name_tbx.Lines = new string[0];
            this.first_name_tbx.Location = new System.Drawing.Point(203, 548);
            this.first_name_tbx.MaxLength = 32767;
            this.first_name_tbx.Multiline = true;
            this.first_name_tbx.Name = "first_name_tbx";
            this.first_name_tbx.PasswordChar = '\0';
            this.first_name_tbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.first_name_tbx.SelectedText = "";
            this.first_name_tbx.SelectionLength = 0;
            this.first_name_tbx.SelectionStart = 0;
            this.first_name_tbx.ShortcutsEnabled = true;
            this.first_name_tbx.Size = new System.Drawing.Size(224, 30);
            this.first_name_tbx.TabIndex = 31;
            this.first_name_tbx.UseSelectable = true;
            this.first_name_tbx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.first_name_tbx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // last_name_tbx
            // 
            // 
            // 
            // 
            this.last_name_tbx.CustomButton.Image = null;
            this.last_name_tbx.CustomButton.Location = new System.Drawing.Point(174, 2);
            this.last_name_tbx.CustomButton.Name = "";
            this.last_name_tbx.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.last_name_tbx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.last_name_tbx.CustomButton.TabIndex = 1;
            this.last_name_tbx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.last_name_tbx.CustomButton.UseSelectable = true;
            this.last_name_tbx.CustomButton.Visible = false;
            this.last_name_tbx.Lines = new string[0];
            this.last_name_tbx.Location = new System.Drawing.Point(203, 593);
            this.last_name_tbx.MaxLength = 32767;
            this.last_name_tbx.Multiline = true;
            this.last_name_tbx.Name = "last_name_tbx";
            this.last_name_tbx.PasswordChar = '\0';
            this.last_name_tbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.last_name_tbx.SelectedText = "";
            this.last_name_tbx.SelectionLength = 0;
            this.last_name_tbx.SelectionStart = 0;
            this.last_name_tbx.ShortcutsEnabled = true;
            this.last_name_tbx.Size = new System.Drawing.Size(224, 30);
            this.last_name_tbx.TabIndex = 32;
            this.last_name_tbx.UseSelectable = true;
            this.last_name_tbx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.last_name_tbx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // age_tbx
            // 
            // 
            // 
            // 
            this.age_tbx.CustomButton.Image = null;
            this.age_tbx.CustomButton.Location = new System.Drawing.Point(174, 2);
            this.age_tbx.CustomButton.Name = "";
            this.age_tbx.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.age_tbx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.age_tbx.CustomButton.TabIndex = 1;
            this.age_tbx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.age_tbx.CustomButton.UseSelectable = true;
            this.age_tbx.CustomButton.Visible = false;
            this.age_tbx.Lines = new string[0];
            this.age_tbx.Location = new System.Drawing.Point(203, 637);
            this.age_tbx.MaxLength = 32767;
            this.age_tbx.Multiline = true;
            this.age_tbx.Name = "age_tbx";
            this.age_tbx.PasswordChar = '\0';
            this.age_tbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.age_tbx.SelectedText = "";
            this.age_tbx.SelectionLength = 0;
            this.age_tbx.SelectionStart = 0;
            this.age_tbx.ShortcutsEnabled = true;
            this.age_tbx.Size = new System.Drawing.Size(224, 30);
            this.age_tbx.TabIndex = 33;
            this.age_tbx.UseSelectable = true;
            this.age_tbx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.age_tbx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // phone_tbx
            // 
            // 
            // 
            // 
            this.phone_tbx.CustomButton.Image = null;
            this.phone_tbx.CustomButton.Location = new System.Drawing.Point(174, 2);
            this.phone_tbx.CustomButton.Name = "";
            this.phone_tbx.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.phone_tbx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.phone_tbx.CustomButton.TabIndex = 1;
            this.phone_tbx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.phone_tbx.CustomButton.UseSelectable = true;
            this.phone_tbx.CustomButton.Visible = false;
            this.phone_tbx.Lines = new string[0];
            this.phone_tbx.Location = new System.Drawing.Point(203, 724);
            this.phone_tbx.MaxLength = 32767;
            this.phone_tbx.Multiline = true;
            this.phone_tbx.Name = "phone_tbx";
            this.phone_tbx.PasswordChar = '\0';
            this.phone_tbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.phone_tbx.SelectedText = "";
            this.phone_tbx.SelectionLength = 0;
            this.phone_tbx.SelectionStart = 0;
            this.phone_tbx.ShortcutsEnabled = true;
            this.phone_tbx.Size = new System.Drawing.Size(224, 30);
            this.phone_tbx.TabIndex = 34;
            this.phone_tbx.UseSelectable = true;
            this.phone_tbx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.phone_tbx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // gender_cbx
            // 
            this.gender_cbx.FormattingEnabled = true;
            this.gender_cbx.ItemHeight = 24;
            this.gender_cbx.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.gender_cbx.Location = new System.Drawing.Point(203, 682);
            this.gender_cbx.Name = "gender_cbx";
            this.gender_cbx.Size = new System.Drawing.Size(224, 30);
            this.gender_cbx.TabIndex = 35;
            this.gender_cbx.UseSelectable = true;
            // 
            // address_tbx
            // 
            // 
            // 
            // 
            this.address_tbx.CustomButton.Image = null;
            this.address_tbx.CustomButton.Location = new System.Drawing.Point(128, 2);
            this.address_tbx.CustomButton.Name = "";
            this.address_tbx.CustomButton.Size = new System.Drawing.Size(71, 71);
            this.address_tbx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.address_tbx.CustomButton.TabIndex = 1;
            this.address_tbx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.address_tbx.CustomButton.UseSelectable = true;
            this.address_tbx.CustomButton.Visible = false;
            this.address_tbx.Lines = new string[0];
            this.address_tbx.Location = new System.Drawing.Point(607, 502);
            this.address_tbx.MaxLength = 32767;
            this.address_tbx.Multiline = true;
            this.address_tbx.Name = "address_tbx";
            this.address_tbx.PasswordChar = '\0';
            this.address_tbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.address_tbx.SelectedText = "";
            this.address_tbx.SelectionLength = 0;
            this.address_tbx.SelectionStart = 0;
            this.address_tbx.ShortcutsEnabled = true;
            this.address_tbx.Size = new System.Drawing.Size(224, 76);
            this.address_tbx.TabIndex = 36;
            this.address_tbx.UseSelectable = true;
            this.address_tbx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.address_tbx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // role_tbx
            // 
            // 
            // 
            // 
            this.role_tbx.CustomButton.Image = null;
            this.role_tbx.CustomButton.Location = new System.Drawing.Point(174, 2);
            this.role_tbx.CustomButton.Name = "";
            this.role_tbx.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.role_tbx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.role_tbx.CustomButton.TabIndex = 1;
            this.role_tbx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.role_tbx.CustomButton.UseSelectable = true;
            this.role_tbx.CustomButton.Visible = false;
            this.role_tbx.Lines = new string[0];
            this.role_tbx.Location = new System.Drawing.Point(607, 593);
            this.role_tbx.MaxLength = 32767;
            this.role_tbx.Multiline = true;
            this.role_tbx.Name = "role_tbx";
            this.role_tbx.PasswordChar = '\0';
            this.role_tbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.role_tbx.SelectedText = "";
            this.role_tbx.SelectionLength = 0;
            this.role_tbx.SelectionStart = 0;
            this.role_tbx.ShortcutsEnabled = true;
            this.role_tbx.Size = new System.Drawing.Size(224, 30);
            this.role_tbx.TabIndex = 37;
            this.role_tbx.UseSelectable = true;
            this.role_tbx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.role_tbx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // startdate_dtp
            // 
            this.startdate_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startdate_dtp.Location = new System.Drawing.Point(607, 637);
            this.startdate_dtp.MinimumSize = new System.Drawing.Size(0, 30);
            this.startdate_dtp.Name = "startdate_dtp";
            this.startdate_dtp.Size = new System.Drawing.Size(222, 30);
            this.startdate_dtp.TabIndex = 38;
            // 
            // enddate_dtp
            // 
            this.enddate_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.enddate_dtp.Location = new System.Drawing.Point(607, 680);
            this.enddate_dtp.MinimumSize = new System.Drawing.Size(0, 30);
            this.enddate_dtp.Name = "enddate_dtp";
            this.enddate_dtp.Size = new System.Drawing.Size(222, 30);
            this.enddate_dtp.TabIndex = 39;
            // 
            // update_personel_btn
            // 
            this.update_personel_btn.Location = new System.Drawing.Point(607, 724);
            this.update_personel_btn.Name = "update_personel_btn";
            this.update_personel_btn.Size = new System.Drawing.Size(224, 30);
            this.update_personel_btn.TabIndex = 40;
            this.update_personel_btn.Text = "Güncelle";
            this.update_personel_btn.UseSelectable = true;
            // 
            // id_number_lbl
            // 
            this.id_number_lbl.AutoSize = true;
            this.id_number_lbl.Location = new System.Drawing.Point(104, 512);
            this.id_number_lbl.Name = "id_number_lbl";
            this.id_number_lbl.Size = new System.Drawing.Size(71, 20);
            this.id_number_lbl.TabIndex = 41;
            this.id_number_lbl.Text = "Kimlik No:";
            // 
            // first_name_lbl
            // 
            this.first_name_lbl.AutoSize = true;
            this.first_name_lbl.Location = new System.Drawing.Point(146, 558);
            this.first_name_lbl.Name = "first_name_lbl";
            this.first_name_lbl.Size = new System.Drawing.Size(29, 20);
            this.first_name_lbl.TabIndex = 42;
            this.first_name_lbl.Text = "Ad:";
            // 
            // last_name_lbl
            // 
            this.last_name_lbl.AutoSize = true;
            this.last_name_lbl.Location = new System.Drawing.Point(126, 603);
            this.last_name_lbl.Name = "last_name_lbl";
            this.last_name_lbl.Size = new System.Drawing.Size(49, 20);
            this.last_name_lbl.TabIndex = 43;
            this.last_name_lbl.Text = "Soyad:";
            // 
            // age_lbl
            // 
            this.age_lbl.AutoSize = true;
            this.age_lbl.Location = new System.Drawing.Point(144, 647);
            this.age_lbl.Name = "age_lbl";
            this.age_lbl.Size = new System.Drawing.Size(31, 20);
            this.age_lbl.TabIndex = 44;
            this.age_lbl.Text = "Yaş:";
            // 
            // gender_lbl
            // 
            this.gender_lbl.AutoSize = true;
            this.gender_lbl.Location = new System.Drawing.Point(115, 692);
            this.gender_lbl.Name = "gender_lbl";
            this.gender_lbl.Size = new System.Drawing.Size(60, 20);
            this.gender_lbl.TabIndex = 45;
            this.gender_lbl.Text = "Cinsiyet:";
            // 
            // phone_lbl
            // 
            this.phone_lbl.AutoSize = true;
            this.phone_lbl.Location = new System.Drawing.Point(115, 734);
            this.phone_lbl.Name = "phone_lbl";
            this.phone_lbl.Size = new System.Drawing.Size(57, 20);
            this.phone_lbl.TabIndex = 46;
            this.phone_lbl.Text = "Telefon:";
            // 
            // address_lbl
            // 
            this.address_lbl.AutoSize = true;
            this.address_lbl.Location = new System.Drawing.Point(534, 512);
            this.address_lbl.Name = "address_lbl";
            this.address_lbl.Size = new System.Drawing.Size(48, 20);
            this.address_lbl.TabIndex = 47;
            this.address_lbl.Text = "Adres:";
            // 
            // ending_lbl
            // 
            this.ending_lbl.AutoSize = true;
            this.ending_lbl.Location = new System.Drawing.Point(498, 690);
            this.ending_lbl.Name = "ending_lbl";
            this.ending_lbl.Size = new System.Drawing.Size(84, 20);
            this.ending_lbl.TabIndex = 48;
            this.ending_lbl.Text = "Ayrılış Tarihi:";
            // 
            // role_lbl
            // 
            this.role_lbl.AutoSize = true;
            this.role_lbl.Location = new System.Drawing.Point(532, 603);
            this.role_lbl.Name = "role_lbl";
            this.role_lbl.Size = new System.Drawing.Size(50, 20);
            this.role_lbl.TabIndex = 48;
            this.role_lbl.Text = "Görev:";
            // 
            // starting_lbl
            // 
            this.starting_lbl.AutoSize = true;
            this.starting_lbl.Location = new System.Drawing.Point(500, 647);
            this.starting_lbl.Name = "starting_lbl";
            this.starting_lbl.Size = new System.Drawing.Size(82, 20);
            this.starting_lbl.TabIndex = 49;
            this.starting_lbl.Text = "Katılış Tarihi:";
            // 
            // Personels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 853);
            this.Controls.Add(this.starting_lbl);
            this.Controls.Add(this.role_lbl);
            this.Controls.Add(this.ending_lbl);
            this.Controls.Add(this.address_lbl);
            this.Controls.Add(this.phone_lbl);
            this.Controls.Add(this.gender_lbl);
            this.Controls.Add(this.age_lbl);
            this.Controls.Add(this.last_name_lbl);
            this.Controls.Add(this.first_name_lbl);
            this.Controls.Add(this.id_number_lbl);
            this.Controls.Add(this.update_personel_btn);
            this.Controls.Add(this.enddate_dtp);
            this.Controls.Add(this.startdate_dtp);
            this.Controls.Add(this.role_tbx);
            this.Controls.Add(this.address_tbx);
            this.Controls.Add(this.gender_cbx);
            this.Controls.Add(this.phone_tbx);
            this.Controls.Add(this.age_tbx);
            this.Controls.Add(this.last_name_tbx);
            this.Controls.Add(this.first_name_tbx);
            this.Controls.Add(this.id_number_tbx);
            this.Controls.Add(this.personelsearch_lbl);
            this.Controls.Add(this.personel_search_tbx);
            this.Controls.Add(this.enddate_cbx);
            this.Controls.Add(this.personels_dgw);
            this.Name = "Personels";
            this.Text = "Personels";
            this.Load += new System.EventHandler(this.Personels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personels_dgw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView personels_dgw;
        private System.Windows.Forms.DataGridViewTextBoxColumn personel_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.DataGridViewTextBoxColumn personel_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn start_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_date;
        private System.Windows.Forms.CheckBox enddate_cbx;
        private MetroFramework.Controls.MetroTextBox personel_search_tbx;
        private MetroFramework.Controls.MetroLabel personelsearch_lbl;
        private MetroFramework.Controls.MetroTextBox id_number_tbx;
        private MetroFramework.Controls.MetroTextBox first_name_tbx;
        private MetroFramework.Controls.MetroTextBox last_name_tbx;
        private MetroFramework.Controls.MetroTextBox age_tbx;
        private MetroFramework.Controls.MetroTextBox phone_tbx;
        private MetroFramework.Controls.MetroComboBox gender_cbx;
        private MetroFramework.Controls.MetroTextBox address_tbx;
        private MetroFramework.Controls.MetroTextBox role_tbx;
        private MetroFramework.Controls.MetroDateTime startdate_dtp;
        private MetroFramework.Controls.MetroDateTime enddate_dtp;
        private MetroFramework.Controls.MetroButton update_personel_btn;
        private MetroFramework.Controls.MetroLabel id_number_lbl;
        private MetroFramework.Controls.MetroLabel first_name_lbl;
        private MetroFramework.Controls.MetroLabel last_name_lbl;
        private MetroFramework.Controls.MetroLabel age_lbl;
        private MetroFramework.Controls.MetroLabel gender_lbl;
        private MetroFramework.Controls.MetroLabel phone_lbl;
        private MetroFramework.Controls.MetroLabel address_lbl;
        private MetroFramework.Controls.MetroLabel ending_lbl;
        private MetroFramework.Controls.MetroLabel role_lbl;
        private MetroFramework.Controls.MetroLabel starting_lbl;
    }
}