namespace pw3_piano
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Октавы с F1 по F5");
            Console.WriteLine("Клавиша A - нота C");
            Console.WriteLine("Клавиша W - нота C#");
            Console.WriteLine("Клавиша S - нота D");
            Console.WriteLine("Клавиша E - нота Eb");
            Console.WriteLine("Клавиша D - нота E");
            Console.WriteLine("Клавиша F - нота F");
            Console.WriteLine("Клавиша T - нота F#");
            Console.WriteLine("Клавиша G - нота G");
            Console.WriteLine("Клавиша Y - нота G#");
            Console.WriteLine("Клавиша H - нота А");
            Console.WriteLine("Клавиша U - нота Bb");
            Console.WriteLine("Клавиша J - нота B");
            Console.WriteLine("F6 - выход из программы");

            ConsoleKeyInfo key;
            int[] Note = new int[12];

            do
            {
                key = Console.ReadKey();

                if ((key.Key == ConsoleKey.F1) ||
                    (key.Key == ConsoleKey.F2) ||
                    (key.Key == ConsoleKey.F3) ||
                    (key.Key == ConsoleKey.F4) ||
                    (key.Key == ConsoleKey.F5))
                    Note = Octaves(key);

                else if ((key.Key == ConsoleKey.A) ||
                    (key.Key == ConsoleKey.W) ||
                    (key.Key == ConsoleKey.S) ||
                    (key.Key == ConsoleKey.E) ||
                    (key.Key == ConsoleKey.D) ||
                    (key.Key == ConsoleKey.F) ||
                    (key.Key == ConsoleKey.T) ||
                    (key.Key == ConsoleKey.G) ||
                    (key.Key == ConsoleKey.Y) ||
                    (key.Key == ConsoleKey.H) ||
                    (key.Key == ConsoleKey.U) ||
                    (key.Key == ConsoleKey.J))
                    Note_Sound(key, Note);
                 else
                    Console.Clear();
            }
            while (key.Key != ConsoleKey.F6);
        }

        static void Note_Sound(ConsoleKeyInfo Sound, int[] Note)
        {
                  
            switch (Sound.Key)
            {
                case ConsoleKey.A:
                    Console.Beep(Note[0], 300);
                    Console.Clear();
                    break;
                case ConsoleKey.W:
                    Console.Beep(Note[1], 300);
                    Console.Clear();
                    break;
                case ConsoleKey.S:
                    Console.Beep(Note[2], 300);
                    Console.Clear();
                    break;
                case ConsoleKey.E:
                     Console.Beep(Note[3], 300);
                     Console.Clear();
                    break;
                case ConsoleKey.D:
                     Console.Beep(Note[4], 300);
                     Console.Clear();
                    break;
                case ConsoleKey.F:
                     Console.Beep(Note[5], 300);
                     Console.Clear();
                    break;
                case ConsoleKey.T:
                     Console.Beep(Note[6], 300);
                     Console.Clear();
                    break;
                case ConsoleKey.G:
                     Console.Beep(Note[7], 300);
                     Console.Clear();
                    break;
                case ConsoleKey.Y:
                     Console.Beep(Note[8], 300);
                     Console.Clear();
                    break;
                case ConsoleKey.H:
                     Console.Beep(Note[9], 300);
                     Console.Clear();
                    break;
                case ConsoleKey.U:
                     Console.Beep(Note[10], 300);
                     Console.Clear();
                    break;
                case ConsoleKey.J:
                     Console.Beep(Note[11], 300);
                     Console.Clear();
                    break;
            }
        }

        static int[] Octaves(ConsoleKeyInfo Octave)
        {
            int[] Fifth_Octave = new int[12] { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 593 };
            int[] Sixth_Octave = new int[12] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
            int[] Seventh_Octave = new int[12] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
            int[] Eighth_Octave = new int[12] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
            int[] Ninth_Octave = new int[12] { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 };

            switch (Octave.Key)
            {
                case ConsoleKey.F1:
                    Console.WriteLine("Пятая октава");
                    return Fifth_Octave;
                case ConsoleKey.F2:
                    Console.WriteLine("Шестая октава");
                    return Sixth_Octave;
                case ConsoleKey.F3:
                    Console.WriteLine("Седьмая октава");
                    return Seventh_Octave;
                case ConsoleKey.F4:
                    Console.WriteLine("Восьмая октава");
                    return Eighth_Octave;
                case ConsoleKey.F5:
                    Console.WriteLine("Девятая октава");
                    return Ninth_Octave;
                default:
                    Console.WriteLine("Первая октава");
                    return Fifth_Octave;
            }
        }   
    }
}