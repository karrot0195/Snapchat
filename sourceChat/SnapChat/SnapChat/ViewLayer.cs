using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapChat
{
    class ViewLayer
    {
        BusinessLayer bsl = new BusinessLayer();
        public ViewLayer()
        {

        }



        internal bool clickDangNhap(System.Windows.Forms.TextBox txtuser, System.Windows.Forms.TextBox txtpass)
        {
            int id = bsl.testDangNhap(txtuser, txtpass);
            if (id!=0)
            {
                frmGiaoDien gd = new frmGiaoDien(id);
                gd.Show();
                return true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Lỗi", "");
                txtpass.Text = "";
                txtuser.Text = "";
                return false;
            }

        }





        internal void loadGiaoDien(int ID, System.Windows.Forms.ListView listViewdanhsach)
        {
            bsl.loadListViewChat(ID + "", listViewdanhsach);
            bsl.isState("true", ID+"");
        }

        //
        internal void updateForm(int ID, System.Windows.Forms.ListView listViewdanhsach)
        {
            bsl.loadListViewChat(ID + "", listViewdanhsach);
        }

        internal void closeGiaoDien(int Id_user)
        {
            //tắt chat
            bsl.isState("False", Id_user + "");
        }

        internal void sendMessage(string p, System.Windows.Forms.TextBox txt_tinnhan, System.Windows.Forms.ListView listView_khungchat)
        {

         
            String mess = "Me: "+txt_tinnhan.Text.ToString();
            listView_khungchat.Items.Add(mess);
        }

        internal void sendMessage(int id_user, string p, System.Windows.Forms.TextBox txt_tinnhan, System.Windows.Forms.ListView listView_khungchat)
        {
            bool t = bsl.saveDataOfMess(id_user, p, txt_tinnhan.Text);
            if (t)
            {
                txt_tinnhan.Text = "";
                String mess = "Me: " + txt_tinnhan.Text.ToString();
                listView_khungchat.Items.Add(mess);
            }
            else
            {
                String mess = "Error";
                listView_khungchat.Items.Add(mess);
            }
        }



        internal string setUser(int Id_user)
        {
            return bsl.svcl.findUsernamefromID(Id_user);
        }

        internal void loadMessage(int id_user, System.Windows.Forms.Label lb_Sender, System.Windows.Forms.ListView listView_khungchat)
        {
            bsl.loadMessage(id_user + "", lb_Sender, listView_khungchat);
        }
    }
}
