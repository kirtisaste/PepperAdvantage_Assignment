using Microsoft.EntityFrameworkCore;
using PepperAdvantage_Assignment.DTOs;
using PepperAdvantage_Assignment.Model;
using System.Diagnostics;

namespace PepperAdvantage_Assignment.Repository
{
    public class UserRepository
    {
        private readonly UserContext _dbContext;
        public UserRepository()
        {
        }
        public async Task<List<User>> GetUsers()
        {
            //return _dbContext.Set<User>().ToListAsync();

            List<User> list;
            string sql = "EXEC GetUserRole";
            list = await _dbContext.Users.FromSqlRaw<User>(sql).ToListAsync();
            Debugger.Break();
            return list;
        }
    }
}
