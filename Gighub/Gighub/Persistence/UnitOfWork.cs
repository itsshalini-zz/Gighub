using Gighub.Models;
using Gighub.Repositories;

namespace Gighub.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        public IAttendanceRepository Attendances { get; private set; }
        public IGigRepository Gigs { get;private set; }
        public IGenreRepository Genres { get; private set; }
        public IFollowingRepository Followings { get;private set; }
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Attendances = new AttendanceRepository(_context);
            Gigs = new GigRepository(_context);
            Genres = new GenreRepository(_context);
            Followings = new FollowingRepository(_context);
        }

        public void Complete()
        {
            _context.SaveChanges();
        }
    }
}