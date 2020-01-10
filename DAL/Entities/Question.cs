using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Question
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Phone { get; set; }// задай маску для номеру у формі

        [Required]
        public string Message { get; set; }


    }
}
