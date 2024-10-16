using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BoardGameNight.Domain.Models;

namespace BoardGameNight.DomainServices
{
    public interface IUserRepository
    {
        public User getById(int userId);

        public IEnumerable<User> getAll();
    }
}
