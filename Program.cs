namespace Gruppupgift_21_blackjack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program Variables

            Random kast = new Random();
            string vinnerfora = "\n\n\t\tIngen har vunnit än";
            int menu = 0;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Clear();

            //Main loop
            while (menu != 4)
            {
                // Displaying Menu
                Console.WriteLine(
                   "\t\t Välkomen till 21:an\n" +
                   "\t\t Välj ett alternativ\n" +
                   "\t\t  1.Spela 21:an\n" +
                   "\t\t  2.Visa senaste vinnaren\n" +
                   "\t\t  3.Spelets regler\n" +
                   "\t\t  4.Avsluta programmet\n");

                Console.Write("\t");
                menu = (Char)Console.ReadKey().KeyChar;

                menu = menu - 48;
                switch (menu)
                {
                    case 1:
                        // Sätt spelarensPoäng och datornsPoäng till 0
                        int användaren = 0;
                        int dator1 = 0;
                        // Dra två kort per spelare
                        Console.WriteLine("\n\t\tNu kommer två kort dras per spelare");

                        for (int i = 0; i < 2; ++i)
                        {
                            int temp1 = kast.Next(1, 11);
                            användaren = användaren + temp1;
                            Console.WriteLine($"\n\tDin kort är  : {temp1}");
                            int temp2 = kast.Next(1, 11);
                            dator1 = dator1 + temp2;
                            Console.WriteLine($"\n\tBot kort är  : {temp2}");
                        }

                        char kortDraw = 'J';

                        while (kortDraw != 'N' && användaren <= 21)
                        {

                            Console.WriteLine($"\n\tDin kortsumma är  : {användaren}");
                            Console.WriteLine($"\n\tBot kortsumma är  : {dator1}");
                            Console.WriteLine("\n\n\t\tVil du dräja kort? Ja / Nej  (j/n) ");
                            Console.Write("\t");
                            kortDraw = Console.ReadKey().KeyChar;


                            if (kortDraw == 74 || kortDraw == 106)
                            {
                                // for j J ascii (kortDraw == 74 || kortDraw == 106);
                                kortDraw = 'J';
                            }
                            else if (kortDraw == 78 || kortDraw == 110)
                            {
                                // for n N ascii (kortDraw == 78 || kortDraw == 110);
                                kortDraw = 'N';
                            }


                            switch (kortDraw)
                            {

                                case 'J':
                                    int temp1 = kast.Next(1, 11);
                                    användaren = användaren + temp1;
                                    Console.WriteLine($"\n\tDin kort är  : {temp1}");
                                    Console.WriteLine($"\n\tDin kortsumma är  : {användaren}");
                                    break;

                                case 'N':
                                    Console.WriteLine("\n\n\t\tViljat inte draw kort..");
                                    break;

                                default:
                                    Console.WriteLine("\n\tInte en giltig nyckel välj J/N");
                                    break;
                            }
                        }

                        // Gå tillbaka till huvudmenyn om användaren har över 21
                        if (användaren > 21)
                        {


                            Console.WriteLine("" +
                                "\n\t             ===============" +
                                "\n\tDu förlorade !!!Bot vann!!!!" +
                                "\n\t             ===============");


                            vinnerfora = "\n\t\t Bot ";

                            break;
                        }

                        // Datorn drar kort tills den vinner eller går över 21
                        while (dator1 < användaren && dator1 <= 21)
                        {
                            int temp2 = kast.Next(1, 11);
                            dator1 = dator1 + temp2;
                            Console.WriteLine($"\n\t\tBot drog kort värt {temp2}");
                        }
                        // Skriv ut datorns och spelarens poäng
                        Console.WriteLine($"\n\t\tDinna kortsumma {användaren}");
                        Console.WriteLine($"\n\t\tBot's kortsumma {dator1}");

                        // Undersök vem som vann
                        if (dator1 > 21)
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\n\t\t  (((((  Du har vunnit!  )))))  ");
                            Console.WriteLine("\n\t\tSkriv in ditt namn\n\t");
                            vinnerfora = Console.ReadLine();
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.WriteLine("\n\n\t\t(((((  Bot har vunnit!  )))))\n\n");
                            vinnerfora = "\n\t\t Bot ";
                        }
                        // Om spelaren vann så får hen skriva in sitt namn
                        break;



                    case 2:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Clear();
                        Console.WriteLine($"\n\n\t\tSenaste vinnaren: {vinnerfora}\n\n");
                        Console.ForegroundColor = ConsoleColor.Magenta;

                        break;


                    case 3:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Clear();

                        Console.WriteLine("" +
                            "\n\n\tDitt mål är att tvinga datorn att få mer än 21 poäng." +
                            "\n\tDu får poäng genom att dra kort, varje kort har 1-10 poäng." +
                            "\n\tOm du får mer än 21 poäng har du förlorat." +
                            "\n\tBåde du och datorn får två kort i början. Därefter får du" +
                            "\n\tdra fler kort tills du är nöjd eller får över 21." +
                            "\n\tNär du är färdig drar datorn kort till den har" +
                            "\n\tmer poäng än dig eller över 21 poäng.\n\n\t");
                        Console.ForegroundColor = ConsoleColor.Magenta;

                        break;

                    case 4:
                        Console.WriteLine($"\n\t Program avsluter");
                        break;

                    default:

                        Console.WriteLine("\n\t\t--Välj ett giltigt nummer!!!--");

                        break;
                }

            }
        }
    }
}