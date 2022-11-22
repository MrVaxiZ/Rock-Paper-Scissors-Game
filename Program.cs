using System;

namespace Rock_Paper_Scissors
{
    class Program
    {
        public static double PointsC;
        public static double PointsU;
        public static int Computer;
        public static bool YesOrNo;
        static void HereMagicHappens()
        {
            Random random = new Random();
            Console.WriteLine();
            Console.WriteLine("Do you want to play again? Y/N");
            string odp = Console.ReadLine();
            odp = odp.ToLower();

            if (odp == "y" || odp == "n")
            {
                if (odp == "y")
                {
                    YesOrNo = true;
                }
                else if (odp == "n")
                {
                    YesOrNo = false;
                    Console.Clear();
                    Console.WriteLine("Thanks for playing!");
                    Console.WriteLine($"You have {PointsU} points! and I have {PointsC}!");
                    if (PointsC > PointsU)
                    {
                        Console.WriteLine("Computer wins whole game!");
                    }
                    else if (PointsU > PointsC)
                    {
                        Console.WriteLine("User wins whole game!");
                    }
                    else
                    {
                        Console.WriteLine("We have a draw!");
                    }
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Unrecognized command!");
                Console.WriteLine();
                HereMagicHappens();
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome in rock paper scissors game!");
            YesOrNo = true;

            while (YesOrNo)
            {
                Console.WriteLine("Say rock/paper/scissors to play!");
                Console.WriteLine();
                string userInput = Console.ReadLine();
                userInput.ToLower();
                if (userInput == "rock" || userInput == "paper" || userInput == "scissors")
                {
                    Random random = new Random();
                    Computer = random.Next(1, 3);

                    if (userInput == "rock")
                    {
                        if (Computer == 1)
                        {
                            Console.WriteLine("Rock!");
                            Console.WriteLine($"We both have a {userInput} so we have a draw!");
                            PointsC += 0.5;
                            PointsU += 0.5;
                            HereMagicHappens();

                        }
                        else if (Computer == 2)
                        {
                            Console.WriteLine("Paper!");
                            Console.WriteLine("You Lose!");
                            PointsC += 1;
                            HereMagicHappens();
                        }
                        else if (Computer == 3)
                        {
                            Console.WriteLine("Scissors!");
                            Console.WriteLine("You win!");
                            PointsU += 1;
                            HereMagicHappens();
                        }
                    }
                    else if (userInput == "paper")
                    {
                        if (Computer == 1)
                        {
                            Console.WriteLine("Rock!");
                            Console.WriteLine("You win!");
                            PointsU += 1;
                            HereMagicHappens();
                        }
                        else if (Computer == 2)
                        {
                            Console.WriteLine("Paper!");
                            Console.WriteLine($"We both have a {userInput} so we have a draw!");
                            PointsC += 0.5;
                            PointsU += 0.5;
                            HereMagicHappens();
                        }
                        else if (Computer == 3)
                        {
                            Console.WriteLine("Scissors!");
                            Console.WriteLine("You Lose!");
                            PointsC += 1;
                            HereMagicHappens();
                        }
                    }
                    else if (userInput == "scissors")
                    {
                        if (Computer == 1)
                        {
                            Console.WriteLine("Rock!");
                            Console.WriteLine("You Lose!");
                            PointsC += 1;
                            HereMagicHappens();
                        }
                        else if (Computer == 2)
                        {
                            Console.WriteLine("Paper!");
                            Console.WriteLine("You win!");
                            PointsU += 1;
                            HereMagicHappens();
                        }
                        else if (Computer == 3)
                        {
                            Console.WriteLine("Scissors!");
                            Console.WriteLine($"We both have a {userInput} so we have a draw!");
                            PointsC += 0.5;
                            PointsU += 0.5;
                            HereMagicHappens();
                        }
                    }

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Unrecognized command!");
                    Console.WriteLine();
                }
            }
        }
    }
}
