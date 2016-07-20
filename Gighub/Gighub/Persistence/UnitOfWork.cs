﻿using Gighub.Models;
using Gighub.Repositories;

namespace Gighub.Persistence
{
    public class UnitOfWork
    {
        public AttendanceRepository Attendances { get; private set; }
        public GigRepository Gigs { get;private set; }
        public GenreRepository Genres { get; private set; }
        public FollowingRepository Followings { get;private set; }
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