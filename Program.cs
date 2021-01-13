using System;
using System.Text.RegularExpressions;
using System.Threading;

namespace Ozow.Assessment
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            #region An exercise in sorting
            Console.WriteLine("*******************  An exercise in sorting *******************");
            Console.WriteLine();
            Console.WriteLine("Enter any text to sort by list of letters: ");
            var inputString = Console.ReadLine();
            Console.WriteLine();
            var alphabaticOrderString = AlphabaticOrder(inputString);
            Console.WriteLine($"Output: { alphabaticOrderString } ");
            Console.WriteLine();
            #endregion

            #region Conway’s Game of Life
            Console.WriteLine("*******************  Conway’s Game of Life *******************");
            Console.WriteLine();
            Console.WriteLine("Enter Board Heigh(Integer)");

            var height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Board Width(Integer)");

            var width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Board Number Of Generations");

            var maxRuns = Convert.ToUInt32(Console.ReadLine());

            Console.Clear();

            GameOfLifeBoard(height, width, maxRuns);

            #endregion
        }

        public static void GameOfLifeBoard(int height, int width, uint maxRuns)
        {
            int runs = 0;
            GOfLife gLife = new GOfLife(height, width);

            while (runs++ < maxRuns)
            {
                gLife.DrawAndGrow();

                Thread.Sleep(1000);
            }
        }

        public static string AlphabaticOrder(string inputString)
        {
            inputString = Regex.Replace(inputString, @"[^0-9a-zA-Z]+", "").ToLower();

            char[] charArray = inputString.ToCharArray();

            Array.Sort(charArray);

            return String.Join("", charArray); ;
        }
    }
}
