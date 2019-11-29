using DAL;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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

        public bool cvp;
        DataAccess DataAcc = new DataAccess();

        public bool AddaMember(Members mbs)
        {
            try
            {
                SqlParameter[] param = { new SqlParameter("@tv_username", mbs.member_username), new SqlParameter("@tv_userpass", mbs.member_passwd) };
                int feedback = DataAcc.ExecuteNonQuery("Insert into tbl_userlogin values (@tv_username,@tv_userpass)", param);
                return feedback > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public List<Members> memberList()
        {

            //Username ComboBox 
            SqlDataReader dr = DataAcc.ExecuteReader("Select tv_userID,tv_username,tv_userpass from tbl_userlogin", null);
            List<Members> lst = new List<Members>();
            while (dr.Read())
            {
                lst.Add(new Members { member_username = dr["tv_username"].ToString(), tv_userID = Convert.ToInt32(dr["tv_userID"]) });
            }
            dr.Close();
            lst.Insert(0, new Members { member_username = "Seçiniz" });
            return lst;
        }

        public Members MemberLogin(string tv_name,string tv_pass)
        {
            Members mb = new Members();
            try
            {
                SqlParameter[] p = { new SqlParameter("@tv_username", tv_name),new SqlParameter("tv_userpass",tv_pass) };
                SqlDataReader dr = DataAcc.ExecuteReader("select * from  tbl_userlogin WHERE tv_username=@tv_username and tv_userpass=@tv_userpass", p);
                Members mem = null;

                if (dr.Read())
                {
                    mem = new Members();
                    mem.member_username = dr["tv_username"].ToString();
                    mem.member_passwd = dr["tv_userpass"].ToString();
                }

                dr.Close();
                return mem;
            }
            catch (Exception)
            {
                throw;
            }
        }





    }
}
