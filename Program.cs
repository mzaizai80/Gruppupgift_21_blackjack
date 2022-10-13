namespace Gruppupgift_21_blackjack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Grupupgifft Blackjack

            /*Skriva välkomnstmeddelande
                * while (menyval != "4")
                * skriv ut meny
                * Läs in menyval
                * switch meny
                * case 1 spela
                * case 2 visa senaste vinnare
                * case 3 visa spelets regler
                * case 4 avsluta spelet
                * default
                * 
                * Case 1 frågar vi om spelaren vill dra ett kort j/n väljer spelaren att dra ett kort så slumpas
                * ett kort mellan 1-10 och då får spelaren reda på vad han fick samt hur mycket poäng hen har,
                * väljer spelaren att inte dra ett kort ska datorn dra ett kort.
                * 
                * Case 2 så behöver vi ha en variabel som sparar spelaren som har vunnit.
                * Default som tar upp tar upp felinmatning
                * 
                * 
                * 
                */



            

            int användaren = 0;
            int dator1 = 0;
            int menu;
            string[] vinnaren;

            const int svar = 21;

            Console.WriteLine(
               "\t\t Välkomen till 21:an\n" +
               "\t\t Välj ett alternativ\n" +
               "\t\t  1.Spela 21:an\n" +
               "\t\t  2.Visa senaste vinnaren\n" +
               "\t\t  3.Spelets regler\n" +
               "\t\t  4.Avsluta programmet\n");

            menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:



                    break;

                case 2:
                    break;


                case 3:
                    break;

                case 4:


                    break;

            }

    
             void Start21(int slump, int användaren, int dator1)
            {
                Random slump2 = new Random();   
                for (int i = 0; i < 2; ++i)
                {
                användaren = användaren + slump2.Next(1, 11);
                dator1= dator1+ slump2.Next(1, 11);
                }


            }


        }
    }
}