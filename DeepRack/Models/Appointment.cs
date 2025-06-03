using System;
using System.ComponentModel.DataAnnotations;

namespace DeepRack.Models
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        public DateTime Date { get; set; }

        public string Purpose { get; set; }

        public bool IsApproved { get; set; } = false;
    }
}