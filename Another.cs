using System;
namespace DotNet
{
    class WordFunctions
    {
        public static string GetReply()
        {
            Console.WriteLine("What's your name?");
            string input = Console.ReadLine();
            return "Hello, " + input + " how are you?";
        }
    }

}