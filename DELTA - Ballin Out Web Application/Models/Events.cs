using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DELTA___Ballin_Out_Web_Application.Models
{
    public class Events
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string EventName { get; set; }
        [Required]
        public string EventImage { get; set; }
        [Required]
        [MaxLength(50)]
        public string EventLocation { get; set; }
        [Required]
        [MaxLength(500)]
        public string EventDescription { get; set; }
        [Required]
        public DateTime EventDate { get; set; } 
    }
}
