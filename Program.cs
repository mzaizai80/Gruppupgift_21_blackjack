namespace Gruppupgift_21_blackjack
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            bool programRunning = true;
            while (programRunning)

            {
                Console.WriteLine("Chose one of the following choices in the meny:");
                Console.WriteLine("1. Play" +
                    "\n2. Show the last winner"
                    +
                    "\n3. Show the game rules"
                    +
                    "\n4. End the game");

                string winner = "Uncoded One";

                string menyChoice = Console.ReadLine();
                switch (menyChoice)
                {
                    case "1":
                        Console.WriteLine("Play the game! :)");

                        Random chance = new Random();
                        int currentCard;
                        int playerSum = 0;
                        int npcSum = 0;


                        playerSum = chance.Next(1, 11);
                        playerSum += chance.Next(1, 11);

                        npcSum = chance.Next(1, 11);
                        npcSum += chance.Next(1, 11);

                        Console.WriteLine($"The player have {playerSum} points.");
                        Console.WriteLine($"The NPC have {npcSum} points.");

                        Console.WriteLine("Pull another card? Write yes or no and press enter.");
                        string answer = Console.ReadLine().ToLower();

                        while (answer == "yes" && playerSum < 22)
                        {
                            currentCard = chance.Next(1, 11);
                            playerSum += currentCard;
                            Console.WriteLine($"The card pulled give {currentCard} points.");
                            Console.WriteLine($"The player have {playerSum} points.");
                            Console.WriteLine($"The NPC have {npcSum} points.");

                            if (playerSum > 21) break;
                            Console.WriteLine("Pull another card? Write yes or no and press enter.");
                            answer = Console.ReadLine().ToLower();
                        }

                        if (playerSum < 22)
                        {
                            while (npcSum < playerSum)
                            {
                                currentCard = chance.Next(1, 11);
                                npcSum += currentCard;
                                Console.WriteLine($"The card pulled give {currentCard} points.");
                                Console.WriteLine($"The player have {playerSum} points.");
                                Console.WriteLine($"The NPC have {npcSum} points.");

                                if (npcSum > 21) break;
                            }
                        }

                        if (playerSum > npcSum && playerSum < 22 || npcSum > 21 && playerSum < 22)
                        {
                            Console.WriteLine("You defeated the NPC! YOU WON!!! B)");
                            Console.WriteLine("Please leave your name!");
                            winner = Console.ReadLine();
                        }

                        else if (npcSum < 22)
                        {
                            Console.WriteLine("You lost to the NPC! T_T");
                            winner = "NPC";
                        }
                        break;

                    case "2":
                        Console.WriteLine(winner);

                        break;

                    case "3":
                        Console.WriteLine();

                        break;

                    case "4":
                        programRunning = false;
                        break;

                    default:
                        Console.WriteLine("You have to chose between 1 - 4.");
                        break;
                }
            }
        }
    }
}