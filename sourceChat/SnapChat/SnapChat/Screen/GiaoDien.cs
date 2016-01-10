using SnapChat.PlugIns;
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
    public partial class frmGiaoDien : Form
    {
        private int id_user;
        public int Id_user
        {
            get { return id_user; }
            set { id_user = value; }
        }
        private ViewLayer viewLayer;
        private string p;


        private static frmGiaoDien singleObject;
        private frmGiaoDien()
        {
            InitializeComponent();
        }
        private frmGiaoDien(int p)
        {
            // TODO: Complete member initialization
            this.Id_user = p;
            
            this.viewLayer = new ViewLayer();
            InitializeComponent();
            viewLayer.loadGiaoDien(Id_user, listViewdanhsach);
            loadeventListFriend.Start();
            this.Text = viewLayer.setUser(Id_user);     
        }
        public static frmGiaoDien getInstance(int p)
        {
            if (singleObject == null)
            {
                singleObject = new frmGiaoDien(p);
            }
            return singleObject;
        }
        public static frmGiaoDien getInstance()
        {
            if (singleObject == null)
            {
                singleObject = new frmGiaoDien();
            }
            return singleObject;
        }

        private void btn_gui_Click(object sender, EventArgs e)
        {

            viewLayer.clicksendMessage(id_user, lb_Sender.Text, txt_tinnhan, listView_khungchat);
        }

        private void frmGiaoDien_FormClosing(object sender, FormClosingEventArgs e)
        {
            viewLayer.closeGiaoDien(Id_user);
        }

 
        private void listViewdanhsach_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                ListView lv = (ListView)sender;
                listView_khungchat.Clear();
                lb_Sender.Text = lv.SelectedItems[0].Text;
                //
                viewLayer.loadMessage(id_user, lb_Sender, listView_khungchat);
                loadeventLKhungChat.Start();
               
            }
            catch
            {

            }
            
        }

        private void lb_Sender_TextChanged(object sender, EventArgs e)
        {
            txt_tinnhan.Enabled = true;
        }

        private void loadeventListFriend_Tick(object sender, EventArgs e)
        {
            listViewdanhsach.Clear();
            viewLayer.updateForm(Id_user, listViewdanhsach);
        }

        private void loadeventLKhungChat_Tick(object sender, EventArgs e)
        {
            //listView_khungchat.Clear();
            viewLayer.loadnewMessage(id_user, lb_Sender, listView_khungchat);

        }

        private void pictureBox_clock_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Delete message!", "Delete message!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                if (viewLayer.clickdelete_message(id_user, lb_Sender, listView_khungchat))
                {
                    listView_khungchat.Clear();
                    viewLayer.loadMessage(id_user, lb_Sender, listView_khungchat);
                }
              
            }
         }
       //Thêm bạn
     
     
        private void frmGiaoDien_Load(object sender, EventArgs e)
        {
            string ThuMuc_PlugIn = Application.StartupPath + @"\PlugIns\";
            //Lấy các nhân vật trong thư mục PlugIn

            PlugIns.QL.Lay_Chuc_Nang(ThuMuc_PlugIn);
            int i = 0;
            foreach (ChucNang cn in PlugIns.QL.DsChucNang)
            {
                menuChucnang.DropDownItems.Add(cn.Chucnang.Ten);
                menuChucnang.DropDownItems[i].Click += new EventHandler(clickItemMenu);
              
                i++;
            }
        }

        private void clickItemMenu(object sender, EventArgs e)
        {
            String s = sender + "";
            PlugIns.QL.clear();
            string ThuMuc_PlugIn = Application.StartupPath + @"\PlugIns\";
            //Lấy các nhân vật trong thư mục PlugIn

            PlugIns.QL.Lay_Chuc_Nang(ThuMuc_PlugIn);

            foreach (ChucNang cn in PlugIns.QL.DsChucNang)
            {
               if(cn.Chucnang.Ten == s){
                   Form GD = cn.Chucnang.GiaoDien;
                   
                   if (GD.ShowDialog() == DialogResult.OK)
                   {
                       GD.Close();
                       String s1 = cn.Chucnang.Value;
                       String s2 = cn.Chucnang.Key;
                       if (viewLayer.ClickFunction(s2, Id_user, s1))
                       {
                           MessageBox.Show("Complete!", "");
                       }
                       else
                       {
                           MessageBox.Show("Fail", "");
                       }
                   }
               }
            }
        }

        private void menuDangxuat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
