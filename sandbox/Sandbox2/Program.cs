namespace Sandbox2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Guess Three Dice!");
        // The computer throws three dice,
        Random randomGenerator = new();
        int d1 = randomGenerator.Next(1, 7);
        int d2 = randomGenerator.Next(1, 7);
        int d3 = randomGenerator.Next(1, 7);
        // sorts them in order (smallest to largest),
        if (d2 > d3)
        {
            (d2, d3) = (d3, d2);
        }
        if (d1 > d3)
        {
            (d1, d3) = (d3, d1);
        }
        if (d1 > d2)
        {
            (d1, d2) = (d2, d1);
        }
        // and outputs their sum.
        Console.WriteLine($"Their sum is: {d1 + d2 + d3}.");
        //Console.WriteLine($"They are: {d1} {d2} {d3}"); // Cheat!
        Console.Write("Guess the values of each of the three dice,");
        Console.WriteLine(" from smallest to largest.");

        // Loop:    
        bool playing = true;
        while (playing)
        {
            // Prompt the user to guess the value of each die,    
            // from smallest to largest (non-decreasing).
            Console.Write("First die: ");
            int guess1 = int.Parse(Console.ReadLine());
            Console.Write("Second die: ");
            int guess2 = int.Parse(Console.ReadLine());
            Console.Write("Third die: ");
            int guess3 = int.Parse(Console.ReadLine());

            // If the guesses are out of order, prompt to guess again.
            if (guess1 > guess2 || guess2 > guess3) {
                Console.Write("Those weren't in order from smallest to largest.");
            }

            // If the guesses don't produce the desired sum, prompt to guess again.
            else if (guess1+guess2+guess3 != d1+d2+d3)
            {
                Console.Write($"Those don't add up to {d1+d2+d3}.");
            }

            // If the guesses are incorrect, prompt to guess again.
            else if (guess1 != d1 || guess2 != d2 || guess3 != d3)
            {
                Console.Write("Good guess, but incorrect.");
            }
            else
            {
                // If the guesses are correct, the user wins!
                Console.WriteLine("Success! Thank you for playing.");
                playing=false;
            }

            if (playing)
            {
                Console.WriteLine(" Try again.");
            }
        }
    }
}