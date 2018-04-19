using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UTS_PLOO_151524025_Reka_Alamsyah.Models
{
    [Table("supplier")]
    public class Supplier
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int supplier_id { get; set; }

        [StringLength(100)]
        public string supplier_name { get; set; }

        [StringLength(100)]
        public string address { get; set; }

        [StringLength(100)]
        public string phone { get; set; }

        [StringLength(100)]
        public string supplier_description { get; set; }

        public virtual ICollection<Product>Products { get; set; }
    }
}