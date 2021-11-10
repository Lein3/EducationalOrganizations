namespace EducationalOrganizationsApp
{
    partial class LoadingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingForm));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_val = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.guna2CircleProgressBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(54, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(572, 63);
            this.label3.TabIndex = 10;
            this.label3.Text = "сейчас все загрузим";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(54, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(868, 63);
            this.label2.TabIndex = 9;
            this.label2.Text = "у нас очень много организаций";
            // 
            // label_val
            // 
            this.label_val.AutoSize = true;
            this.label_val.BackColor = System.Drawing.Color.Transparent;
            this.label_val.Font = new System.Drawing.Font("Bahnschrift Condensed", 90F);
            this.label_val.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(186)))), ((int)(((byte)(235)))));
            this.label_val.Location = new System.Drawing.Point(326, 371);
            this.label_val.Name = "label_val";
            this.label_val.Size = new System.Drawing.Size(110, 144);
            this.label_val.TabIndex = 8;
            this.label_val.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(684, 515);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Loading ...";
            // 
            // guna2PictureBox
            // 
            this.guna2PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox.Image")));
            this.guna2PictureBox.ImageRotate = 0F;
            this.guna2PictureBox.Location = new System.Drawing.Point(557, 245);
            this.guna2PictureBox.Name = "guna2PictureBox";
            this.guna2PictureBox.ShadowDecoration.Parent = this.guna2PictureBox;
            this.guna2PictureBox.Size = new System.Drawing.Size(314, 255);
            this.guna2PictureBox.TabIndex = 6;
            this.guna2PictureBox.TabStop = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // guna2CircleProgressBar
            // 
            this.guna2CircleProgressBar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2CircleProgressBar.ForeColor = System.Drawing.Color.White;
            this.guna2CircleProgressBar.Location = new System.Drawing.Point(167, 385);
            this.guna2CircleProgressBar.Minimum = 0;
            this.guna2CircleProgressBar.Name = "guna2CircleProgressBar";
            this.guna2CircleProgressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressBar.ShadowDecoration.Parent = this.guna2CircleProgressBar;
            this.guna2CircleProgressBar.Size = new System.Drawing.Size(130, 130);
            this.guna2CircleProgressBar.TabIndex = 0;
            this.guna2CircleProgressBar.Text = "guna2CircleProgressBar1";
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.label_val);
            this.Controls.Add(this.guna2CircleProgressBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingForm";
            this.Load += new System.EventHandler(this.Loading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_val;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox;
        private System.Windows.Forms.Timer timer;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar;
    }
}