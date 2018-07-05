using System.Threading.Tasks;
using CourseProject.Core;
using CourseProject.Persistence;

namespace vega.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ProjectDbContext context;
        public UnitOfWork(ProjectDbContext context)
        {
            this.context = context;
        }

        public async Task CompleteAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}