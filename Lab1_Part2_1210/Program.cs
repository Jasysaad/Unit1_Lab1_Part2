using System;

namespace Lab1_Part2_1210
{
    class Program
    {
        static void Main(string[] args)

        {
            Random rnd = new Random();
            Console.WriteLine("Guess: Will we flip heads or tails more?");
            string headsOrTailsGuess = Console.ReadLine(); 
            Console.WriteLine("How many coin flips?");
            string NumberofFlips = Console.ReadLine();
            int CorrectCount;
            int flips = int.Parse(NumberofFlips); //convert string to number for loop
            int heads = 0; //counter for heads
            int tails = 0; //counter for tails

            for (int i=0; i< flips; i++) //each flip is a loop
            {
                
                int num = rnd.Next(1,3); //generates random number between 1 and 3
               
                if (num == 1) //generated 1 is heads
                {
                    heads++;
                    Console.WriteLine("heads");
                }
                else
                {
                    tails++;
                    Console.WriteLine("tails");
                }

            }
            if(headsOrTailsGuess[0]=='t'|| headsOrTailsGuess[0] == 'T') //checks first letter of guess, if a t it is tails
            {
                CorrectCount = flips - heads;
            }
            else
            {
                CorrectCount = flips - tails;
            }
           
            float Percentage = CorrectCount * 100 / flips; //calculates percentage

            Console.WriteLine("You guessed correctly " + CorrectCount +" times, which is " + Percentage +"%");
        }
    }
}
