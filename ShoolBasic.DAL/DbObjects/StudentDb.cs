
using ShoolBasic.DAL.Contracts;
using ShoolBasic.DAL.Entities;

namespace ShoolBasic.DAL.DbObjects
{
    public class StudentDb : IStudentDb
    {
        public StudentDb()
        {

        }
        public Student GetStudent(int studentId)
        {
            throw new NotImplementedException();
        }

        public Student GetStudent(string maricula)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetStudents(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public void Remove(Student student)
        {
            throw new NotImplementedException();
        }

        public void Save(Student student)
        {
            throw new NotImplementedException();
        }

        public void Update(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
