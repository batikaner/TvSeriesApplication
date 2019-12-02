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
    public class DataAccess : IDisposable
    {
        public SqlConnection sql_cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString);
        public SqlCommand sql_cmd;


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


        public SqlDataReader ExecuteReader(string cmdText, SqlParameter[] p)
        {
            sql_cmd = new SqlCommand(cmdText, sql_cn);
            if (p != null)
            {
                sql_cmd.Parameters.AddRange(p);
            }
            ConnAc();
            return sql_cmd.ExecuteReader(CommandBehavior.CloseConnection);
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

        public bool ExecuteNonQuery(string v)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {

            if (sql_cn != null && sql_cmd != null)
            {
                sql_cn.Dispose();
                sql_cmd.Dispose();
            }


        }
    }





}

