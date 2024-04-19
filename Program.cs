namespace ConsoleApp1
{
    internal class Program
    {
        static int HasExit(int startI, int startJ, int[,] l)
        {
            int exits = 0;

            if (l[startI, startJ] == 0)
            {
                exits++;
            }

            l[startI, startJ] = 2;

            if (startI > 0 && l[startI - 1, startJ] != 2)
            {
                exits += HasExit(startI - 1, startJ, l);
            }
            if (startI < l.GetLength(0) - 1 && l[startI + 1, startJ] != 2)
            {
                exits += HasExit(startI + 1, startJ, l);
            }
            if (startJ > 0 && l[startI, startJ - 1] != 2)
            {
                exits += HasExit(startI, startJ - 1, l);
            }
            if (startJ < l.GetLength(1) - 1 && l[startI, startJ + 1] != 2)
            {
                exits += HasExit(startI, startJ + 1, l);
            }
            return exits;
        }

        static void Main(string[] args)
        {
            int[,] labirynth1 = new int[,]
            {
            {1, 1, 1, 1, 1, 1, 1 },
            {1, 0, 0, 0, 0, 0, 1 },
            {1, 0, 1, 1, 1, 0, 1 },
            {0, 0, 0, 0, 1, 0, 0 },
            {1, 1, 0, 0, 1, 1, 1 },
            {1, 1, 1, 0, 1, 1, 1 },
            {1, 1, 1, 0, 1, 1, 1 }
            };

            int exits = HasExit(0, 0, labirynth1);

            Console.WriteLine($"Всего: " + exits + " выходов.");
        }
    }
}
