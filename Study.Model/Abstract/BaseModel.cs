using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Model.Abstract
{
    //kế thừa từ Interface: public get;set toàn bộ thuộc tính bên trong interface 
    public abstract class BaseModel : IBaseModel
    {
        [MaxLength(250)]
        public string MetaKeyword { get; set; }
        [MaxLength(250)]
        public string MetaDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        [MaxLength(250)]
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        [MaxLength(250)]
        public string UpdatedBy { get; set; }
        public bool Status { get; set; }
    }
}
