using System;

namespace LoopChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Imagine you are a developer and get a job in which you need to create a program for a teacher. 
             * He needs a program written in c# that calculates the average score of his students. 
             * So he wants to be able to enter each score individually and then get the final average score once he enters -1.
            So the tool should check if the entry is a number and should add that to the sum.
            Finally once he is done entering scores, the program should write onto the console what the average score is.
            The numbers entered should only be between 0 and 20.
            Make sure the program doesn't crash if the teacher enters an incorrect value.
            Test your program thoroughly.*/

            string input = "0";
            int count = 0;
            int total = 0;
            int currentNum = 0;

            while(input != "-1")
            {
                Console.WriteLine("Last number was {0}", currentNum);
                Console.WriteLine("Please enter the next score: ");
                Console.WriteLine("Current amount of entries: {0}", count);
                Console.WriteLine("Please enter -1 once you are ready to calculate the average");

                input = Console.ReadLine();
                if(input == "-1")
                {
                    Console.WriteLine("----------------------------------");
                    //calculate average
                    double average = (double)total / (double)count;
                    Console.WriteLine("The average of all scores is {0}", average);
                }
                if (int.TryParse(input, out currentNum) && currentNum > 0 && currentNum < 21)
                {
                    total += currentNum;
                    count++;
                }
                else
                {
                    if (!(input.Equals("-1")))
                    {
                        Console.WriteLine("Please enter a value between 1 and 20.");
                    }
                    continue;
                }
            }

        }
    }
}
