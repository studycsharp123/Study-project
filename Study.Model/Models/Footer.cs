using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Study.Model.Models
{
    [Table("Footers")]
    public class Footer
    {
       [Key]
       [MaxLength(50)]
       public string ID {get; set;}
       [Required]
       public string Content {get; set;}
    }
}
