using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20
{
    public class Employee
    {
        public string Name;
        public bool IsSuccessfull;
        public int Salary;

        public Employee(string name, bool ısSuccessfull, int salary) 
        {
            Name = name;
            IsSuccessfull = ısSuccessfull;
            Salary = salary;
        }
        public Employee()
        {

        }
      
    }
}
