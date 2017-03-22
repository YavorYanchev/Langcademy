using Langcademy.Services.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Langcademy.Data.Models;

namespace Langcademy.Services.Data
{
    class UsersService : IUsersService
    {
        public IQueryable<ApplicationUser> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<ApplicationUser> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
