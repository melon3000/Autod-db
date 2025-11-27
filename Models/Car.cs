using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarServiceApp.Models
{
    public class Car
    {
        public int Id { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string RegistrationNumber { get; set; }

        public int OwnerId { get; set; }
        public Owner Owner { get; set; }

        public ICollection<CarService> CarServices { get; set; } = new List<CarService>();
    }
}
