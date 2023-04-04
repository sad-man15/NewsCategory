using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class NewsContext:DbContext
    {
        public DbSet<News> Newses { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
