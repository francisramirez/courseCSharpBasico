

using ShoolBasic.DAL.Entities;

namespace ShoolBasic.DAL.Contracts
{
    public interface IStudentDb
    {
        void Save(Student student);
        void Update(Student student);
        void Remove(Student student);
        Student GetStudent(int studentId);
        Student GetStudent(string maricula);
        List<Student> GetStudents(DateTime startDate, DateTime endDate);
    }
}
