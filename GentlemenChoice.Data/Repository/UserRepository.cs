using GentlemenChoice.Data.DBContext;
using GentlemenChoice.Data.Models;
using KoiShowManagement.Data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GentlemenChoice.Data.Repository
{
    public class UserRepository : GenericRepository<User>
    {
        public UserRepository() { }
        public UserRepository(MenAccessoryStoreContext context) => _context = context;
    }
}
