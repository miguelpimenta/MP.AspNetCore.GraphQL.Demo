using MP.AspNetCore.GraphQL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MP.AspNetCore.GraphQL.Data.Interfaces
{
    internal interface IStudentsRepository
    {
        Task<List<Student>> GetStudensByClassAsync(int classId);

        Task<List<Student>> GetStudentsByCourseAsync(int courseId);

        Task<Student> GetStudentAsync(int id);
    }
}