using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APIServiceForm.DAta
{
    [Table("FormUsers")]
    public class Form
    {
        [Key]
        public string name { get; set; }
        public string email { get; set; }
        public string Topic { get; set; }
        public Int32? Phone { get; set; }
    }
}
