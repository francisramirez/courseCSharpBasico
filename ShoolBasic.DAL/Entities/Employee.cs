using ShoolBasic.DAL.Core;

namespace ShoolBasic.DAL.Entities
{
    public abstract class Employee : Person
    {
        public int Id { get; set; }
        public DateTime HireDate { get; set; }
        public abstract void CalcularSueldo();
    }
}
