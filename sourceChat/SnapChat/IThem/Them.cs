using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IThem
{
    public partial class Them : Form, IChucNang.IChucNang
    {
        String ten = "Add Friend";

        public String Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        String key = "addFriend";
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
        public Them()
        {
            InitializeComponent();
        }

        void IChucNang.IChucNang.laygiatri()
        {
            Value = txtnhap.Text;
        }

        public Form GiaoDien
        {
            get {return this;}
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Value = txtnhap.Text;
            this.Close();
        }
    }
}
