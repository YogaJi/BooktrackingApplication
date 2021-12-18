using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace booktrackingapp.Models
{
    public class Book
    {
        [Key]
        public string ISBN { get; set; }

        public string Title { get; set; }
        public string Author { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("Category")]
        public Category category { get; set; }
    }
}
