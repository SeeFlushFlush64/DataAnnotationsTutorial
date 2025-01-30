using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationsTutorial.EntityClasses
{
    class Product
    {
        
        public int ProductID { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string ProductNumber { get; set; } = string.Empty;
        [Required]
        public string Color { get; set; } = string.Empty;
        public decimal StandardCost { get; set; }
        public decimal ListPrice { get; set; }
        public DateTime SellStartDate { get; set; }
        public DateTime? SellEndDate { get; set; }
        public DateTime? DiscontinuedDate { get; set; }

        public override string ToString()
        {
            return $"{Name} ({ProductID})";
        }
    }
}
