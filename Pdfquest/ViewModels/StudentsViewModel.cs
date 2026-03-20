using Pdfquest.Helper;
using Pdfquest.Repositories;
using QuestPDF.Fluent;

public class StudentsViewModel
{
    private readonly StudentRepository _repo;

    public StudentsViewModel()
    {
        _repo = new StudentRepository();

        var students = _repo.GetAll().ToList();
        var document = new StudentDocument(students);
        document.GeneratePdf("students.pdf");
    }
}