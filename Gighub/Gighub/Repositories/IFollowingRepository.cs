using System.Collections.Generic;
using Gighub.Models;

namespace Gighub.Repositories
{
    public interface IFollowingRepository
    {
        IEnumerable<Following> GetFollowing(string userId, string artistId);
    }
}