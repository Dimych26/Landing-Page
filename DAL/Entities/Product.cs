using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DAL.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        //[NotMapped]
        //public bool Top { get; set; }
        //[NotMapped]
        //public bool New { get; set; }

        [NotMapped]
        public string Color { get; set; }

    }
}