using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine("Enter first name: ");
            student.FirstName = Console.ReadLine();
            Console.WriteLine("Enter last name: ");
            student.LastName = Console.ReadLine();
            Console.WriteLine("Enter birthday (dd/mm/yyyy)");
            student.Birthday = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter gender: ");
            student.Gender = Console.ReadLine();

            Console.WriteLine(student.GetStudentDetails());

        }
    }
}