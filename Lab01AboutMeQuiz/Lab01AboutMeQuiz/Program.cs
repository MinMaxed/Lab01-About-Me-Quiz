using System;

namespace Lab01AboutMeQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            //set up
            int score = 0;
            Console.WriteLine("Greetings. Would you like to play a game?");
            Console.WriteLine("Here's 5 questions to see how well you know me");
            Console.WriteLine("Press any key to begin");
            Console.ReadLine();

            //executing questions & tallying score
            bool nachosAnswer = Nachos();
            if (nachosAnswer == true)
            {
                score++;
            }

            int ageAnswer = Age();
            if (ageAnswer == 28)
            {
                score++;
            }

            bool gamesAnswer = Games();
            if (gamesAnswer == true)
            {
                score++;
            }

            bool trickyAnswer = Tricky();
            if (trickyAnswer == true)
            {
                score++;
            }

            string beverageAnswer = Beverage();
            if (beverageAnswer == "coffee" || beverageAnswer == "whiskey")
            {
                score++;
            }

            //results
            Console.WriteLine($"You got {score} total points!");
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
                Console.WriteLine("The freest of free's and you passed it up. For shame");
            }
            else
            {
                Console.WriteLine("Wanna play some time!?");
                answered = true;
            }
            return answered;
        }

        //question 4
        static bool Tricky()
        {
            Console.WriteLine("Is the answer to this question A) c, B) a, C) d, or D) b?");
            string answer = Console.ReadLine();
            answer = answer.ToLower();
            bool answered = false;

            if (answer == "a")
            {
                answered = true;
                Console.WriteLine("I C what you did there.");
            }
            else if (answer == "b")
            {
                answered = true;
                Console.WriteLine("A for effort.");

            }
            else if (answer == "c")
            {
                answered = true;
                Console.WriteLine("You like to live Dangerously.");

            }
            else if (answer == "d")
            {
                answered = true;
                Console.WriteLine("Seriously!? Not this time Buddy.");

            }
            else
            {
                Console.WriteLine("Party pooper. No cake for you.");
            }
                return answered;

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
