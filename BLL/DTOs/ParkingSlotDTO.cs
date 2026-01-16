using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ParkingSlotDTO
    {

        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Location { get; set; }

        [Required]
        [MaxLength(10)]
        public string SlotNumber { get; set; }

        [Required]
        [MaxLength(20)]
        public string Status { get; set; }
    }
}
