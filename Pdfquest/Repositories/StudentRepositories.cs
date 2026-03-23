using Pdfquest.Data;
using Pdfquest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pdfquest.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentsDataContext _Context;



        public StudentRepository(StudentsDataContext context)
        {
            _Context = context;
        }
        public List<Estudiantes> GetAll()
        {
            return _Context.Estudiantes.ToList();

        }

    }
}