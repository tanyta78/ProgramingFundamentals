namespace _8.Mentor_group
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            SortedDictionary<string, Student> students = new SortedDictionary<string, Student>();

            string dateInfo = Console.ReadLine();
            while (!dateInfo.Equals("end of dates"))
            {
                string name = dateInfo.Split(' ').ToArray()[0];
                ////create students dict name student
                Student student = new Student();
                student.Name = name;
                if (!students.ContainsKey(name))
                {
                    students.Add(name, student);
                }
                List<DateTime> dates = new List<DateTime>();
                ////make datetime list for student name if there are dates input

                if (dateInfo.Split(' ').ToArray().Length > 1)
                {
                    string[] dateString = dateInfo.Split(' ').ToArray()[1].Split(',').ToArray();

                    for (int i = 0; i < dateString.Length; i++)
                    {
                        DateTime date = DateTime.ParseExact(dateString[i], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                        dates.Add(date);
                    }

                }
                if (students[name].Dates != null)
                {
                    students[name].Dates.AddRange(dates);
                }
                else
                {
                    students[name].Dates = dates;
                }

                dateInfo = Console.ReadLine();
            }
            //  Console.WriteLine();

            string commentInfo = Console.ReadLine();

            while (!commentInfo.Equals("end of comments"))
            {
                ////read coment info
                string name = commentInfo.Split('-').ToArray()[0];
                string currentcomment = commentInfo.Split('-').ToArray()[1];
                ////create list comments
                List<string> comments = new List<string>();
                comments.Add(currentcomment);

                ////add list comments to list Student as a property of Student
                if (students.ContainsKey(name))
                {
                    if (students[name].Comments != null)
                    {
                        students[name].Comments.AddRange(comments);
                    }
                    else
                    {
                        students[name].Comments = comments;
                    }
                }

                commentInfo = Console.ReadLine();
            }

            foreach (var student in students.OrderBy(x => x.Key))
            {
                Console.WriteLine("{0}", student.Key);
                Console.WriteLine("Comments:");

                if (student.Value.Comments != null)
                {
                    foreach (var comment in student.Value.Comments)
                    {
                        Console.WriteLine("- {0}", comment);
                    }
                }

                Console.WriteLine("Dates attended:");

                foreach (var date in student.Value.Dates.OrderBy(d => d))
                {
                    Console.WriteLine("-- {0:dd/MM/yyyy}", date);
                }
            }
            Console.WriteLine();
        }

        public class Student
        {
            public string Name { get; set; }

            public List<DateTime> Dates { get; set; }

            public List<string> Comments { get; set; }
        }
    }
}