using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag
    {
        [Key]
        public int TagID { get; set; }
        [Key]
        public int ProductID { get; set; }
        [ForeignKey("TagID")]
        public virtual Tag Tag { get; set; }
        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }

    }
}
