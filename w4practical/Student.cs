using System.ComponentModel.DataAnnotations;

namespace w4practical

{
    public class Student
    {

        // private fields
        private int id;
        private string name;
        private int age;

        // public properties
        public int ID
        {
            get { return id; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Error: ID must be a positive integer.");
                }
                id = value;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (!value.Any(char.IsDigit) && value != "")
                {
                    name = value;
                }
                Console.WriteLine("Error: Name cannot be empty or a number.");
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error: Age cannot be negative.");
                }
                age = value;
            }
        }

        // constructor

        public Student(int id, string name, int age)
        {
            ID = id;
            Name = name;
            Age = age;
        }

        public void Display()
        {
            Console.WriteLine($"Student ID: {id}, Name: {name}, Age: {age}");
        }
    }

}   