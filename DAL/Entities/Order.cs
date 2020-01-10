using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Order
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }
        
        public string Patronymic { get; set; }

        public string Email { get; set; }

        [Required]
        public string MailNumber { get; set; }

        public string Instagram { get; set; }

        [Required]
        public string City { get; set; }

        public string Phone { get; set; }// задай маску для номеру у формі

        public string Comment { get; set; }

        public string Count { get; set; }



    }
}
