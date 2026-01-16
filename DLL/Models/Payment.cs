using DAL.Migrations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Payment
    {
        [Key] 
        [ForeignKey("Reservation")] 
        public int ReservationId { get; set; } 

        [Required]
        public decimal Amount { get; set; }

        [Required] 
        [MaxLength(20)]
        public string PaymentStatus { get; set; } // Pending / Completed / Failed

        [Required] 
        [MaxLength(30)]
        public string Method { get; set; } // Card / Cash / Online
        public virtual Reservation Reservation { get; set; }
        public int Id { get; internal set; }
    }
}
