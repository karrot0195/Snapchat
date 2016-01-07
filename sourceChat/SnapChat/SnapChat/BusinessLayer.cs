using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnapChat
{
    class BusinessLayer
    {
        //Webservice
        public ServiceReference1.Service_DatachatSoapClient svcl;
        //Dataset
        public DataSet ds;

        //contructor
        public BusinessLayer()
        {
            svcl = new ServiceReference1.Service_DatachatSoapClient();
            //load dữ liệu bảng Users cho dataset
            ds = svcl.loadDatafromTable("Users","");
        }

        //load dữ liệu của bảng nametable với điều kiện queue
        public DataSet loadData(String nametable, String queue)
        {
            return svcl.loadDatafromTable(nametable, queue);
        }
        //Load danh sách chat
        public void loadListViewChat(String ID, ListView lv){
            //chứa list ban be
            DataSet ds = loadData("FriendList", "");
            //chua thong tin user
            DataSet ds2 = loadData("Users", "");
            
            //
            DataTable dt = ds.Tables[0];
            DataTable dt2 = ds2.Tables[0];
            //
            lv.View = View.Details;
            lv.Columns.Add("Friends", 100);
            lv.Columns.Add("Stast",100);
            //truyen du lieu vao listview
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["IDUser"].ToString().Equals(ID))
                {
                    for (int j = 0; j < dt2.Rows.Count; j++)
                    {
                        if (dt2.Rows[j]["IDUser"].ToString().Equals(dt.Rows[i]["IDFriendList"].ToString()))
                        {
                            ListViewItem items = new ListViewItem(dt2.Rows[j]["Username"].ToString());
                            String s = (dt2.Rows[j]["State"].Equals(true))?"ON":"OFF";
                            items.SubItems.Add(s);
                            lv.Items.Add(items);
                        }
                    }
                }
            }
        }

        //giá trị state của user
        public bool isState(String p, String id)
        {
            return svcl.changeStateUser(p, id);
        }

        //kiểm tra đăng nhập
        internal int testDangNhap(System.Windows.Forms.TextBox txtuser, System.Windows.Forms.TextBox txtpass)
        {
            DataTable tb = ds.Tables[0];
            if (txtuser.Text == "" || txtpass.Text == "")
                return 0;
            for (int i = 0; i < tb.Rows.Count; i++)
            {
               
                if (txtuser.Text.Equals(tb.Rows[i]["Username"]))                {
                    if (txtpass.Text.Equals(tb.Rows[i]["Password"]))
                    {
                        return (int)tb.Rows[i]["IDUser"];

                    }
                        
                }
            }
                return 0;
        }
       //Lưu tin nhắn gửi đi
        internal bool saveDataOfMess(int id_user, string sendername, string content)
        {
            int idsender = svcl.findIDfromUsername(sendername);
            return svcl.insertDatatoMessage(id_user + "", idsender + "", DateTime.Now, content, "0");
        }

        //load tất cả tin nhắn lên
        internal void loadallMessage(string idUser, Label lb_Sender, ListView listView_khungchat)
        {
           String idSender = svcl.findIDfromUsername(lb_Sender.Text)+"";
                //Danh sách tin nhắn theo thứ thự sắp xếp thời gian
                DataTable tb = svcl.loadDatafromTable("Message order by DateTime", "").Tables[0];
                //
                listView_khungchat.Columns.Add("Message", 500, HorizontalAlignment.Center);
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    DataRow row = tb.Rows[i];
                    string mess = "";
                    //Tin được nhận
                    if (row[1].ToString() == idUser && row[0].ToString()== idSender)
                    {
                       svcl.changeStateMess("true", row[0].ToString(), row[1].ToString(), row[2].ToString());
                        mess = lb_Sender.Text + ": " + row["Message"].ToString();
                        ListViewItem item = new ListViewItem(mess);
                        listView_khungchat.Items.Add(item);
                    }
                        //tin gửi
                    else if (row[1].ToString() == idSender && row[0].ToString() == idUser)
                    {
                        mess = "me: " + row["Message"].ToString();
                        ListViewItem item = new ListViewItem(mess);
                        listView_khungchat.Items.Add(item);
                    }
                    
                }
        }

        internal void loadnewMessage(string idUser, Label lb_Sender, ListView listView_khungchat)
        {
            String idSender = svcl.findIDfromUsername(lb_Sender.Text) + "";
            //Danh sách tin nhắn theo thứ thự sắp xếp thời gian
            DataTable tb = svcl.loadDatafromTable("Message order by DateTime", "").Tables[0];
            //
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                DataRow row = tb.Rows[i];
                string mess = "";
                //Tin được nhận
                if (row[1].ToString() == idUser && row[0].ToString() == idSender && row[4].ToString()=="False")
                {
                    svcl.changeStateMess("true", row[0].ToString(), row[1].ToString(), row[2].ToString());
                    mess = lb_Sender.Text + ": " + row["Message"].ToString();
                    ListViewItem item = new ListViewItem(mess);
                    listView_khungchat.Items.Add(item);
                }
            }
          
        }

        internal bool testDangKi(TextBox txt_username, TextBox txt_pas, TextBox txt_re, TextBox txt_email)
        {
            if (txt_pas.Text != txt_re.Text)
            {
                return false;
            }
            return svcl.insertUsers(txt_username.Text, txt_pas.Text, "False", "", txt_email.Text, "");
        }
    }
}
