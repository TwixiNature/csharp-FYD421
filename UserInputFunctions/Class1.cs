namespace UserInputFunctions
{
    public class UserInputFunctions
    {
        static public void ReadInt(string q, out int output) //  Func<int,bool> pred
        {
            Console.Write(q);
            while (!int.TryParse(Console.ReadLine(), out output)) //&& pred(output)
            {
                Console.WriteLine("Expected integer, please try your input again!");
                Console.WriteLine();
                Console.WriteLine(q);
            };
        }

        static public void ReadIntwithLimit(string q, out int output, int lowlim, int upperlim) //  Func<int,bool> pred
        {
            Console.Write(q);
            while (!int.TryParse(Console.ReadLine(), out output) || output < lowlim || output > upperlim) //&& pred(output)
            {
                Console.WriteLine($"Expected integer between {lowlim} and {upperlim}, please try your input again!");
                Console.WriteLine();
                Console.WriteLine(q);
            };
        }
        static public double tryReadDouble(string q)
        {
            bool correct = false;
            double cost = 0;
            //get cost (exception handling)
            while (!correct)
            {
                Console.WriteLine(q);
                try
                {
                    cost = Convert.ToDouble(Console.ReadLine());
                    correct = true; // if conversion worked
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message); // print exception
                }
            }
            return cost;

        }
        static public string ReadString(string q)
        {
            bool correct = false;
            string str = "0";
            //get cost (exception handling)
            while (!correct)
            {
                Console.WriteLine(q);
                try
                {
                    str = Console.ReadLine();
                    correct = true; // if conversion worked
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message); // print exception
                }
            }
            return str;
        }

    }
}