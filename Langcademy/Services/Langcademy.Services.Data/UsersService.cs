using Langcademy.Services.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Langcademy.Data.Models;
using Langcademy.Data.Common;

namespace Langcademy.Services.Data
{
    class UsersService : IUsersService
    {
        private readonly IDbRepository<ApplicationUser> users;

        public UsersService(IDbRepository<ApplicationUser> users)
        {
            this.users = users;
        }

        public IQueryable<ApplicationUser> GetAll()
        {
            return this.users.All();
        }

        public IQueryable<ApplicationUser> GetById(string id)
        {
            return this.users.All().Where(u => u.Id == id);
        }
    }
}
