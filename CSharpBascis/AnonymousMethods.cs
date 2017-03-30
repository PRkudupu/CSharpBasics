using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBascis
{
    class AnonymousMethods
    {
        List<Employee> listEmployees = new List<Employee>()
        {
            new Employee{ID=101,Name="Prathap"},
            new Employee{ID=102,Name="Kiran"},
            new Employee{ID=103,Name="Rakshith"}
        };
        public static bool FindEmployee(Employee emp)
        {
            return emp.ID == 102;
        }

    }
    
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
