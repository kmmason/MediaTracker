using MediaTracker.Models;
using System.Collections.Generic;

namespace MediaTracker.ViewModels
{
    public class MediaFormViewModel
    {
        public int Viewer { get; set; }
        public IEnumerable<Viewer> Viewers { get; set; }
        public string Date { get; set; }
        public int Type { get; set; }
        public IEnumerable<Type> Types { get; set; }
        public string Title { get; set; }

    }
}