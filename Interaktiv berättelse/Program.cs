using System;

namespace Interaktiv_berättelse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Du går i skogen. Vill du svänga höger eller vänster?");
            string riktning1 = GetDirection();

            //Första Svänger Höger 
            if (riktning1 == "höger")
            {
                Console.WriteLine("Du går längre in i skogen och kommer till en äng. Vill du svänga vänster på vägen eller höger? ");

                string riktning2 = GetDirection();

                if (riktning2 == "vänster")
                {
                    Console.WriteLine("Du kommer till en vägkorsning. Går du höger går du hem, går du vänster går du och handlar.");
                    string riktning3 = GetDirection();

                    if (riktning3 == "vänster")
                    //Scenario 1
                    {
                        Console.WriteLine("Du går och handlar. Effter du handlat går du hem med varorna.");
                    }
                    else if (riktning3 == "höger")
                    //Scenario 2
                    {
                        Console.WriteLine("Du kom hem");
                    }
                }
                else if (riktning2 == "höger")
                {
                    Console.WriteLine("Du följer högerkanten tills du kommer till en väg. Vill du svänga höger eller vänster?");
                    string riktning3 = GetDirection();

                    if (riktning3 == "vänster")
                    //Scenario 3
                    {
                        Console.WriteLine("Du fortsättter längs vägen tills du kommer hem.");
                    }
                    else if (riktning3 == "höger")
                    //Scenario 4
                    {
                        Console.WriteLine("Du svänger höger och kommer till en matbutik. Du handlar dina varor och går hem.");
                    }
                }





            }
            //Första Svänger vänster
            else if (riktning1 == "vänster")
            {
                Console.WriteLine("Du svänger vänster och fortsätter längs vägen. Du komemr fram till en korsning. Ska du svänga Vänster eller Höger.");
                string riktning2 = GetDirection();

                if (riktning2 == "höger")
                {
                    Console.WriteLine("Du svänger höger och kommer framm till en korsning. Svänger du Höger eller Vänster?");
                    string riktning3 = GetDirection();
                    if (riktning3 == "höger")
                    //Scenario 5
                    {
                        Console.WriteLine("Du kom framm till en matbutik. Du hadlar dina varor och går hem.");
                    }
                    else if (riktning3 == "vänster")
                        //Scenario 6
                        Console.WriteLine("Du svängde vänster och kom hem.");
                }
                else if (riktning2 == "vänster")
                {
                    Console.WriteLine("Du svänger vänster och kom fram till en korsning. Ska du svänga vänster eller höger?");
                    string riktning3 = GetDirection();
                    riktning3 = riktning3.ToLower();
                    if (riktning3 == "höger")
                    //Scenario 7
                    {
                        Console.WriteLine("Du kom fram till en datorutik. Du köper en dator och går hem.");
                    }
                    else if (riktning3 == "vänster")
                    //Scenario 8
                    {
                        Console.WriteLine("Du kom fram till en korsning. Du ser ditt hus och går hem.");
                    }

                }

            }

            Console.ReadLine();
        }

        static string GetDirection()
        {
            string direction = Console.ReadLine();
            direction = direction.ToLower();

            return direction;
        }
    }
}