using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace teveguide.Models
{
    public class TvShow
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Starttime { get; set; }
        public DateTime Endtime { get; set; }
        public string Substance { get; set; }
        public string Category { get; set; }
        public string Channel { get; set; }
    }

}