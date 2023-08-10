namespace Project
{
    internal class Student
    {
        int rollNo;
        string name;
        string course;
        int fees;
        public void Display()
        {
            Console.WriteLine("Enter the Student Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Course name C# or ASP.net:");
            string course = Console.ReadLine();
            if (course == "C#")
            {
                fees = 2000;
            }
            else if (course == "ASP.net")
            {
                fees = 3000;
            }
            Console.WriteLine($"Name:{name} Course:{course} Fee:{fees} ");
        }

    }
}