using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class ParkingSlot
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Location { get; set; }

        [Required]
        [MaxLength(10)]
        public string SlotNumber { get; set; }

        [Required]
        [MaxLength(20)]
        public string Status { get; set; } // Available / Occupied

        //One slot can have many reservations
        public virtual ICollection<Reservation> Reservations { get; set; }

        public ParkingSlot()
        {
            Reservations = new List<Reservation>();
        }
    }
}
