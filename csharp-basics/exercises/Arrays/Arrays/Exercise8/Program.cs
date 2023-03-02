namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "leviathan", "car", "telephone", "autobus" };
            Random rnd = new Random();
            string randomWord = words[rnd.Next(0,words.Length)];
            string guessedWord = randomWordStripes(randomWord);
            int maxMisses = 5;
            string missedLetters = "";
            int missedGuesses = 0;
            char guess = ' ';
            string askAgain = "";
            while (guessedWord != randomWord && maxMisses >= missedGuesses)
            {
                Console.WriteLine();
                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                Console.WriteLine("Word : "+ guessedWord);
                Console.WriteLine("Misses : "+ missedLetters);
                Console.Write("Guess : ");
                guess = Console.ReadKey().KeyChar;
                if (!randomWord.Contains(guess) && !missedLetters.Contains(guess))
                {
                    missedLetters = missedLetters.Insert(missedGuesses, guess.ToString());
                    missedGuesses++;
                }
                else if (randomWord.Contains(guess))
                { 
                    for (int i = 0; i < randomWord.Length; i++)
                    {
                        if (randomWord[i] == guess)
                        {
                            guessedWord = guessedWord.Substring(0, i) + guess + guessedWord.Substring(i + 1);
                        }
                    }
                }
                if (guessedWord == randomWord)
                {
                    Console.WriteLine();
                    Console.WriteLine("YOU GOT IT!");
                    Console.WriteLine("Play `again` or `quit`?");
                    askAgain = Console.ReadLine();
                }
            }
            if (maxMisses <= missedGuesses)
            {
                Console.WriteLine();
                Console.WriteLine("You lost! Your random word was : " + randomWord);
            }
            if (askAgain == "again")
            {
                Main(args);
            }
        }
        public static string randomWordStripes(string word)
        {
            string result = "";
            for(int i = 0; i < word.Length; i++)
            {
                result += "_";
            }
            return result;
        }
    }
}