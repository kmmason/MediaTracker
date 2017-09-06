using System.ComponentModel.DataAnnotations;

namespace MediaTracker.Models
{
    public class Viewer
    {
        public byte Id { get; set; }

        [StringLength(25)]
        public string Name { get; set; }
    }
}