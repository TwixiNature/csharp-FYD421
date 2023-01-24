namespace UserInputFunctions
{
    public class UserInputFunctions
    {
        static public void ReadInt(string q, out int output)
        {
            Console.Write(q);
            while (!int.TryParse(Console.ReadLine(), out output))
            {
                Console.WriteLine("Expected integer, please try your input again!");
                Console.WriteLine();
                Console.WriteLine(q);
            };
        }
    }
}