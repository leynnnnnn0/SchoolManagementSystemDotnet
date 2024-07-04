using DataAccess.Data;
using DataAccess.Repository.IRepository;

namespace DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public IStudentRepository Student { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Student = new StudentRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
