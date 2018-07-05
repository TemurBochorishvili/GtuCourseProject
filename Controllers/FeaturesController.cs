using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using CourseProject.Controllers.Resources;
using CourseProject.Persistence;

namespace CourseProject.Controllers
{
    public class FeaturesController
    {
        private readonly IMapper mapper;
        private readonly ProjectDbContext context;
        public FeaturesController(ProjectDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;

        }

        [HttpGet("/api/features")]
        //[Authorize]
        public IEnumerable<KeyValuePairResource> GetFeatures()
        {
            var featureList = new List<KeyValuePairResource> {
                new KeyValuePairResource{Id = 1, Name = "Feature 1"},
                new KeyValuePairResource{Id = 2, Name = "Feature 2"},
                new KeyValuePairResource{Id = 3, Name = "Feature 3"}};

                return featureList;

        }
    }
}