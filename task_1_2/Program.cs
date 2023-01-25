/*
 * När du handlar i en affär och betalar kontant får du kanske växel tillbaka. I regel får affärsbiträdet 
hjälp av kassaapparaten med att beräkna summan man ska få tillbaka, men inte alltid vilka sedlar 
och  mynt  som  ska  lämnas  tillbaka.  Skriv  ett  program  som  beräknar  den  växel  biträdet  ska  ge 
tillbaka i samband med ett köp. Programmet ska, förutom att presentera beloppet kunden får tillbaka 
avrundat till närmsta 50-öring, även bestämma vilka, och antalet, sedlar och mynt. Kunden ska få 
så få sedlar och mynt som möjligt tillbaka. Programmet ska kunna ge växel tillbaka med sedlar av 
valörerna 1000, 500, 200, 100, 50 och 20 samt mynten 10, 5, 1 och 50-öring. Du kan anta att det 
alltid finns tillräckligt antal av de sedlar och mynt som krävs. 
 
Skriv endast ut de valörer som ska lämnas tillbaka. Eventuella fel i samband med inmatningen ska 
tas om hand. Använd try/catch och fånga lämpligt undantag (exception). Glöm inte att testa 
programmet. Om t.ex. en kund handlar för 371,38 kr avrundas beloppet till 371,50 kr. Om kunden 
betalar med en 1000 kr-sedel ska kunden få 628,50 kr tillbaka, fördelat enligt figuren.
*/

using System;
using static UserInputFunctions.UserInputFunctions;

namespace store
{
    internal class cashier
    {
        static void Main(string[] args)
        {
            double cost = 0;
            double sum = 0;
            double dif = 0;


            cost = tryReadDouble("What did it cost?"); //we made a library with exception handling

            //BEST ROUND UP FUNCTION I'VE EVER DONE
            //round up cost to closest 50 öre
            //how many times is cost divisable with 0.5?
            //math.ceiling rounds it up to the closest integer (in double format) 
            // and then multiplied by 0.5
            cost = Math.Ceiling(cost / 0.5) * 0.5;


            sum = tryReadDouble("What did you pay?"); // we made a library with exception handling

            while (sum < cost) //if you payed too little, try again
            {
                Console.WriteLine("You payed too little, try again");
                sum = tryReadDouble("What did you pay?");
            }            

            // calc diff
            dif = sum - cost;

            Console.WriteLine($"You get {dif} kronor back"); // the total sum back

            double[] money = { 1000, 500, 200, 100, 50, 20, 10, 5, 1, 0.5 }; // array for the different notes

            foreach (double note in money) // for each available note going from biggest to smallest
            {
                if(dif / note>=1) //if the current note fits in difference
                {
                    if(note> 10) //just different prints for different notes
                    {
                        Console.WriteLine($"{note}-lappar : {(int)(dif / note)}"); // print how many you can give out, ex 5 st 200
                    }
                    else if( note > 0.5)
                    {
                        Console.WriteLine($"{note}-kronor : {(int)(dif / note)}");
                    }
                    else
                    {
                        Console.WriteLine($"50-öring : {(int)(dif / note)}");
                    }
                    
                    dif = dif - (int)(dif / note) * note; // and subtract 5 * 200 from difference
                }
            }
        }
    }
}