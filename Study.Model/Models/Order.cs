using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string CustomerEmail { get; set; }
        [Required]
        public string CustomerMobile { get; set; }

        public string CusomerMessage { get; set; }
        [Required]
        public string PaymentMethod { get; set; }

        public string PaymentStatus { get; set; }
        
        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }

    }
}
