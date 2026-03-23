using Microsoft.EntityFrameworkCore;
using Pdfquest.Models;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Pdfquest.Data
{
    public class StudentsDataContext : DbContext
    {
        //esquema que representa la base de datos
        public DbSet<Estudiantes> Estudiantes { get; set; }

        public StudentsDataContext()
        {
        }
        //constructor que recibe parametros
        public StudentsDataContext(DbContextOptions<StudentsDataContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                @"Server = (localdb)\MSSQLLocalDB; Database = Students; Trusted_Connection = True; TrustServerCertificate = True; ");



            }
        }
       
            
            

    }
}
