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
    public partial class DangKi : Form
    {
     

        public DangKi()
        {
            InitializeComponent();
             
        }

   
        private void btn_log_Click(object sender, EventArgs e)
        {
            ViewLayer vl = new ViewLayer();
            String s = (vl.clickDangKi(txt_username, txt_pas, txt_re, txt_email) == true) ? "Đăng kí thành công" : "Thông tin không hợp lệ";
            MessageBox.Show(s, "");
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DangKi_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
