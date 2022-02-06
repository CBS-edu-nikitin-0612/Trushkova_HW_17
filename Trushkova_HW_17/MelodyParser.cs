namespace Task2
{
    internal static class MelodyParser
    {
        //Парсинг строки для считывания нот и записи их в массив
        //на основе определения положения считываемого числа на гамме нот
        public static Note[] ParseMelody(string melody, int length, int oktava)
        {
            char[] charNotes = melody.ToCharArray();
            Note[] notes = new Note[charNotes.Length];
            NoteGamma gamma = new NoteGamma(length, oktava);
            for (int i = 0; i < charNotes.Length; i++)
            {
                if (charNotes[i] != ' ')
                {
                    int numOfNotes = Convert.ToInt32(charNotes[i]) % 7;
                    notes[i] = gamma[numOfNotes];
                }
                else
                {
                    notes[i] = Note.Pause(0, length, true);
                }
            }
            return notes;
        }
    }
}
