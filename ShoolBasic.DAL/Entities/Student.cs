
using ShoolBasic.DAL.Core;

namespace ShoolBasic.DAL.Entities
{
    public class Student : Person
    {
        public int Id { get; set; }
        public string? Matricula { get; set; }

        public DateTime EnrollmentDate { get; set; }

    }
}
