using System;

namespace Lab01AboutMeQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //int score = 0;
            Nachos();
            //if (outcome == true)
            //{
            //    score++;
            //}
            Age();
            //if (numAnswer == 28)
            //{
            //    score++;
            //}
            Games();
            Tricky();
            Beverage();
            Console.WriteLine("Will display score later");
            Console.ReadLine();
            
        }
        //question 1
        static bool Nachos()
        {
            Console.WriteLine("I make the best nachos in the world ('true' or 'false')");

            string answer = Console.ReadLine();
            answer = answer.ToLower();
            bool outcome = false;

            if (answer == "true")
            {
                Console.WriteLine("Truth, I am the Nacho King");
                outcome = true;
            }
            else if (answer == "false")
            {
                Console.WriteLine("You couldn't be more wrong");
            }
            else 
            {
                Console.WriteLine("Does not compute");
            }
            return outcome;
        }

        //question 2
        static int Age()
        {
            Console.WriteLine("How old am I? (numeral)");
            string answer = Console.ReadLine();
            int myAge = 28;
            int numAnswer = Convert.ToInt32(answer);

            if (numAnswer == myAge)
            {
                Console.WriteLine("Are you psychic?!");
            }
            else
            {
                Console.WriteLine("And I thought we were friends...");
            }
            return numAnswer;
        }

        //question 3
        static bool Games()
        {
            Console.WriteLine("Is my favorite game A) Magic The Gathering, B) Magic, or C) MTG?");
            string answer = Console.ReadLine();
            bool answered = false;
            if (answer == "")
            {
                Console.WriteLine("Wanna play some time!?");
                answered = true;
            }
            else
            {
                Console.WriteLine("The freest of free's and you passed it up. For shame");
            }
            return answered;
        }

        //question 4
        static string Tricky()
        {
            Console.WriteLine("Is the answer to this question A) c, B) a, C) d, or D) b?");
            string answer = Console.ReadLine();
            answer = answer.ToLower();

            if (answer == "a")
            {
                Console.WriteLine("I C what you did there.");
                return answer;
            }
            else if (answer == "b")
            {
                Console.WriteLine("A for effort.");
                return answer;

            }
            else if (answer == "c")
            {
                Console.WriteLine("You like to live Dangerously.");
                return answer;

            }
            else if (answer == "d")
            {
                Console.WriteLine("Seriously!? Not this time Buddy.");
                return answer;

            }
            else
            {
                Console.WriteLine("Party pooper. No cake for you.");
                return answer;
            }

        }

        //question 5
        static string Beverage()
        {
            Console.WriteLine("What's my favorite thing to drink; coffee, soda, tea, or whiskey?");
            string answer = Console.ReadLine();
            answer = answer.ToLower();

            if (answer == "coffee")
            {
                Console.WriteLine("Its my lifeblood");
            }
            else if (answer == "soda")
            {
                Console.WriteLine("GROSS. Cut that shit outta my diet years ago");
            }
            else if (answer == "tea")
            {
                Console.WriteLine("Ew. Only touch the stuff when I'm sick");
            }
            else if (answer == "whiskey")
            {
                Console.WriteLine("Sweet, sweet nectar of the gods.");

            }
            else 
            {
                Console.WriteLine("Read simple instructions you toadstool");
            }
            return answer;

        }
    }
}
