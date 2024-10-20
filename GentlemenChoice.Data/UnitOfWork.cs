using GentlemenChoice.Data.DBContext;
using GentlemenChoice.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GentlemenChoice.Data
{
    public class UnitOfWork
    {
        private MenAccessoryStoreContext _unitOfWorkContext;
        private UserRepository _userRepository;

        public UnitOfWork()
        {
            _unitOfWorkContext ??= new MenAccessoryStoreContext();
        }

        public UserRepository UserRepository
        {
            get
            {
                return _userRepository ??= new Repository.UserRepository(_unitOfWorkContext);
            }
        }
    }
}
