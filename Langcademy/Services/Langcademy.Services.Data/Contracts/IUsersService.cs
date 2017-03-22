using Langcademy.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Langcademy.Services.Data.Contracts
{
    public interface IUsersService
    {
        IQueryable<ApplicationUser> GetAll();

        IQueryable<ApplicationUser> GetById(string id);
    }
}
