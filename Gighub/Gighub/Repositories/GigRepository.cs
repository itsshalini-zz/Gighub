using Gighub.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Gighub.Repositories
{
    public class GigRepository : IGigRepository
    {
        private readonly ApplicationDbContext _context;
        public GigRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Gig GetGigWithAttendees(int gigId)
        {
            return _context.Gigs
                .Single(g => g.Id == gigId);
        }

        public IEnumerable<Gig> GetGigsUserAttending(string userId)
        {
            return _context.Attendances
                .Where(a => a.AttendeeId == userId)
                .Select(a => a.Gig)
                .Include(g => g.Artist)
                .Include(g => g.Genre)
                .ToList();
        }

        public IEnumerable<Gig> GetUpcomingGigsByArtist(string id)
        {
            return _context.Gigs
                .Where(g => g.ArtistId == id
                    && g.DateTime > DateTime.Now
                    && !g.IsCanceled)
                .Include(g => g.Genre)
                .ToList();
        }

       

        public Gig GetGigById(int id)
        {
            return _context.Gigs
                .Include(g => g.Artist)
                .Include(g => g.Genre)
                .SingleOrDefault(g => g.Id == id);
        }

        public void Add(Gig gig)
        {
            _context.Gigs.Add(gig);
        }
    }
}