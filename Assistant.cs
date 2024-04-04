using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20
{
    public class Assistant:Employee
    {
        public Assistant(string name, bool ısSuccessfull, int salary) : base(name, ısSuccessfull, salary)
        {
            
        }
        public Assistant()
        {

        }

        public int getFeedBack(Employee employee)
        {
                Manager manager = new Manager();
            if (employee.IsSuccessfull)
            {
                return manager.GetPromotion(employee);
            }
            else
            {
                return manager.GetMinusPromotion(employee);
            }

        }
    }
}
