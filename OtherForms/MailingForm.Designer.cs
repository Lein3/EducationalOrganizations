
namespace EducationalOrganizationsApp
{
    partial class MailingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_accept = new System.Windows.Forms.Button();
            this.label_validation1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_validation2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_validation4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label_validation13 = new System.Windows.Forms.Label();
            this.label_validation12 = new System.Windows.Forms.Label();
            this.guna2DataGridView_Emails = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label_addressname = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.button_addFile = new System.Windows.Forms.Button();
            this.guna2DataGridView_Files = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_mailing = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox_rememberMe = new System.Windows.Forms.CheckBox();
            this.button_mailing_Update = new System.Windows.Forms.Button();
            this.button_passwordVisible = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView_Emails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView_Files)).BeginInit();
            this.SuspendLayout();
            // 
            // button_accept
            // 
            this.button_accept.Location = new System.Drawing.Point(687, 504);
            this.button_accept.Margin = new System.Windows.Forms.Padding(2);
            this.button_accept.Name = "button_accept";
            this.button_accept.Size = new System.Drawing.Size(153, 57);
            this.button_accept.TabIndex = 0;
            this.button_accept.Text = "отправить";
            this.button_accept.UseVisualStyleBackColor = true;
            this.button_accept.Click += new System.EventHandler(this.button_Accept_Click);
            // 
            // label_validation1
            // 
            this.label_validation1.AutoSize = true;
            this.label_validation1.ForeColor = System.Drawing.Color.Red;
            this.label_validation1.Location = new System.Drawing.Point(335, 88);
            this.label_validation1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_validation1.Name = "label_validation1";
            this.label_validation1.Size = new System.Drawing.Size(105, 13);
            this.label_validation1.TabIndex = 79;
            this.label_validation1.Text = "обязательное поле";
            this.label_validation1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 20);
            this.textBox1.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(93, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 77;
            this.label1.Text = "Логин";
            // 
            // label_validation2
            // 
            this.label_validation2.AutoSize = true;
            this.label_validation2.ForeColor = System.Drawing.Color.Red;
            this.label_validation2.Location = new System.Drawing.Point(335, 131);
            this.label_validation2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_validation2.Name = "label_validation2";
            this.label_validation2.Size = new System.Drawing.Size(105, 13);
            this.label_validation2.TabIndex = 82;
            this.label_validation2.Text = "обязательное поле";
            this.label_validation2.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(168, 147);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(275, 20);
            this.textBox2.TabIndex = 81;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(80, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 80;
            this.label2.Text = "Пароль";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(168, 224);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(275, 20);
            this.textBox3.TabIndex = 84;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(93, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 83;
            this.label3.Text = "Тема";
            // 
            // label_validation4
            // 
            this.label_validation4.AutoSize = true;
            this.label_validation4.ForeColor = System.Drawing.Color.Red;
            this.label_validation4.Location = new System.Drawing.Point(735, 258);
            this.label_validation4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_validation4.Name = "label_validation4";
            this.label_validation4.Size = new System.Drawing.Size(105, 13);
            this.label_validation4.TabIndex = 88;
            this.label_validation4.Text = "обязательное поле";
            this.label_validation4.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(170, 274);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(670, 223);
            this.textBox4.TabIndex = 87;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(92, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 24);
            this.label4.TabIndex = 86;
            this.label4.Text = "Текст";
            // 
            // label_validation13
            // 
            this.label_validation13.AutoSize = true;
            this.label_validation13.ForeColor = System.Drawing.Color.Red;
            this.label_validation13.Location = new System.Drawing.Point(446, 88);
            this.label_validation13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_validation13.Name = "label_validation13";
            this.label_validation13.Size = new System.Drawing.Size(65, 39);
            this.label_validation13.TabIndex = 89;
            this.label_validation13.Text = "@mail.ru\r\n@gmail.com\r\n@yandex.ru";
            this.label_validation13.Visible = false;
            // 
            // label_validation12
            // 
            this.label_validation12.AutoSize = true;
            this.label_validation12.ForeColor = System.Drawing.Color.Red;
            this.label_validation12.Location = new System.Drawing.Point(165, 88);
            this.label_validation12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_validation12.Name = "label_validation12";
            this.label_validation12.Size = new System.Drawing.Size(150, 13);
            this.label_validation12.TabIndex = 90;
            this.label_validation12.Text = "Почта введена неккоректно";
            this.label_validation12.Visible = false;
            // 
            // guna2DataGridView_Emails
            // 
            this.guna2DataGridView_Emails.AllowUserToDeleteRows = false;
            this.guna2DataGridView_Emails.AllowUserToResizeColumns = false;
            this.guna2DataGridView_Emails.AllowUserToResizeRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView_Emails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.guna2DataGridView_Emails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView_Emails.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView_Emails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView_Emails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView_Emails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView_Emails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.guna2DataGridView_Emails.ColumnHeadersHeight = 4;
            this.guna2DataGridView_Emails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView_Emails.DefaultCellStyle = dataGridViewCellStyle21;
            this.guna2DataGridView_Emails.EnableHeadersVisualStyles = false;
            this.guna2DataGridView_Emails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView_Emails.Location = new System.Drawing.Point(530, 22);
            this.guna2DataGridView_Emails.MultiSelect = false;
            this.guna2DataGridView_Emails.Name = "guna2DataGridView_Emails";
            this.guna2DataGridView_Emails.ReadOnly = true;
            this.guna2DataGridView_Emails.RowHeadersVisible = false;
            this.guna2DataGridView_Emails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.guna2DataGridView_Emails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView_Emails.Size = new System.Drawing.Size(310, 199);
            this.guna2DataGridView_Emails.TabIndex = 91;
            this.guna2DataGridView_Emails.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView_Emails.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView_Emails.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView_Emails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView_Emails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView_Emails.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView_Emails.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView_Emails.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView_Emails.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView_Emails.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView_Emails.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView_Emails.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.guna2DataGridView_Emails.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridView_Emails.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView_Emails.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView_Emails.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView_Emails.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView_Emails.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView_Emails.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView_Emails.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView_Emails.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView_Emails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView_CellClick);
            // 
            // label_addressname
            // 
            this.label_addressname.AutoSize = true;
            this.label_addressname.Location = new System.Drawing.Point(527, 224);
            this.label_addressname.Name = "label_addressname";
            this.label_addressname.Size = new System.Drawing.Size(0, 13);
            this.label_addressname.TabIndex = 92;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Multiselect = true;
            // 
            // button_addFile
            // 
            this.button_addFile.Location = new System.Drawing.Point(170, 503);
            this.button_addFile.Name = "button_addFile";
            this.button_addFile.Size = new System.Drawing.Size(66, 30);
            this.button_addFile.TabIndex = 93;
            this.button_addFile.Text = "Вложение";
            this.button_addFile.UseVisualStyleBackColor = true;
            this.button_addFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // guna2DataGridView_Files
            // 
            this.guna2DataGridView_Files.AllowUserToDeleteRows = false;
            this.guna2DataGridView_Files.AllowUserToResizeColumns = false;
            this.guna2DataGridView_Files.AllowUserToResizeRows = false;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView_Files.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.guna2DataGridView_Files.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView_Files.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView_Files.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView_Files.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView_Files.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView_Files.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.guna2DataGridView_Files.ColumnHeadersHeight = 4;
            this.guna2DataGridView_Files.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView_Files.DefaultCellStyle = dataGridViewCellStyle24;
            this.guna2DataGridView_Files.EnableHeadersVisualStyles = false;
            this.guna2DataGridView_Files.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView_Files.Location = new System.Drawing.Point(249, 504);
            this.guna2DataGridView_Files.MultiSelect = false;
            this.guna2DataGridView_Files.Name = "guna2DataGridView_Files";
            this.guna2DataGridView_Files.ReadOnly = true;
            this.guna2DataGridView_Files.RowHeadersVisible = false;
            this.guna2DataGridView_Files.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.guna2DataGridView_Files.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView_Files.Size = new System.Drawing.Size(191, 128);
            this.guna2DataGridView_Files.TabIndex = 94;
            this.guna2DataGridView_Files.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView_Files.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView_Files.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView_Files.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView_Files.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView_Files.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView_Files.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView_Files.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView_Files.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView_Files.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView_Files.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView_Files.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.guna2DataGridView_Files.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridView_Files.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView_Files.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView_Files.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView_Files.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView_Files.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView_Files.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView_Files.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView_Files.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(273, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 24);
            this.label5.TabIndex = 95;
            this.label5.Text = "Или";
            // 
            // comboBox_mailing
            // 
            this.comboBox_mailing.FormattingEnabled = true;
            this.comboBox_mailing.Location = new System.Drawing.Point(168, 22);
            this.comboBox_mailing.Name = "comboBox_mailing";
            this.comboBox_mailing.Size = new System.Drawing.Size(275, 21);
            this.comboBox_mailing.TabIndex = 96;
            this.comboBox_mailing.SelectionChangeCommitted += new System.EventHandler(this.comboBox_mailing_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(60, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 44);
            this.label6.TabIndex = 97;
            this.label6.Text = "Сохраненная почта";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkBox_rememberMe
            // 
            this.checkBox_rememberMe.AutoSize = true;
            this.checkBox_rememberMe.Location = new System.Drawing.Point(332, 173);
            this.checkBox_rememberMe.Name = "checkBox_rememberMe";
            this.checkBox_rememberMe.Size = new System.Drawing.Size(111, 17);
            this.checkBox_rememberMe.TabIndex = 98;
            this.checkBox_rememberMe.Text = "запомнить почту";
            this.checkBox_rememberMe.UseVisualStyleBackColor = true;
            // 
            // button_mailing_Update
            // 
            this.button_mailing_Update.Enabled = false;
            this.button_mailing_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_mailing_Update.Location = new System.Drawing.Point(449, 22);
            this.button_mailing_Update.Name = "button_mailing_Update";
            this.button_mailing_Update.Size = new System.Drawing.Size(28, 22);
            this.button_mailing_Update.TabIndex = 99;
            this.button_mailing_Update.Text = "✎";
            this.button_mailing_Update.UseVisualStyleBackColor = true;
            this.button_mailing_Update.Click += new System.EventHandler(this.button_mailing_Update_Click);
            // 
            // button_passwordVisible
            // 
            this.button_passwordVisible.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_passwordVisible.Location = new System.Drawing.Point(449, 147);
            this.button_passwordVisible.Name = "button_passwordVisible";
            this.button_passwordVisible.Size = new System.Drawing.Size(28, 22);
            this.button_passwordVisible.TabIndex = 100;
            this.button_passwordVisible.Text = "✎";
            this.button_passwordVisible.UseVisualStyleBackColor = true;
            this.button_passwordVisible.MouseEnter += new System.EventHandler(this.button_passwordVisible_MouseEnter);
            this.button_passwordVisible.MouseLeave += new System.EventHandler(this.button_passwordVisible_MouseLeave);
            // 
            // MailingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 601);
            this.Controls.Add(this.button_passwordVisible);
            this.Controls.Add(this.button_mailing_Update);
            this.Controls.Add(this.checkBox_rememberMe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox_mailing);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.guna2DataGridView_Files);
            this.Controls.Add(this.button_addFile);
            this.Controls.Add(this.label_addressname);
            this.Controls.Add(this.guna2DataGridView_Emails);
            this.Controls.Add(this.label_validation12);
            this.Controls.Add(this.label_validation13);
            this.Controls.Add(this.label_validation4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_validation2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_validation1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_accept);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MailingForm";
            this.Text = "MailingForm";
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView_Emails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView_Files)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_accept;
        private System.Windows.Forms.Label label_validation1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_validation2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_validation4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_validation13;
        private System.Windows.Forms.Label label_validation12;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView_Emails;
        private System.Windows.Forms.Label label_addressname;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button button_addFile;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView_Files;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_mailing;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox_rememberMe;
        private System.Windows.Forms.Button button_mailing_Update;
        private System.Windows.Forms.Button button_passwordVisible;
    }
}