using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
        public class User
        {
            [Key]
            public int Id { get; set; }

            [Required]
            [MaxLength(100)]
            public string Name { get; set; }

            [Required]
            [MaxLength(150)]
            public string Email { get; set; }

            [Required]
            [MaxLength(20)]
            public string VehicleNumber { get; set; }

            [Required]
            [MaxLength(20)]
            public string Role { get; set; }

            // One user can have many reservations
            public virtual ICollection<Reservation> Reservations { get; set; }

            public User()
            {
                Reservations = new List<Reservation>();
            }
        }
}
