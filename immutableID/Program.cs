using System;
class Student
    {
        // auto-implemented properties
        public int Id { get; init; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // default constructor
        public Student()
        {
            Id = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
        }
        // parameterized constructor
        public Student(int i, string First, string Last)
        {
            Id = i;
            FirstName = First;
            LastName = Last;
        }
        public Student(int id)
        {
            Id = id;
            FirstName = string.Empty;
            LastName = string.Empty;
        }
        public static void Main()
        {
            Student student = new(5);
            student.FirstName = "John";
            student.LastName = "Doe";
            Console.WriteLine($"Student ID = {student.Id}, First Name = {student.FirstName}, Last Name = {student.LastName}");
            Student student2 = new(3,"Jane","Jones");
            Console.WriteLine($"Student ID = {student2.Id}, First Name = {student2.FirstName}, Last Name = {student2.LastName}");
        }
    }