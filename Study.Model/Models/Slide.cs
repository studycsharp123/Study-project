﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Model.Models
{
    [Table("Slides")]
    class Slide
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string URL { get; set; }
        public int DisplayOrder { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}
