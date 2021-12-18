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
        
        [Key]
        public int CategoryId { get; set; }
        public string NameToken { get; set; }
       
        public string Description { get; set; }

        [ForeignKey("CategoryType")]
        public CategoryType categoryType { get; set; }
        public int CategoryTypeId { get; set; }
    }
}
