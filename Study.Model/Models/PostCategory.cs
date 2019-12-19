﻿using Study.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Model.Models
{
    [Table("PostCategories")]
    public class PostCategory : BaseModel
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Alias { get; set; }
        public string Description { get; set; }
        public int ParentID { get; set; }
        public int DisplayOrder { get; set; }
        public string Image { get; set; }
        [Required]
        public bool HomeFlag { get; set; }

        public virtual IEnumerable<Post> Posts { get; set; }

    }
}
