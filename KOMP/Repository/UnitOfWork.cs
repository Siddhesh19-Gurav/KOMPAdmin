using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KOMP.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }

    public partial class UnitOfWork : IUnitOfWork
    {
        private IRepository<User> _userRepository;
        private DBKOMPEntities _context;

        //Add any new repository here 

        public IRepository<User> UserRepository
        {
            get {

                if (_userRepository == null)
                    _userRepository = new Repository<User>(_context);

                return _userRepository; }
        }

        public UnitOfWork()
        {
            _context=new DBKOMPEntities();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}