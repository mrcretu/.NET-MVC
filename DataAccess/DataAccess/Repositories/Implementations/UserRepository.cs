using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Implementations;
using DataAccess.Repositories.Abstractions;

namespace DataAccess.Repositories.Implementations
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }
    }
}
