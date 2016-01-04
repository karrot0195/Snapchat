namespace SnapChat
{
    partial class frmGiaoDien
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
            this.listViewdanhsach = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.listView_khungchat = new System.Windows.Forms.ListView();
            this.txt_tinnhan = new System.Windows.Forms.TextBox();
            this.btn_gui = new System.Windows.Forms.Button();
            this.loadeventListFriend = new System.Windows.Forms.Timer(this.components);
            this.lb_Sender = new System.Windows.Forms.Label();
            this.loadeventLKhungChat = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // listViewdanhsach
            // 
            this.listViewdanhsach.BackColor = System.Drawing.Color.Wheat;
            this.listViewdanhsach.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listViewdanhsach.Location = new System.Drawing.Point(427, 35);
            this.listViewdanhsach.Name = "listViewdanhsach";
            this.listViewdanhsach.Size = new System.Drawing.Size(146, 271);
            this.listViewdanhsach.TabIndex = 0;
            this.listViewdanhsach.UseCompatibleStateImageBehavior = false;
            this.listViewdanhsach.SelectedIndexChanged += new System.EventHandler(this.listViewdanhsach_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(458, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách chat";
            // 
            // listView_khungchat
            // 
            this.listView_khungchat.BackColor = System.Drawing.Color.NavajoWhite;
            this.listView_khungchat.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listView_khungchat.Location = new System.Drawing.Point(25, 35);
            this.listView_khungchat.Name = "listView_khungchat";
            this.listView_khungchat.Size = new System.Drawing.Size(348, 189);
            this.listView_khungchat.TabIndex = 2;
            this.listView_khungchat.UseCompatibleStateImageBehavior = false;
            this.listView_khungchat.View = System.Windows.Forms.View.Details;
            // 
            // txt_tinnhan
            // 
            this.txt_tinnhan.Enabled = false;
            this.txt_tinnhan.Location = new System.Drawing.Point(25, 252);
            this.txt_tinnhan.Multiline = true;
            this.txt_tinnhan.Name = "txt_tinnhan";
            this.txt_tinnhan.Size = new System.Drawing.Size(278, 54);
            this.txt_tinnhan.TabIndex = 3;
            // 
            // btn_gui
            // 
            this.btn_gui.Location = new System.Drawing.Point(309, 252);
            this.btn_gui.Name = "btn_gui";
            this.btn_gui.Size = new System.Drawing.Size(64, 54);
            this.btn_gui.TabIndex = 4;
            this.btn_gui.Text = "Gửi";
            this.btn_gui.UseVisualStyleBackColor = true;
            this.btn_gui.Click += new System.EventHandler(this.btn_gui_Click);
            // 
            // loadeventListFriend
            // 
            this.loadeventListFriend.Interval = 5000;
            this.loadeventListFriend.Tick += new System.EventHandler(this.loadeventListFriend_Tick);
            // 
            // lb_Sender
            // 
            this.lb_Sender.AutoSize = true;
            this.lb_Sender.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_Sender.ForeColor = System.Drawing.Color.Red;
            this.lb_Sender.Location = new System.Drawing.Point(25, 234);
            this.lb_Sender.Name = "lb_Sender";
            this.lb_Sender.Size = new System.Drawing.Size(46, 15);
            this.lb_Sender.TabIndex = 5;
            this.lb_Sender.Text = "Sender:";
            this.lb_Sender.TextChanged += new System.EventHandler(this.lb_Sender_TextChanged);
            // 
            // loadeventLKhungChat
            // 
            this.loadeventLKhungChat.Interval = 5000;
            this.loadeventLKhungChat.Tick += new System.EventHandler(this.loadeventLKhungChat_Tick);
            // 
            // frmGiaoDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 318);
            this.Controls.Add(this.lb_Sender);
            this.Controls.Add(this.btn_gui);
            this.Controls.Add(this.txt_tinnhan);
            this.Controls.Add(this.listView_khungchat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewdanhsach);
            this.Name = "frmGiaoDien";
            this.Text = "GiaoDien";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGiaoDien_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewdanhsach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView_khungchat;
        private System.Windows.Forms.TextBox txt_tinnhan;
        private System.Windows.Forms.Button btn_gui;
        private System.Windows.Forms.Timer loadeventListFriend;
        private System.Windows.Forms.Label lb_Sender;
        private System.Windows.Forms.Timer loadeventLKhungChat;
    }
}