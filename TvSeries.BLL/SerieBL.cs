using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TvSeries.MODEL;

namespace TvSeries.BLL
{
    public class SerieBL
    {
        DataAccess da = new DataAccess();

        public List<Serie> FindSerie()
        {
            SqlDataReader dr = da.ExecuteReader("select * from tbl_Series ", null);
            List<Serie> lst = new List<Serie>();
            while (dr.Read())
            {
                lst.Add(new Serie { serie_name = dr["serie_name"].ToString(), serie_id = Convert.ToInt32(dr["serie_id"]), serie_date = dr["serie_date"].ToString(), serie_rating = dr["serie_rating"].ToString() });
            }
            dr.Close();
            lst.Insert(0, new Serie { serie_name = "Choose" });
            return lst;
        }

        public Serie tv_SerieFinder(int numara)
        {

            SqlParameter[] p = { new SqlParameter("@serie_id", numara) };
            SqlDataReader dtr = da.ExecuteReader("select * from tbl_Series  where serie_id= @serie_id", p);
            Serie serie = null;
            if (dtr.Read())
            {
                serie = new Serie();
                serie.serie_name = dtr["serie_name"].ToString();
                serie.serie_date = dtr["serie_date"].ToString();
                serie.serie_rating = dtr["serie_rating"].ToString();
                serie.serie_id = Convert.ToInt32(dtr["serie_id"]);
                serie.serie_link = dtr["serie_link"].ToString();
            }
            dtr.Close();
            return serie;
        }


    }


}

