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
                serie.serie_image = Convert.ToString(dtr["serie_image"]);
            }
            dtr.Close();
            return serie;
        }

        public Comment tv_Comment(int id)
        {
            SqlParameter[] p = { new SqlParameter("serie_id", id) };
            SqlDataReader dtr = da.ExecuteReader("select * from tbl_serieComment where serie_id=@serie_id", p);
            Comment comment = null;
            while (dtr.Read())
            {   
                comment = new Comment();
                comment.comment = dtr["comment"].ToString();
                comment.serie_id = dtr["serie_id"].ToString();
                comment.user_id = dtr["user_id"].ToString();
                
            }
            dtr.Close();
            return comment;

           
        }



        public List<Comment> GetComments(int serieid)
        {
            List<Comment> lst = new List<Comment>();
            SqlParameter[] p = { new SqlParameter("@serie_id", serieid) };
            SqlDataReader dr = da.ExecuteReader("select tbl_serieComment.serie_id, tbl_serieComment.user_id , tbl_userlogin.tv_username ,tbl_serieComment.comment from tbl_serieComment inner join tbl_userlogin on tbl_serieComment.user_id = tbl_userlogin.tv_userID where tbl_serieComment.serie_id = @serie_id", p);

            while (dr.Read())
            {
                lst.Add(new Comment { serie_id = (dr["serie_id"].ToString()), user_id =(dr["user_id"]).ToString(),UserName=(dr["tv_username"]).ToString() , comment =(dr["comment"]).ToString()  });
            }
            dr.Close();
            return lst;
        }



    }


}

