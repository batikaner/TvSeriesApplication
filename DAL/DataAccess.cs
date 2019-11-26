using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics;

namespace DAL
{
    public class DataAccess
    {
        public SqlConnection sql_cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString);
        public SqlCommand sql_cmd = null;


        public int ExecuteNonQuery(string cmdtext, SqlParameter[] param)
        {

            sql_cmd = new SqlCommand(cmdtext, sql_cn);
            if (param != null)
            {
                sql_cmd.Parameters.AddRange(param);
            }
            ConnAc();
            int feedback = sql_cmd.ExecuteNonQuery();

            return feedback;

        }

        public void ConnAc()
        {
            try
            {

                if (sql_cn != null && sql_cn.State != ConnectionState.Open)
                {
                    sql_cn.Open();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }



        public void ConnKapat()
        {
            try
            {

                if (sql_cn != null && sql_cn.State != ConnectionState.Closed)
                {
                    sql_cn.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }





}

