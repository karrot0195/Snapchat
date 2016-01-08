using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnapChat
{
    public partial class frmDangNhap : Form
    {
        #region varible
        ViewLayer vl;
        #endregion
        public frmDangNhap()
        {
            InitializeComponent();
            vl = new ViewLayer();
        }

        #region event
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            int id = vl.clickDangNhap(txtuser, txtpass);
          
            if (id != 0)
            {
                frmGiaoDien gd = new frmGiaoDien(id);
                this.Visible = false;
                if (gd.ShowDialog() == DialogResult.Cancel)
                {
                    this.Close();
                }
                else if (gd.ShowDialog() == DialogResult.Yes)
                {
                    this.Visible = true;
                    txtpass.Text = "";
                    txtuser.Text = "";
                }
               
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Lỗi", "");
                txtpass.Text = "";
                txtuser.Text = "";
            }

        }

        private void btn_dangki_Click(object sender, EventArgs e)
        {
            //vl.clickDangKi(txtuser, txtpass);
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

     
        private void linkLb_Sign_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKi dk = new DangKi();
            this.Visible = false;
          //  dk.Show();
            if (dk.ShowDialog() == DialogResult.Cancel)
            {
                dk.Close();
                this.Visible = true;
                vl = new ViewLayer();
            }
            else
            {
                linkLb_Sign_LinkClicked(sender, e);
            }
          
           // frmDangNhap.ActiveForm.Visible = true;

        }
        //Bắt sự kiên lấy lại mật khẩu
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Mật khẩu đã được khôi phục mặc định!", "THÔNG BÁO");
        }
        #endregion

       

      

    }
}
