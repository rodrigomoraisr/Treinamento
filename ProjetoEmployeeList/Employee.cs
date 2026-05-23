using System.Dynamic;
using System.Runtime.CompilerServices;

namespace ProjetoEmployeeList
{
    class Employee
    {
        public int Id{get; set;}
        public string? Name{get; set;}
        public double Salary{get; set;}

        public static Employee IncreaseSalary(Employee emp, double porcentagem)
        {
            emp.Salary += emp.Salary * (porcentagem / 100);
            return emp;
        }

        public override string ToString()
        {
            return Id
                + ", " 
                + Name
                + ", "
                + Salary;
        }
    }
}
