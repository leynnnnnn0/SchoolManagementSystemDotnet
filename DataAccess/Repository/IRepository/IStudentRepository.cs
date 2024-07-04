using Models;

namespace DataAccess.Repository.IRepository
{
    public interface IStudentRepository : IRepository<Student>
    {
        void Update(Student student);
    }
}
