using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IXoaTK
{
    public partial class XoaTaiKhoan : Form, IChucNang.IChucNang
    {
        public XoaTaiKhoan()
        {
            InitializeComponent();
        }
        
          String ten = "Delete Account";

        public String Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        String key = "deleteAccount";
        String value;
        public String Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public String Key
        {
            get { return key; }
            set { key = value; }
        }

        void IChucNang.IChucNang.laygiatri()
        {
            Value = "";
        }

        public Form GiaoDien
        {
            get {return this;}
        }


        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            Value = "";
        }
    }
}
