namespace Task2
{
    internal static class Player
    {
        //Воспроизводение массива нот с помощью Beep
        public static void Play(Note[] notes)
        {
            for (int i = 0; i < notes.Length; i++)
            {
                if (!notes[i].IsPause)
                    Console.Beep(notes[i].Frequency, notes[i].Length);
                else
                    Thread.Sleep(notes[i].Length);
            }
        }
    }
}
