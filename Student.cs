using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20
{
    public class Student : Person
    {
        public bool IsOnline;
        public Student(string name, string surname, int age, bool ısOnline) : base(name, surname, age)
        {
            IsOnline = ısOnline;
        }
     
        
    }
}
