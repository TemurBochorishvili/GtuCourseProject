using System.Threading.Tasks;

namespace CourseProject.Core
{

    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}