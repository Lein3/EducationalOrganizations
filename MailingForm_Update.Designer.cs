namespace EducationalOrganizationsApp
{
    partial class MailingForm_Update
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
            this.button_Accept = new System.Windows.Forms.Button();
            this.label_validation12 = new System.Windows.Forms.Label();
            this.label_validation13 = new System.Windows.Forms.Label();
            this.label_validation2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_validation1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Accept
            // 
            this.button_Accept.Location = new System.Drawing.Point(158, 120);
            this.button_Accept.Name = "button_Accept";
            this.button_Accept.Size = new System.Drawing.Size(120, 50);
            this.button_Accept.TabIndex = 91;
            this.button_Accept.Text = "Подтвердить";
            this.button_Accept.UseVisualStyleBackColor = true;
            this.button_Accept.Click += new System.EventHandler(this.button_Accept_Click);
            // 
            // label_validation12
            // 
            this.label_validation12.AutoSize = true;
            this.label_validation12.ForeColor = System.Drawing.Color.Red;
            this.label_validation12.Location = new System.Drawing.Point(98, 13);
            this.label_validation12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_validation12.Name = "label_validation12";
            this.label_validation12.Size = new System.Drawing.Size(150, 13);
            this.label_validation12.TabIndex = 106;
            this.label_validation12.Text = "Почта введена неккоректно";
            this.label_validation12.Visible = false;
            // 
            // label_validation13
            // 
            this.label_validation13.AutoSize = true;
            this.label_validation13.ForeColor = System.Drawing.Color.Red;
            this.label_validation13.Location = new System.Drawing.Point(379, 13);
            this.label_validation13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_validation13.Name = "label_validation13";
            this.label_validation13.Size = new System.Drawing.Size(65, 39);
            this.label_validation13.TabIndex = 105;
            this.label_validation13.Text = "@mail.ru\r\n@gmail.com\r\n@yandex.ru";
            this.label_validation13.Visible = false;
            // 
            // label_validation2
            // 
            this.label_validation2.AutoSize = true;
            this.label_validation2.ForeColor = System.Drawing.Color.Red;
            this.label_validation2.Location = new System.Drawing.Point(268, 56);
            this.label_validation2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_validation2.Name = "label_validation2";
            this.label_validation2.Size = new System.Drawing.Size(105, 13);
            this.label_validation2.TabIndex = 104;
            this.label_validation2.Text = "обязательное поле";
            this.label_validation2.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(275, 20);
            this.textBox2.TabIndex = 103;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 102;
            this.label2.Text = "Пароль";
            // 
            // label_validation1
            // 
            this.label_validation1.AutoSize = true;
            this.label_validation1.ForeColor = System.Drawing.Color.Red;
            this.label_validation1.Location = new System.Drawing.Point(268, 13);
            this.label_validation1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_validation1.Name = "label_validation1";
            this.label_validation1.Size = new System.Drawing.Size(105, 13);
            this.label_validation1.TabIndex = 101;
            this.label_validation1.Text = "обязательное поле";
            this.label_validation1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 20);
            this.textBox1.TabIndex = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 99;
            this.label1.Text = "Логин";
            // 
            // MailingForm_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 202);
            this.Controls.Add(this.label_validation12);
            this.Controls.Add(this.label_validation13);
            this.Controls.Add(this.label_validation2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_validation1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Accept);
            this.Name = "MailingForm_Update";
            this.Text = "Обновить";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Accept;
        private System.Windows.Forms.Label label_validation12;
        private System.Windows.Forms.Label label_validation13;
        private System.Windows.Forms.Label label_validation2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_validation1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}