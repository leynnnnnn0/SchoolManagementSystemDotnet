using DataAccess.Data;
using DataAccess.Repository.IRepository;
using Models;
using System.Linq.Expressions;

namespace DataAccess.Repository
{
    public class StudentRepository : Repository<Student> , IStudentRepository
    {
        private readonly ApplicationDbContext _db;
        public StudentRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Student student)
        {
            _db.Update(student);
        }
    }
}
