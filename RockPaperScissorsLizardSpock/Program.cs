using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number of attempts: ");
            int attempts = 1;
            try
            {
                attempts = Convert.ToInt32(Console.ReadLine());
                if (attempts <= 0) { throw new LessOrEqualsToZeroException(); }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                attempts = 1;
            }

            for (int i = 0; i < attempts; i++)
            {
                Console.WriteLine();

                Move firstPlayerMove = new Move().DoMove();
                Move secondPlayerMove = new Move().DoMove();

                if (firstPlayerMove > secondPlayerMove)
                {
                    Console.WriteLine("First player win!");
                }
                else if (firstPlayerMove == secondPlayerMove)
                {
                    Console.WriteLine("Draw!");
                }
                else
                {
                    Console.WriteLine("Second player win!");
                }

                Console.WriteLine(firstPlayerMove.ToString() + " vs " + secondPlayerMove.ToString());
            }

            Console.ReadKey();
        }
    }
}
