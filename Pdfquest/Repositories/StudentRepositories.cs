using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pdfquest.Repositories
{
    public class StudentRepository : IStudentRepository
{
    public IEnumerable<Student> GetAll()
    {
        return new List<Student>
        {
            new Student { Id = 1, FullName = "Kevin" },
            new Student { Id = 2, FullName = "Jose" }
        };
    }
}
}
