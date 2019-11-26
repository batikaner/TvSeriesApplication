using DAL;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TvSeries.MODEL;

namespace TvSeries.BLL
{

    public class MemberBL

    {
        DataAccess DataAcc = new DataAccess();

        
        public bool AddaMember(Members mbs)
        {
            SqlParameter[] param = { new SqlParameter("@tv_username", mbs.member_username), new SqlParameter("@tv_userpass", mbs.member_passwd) };
            int feedback = DataAcc.ExecuteNonQuery("Insert into tbl_userlogin values (@tv_username,@tv_userpass)", param);
            return feedback > 0;
            

        }
        //SqlConnection cn = null;


        //public Members GetMembers(string tv_username)
        //{
        //    SqlParameter[] p = { new SqlParameter("@tv_username", tv_username) };
        //    SqlDataReader dtr = DataAcc.ExecuteReader("select * from tbl_userlogin  where tv_username= @tv_username", p);
        //    Members mem = null;
        //    if (dtr.Read())
        //    {
        //        mem = new Members();
        //        mem.member_username = dtr["tv_username"].ToString();
        //        mem.member_passwd = dtr["tv_userpass"].ToString();
        //    }
        //    dtr.Close();
        //    DataAcc.ConnKapat();

            //SqlDataReader dr;
            //cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString);
            //SqlCommand cm = new SqlCommand();
            //cn.Open();

            //Members mem = new Members();            
            //cm.CommandText = ("SELECT * FROM tbl_userlogin where tv_username='" + mem.member_username+ "' AND tv_userpass='" + mem.member_passwd);
            //cn.Close();
           // return mem;
       // }

        //public void veriTabaniBakA(string yser, string pswd)
        //{

        //    SqlDataReader dr;
        //    cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString);
        //    SqlCommand cm = new SqlCommand();
        //    cn.Open();

        //    Members mem = new Members();
        //    cm.CommandText = ("SELECT * FROM tbl_userlogin where tv_username='" + mem.member_username + "' AND tv_userpass='" + mem.member_passwd);
        //    cn.Close();



        //}
    }
}
