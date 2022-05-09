using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängijat - arvuti (cpu) ja kasutaja (user);
            //mõlemad mängijad viskavad täringuid;
            //programm kontrollib, kumb mängija viskas rohkem;
            //mängija, kes viskab rohkem, ongi mängu võitja;
            //*täringuid visatakse kolm korda
            //programm kuulutab võitja;

            Random rnd = new Random();

            //arvuti vise
            int cpuRandom = rnd.Next(1, 7);
            //kasutaja vise
            int userRandom = rnd.Next(1, 7);

            int cpuScore = 0;
            int userScore = 0;
            int i = 0;

            while (i < 3)
            {
                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}");
                
                if (cpuRandom < userRandom)
                {
                    userScore++;
                }

                else
                {
                    cpuScore++;
                }
                cpuRandom = rnd.Next(1, 7);
                userRandom = rnd.Next(1, 7);
                i++;

            }

            if (cpuScore < userScore)
            {
                Console.WriteLine("Kasutaja on mängu võitnud!");
            }
            else if(cpuScore > userScore)
            {
                Console.WriteLine("Arvuti on mängu võitnud.");
            }
            else
            {
                Console.WriteLine("Viik!");
            }


        }
    }
}
