using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarServiceApp.Models
{
    public class Owner
    {
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        public string Phone { get; set; }
        public ICollection<Car> Cars { get; set; } = new List<Car>();
    }
}
