using System.Data.Common;
using System.Globalization;

namespace ProjetoEmployeeList
{
    class Program
    {
        static void Main(string [] args)
        {
            List<Employee> ListEmployee = new List<Employee>();
            System.Console.Write("How many employee will be registered? ");
            int qtdEmp = int.Parse(Console.ReadLine());

            for(int i = 0; i < qtdEmp; i++)
            {
                System.Console.WriteLine("Employee #" + (i + 1));
                System.Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                System.Console.Write("Name: ");
                string name = Console.ReadLine();
                
                System.Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                ListEmployee.Add(new Employee{Id = id, Name = name, Salary = salary});
            }

            System.Console.Write("Enter the employee id that will have salary increase: ");
            int idEmp = int.Parse(Console.ReadLine());

            System.Console.Write("Enter the percentage: ");
            double increaseRate = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Employee.IncreaseSalary(ListEmployee.Find(x => x.Id == idEmp), increaseRate);

            System.Console.WriteLine("Updated list of employees: ");

            foreach(Employee emp in ListEmployee)
            {
                Console.WriteLine(emp.ToString());
            }
        }
    }
}
