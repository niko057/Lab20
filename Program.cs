namespace Lab20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assistant assistant = new();
            //Employee employee1 = new("Ali", true, 1000);
            //Console.WriteLine(assistant.getFeedBack(employee1));
            //Employee employee2 = new("Nicat", false, 800);
            //Console.WriteLine(assistant.getFeedBack(employee2));

            Student[] students = new Student[]
            {
                new Student("Nicat","Namazov",27,true),
                new Student("Ali","Xuduyev",24,true),
                new Student("Pasha","Quliyev",25,false),
            };

            Group group = new Group("C#",students);

            group.GetAll();
            Console.WriteLine("= = = =  = =");
            group.GetOnlineStudents();
            Console.WriteLine("= = = =  = =");
            group.GetOfflineStudents();

        }
    }
}