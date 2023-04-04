using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class NewsDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public String Description { get; set; }
        [ForeignKey("Category")]
        public int CId { get; set; }
        public virtual Category Category { get; set; }
        public DateTime Date { get; set; }

    }
}
