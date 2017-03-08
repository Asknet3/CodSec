using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodSec.Models
{
    public class Code
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [Required (ErrorMessage ="Inserire il Pin")]
        [StringLength(50)]
        public string Pin { get; set; }
    }
}