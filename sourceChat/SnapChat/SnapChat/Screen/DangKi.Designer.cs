namespace SnapChat
{
    partial class DangKi
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
            this.btn_log = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.group_information = new System.Windows.Forms.GroupBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_re = new System.Windows.Forms.TextBox();
            this.txt_pas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.group_information.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_log
            // 
            this.btn_log.BackColor = System.Drawing.Color.DarkViolet;
            this.btn_log.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_log.ForeColor = System.Drawing.Color.Transparent;
            this.btn_log.Location = new System.Drawing.Point(42, 195);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(75, 23);
            this.btn_log.TabIndex = 8;
            this.btn_log.Text = "Đăng kí";
            this.btn_log.UseVisualStyleBackColor = false;
            this.btn_log.Click += new System.EventHandler(this.btn_log_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.DarkViolet;
            this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.Transparent;
            this.btn_exit.Location = new System.Drawing.Point(152, 195);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // group_information
            // 
            this.group_information.BackColor = System.Drawing.Color.Transparent;
            this.group_information.Controls.Add(this.txt_email);
            this.group_information.Controls.Add(this.label3);
            this.group_information.Controls.Add(this.txt_re);
            this.group_information.Controls.Add(this.txt_pas);
            this.group_information.Controls.Add(this.label2);
            this.group_information.Controls.Add(this.txt_username);
            this.group_information.Controls.Add(this.label1);
            this.group_information.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_information.ForeColor = System.Drawing.Color.White;
            this.group_information.Location = new System.Drawing.Point(12, 12);
            this.group_information.Name = "group_information";
            this.group_information.Size = new System.Drawing.Size(251, 164);
            this.group_information.TabIndex = 10;
            this.group_information.TabStop = false;
            this.group_information.Text = "Thông tin";
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.Color.Violet;
            this.txt_email.ForeColor = System.Drawing.Color.Blue;
            this.txt_email.Location = new System.Drawing.Point(82, 124);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(151, 23);
            this.txt_email.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Email:";
            // 
            // txt_re
            // 
            this.txt_re.BackColor = System.Drawing.Color.Violet;
            this.txt_re.ForeColor = System.Drawing.Color.Blue;
            this.txt_re.Location = new System.Drawing.Point(82, 93);
            this.txt_re.Name = "txt_re";
            this.txt_re.Size = new System.Drawing.Size(151, 23);
            this.txt_re.TabIndex = 12;
            // 
            // txt_pas
            // 
            this.txt_pas.BackColor = System.Drawing.Color.Violet;
            this.txt_pas.ForeColor = System.Drawing.Color.Blue;
            this.txt_pas.Location = new System.Drawing.Point(82, 67);
            this.txt_pas.Name = "txt_pas";
            this.txt_pas.Size = new System.Drawing.Size(151, 23);
            this.txt_pas.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mật khẩu:";
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.Violet;
            this.txt_username.ForeColor = System.Drawing.Color.Blue;
            this.txt_username.Location = new System.Drawing.Point(82, 31);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(151, 23);
            this.txt_username.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên:";
            // 
            // DangKi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SnapChat.Properties.Resources.Icon2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(285, 233);
            this.Controls.Add(this.group_information);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_log);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "DangKi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Kí";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DangKi_FormClosing);
            this.group_information.ResumeLayout(false);
            this.group_information.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_log;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.GroupBox group_information;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_re;
        private System.Windows.Forms.TextBox txt_pas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label1;
    }
}