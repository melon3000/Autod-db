using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarServiceApp.Models
{
    public class Service
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public ICollection<CarService> CarServices { get; set; } = new List<CarService>();
    }
}
