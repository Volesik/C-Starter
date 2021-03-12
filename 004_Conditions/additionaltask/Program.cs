using System;

namespace additionaltask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Viktor translate know this words -> погода/дождь/снег/солнце/зима/весна/лето/осень/температура/холодно");
            Console.Write("Enter a value for translate > ");
            string userWord = Console.ReadLine().ToLower();

            string translatedWord = userWord switch
            {
                "погода" => $"{userWord} - weather",
                "дождь" => $"{userWord} - rain",
                "снег" => $"{userWord} - snow",
                "солнце" => $"{userWord} - sunny",
                "зима" => $"{userWord} - winter",
                "весна" => $"{userWord} - spring",
                "лето" => $"{userWord} - summer",
                "осень" => $"{userWord} - autumn",
                "температура" => $"{userWord} - temperature",
                "холодно" => $"{userWord} - cold",
                _ => $"Have not '{userWord}' in database yet."
            };

            Console.WriteLine(translatedWord);

            Console.ReadKey();
        }
    }
}
