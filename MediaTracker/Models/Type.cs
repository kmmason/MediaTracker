using System.ComponentModel.DataAnnotations;

namespace MediaTracker.Models
{
    public class Type
    {
        public byte Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
    }
}