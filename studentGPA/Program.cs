using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentLINQQueries
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public string Major { get; set; }
        public double Tuition { get; set; }
    }

    public class StudentClubs
    {
        public int StudentID { get; set; }
        public string ClubName { get; set; }
    }

    public class StudentGPA
    {
        public int StudentID { get; set; }
        public double GPA { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "Frank Furter", Age = 55, Major="Hospitality", Tuition=3500.00} ,
                new Student() { StudentID = 2, StudentName = "Gina Host", Age = 21, Major="Hospitality", Tuition=4500.00 } ,
                new Student() { StudentID = 3, StudentName = "Cookie Crumb",  Age = 21, Major="CIT", Tuition=2500.00 } ,
                new Student() { StudentID = 4, StudentName = "Ima Script",  Age = 48, Major="CIT", Tuition=5500.00 } ,
                new Student() { StudentID = 5, StudentName = "Cora Coder",  Age = 35, Major="CIT", Tuition=1500.00 } ,
                new Student() { StudentID = 6, StudentName = "Ura Goodchild" , Age = 40, Major="Marketing", Tuition=500.00} ,
                new Student() { StudentID = 7, StudentName = "Take Mewith" , Age = 29, Major="Aerospace Engineering", Tuition=5500.00 }
            };

            IList<StudentGPA> studentGPAList = new List<StudentGPA>() {
                new StudentGPA() { StudentID = 1,  GPA=4.0} ,
                new StudentGPA() { StudentID = 2,  GPA=3.5} ,
                new StudentGPA() { StudentID = 3,  GPA=2.0 } ,
                new StudentGPA() { StudentID = 4,  GPA=1.5 } ,
                new StudentGPA() { StudentID = 5,  GPA=4.0 } ,
                new StudentGPA() { StudentID = 6,  GPA=2.5} ,
                new StudentGPA() { StudentID = 7,  GPA=1.0 }
            };

            IList<StudentClubs> studentClubList = new List<StudentClubs>() {
                new StudentClubs() {StudentID=1, ClubName="Photography" },
                new StudentClubs() {StudentID=1, ClubName="Game" },
                new StudentClubs() {StudentID=2, ClubName="Game" },
                new StudentClubs() {StudentID=5, ClubName="Photography" },
                new StudentClubs() {StudentID=6, ClubName="Game" },
                new StudentClubs() {StudentID=7, ClubName="Photography" },
                new StudentClubs() {StudentID=3, ClubName="PTK" },
            };

            Console.WriteLine("Group by GPA:");
            var groupByGPA = studentGPAList.GroupBy(g => g.GPA);
            foreach (var group in groupByGPA)
            {
                Console.WriteLine($"GPA: {group.Key}");
                foreach (var student in group)
                {
                    Console.WriteLine($"StudentID: {student.StudentID}");
                }
            }

            Console.WriteLine("\n Group by Club (sorted):");
            var groupByClub = studentClubList
                .OrderBy(sc => sc.ClubName)
                .GroupBy(sc => sc.ClubName);
            foreach (var club in groupByClub)
            {
                Console.WriteLine($"Club: {club.Key}");
                foreach (var member in club)
                {
                    Console.WriteLine($"StudentID: {member.StudentID}");
                }
            }

            var countInRange = studentGPAList
                .Count(g => g.GPA >= 2.5 && g.GPA <= 4.0);
            Console.WriteLine($"\n Count of students with GPA between 2.5 and 4.0: {countInRange}");

            var averageTuition = studentList.Average(s => s.Tuition);
            Console.WriteLine($"\n Average Tuition: {averageTuition:C}");

            var highestTuition = studentList.Max(s => s.Tuition);
            Console.WriteLine("\n Student(s) paying the most tuition:");
            foreach (var student in studentList)
            {
                if (student.Tuition == highestTuition)
                {
                    Console.WriteLine($"Name: {student.StudentName}, Major: {student.Major}, Tuition: {student.Tuition:C}");
                }
            }

            Console.WriteLine("\n Students with GPA:");
            var studentWithGPA = studentList
                .Join(studentGPAList,
                      s => s.StudentID,
                      g => g.StudentID,
                      (s, g) => new { s.StudentName, s.Major, g.GPA });

            foreach (var student in studentWithGPA)
            {
                Console.WriteLine($"Name: {student.StudentName}, Major: {student.Major}, GPA: {student.GPA}");
            }

            Console.WriteLine("\n Students in the Game club:");
            var gameClubStudents = studentList
                .Join(studentClubList,
                      s => s.StudentID,
                      c => c.StudentID,
                      (s, c) => new { s.StudentName, c.ClubName })
                .Where(x => x.ClubName == "Game")
                .Select(x => x.StudentName)
                .Distinct();

            foreach (var name in gameClubStudents)
            {
                Console.WriteLine($" - {name}");
            }
        }
    }
}