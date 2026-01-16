using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;


namespace BLL.DTOs
{
    public class PaymentDTO
    {
        public int ReservationId { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        [MaxLength(20)]
        public string PaymentStatus { get; set; } // Pending / Completed / Failed

        [Required]
        [MaxLength(30)]
        public string Method { get; set; } // Card / Cash / Online
    }
}
