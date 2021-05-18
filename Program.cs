using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new BlackBoxMetters();
            game.Play(new Consol());
            game.Play(new PK());
            Console.ReadKey();
        }
    }
}
