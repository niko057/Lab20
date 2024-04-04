using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20
{
    public class Manager:Employee
    {
        public Manager(string name, bool isSuccessfull, int salary) : base(name, isSuccessfull, salary)
        {
            Name = name;
            IsSuccessfull =  isSuccessfull;
            Salary = salary;
        }

        public Manager()
        {
            
        }

        public int GetPromotion(Employee employee)
        {
            return employee.Salary += 100;
          

        }
        public int GetMinusPromotion(Employee employee)
        {
           return employee.Salary -= 50;

        }

    }
}
