using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }

        public Student()
        {

        }

        public Student(string firstName, string lastName, DateTime birthday, string gender)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
            Gender = gender;
        }

        public int CalculateAge()
        {
            DateTime currentDate = DateTime.Now;    
            int age = currentDate.Year - Birthday.Year;

            if (currentDate < Birthday.AddYears(age))
            {
                age--;
            }
            return age;
        }

        public string GetStudentDetails()
        {
            return $"Name: {FirstName} {LastName}\nBirthday: {Birthday}\nGender: {Gender}\nAge: {CalculateAge()}";
        }
    }
}
