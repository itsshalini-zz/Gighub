using System.Collections.Generic;
using Gighub.Models;

namespace Gighub.Repositories
{
    public interface IAttendanceRepository
    {
        IEnumerable<Attendance> GetAttendance(int id, string userId);
        IEnumerable<Attendance> GetFutureAttendances(string userId);
    }
}