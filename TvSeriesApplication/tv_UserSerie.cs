//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TvSeriesApplication
{
    using System;
    using System.Collections.Generic;
    
    public partial class tv_UserSerie
    {
        public Nullable<int> serie_id { get; set; }
        public int tv_userid { get; set; }
    
        public virtual tbl_Series tbl_Series { get; set; }
        public virtual tbl_userlogin tbl_userlogin { get; set; }
    }
}