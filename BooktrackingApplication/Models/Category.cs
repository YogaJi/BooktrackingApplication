using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace booktrackingapp.Models
{
    public class Category
    {
        [ForeignKey("NameToken")]
        [Key]
        public string NameToken { get; set; }
        public int Type { get; set; }
        public string Description { get; set; }
    }
}
