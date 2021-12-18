using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace booktrackingapp.Models
{
    public class CategoryType
    {
        [Key]
        public string Type { get; set; }
        public string Name { get; set; }
    }
}
