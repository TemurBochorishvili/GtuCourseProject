using System.Collections.Generic;
using System.Threading.Tasks;

namespace CourseProject.Core.Models
{
    public interface IPhotoRepository
    {
         Task<IEnumerable<Photo>> GetPhotos(int vehicleId);
    }
}