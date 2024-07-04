using DataAccess.Data;

namespace DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IStudentRepository Student { get; }

        void Save();
    }
}
