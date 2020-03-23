using Onion.Domain.Entities;
using Onion.Domain.Services;
using Onion.Infrastructure.MssqlDbService.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Onion.Infrastructure.MssqlDbService.Services
{
    public class MssqlDbService : IStudentDbService
    {
        public bool EnrollStudent(Student newStudent, int semestr)
        {
            using(var _context = new StudentContext())
            {
                var student = new Student
                {
                    IdStudent = 1,
                    FirstName = "Adam",
                    LastName = "Kowalski"
                };

                _context.Students.Add(student);
                _context.SaveChanges();

            }
            return true;
           
        }

        public IEnumerable<Student> GetStudents()
        {
            using(var _context = new StudentContext())
            {
                return _context.Students.ToList<Student>();
            }
            
        }
    }
}
