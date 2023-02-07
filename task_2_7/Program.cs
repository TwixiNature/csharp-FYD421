/*Skriv ett program som beräknar omkretsen av en geometrisk form. Användaren kan välja mellan en 
rektangel, en triangel, en cirkel och en kvadrat. Användaren kan också välja formens parametrar, 
såsom sidlängd, radie osv. Använd klasser och arv i programmet. */
using System;
using System.Reflection.Metadata.Ecma335;
using static UserInputFunctions.UserInputFunctions;



namespace MathClass
{
    abstract class shape
    {
        public double get_input(string q) // testing some inheritance
        {
            double input = tryReadDouble(q);
            return input;
        }
        public abstract double calc_circfrc();

        static void Main(string[] args)
        {
            int choice;
            ReadInt("What shape? 1) rectangle, 2) triangle, 3) circle 4) square", out choice);

            switch (choice)
            {
                case 1:
                    Console.WriteLine("You chose rectangle");
                    rectangle rect = new rectangle();
                    Console.WriteLine($"Circumference is {rect.calc_circfrc()}");
                    break;
                case 2:
                    Console.WriteLine("You chose triangle");
                    triangle tri = new triangle();
                    Console.WriteLine($"Circumference is {tri.calc_circfrc()}");
                    break;
                case 3:
                    Console.WriteLine("You chose circle");
                    circle crc = new circle();
                    Console.WriteLine($"Circumference is {crc.calc_circfrc()}");
                    break;
                case 4:
                    Console.WriteLine("You chose square");
                    square sqr = new square();
                    Console.WriteLine($"Circumference is {sqr.calc_circfrc()}");
                    break;
                default:
                    Console.WriteLine("Not one of the choices, you failed this simple task...");
                    break;
            }
        }
        class rectangle : shape // rectangle
        {
            double side1 = 1;
            double side2 = 2;

            public rectangle()
            {
                this.side1 = get_input("length of one side?");
                this.side2 = get_input("length of other side?");
            }

            override public double calc_circfrc()
            {
                return (this.side1 + this.side2) * 2;
            }
        }
        class triangle : shape //triangle
        {
            double side = 0;

            public triangle()
            {
                this.side = get_input("lenth of side?");
            }

            public override double calc_circfrc()
            {
                return this.side * 3;
            }
        }
        class circle : shape //circle
        {
            double radius = 0;

            public circle()
            {
                this.radius = get_input("Radius of circle?");
            }

            public override double calc_circfrc()
            {
                return this.radius * Math.PI * 2;
            }
        }
        class square : shape //square
        {
            double side = 0;

            public square()
            {
                this.side = get_input("Length of side?");
            }
            public override double calc_circfrc()
            {
                return this.side * 4;
            }
        }
    }
}
