using Pdfquest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pdfquest.Repositories
{
    public interface IStudentRepository
    {
        List<Estudiantes> GetAll();
    }
}
