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

       

        public frmGiaoDien()
        {
            InitializeComponent();
        }

        public frmGiaoDien(int p)
        {
            // TODO: Complete member initialization
            this.Id_user = p;
            
            this.viewLayer = new ViewLayer();
            InitializeComponent();
            viewLayer.loadGiaoDien(Id_user, listViewdanhsach);
            loadeventListFriend.Start();
            this.Text = viewLayer.setUser(Id_user);
            
            
        }

    

     

        private void btn_gui_Click(object sender, EventArgs e)
        {

            viewLayer.sendMessage(id_user, lb_Sender.Text, txt_tinnhan, listView_khungchat);
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
            listView_khungchat.Clear();
            viewLayer.loadMessage(id_user, lb_Sender, listView_khungchat);

        }
    }
}
