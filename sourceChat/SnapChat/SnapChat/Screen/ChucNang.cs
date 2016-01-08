using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnapChat.Screen
{
    public partial class frmChucNang : Form
    {
        public frmChucNang(String s1)
        {
            InitializeComponent();
            label1.Text = s1;
            this.Text = s1;
        }
        public delegate void del(String s);
       public  del send_Info;
        private void btn_OK_Click(object sender, EventArgs e)
        {
            send_Info.Invoke(textBox1.Text);
            this.Close();
        }
    }
}
