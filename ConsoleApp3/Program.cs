using System;
using System.Collections;

namespace Sorting
{

    internal class Student : IComparable<Student> //part a)
    {
        private int age;
        private string name;
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public class CompareName : IComparer<Student> //part b)
        {
            public int Compare(Student? x, Student? y)
            {
                if (x == null && y == null) return 0;
                if (x == null || y == null) { return 1; }

                return new CaseInsensitiveComparer().Compare(x.name, y.name);
            }
        }
        public class CompareAge : IComparer<Student> // part b)
        {
            public int Compare(Student? x, Student? y)
            {
                if (x == null && y == null) return 0;
                if (x == null || y == null) { return 1; }

                return new CaseInsensitiveComparer().Compare(x.age, y.age);
            }
        }
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>(); //empty list of students
            list.Add(new Student("Linnea", 3)); //adding students with different ages
            list.Add(new Student("Linnea", 1));
            list.Add(new Student("Adrian", 2));
            list.Add(new Student("Anna", -2));

            Console.WriteLine("List before sorting"); // printing list
            list.ForEach(student => Console.WriteLine(student.name + " " + student.age));
            Console.WriteLine();
            list.Sort(); // general sorting function
            Console.WriteLine("List after general sorting");
            list.ForEach(student => Console.WriteLine(student.name + " " + student.age));
            Console.WriteLine();
            list.Sort(new CompareAge());
            Console.WriteLine("List after age sorting");
            list.ForEach(student => Console.WriteLine(student.name + " " + student.age));
            Console.WriteLine();
            list.Sort(new CompareName());
            Console.WriteLine("List after name sorting");
            list.ForEach(student => Console.WriteLine(student.name + " " + student.age));

        }

        public int CompareTo(Student? other)
        {
            if (other == null)
            {
                return 0; // Do not change order with null
            }
            if (other.name == this.name) // if same name
            {
                return this.age.CompareTo(other.age); //sort age

            }
            return this.name.CompareTo(other.name); //otherwise sort name
        }
    }
}