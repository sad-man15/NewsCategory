using BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Models;
using DAL.Repos;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class NewsServices
    {
        public static List<NewsDTO> Get()
        {
            var data = NewsRepo.Get();
            return Convert(data);

        }
        public static NewsDTO Get(int id)
        {
            return Convert(NewsRepo.Get(id));
        }


        public static List<NewsDTO> GetN(string cname)
        {
            var data = (from e in NewsRepo.Get()
                        where e.Category.Name == cname
                        select e).ToList();
            return Convert(data);
        }
        public static List<NewsDTO> GetD(DateTime date)
        {
            var data = (from e in NewsRepo.Get()
                        where e.Date == date
                        select e).ToList();
            return Convert(data);
        }

        public static List<NewsDTO> GetDN(DateTime date,string cname)
        {
            var data = (from e in NewsRepo.Get()
                        where e.Date == date && e.Category.Name==cname
                        select e).ToList();
            return Convert(data);
        }

        static List<NewsDTO> Convert(List<News> news)
        {
            var data = new List<NewsDTO>();
            foreach (var ns in news)
            {
                data.Add(new NewsDTO()
                {
                    Id = ns.Id,
                    Title = ns.Title,
                    Description = ns.Description,
                    CId = ns.CId,
                    Date=ns.Date
                });
            }
            return data;

        }
/*        static News Convert(NewsDTO ns)
        {
            return new News()
            {
                Id = ns.Id,
                Title = ns.Title,
                Description = ns.Description,
                CId = ns.CId,
                Date = ns.Date
            };
        }*/
        static NewsDTO Convert(News ns)
        {
            return new NewsDTO()
            {
                Id = ns.Id,
                Title = ns.Title,
                Description = ns.Description,
                CId = ns.CId,
                Date = ns.Date
            };
        }
    }
}
