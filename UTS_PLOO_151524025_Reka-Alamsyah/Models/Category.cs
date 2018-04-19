using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UTS_PLOO_151524025_Reka_Alamsyah.Models
{
    [Table("category")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int category_id { get; set; }

        [StringLength(100)]
        public string category_name { get; set; }

        [StringLength(100)]
        public string category_description { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}