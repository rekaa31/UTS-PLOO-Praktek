using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UTS_PLOO_151524025_Reka_Alamsyah.Models
{
    [Table("product")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int product_id { get; set; }

        [StringLength(100)]
        public string product_name { get; set; }

        //Foreign Key
        public int category_id { get; set; }
        public virtual Category Category { get; set; }

        //Foreign Key
        public int supplier_id { get; set; }
        public virtual Supplier Supplier { get; set; }


        public int product_price { get; set; }

        public int minimum_stock { get; set; }
    }
}