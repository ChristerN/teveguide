using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using teveguide.Models;
using teveguide.Models.db;
using System.Data.Entity;

namespace teveguide.Data
{
    public class DbOperations
    {
        private TeveGuideEntities2 db = new TeveGuideEntities2();

        //public List<TvShow> GetTvShowNow()
        //{
        //    var startTime = db.tv_shows.OrderBy(st => st.Starttime);
        //    var endTime = db.tv_shows.GroupBy(et => et.Endtime);
        //    if (startTime >= DateTime.Now && endTime <= DateTime.Now)
        //    {
                
                   
        //    }
        //    return tvShows.ToList();
        //}
       


    }
}