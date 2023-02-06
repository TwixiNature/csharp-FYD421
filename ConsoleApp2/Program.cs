namespace Sorting
{
 
    internal class Student : IComparable<Student>
    {
        private int age;
        private string name;
        public Student(string name, int age) { 
            this.name = name;
            this.age = age;
        }
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();
            list.Add(new Student("Badrian", 3));
            list.Add(new Student("Cadrian", 1));
            list.Add(new Student("Adrian", 2));
            list.Add(new Student("Badrian", -2));

            list.ForEach(student => Console.WriteLine(student.name + " " + student.age));
            Console.WriteLine();
            list.Sort();
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