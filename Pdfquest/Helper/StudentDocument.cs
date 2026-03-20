using System;
using System.Collections.Generic;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using Pdfquest.Models;

namespace Pdfquest.Helper
{
    public class StudentDocument : IDocument
    {
        private readonly List<Student> _students;

        public StudentDocument(List<Student> students)
        {
            _students = students;
        }

        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.Margin(20);
                page.Header().Element(ComposeHeader);
                page.Content().Element(ComposeContent);
                page.Footer().Element(ComposeFooter);
            });
        }

        private void ComposeHeader(IContainer container)
        {
            container.Text("Reporte de estudiantes").FontSize(20).Bold().AlignCenter();
        }

        private void ComposeFooter(IContainer container)
        {
            container.AlignCenter().Text(text =>
            {
                text.Span("pagina ");
                text.CurrentPageNumber();
                text.Span(" de ");
                text.TotalPages();
            });
        }

        private void ComposeContent(IContainer container)
        {
            container.PaddingVertical(10).Table(table =>
            {
                table.ColumnsDefinition(columns =>
                {
                    columns.ConstantColumn(50);
                    columns.RelativeColumn(8);
                });

                table.Header(header =>
                {
                    header.Cell().Text("Id").Bold();
                    header.Cell().Text("Nombre").Bold();
                });

                foreach (var student in _students)
                {
                    table.Cell().Text(student.Id.ToString());
                    table.Cell().Text(student.FullName);
                }
            });
        }
    }
}