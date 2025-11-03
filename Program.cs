using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SharkGameLoop
{
    internal class Program
    {
        static bool isPlaying = true;

        static int horizontalInput = 0;
        static int verticalInput = 0;

        static int horizontalPos = 0;
        static int verticalPos = 0;

        static int ticksMs = 17;
        static void Main(string[] args)
        {
            while(isPlaying == true)
            {
                ProcessInput();
                Update();
                Draw();

                Thread.Sleep(ticksMs);
            }

            GameOverScreen();
        }

        static void ProcessInput()
        {
            horizontalInput = 0;
            verticalInput = 0;

            if (!Console.KeyAvailable)
            {
                return;
            }

            ConsoleKeyInfo inputKey = Console.ReadKey();

            if (inputKey.Key == ConsoleKey.A) horizontalInput -= 1;

            if (inputKey.Key == ConsoleKey.D) horizontalInput += 1;

            if (inputKey.Key == ConsoleKey.W) verticalInput += 1;

            if (inputKey.Key == ConsoleKey.S) verticalInput -= 1;
        }

        static void Update()
        {
            verticalPos += verticalInput;
            horizontalPos += horizontalInput;
        }

        static void Draw()
        {
            //
        }

        static void GameOverScreen()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Game Over");
        }
    }
}
