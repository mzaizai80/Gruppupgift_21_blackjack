

/*       // When New game starts
       static int Start21(int användaren, int dator1, Random slump)
       {

           for (int i = 0; i < 2; ++i)
           {
               användaren = användaren + slump.Next(1, 11);
               dator1 = dator1 + slump.Next(1, 11);
               Console.WriteLine($"\n\tDatorn kortsumma är  : {dator1}");

               Console.WriteLine($"\n\tDin kortsumma är  : {användaren}");
           }
           return + dator1;
           return + användaren;
       }

       static int AnvändarenSpelar(int användaren, Random slump)
       {

           Console.WriteLine("Vil du dräja kort? Ja / Nej  (j/n) ");
           char input = Convert.ToChar(Console.ReadKey().KeyChar);


           if (användaren <= 21)
           {
               användaren = användaren + slump.Next(1, 11);
               Console.WriteLine($"\n\tDin kortsumma är  : {användaren}");

           }



           return användaren;
       }*/


/*
        asd:

            int choose;
            Console.WriteLine("1/2");
            choose = Console.ReadKey().KeyChar;
            choose = choose - 48;
            switch (choose)
            {
                case 1:

                    Random slump = new Random();
                    string senasteVinnaren = "Ingen har vunnit än";

                    Console.WriteLine("Välkommen till 21:an!");

                    string menyVal = "0";
                    while (menyVal != "4")
                    {
                        // Skriv ut huvudmenyn
                        Console.WriteLine("Välj ett alternativ");
                        Console.WriteLine("1. Spela 21:an");
                        Console.WriteLine("2. Visa senaste vinnaren");
                        Console.WriteLine("3. Spelets regler");
                        Console.WriteLine("4. Avsluta programmet");
                        menyVal = Console.ReadLine();

                        // Tom rad innan användarens val körs
                        Console.WriteLine();

                        switch (menyVal)
                        {
                            // Spela en omgång av 21:an
                            case "1":
                                int datornsPoäng = 0;
                                int spelarensPoäng = 0;
                                Console.WriteLine("Nu kommer två kort dras per spelare");
                                datornsPoäng += slump.Next(1, 11);
                                datornsPoäng += slump.Next(1, 11);
                                spelarensPoäng += slump.Next(1, 11);
                                spelarensPoäng += slump.Next(1, 11);

                                // Låt användaren dra fler kort
                                string kortVal = "";
                                while (kortVal != "n" && spelarensPoäng <= 21)
                                {
                                    Console.WriteLine($"Din poäng: {spelarensPoäng}");
                                    Console.WriteLine($"Datorns poäng: {datornsPoäng}");
                                    Console.WriteLine("Vill du ha ett till kort? (j/n)");
                                    kortVal = Console.ReadLine();

                                    switch (kortVal)
                                    {
                                        case "j":
                                            int nyPoäng = slump.Next(1, 11);
                                            spelarensPoäng += nyPoäng;
                                            Console.WriteLine($"Ditt nya kort är värt {nyPoäng} poäng");
                                            Console.WriteLine($"Din totalpoäng är {spelarensPoäng}");
                                            break;

                                        case "n":
                                            break;

                                        default:
                                            Console.WriteLine("Du valde inte ett giltigt alternativ");
                                            break;
                                    }

                                }

                                // Gå tillbaka till huvudmenyn om användaren har över 21
                                if (spelarensPoäng > 21)
                                {
                                    Console.WriteLine("Du har mer än 21 och har förlorat");
                                    break;
                                }

                                // Datorn drar kort tills den vinner eller går över 21
                                while (datornsPoäng < spelarensPoäng && datornsPoäng <= 21)
                                {
                                    int datornsNyaPoäng = slump.Next(1, 11);
                                    datornsPoäng += datornsNyaPoäng;
                                    Console.WriteLine($"Datorn drog ett kort värt {datornsNyaPoäng}");
                                }

                                Console.WriteLine($"Din poäng: {spelarensPoäng}");
                                Console.WriteLine($"Datorns poäng: {datornsPoäng}");

                                // Undersök vem som vann
                                if (datornsPoäng > 21)
                                {
                                    Console.WriteLine("Du har vunnit!");
                                    Console.WriteLine("Skriv in ditt namn");
                                    senasteVinnaren = Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("Datorn har vunnit!");
                                }

                                break;

                            // Visa senaste vinnaren
                            case "2":
                                Console.WriteLine($"Senaste vinnaren: {senasteVinnaren}");
                                break;

                            // Visa spelets regler
                            case "3":
                                Console.WriteLine("Ditt mål är att tvinga datorn att få mer än 21 poäng.");
                                Console.WriteLine("Du får poäng genom att dra kort, varje kort har 1-10 poäng.");
                                Console.WriteLine("Om du får mer än 21 poäng har du förlorat.");
                                Console.WriteLine("Både du och datorn får två kort i början. Därefter får du");
                                Console.WriteLine("dra fler kort tills du är nöjd eller får över 21.");
                                Console.WriteLine("När du är färdig drar datorn kort till den har");
                                Console.WriteLine("mer poäng än dig eller över 21 poäng.");
                                break;

                            // Gör ingenting (programmet avslutas)
                            case "4":
                                break;

                            default:
                                Console.WriteLine("Du valde inte ett giltigt alternativ");
                                break;
                        }

                        // Tom rad innan nästa körning
                        Console.WriteLine();
                    }


                    break;
                case 2:

                    break;

                default:

                    Console.WriteLine("closes");
                    break;

            }
            goto asd;
 */


/*

namespace Gruppupgift_21_blackjack
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Skriv välkomstmeddelande

            // Sätt menyVal till "0"

            // while (menyval != ”4”)

            // Skriv ut meny

            // Läs in menyVal

            // switch menyVal
            // case 1:Spela en omgång av 21:an
            // Spela en omgång av 21:an
            //    case "1":
            // Sätt spelarensPoäng och datornsPoäng till 0
            // Dra två kort per spelare

            // sätt kortVal till "j"
            // while (kortVal != "n" och spelarensPoäng <= 21)
            // Skriv ut poängställningen
            // Fråga om spelaren vill ha ett till kort
            // Läs in kortval

            // switch kortVal
            // case "j": Dra ett kort till
            // case "n": Gör ingenting (loopen kommer sluta köras)
            // default: Skriv att alternativet var ogiltigt
            //           break;
            // Gå tillbaka till huvudmenyn om användaren har över 21
            // Datorn drar kort tills den vinner eller går över 21
            // Skriv ut datorns och spelarens poäng
            // Undersök vem som vann
            // Om spelaren vann så får hen skriva in sitt namn


            // case 2: Visa senaste vinnaren
            // case 3: Visa spelets regler
            // case 4: Gör ingenting (programmet avslutas)
            // default: Skriv att alternativet var ogiltigt







            Random slump = new Random();
            string senasteVinnaren = "Ingen har vunnit än";

            Console.WriteLine("Välkommen till 21:an!");

            string menyVal = "0";
            while (menyVal != "4")
            {
                // Skriv ut huvudmenyn
                Console.WriteLine("Välj ett alternativ");
                Console.WriteLine("1. Spela 21:an");
                Console.WriteLine("2. Visa senaste vinnaren");
                Console.WriteLine("3. Spelets regler");
                Console.WriteLine("4. Avsluta programmet");
                menyVal = Console.ReadLine();

                // Tom rad innan användarens val körs
                Console.WriteLine();

                switch (menyVal)
                {
                    // Spela en omgång av 21:an
                    case "1":
                        int datornsPoäng = 0;
                        int spelarensPoäng = 0;
                        Console.WriteLine("Nu kommer två kort dras per spelare");
                        datornsPoäng += slump.Next(1, 11);
                        datornsPoäng += slump.Next(1, 11);
                        spelarensPoäng += slump.Next(1, 11);
                        spelarensPoäng += slump.Next(1, 11);

                        // Låt användaren dra fler kort
                        string kortVal = "";
                        while (kortVal != "n" && spelarensPoäng <= 21)
                        {
                            Console.WriteLine($"Din poäng: {spelarensPoäng}");
                            Console.WriteLine($"Datorns poäng: {datornsPoäng}");
                            Console.WriteLine("Vill du ha ett till kort? (j/n)");
                            kortVal = Console.ReadLine();

                            switch (kortVal)
                            {
                                case "j":
                                    int nyPoäng = slump.Next(1, 11);
                                    spelarensPoäng += nyPoäng;
                                    Console.WriteLine($"Ditt nya kort är värt {nyPoäng} poäng");
                                    Console.WriteLine($"Din totalpoäng är {spelarensPoäng}");
                                    break;

                                case "n":
                                    break;

                                default:
                                    Console.WriteLine("Du valde inte ett giltigt alternativ");
                                    break;
                            }

                        }

                        // Gå tillbaka till huvudmenyn om användaren har över 21
                        if (spelarensPoäng > 21)
                        {
                            Console.WriteLine("Du har mer än 21 och har förlorat");
                            break;
                        }

                        // Datorn drar kort tills den vinner eller går över 21
                        while (datornsPoäng < spelarensPoäng && datornsPoäng <= 21)
                        {
                            int datornsNyaPoäng = slump.Next(1, 11);
                            datornsPoäng += datornsNyaPoäng;
                            Console.WriteLine($"Datorn drog ett kort värt {datornsNyaPoäng}");
                        }

                        Console.WriteLine($"Din poäng: {spelarensPoäng}");
                        Console.WriteLine($"Datorns poäng: {datornsPoäng}");

                        // Undersök vem som vann
                        if (datornsPoäng > 21)
                        {
                            Console.WriteLine("Du har vunnit!");
                            Console.WriteLine("Skriv in ditt namn");
                            senasteVinnaren = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Datorn har vunnit!");
                        }

                        break;

                    // Visa senaste vinnaren
                    case "2":
                        Console.WriteLine($"Senaste vinnaren: {senasteVinnaren}");
                        break;

                    // Visa spelets regler
                    case "3":
                        Console.WriteLine("Ditt mål är att tvinga datorn att få mer än 21 poäng.");
                        Console.WriteLine("Du får poäng genom att dra kort, varje kort har 1-10 poäng.");
                        Console.WriteLine("Om du får mer än 21 poäng har du förlorat.");
                        Console.WriteLine("Både du och datorn får två kort i början. Därefter får du");
                        Console.WriteLine("dra fler kort tills du är nöjd eller får över 21.");
                        Console.WriteLine("När du är färdig drar datorn kort till den har");
                        Console.WriteLine("mer poäng än dig eller över 21 poäng.");
                        break;

                    // Gör ingenting (programmet avslutas)
                    case "4":
                        break;

                    default:
                        Console.WriteLine("Du valde inte ett giltigt alternativ");
                        break;
                }

                // Tom rad innan nästa körning
                Console.WriteLine();
            }

        }
    }
}
*/




//------------------------------------------------------------------
