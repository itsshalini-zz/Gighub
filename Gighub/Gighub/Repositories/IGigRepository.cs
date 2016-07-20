using System.Collections.Generic;
using Gighub.Models;

namespace Gighub.Repositories
{
    public interface IGigRepository
    {
        Gig GetGigById(int id);
        IEnumerable<Gig> GetGigsUserAttending(string userId);
        Gig GetGigWithAttendees(int gigId);
        IEnumerable<Gig> GetUpcomingGigsByArtist(string id);
        void Add(Gig gig);
    }
}