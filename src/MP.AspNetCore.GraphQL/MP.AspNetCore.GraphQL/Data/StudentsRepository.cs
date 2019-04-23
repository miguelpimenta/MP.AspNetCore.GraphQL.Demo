using MP.AspNetCore.GraphQL.Data.Interfaces;
using MP.AspNetCore.GraphQL.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MP.AspNetCore.GraphQL.Data
{
    public class StudentsRepository : IStudentsRepository
    {
        private List<Student> _students;

        public StudentsRepository()
        {
            _students = new List<Student>{
                new Student()
                {
                    Id = 1,
                    RoleId = 2,
                    Name = "John Smith",
                    BirthDate = new System.DateTime(1985, 01, 01),
                    Description = "Someone...",
                    CoursesId =  new int[] { 1, 2 }
                },
                new Student()
                {
                    Id = 2,
                    RoleId = 1,
                    Name = "Donald Trump",
                    BirthDate = new System.DateTime(1960, 01, 01),
                    Description = "An alien...",
                    CoursesId =  new int[] { 1 }
                },
                new Student()
                {
                    Id = 3,
                    RoleId = 1,
                    Name = "Chuck Norris",
                    BirthDate = new System.DateTime(1965, 01, 01),
                    Description = "80's/90's Action hero",
                }
            };
        }

        Task<List<Student>> IStudentsRepository.GetStudensByClassAsync(int classId)
        {
            return Task.FromResult(_students.Where(x => x.ClassId == classId).ToList());
        }

        Task<List<Student>> IStudentsRepository.GetStudentsByCourseAsync(int courseId)
        {
            return Task.FromResult(_students.Where(x => x.CourseId == courseId).ToList());
        }

        Task<Student> IStudentsRepository.GetStudentAsync(int id)
        {
            return Task.FromResult(_students.FirstOrDefault(x => x.Id == id));
        }
    }
}