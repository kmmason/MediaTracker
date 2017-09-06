using System;
using System.ComponentModel.DataAnnotations;

namespace MediaTracker.Models
{
    public class Media
    {
        public byte Id { get; set; }

        [Required]
        [StringLength(25)]
        public Viewer Viewer { get; set; }

        [Required]
        [StringLength(15)]
        public Type Type { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        public DateTime When { get; set; }
    }
}