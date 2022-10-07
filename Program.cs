using System.Security.Cryptography;

namespace Piano
{
    internal class Program
    {

        static void makeSound(int octave, int duration = 500)
        {
            int[] fourthOctave = new int[] { 261, 277, 293, 311, 329, 349, 370};        // C, C#, D, Eb, E, F, F#
            int[] fifthOctave = new int[] { 523, 554, 587, 622, 659, 698, 740 };        // C, C#, D, Eb, E, F, F#
            int[] sixthOctave = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480 }; // C, C#, D, Eb, E, F, F#
            
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.Q:
                    if (octave == 4)
                    {
                        Console.Beep(fourthOctave[0], duration);
                    }
                    else if (octave == 5)
                    {
                        Console.Beep(fifthOctave[0], duration);
                    }

                    else if (octave == 6)
                    {
                        Console.Beep(sixthOctave[0], duration);
                    }
                    break;

                case ConsoleKey.W:
                    if (octave == 4)
                    {
                        Console.Beep(fourthOctave[1], duration);
                    }
                    else if (octave == 5)
                    {
                        Console.Beep(fifthOctave[1], duration);
                    }

                    else if (octave == 6)
                    {
                        Console.Beep(sixthOctave[1], duration);
                    }
                    break;

                case ConsoleKey.E:
                    if (octave == 4)
                    {
                        Console.Beep(fourthOctave[2], duration);
                    }
                    else if (octave == 5)
                    {
                        Console.Beep(fifthOctave[2], duration);
                    }

                    else if (octave == 6)
                    {
                        Console.Beep(sixthOctave[2], duration);
                    }
                    break;

                case ConsoleKey.R:
                    if (octave == 4)
                    {
                        Console.Beep(fourthOctave[3], duration);
                    }
                    else if (octave == 5)
                    {
                        Console.Beep(fifthOctave[3], duration);
                    }

                    else if (octave == 6)
                    {
                        Console.Beep(sixthOctave[3], duration);
                    }
                    break;

                case ConsoleKey.T:
                    if (octave == 4)
                    {
                        Console.Beep(fourthOctave[4], duration);
                    }
                    else if (octave == 5)
                    {
                        Console.Beep(fifthOctave[4], duration);
                    }

                    else if (octave == 6)
                    {
                        Console.Beep(sixthOctave[4], duration);
                    }
                    break;

                case ConsoleKey.Y:
                    if (octave == 4)
                    {
                        Console.Beep(fourthOctave[5], duration);
                    }
                    else if (octave == 5)
                    {
                        Console.Beep(fifthOctave[5], duration);
                    }

                    else if (octave == 6)
                    {
                        Console.Beep(sixthOctave[5], duration);
                    }
                    break;

                case ConsoleKey.U:
                    if (octave == 4)
                    {
                        Console.Beep(fourthOctave[6], duration);
                    }
                    else if (octave == 5)
                    {
                        Console.Beep(fifthOctave[6], duration);
                    }

                    else if (octave == 6)
                    {
                        Console.Beep(sixthOctave[6], duration);
                    }
                    break;
            }

        }

        static int switchOctave(int octave)
        {
            if (octave == 4)
            {
                octave = 4;
            }
            if (octave == 5)
            {
                octave = 5;
            }

            if (octave == 6)
            {
                octave = 6;
            }

            return octave;

        }

        static void Main()
        {
            ConsoleKey key;

            int currentOctave = 0;

            do
            {
                key = Console.ReadKey().Key;

                if (key == ConsoleKey.F4)
                {
                    currentOctave = switchOctave(4);
                    Console.WriteLine($"Текущая октава {currentOctave}");

                }
                else if (key == ConsoleKey.F5)
                {
                    currentOctave = switchOctave(5);
                    Console.WriteLine($"Текущая октава {currentOctave}");
                }

                else if (key == ConsoleKey.F6)
                {
                    currentOctave = switchOctave(6);
                    Console.WriteLine($"Текущая октава {currentOctave}");
                }
            
                makeSound(currentOctave);

            } while (key != ConsoleKey.Escape);
        }

    }  
}
