using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;

namespace DataChat
{
    /// <summary>
    /// Summary description for Service_Datachat
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service_Datachat : System.Web.Services.WebService
    {
        //Biến kết nối
        private String connect;

        public String Connect1
        {
            get { return connect; }
            set { connect = value; }
        }
        private SqlConnection cnt;

        public SqlConnection Cnt
        {
            get { return cnt; }
            set { cnt = value; }
        }
        private SqlDataAdapter da;

        public SqlDataAdapter Da
        {
            get { return da; }
            set { da = value; }
        }
        private DataSet ds;

        public DataSet Ds
        {
            get { return ds; }
            set { ds = value; }
        }

        public String Connect
        {
            get { return Connect1; }
            set { Connect1 = value; }
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        //Kết nối CSDL
        public void connectData(){
            Connect = System.Configuration.ConfigurationSettings.AppSettings["connectstring"];
            Cnt = new SqlConnection();
            Cnt.ConnectionString = Connect;
        }
        //Load tất cả dữ liệu bản Users
         [WebMethod]
        public DataSet loadAllData()
        {
            Connect = System.Configuration.ConfigurationSettings.AppSettings["connectstring"];
            Cnt = new SqlConnection();
            Ds = new DataSet();
            Cnt.ConnectionString = Connect;
            Da = new SqlDataAdapter("select* from Users", Cnt);
            Da.Fill(Ds);
            return Ds;
        }
        //Load dữ liệu từ bản table
         [WebMethod]
         public DataSet loadDatafromTable(String table, String queue)
         {
             connectData();
             Ds = new DataSet();
             if (queue == "")
                  Da = new SqlDataAdapter("select* from " + table, Cnt);
             else
                 Da = new SqlDataAdapter("select* from " + table + " where " + queue, Cnt);

             Da.Fill(Ds);
             return Ds;
         }
        //Thay đổi trang thái online của người dùng
         [WebMethod]
        public bool changeStateUser(String state, String id)
         {
             connectData();             
             Cnt.Open();
             String t = "UPDATE Users set State='"+state+"' where IDUser='"+id+"'";
             SqlCommand cmn = new SqlCommand();
             cmn.Connection = Cnt;
             cmn.CommandType = CommandType.Text;
             cmn.CommandText = t;
             cmn.ExecuteNonQuery();
              Cnt.Close();
             return true;
         }
        [WebMethod]
        public bool changeStateMess(String state, String id1, String id2, String dt)
        {
            connectData();
            Cnt.Open();
            String t = "UPDATE Message set State='" + state + "' where IDUser=' " + id1 +"' and IDSender = '" +id2+ "' and DateTime = '" + dt + "'";
            SqlCommand cmn = new SqlCommand();
            cmn.Connection = Cnt;
            cmn.CommandType = CommandType.Text;
            cmn.CommandText = t;
            cmn.ExecuteNonQuery();
            Cnt.Close();
            return true;
        }

        [WebMethod]
        public int findIDfromUsername(String s)
         {
             try
             {
                 return (int)loadDatafromTable("Users", "Username = '" + s+"'").Tables[0].Rows[0]["IDUser"];
             }
             catch
             {
                 return 0;
             }
         }

        [WebMethod]
         public String findUsernamefromID(int ID)
         {
             try
             {
                 return (String)loadDatafromTable("Users", "IDUser = " + ID).Tables[0].Rows[0]["Username"]; 
             }
             catch
             {
                 return "";
             }
            
         }
        //Chèn thêm thêm dữ liệu vào bảng table
        [WebMethod]
        public bool insertUsers(String User, String Pass, String State, String FullName, String Email, String Address)
        {
            try
            {
                String id = loadDatafromTable("Users", "").Tables[0].Rows.Count+1+"";
                if (findIDfromUsername(User) == 0) return false;
                connectData();
                Cnt.Open();
               
                String t = "insert Users values('" + id + "','" + User + "','" + Pass + "','" + State + "','" + FullName + "','" + Email + "','" + Address + "')";
                SqlCommand cmn = new SqlCommand();
                cmn.Connection = Cnt;
                cmn.CommandType = CommandType.Text;
                cmn.CommandText = t;
                cmn.ExecuteNonQuery();
                Cnt.Close();
                return true;
                //String t = "insert Users values('"  +id +"','" + User + "','" + Pass + "','" + State + "','" + FullName +"','"+Email+"','"+Address +"')";

            }
            catch
            {
                return false;
            }
  
        }
      //Thêm dữ liệu vào table Message
        [WebMethod]
       public bool insertDatatoMessage(string id_user, string id_sender,DateTime time, string content, String State)
        {
            try
            {
                connectData();
                Cnt.Open();
                String t = "insert Message values('" + id_user + "','" + id_sender + "','" + time + "','" + content + "','"+ State+"')";
                SqlCommand cmn = new SqlCommand();
                cmn.Connection = Cnt;
                cmn.CommandType = CommandType.Text;
                cmn.CommandText = t;
                cmn.ExecuteNonQuery();
                Cnt.Close();
                return true;
            }
            catch
            {
                return false;
            }
           
        }
    }
}
