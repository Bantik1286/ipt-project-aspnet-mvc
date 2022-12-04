using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IPT_PROJECT.Models
{
    public class Post
    {
        public int PostId { set; get; }
        public String Description { set; get; }
        public String Subject { set; get; }
        public String CreatedBy { set; get; }
        public DateTime dateTime { set; get; }


    }
}