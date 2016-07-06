using System.Linq;
using Gighub.Models;
using System.Collections.Generic;

namespace Gighub.ViewModels
{
    public class GigsViewModel
    {
        public bool ShowActions { get; set; }
        public IEnumerable<Gig> UpcomingGigs { get; set; }
        public string Heading { get; set; }
    }
}