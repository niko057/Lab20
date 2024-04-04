using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20
{
    public class Group
    {
        public string GroupName;

        public Student[] Students;

        public Group(string groupName, Student[] students)
        {
            GroupName = groupName;
            Students = students;
        }
        

        public void GetAll()
        {
            foreach (var student in Students)
            {
                Console.WriteLine($"{student.Name} {student.SurName}");
            }
        }
        public void GetOnlineStudents()
        {
            foreach (var student in Students)
            {
                if (student.IsOnline)
                {

                Console.WriteLine($"{student.Name} {student.SurName}");
                }
            }
        }
        public void GetOfflineStudents()
        {
            foreach (var student in Students)
            {
                if (!student.IsOnline)
                {

                    Console.WriteLine($"{student.Name} {student.SurName}");
                }
            }
        }
    }
}
