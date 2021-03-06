﻿using DAL;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
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
                SqlParameter[] param = { new SqlParameter("@tv_username", mbs.member_username), new SqlParameter("@tv_userpass", mbs.member_passwd), new SqlParameter("tv_image",mbs.member_image) };
                int feedback = DataAcc.ExecuteNonQuery("Insert into tbl_userlogin values (@tv_username,@tv_userpass,@tv_image)", param);
                return feedback > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<Members> memberList()
        {
            SqlDataReader dr = DataAcc.ExecuteReader("Select tv_userID,tv_username,tv_userpass from tbl_userlogin", null);
            List<Members> lst = new List<Members>();
            while (dr.Read())
            {
                lst.Add(new Members { member_username = dr["tv_username"].ToString(), tv_userID = Convert.ToInt32(dr["tv_userID"]) });
            }
            dr.Close();
            lst.Insert(0, new Members { member_username = "Seçiniz" });
            DataAcc.Dispose();
            return lst;
        }
        public Members MemberLogin(string tv_name, string tv_pass)
        {
            Members mb = new Members();
            try
            {
                SqlParameter[] p = { new SqlParameter("@tv_username", tv_name), new SqlParameter("tv_userpass", tv_pass) };
                SqlDataReader dr = DataAcc.ExecuteReader("select * from  tbl_userlogin WHERE tv_username=@tv_username and tv_userpass=@tv_userpass", p);
                Members mem = null;
                if (dr.Read())
                {
                    mem = new Members();
                    mem.member_username = dr["tv_username"].ToString();
                    mem.member_passwd = dr["tv_userpass"].ToString();
                 //   mem.member_image = Convert.ToString(dr["tv_image"].ToString());
                }
                DataAcc.Dispose();
                dr.Close();
                return mem;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool MemberDelete(int tvv_userid)
        {
            SqlParameter[] p = { new SqlParameter("@tv_userID", tvv_userid) };
            return DataAcc.ExecuteNonQuery("delete from tbl_userlogin where tv_userID=@tv_userID", p) > 0;
        }
        
        public DataTable MemberList()
        {
            return DataAcc.MyDataTable("select * from tbl_Series");
        }

        public bool MemberUpdate(Members mem)
        {
            SqlParameter[] p = { new SqlParameter("@tv_username", mem.member_username), new SqlParameter("@tv_userpass", mem.member_passwd), new SqlParameter("@tv_userID", mem.tv_userID) };
            int sonuc = DataAcc.ExecuteNonQuery("UPDATE tbl_userlogin SET tv_username=@tv_username, tv_userpass=@tv_userpass  WHERE tv_userID=@tv_userID", p);
            return sonuc > 0;
        }
        //public bool SameMember(string tvv_userid)
        //{
        //    SqlParameter[] p = { new SqlParameter("@tv_userID", tvv_userid) };
        //    return DataAcc.ExecuteNonQuery("delete from tbl_userlogin where tv_userID=@tv_userID", p) > 0;
        //}
        public void Dispose()
        {
            ((IDisposable)DataAcc).Dispose();
        }

        public string imagePath;
        public Members ImageTest(int iid)
        {
            //FileStream fs = new FileStream(imagePath,FileMode.Open,FileAccess.Read);
            //BinaryReader br = new BinaryReader(fs);
            //byte[] img = br.ReadBytes((int)fs.Length);
            //br.Close();
            //fs.Close();
            SqlParameter[] p = { new SqlParameter("@tv_userID", iid) };
            SqlDataReader dtr = DataAcc.ExecuteReader("select * from tbl_userlogin  where tv_userID= @tv_userID", p);
            Members members= null;
            if (dtr.Read())
            {
                 members = new Members();
                members.member_passwd= dtr["tv_userpass"].ToString();
                members.member_image = Convert.ToString(dtr["tv_image"]);
            }
            dtr.Close();
            return members;


        }








    }
}
