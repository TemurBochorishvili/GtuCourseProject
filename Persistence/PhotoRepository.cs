using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CourseProject.Core.Models;

namespace CourseProject.Persistence
{
    public class PhotoRepository: IPhotoRepository
    {
        private readonly ProjectDbContext context;
        public PhotoRepository(ProjectDbContext context)
        {
            this.context = context;

        }

        public async Task<IEnumerable<Photo>> GetPhotos(int vehicleId)
        {
            return await context.Photos
            .Where(p => p.VehicleId == vehicleId)
            .ToListAsync();
        }
    }
}