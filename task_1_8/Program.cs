/*Skriv ett program som numeriskt beräknar en integral. Den enklaste numeriska integrationsmetoden 
tillämpar den så kallade rektangulärregeln.Variablerna x0 = a, xN = b. Antalet intervall, N, skall anges av användaren (större N ger ett bättre 
värde på integralen men innebär samtidigt att programmet tar längre tid att köra). Programmet ska 
fungera  för  godtycklig  integral  (som  finns  i  källkoden  och  som  inte  ska  anges  av  användaren). 
 */

using System;
using System.Reflection.Metadata.Ecma335;
using static UserInputFunctions.UserInputFunctions;

namespace calculation
{
    internal class Integral_calc
    {

        static void Main(string[] args)
        {
            var integral = new Integral_calc(); //create object
            int a , b, N;
            double n, sum = 0 ; 
            ReadInt("Set start of integral, a= ?", out a); //set start of integral
            ReadInt("Set end of integral, b= ?", out b); //set end of integral
            ReadInt("Set number of sections, N= ?", out N); //set number of sections

            
            n = (b-a)/(double)N; //width of rectangl


            for (double x =a; x <b; x =x + n){
                double y = integral.get_func_val(x+ n/2); // measures height at middle of rectangle
                sum = sum + y * n;  // height * width of rectangle
            }

            Console.WriteLine($"The integral is {sum}");
            
        }

        double get_func_val ( double x) // returns value of integral function at x
        {
            double f =  x; //4 * Math.Pow(x, 2) + 3; // 4x^2 +3

            return f; 
        }
    } 
}