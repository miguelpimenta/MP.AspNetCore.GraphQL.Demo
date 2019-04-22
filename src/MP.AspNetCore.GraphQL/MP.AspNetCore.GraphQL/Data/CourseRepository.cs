using MP.AspNetCore.GraphQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MP.AspNetCore.GraphQL.Data
{
    public class CourseRepository
    {
        private readonly List<CourseUnit> _courseUnits;

        public CourseRepository()
        {
            _courseUnits = new List<CourseUnit> {
                new CourseUnit()
                {
                    Id = 1,
                    AreaId = 1,
                    Code = "XYZ123",
                    Name = "ISI",
                    Description = "ISI",
                    Credits = 6,
                    StartDate = new DateTime(2000,09,10),
                    Active = true
                },
                new CourseUnit()
                {
                    Id = 2,
                    AreaId = 2,
                    Code = "ABC123",
                    Name = "LPII",
                    Description = "LPII",
                    Credits = 6,
                    StartDate = new DateTime(2000,09,10),
                    Active = true
                },
            };
        }

        public Task<List<CourseUnit>> RolesAsync()
        {
            return Task.FromResult(_courseUnits);
        }

        public Task<CourseUnit> GetRoleAsync(int id)
        {
            return Task.FromResult(_courseUnits.FirstOrDefault(x => x.Id == id));
        }
    }
}