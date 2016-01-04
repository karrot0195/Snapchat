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
        public ServiceReference1.Service_DatachatSoapClient svcl;
        public DataSet ds;

        //contructor
        public BusinessLayer()
        {
            svcl = new ServiceReference1.Service_DatachatSoapClient();
            ds = svcl.loadDatafromTable("Users","");
        }

        //load dữ liệu user
        public DataSet loadData(String nametable, String queue)
        {
            return svcl.loadDatafromTable(nametable, queue);
        }
        
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
            lv.Columns.Add("Friends");
            lv.Columns.Add("Stast");
            //truyen du lieu vao listview
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //String s1 = dt.Rows[i]["IDUser"].ToString();
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
        //thao tac state cua user
        public bool isState(String p, String id)
        {
            return svcl.changeState(p, id);
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

      
       
        internal bool saveDataOfMess(int id_user, string p1, string p2)
        {
            int idsender = svcl.findIDfromUsername(p1);
            return svcl.insertDatatoMessage(id_user+"", idsender+"",DateTime.Now, p2);
        }

        internal void loadMessage(string idUser, Label lb_Sender, ListView listView_khungchat)
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
                    if (row[1].ToString() == idUser && row[0].ToString()== idSender)
                    {
                        mess = lb_Sender.Text + ": " + row["Message"].ToString();
                        ListViewItem item = new ListViewItem(mess);
                        listView_khungchat.Items.Add(item);
                    }
                    else if (row[1].ToString() == idSender && row[0].ToString() == idUser)
                    {
                        mess = "me: " + row["Message"].ToString();
                        ListViewItem item = new ListViewItem(mess);
                        listView_khungchat.Items.Add(item);
                    }
                    
                }
        }
    }
}
