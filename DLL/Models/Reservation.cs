using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int SlotId { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        [Required]
        [MaxLength(20)]
        public string Status { get; set; } // Active / Completed / Cancelled

     
        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        [ForeignKey("SlotId")]
        public virtual ParkingSlot ParkingSlot { get; set; }
        public virtual Payment Payment { get; set; }

    }
}
