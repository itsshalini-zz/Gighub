using Gighub.Models;
using System.Collections.Generic;
using System.Linq;

namespace Gighub.Repositories
{
    public class FollowingRepository : IFollowingRepository
    {
        private readonly ApplicationDbContext _context;

        public FollowingRepository(ApplicationDbContext context)
        {
            _context = context;

        }

        public IEnumerable<Following> GetFollowing(string userId, string artistId)
        {
            return _context.Followings
                    .Where(f => f.FollowerId == userId && f.FolloweeId == artistId);
        }
    }
}