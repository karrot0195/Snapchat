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
        public void connectData(){
            Connect = System.Configuration.ConfigurationSettings.AppSettings["connectstring"];
            Cnt = new SqlConnection();
            Cnt.ConnectionString = Connect;
        }
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
         [WebMethod]
        public bool changeState(String p, String id)
         {
             connectData();             
             Cnt.Open();
             String t = "UPDATE Users set State='"+p+"' where IDUser='"+id+"'";
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
            [WebMethod]
       public bool insertDatatoMessage(string id_user, string id_sender,DateTime time, string content)
        {
            try
            {
                connectData();
                Cnt.Open();
                String t = "insert Message values('" + id_user + "','" + id_sender + "','" + time + "','" + content + "')";
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
