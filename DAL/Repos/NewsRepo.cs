using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class NewsRepo
    {
        static NewsContext newsContext;
        static NewsRepo()
        {
            newsContext = new NewsContext();
        }
        public static List<News> Get()
        {
            return newsContext.Newses.ToList();
        }
        public static News Get(int id)
        {
            return newsContext.Newses.Find(id);
        }


    }
}
