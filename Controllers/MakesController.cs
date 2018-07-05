using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CourseProject.Controllers.Resources;
using CourseProject.Core.Models;
using CourseProject.Persistence;

namespace CourseProject.Controllers
{
    public class MakesController : Controller
    {
        private readonly ProjectDbContext context;
        private readonly IMapper mapper;
        public MakesController(ProjectDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;

        }

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {
            var makes = await context.Makes.Include(m => m.Models).ToListAsync();

            return mapper.Map<List<Make>, List<MakeResource>>(makes);
        }
    }
}