namespace _4.Average_Grades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Average_Grades
    {
        public static void Main()
        {
            int numberStudents = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();
            for (int i = 1; i <= numberStudents; i++)
            {
                string[] studentInfo = Console.ReadLine().Split();

                string studentName = studentInfo[0];
                List<double> studentGrades = new List<double>();
                for (int j = 1; j < studentInfo.Length; j++)
                {
                    double grade = double.Parse(studentInfo[j]);
                    studentGrades.Add(grade);
                }


                Student currentStudent = new Student();
                currentStudent.Name = studentName;
                currentStudent.Grades = studentGrades;

                students.Add(currentStudent);
            }

            foreach (var item in students.Where(x => x.AverageGrades() >= 5)
                .OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrades()))
            {
                Console.WriteLine("{0} -> {1:f2}", item.Name, item.AverageGrades());
            }

        }
        public class Student
        {
            public string Name { get; set; }
            public List<double> Grades { get; set; }
            public double AverageGrades()
            {
                double averageGrade = this.Grades.Average();
                return averageGrade;

            }
        }
    }
}