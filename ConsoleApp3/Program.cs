using System;
using System.Collections;

namespace Sorting
{

    internal class Student : IComparable<Student>
    {
        private int age;
        private string name;
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public class CompareName : IComparer<Student>
        {
            public int Compare(Student? x, Student? y)
            {
                if (x == null && y == null) return 0;
                if (x == null || y == null) { return 1; }

                return (new CaseInsensitiveComparer()).Compare(x.name, y.name);
            }
        }
        public class CompareAge : IComparer<Student>
        {
            public int Compare(Student? x, Student? y)
            {
                if (x == null && y == null) return 0;
                if (x == null || y == null) { return 1; }

                return (new CaseInsensitiveComparer()).Compare(x.age, y.age);
            }
        }
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();
            list.Add(new Student("Badrian", 3));
            list.Add(new Student("Cadrian", 1));
            list.Add(new Student("Adrian", 2));
            list.Add(new Student("Badrian", -2));

            Console.WriteLine("List before sorting");
            list.ForEach(student => Console.WriteLine(student.name + " " + student.age));
            Console.WriteLine();
            list.Sort();
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
                return 0;
            }
            if (other.name == this.name)
            {
                return this.age.CompareTo(other.age); ;

            }
            return this.name.CompareTo(other.name);
        }
    }
}