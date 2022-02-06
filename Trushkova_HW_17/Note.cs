namespace Task2
{
    internal class Note
    {
        private int _frequency;
        private int _length;
        private bool _isPause;
        
        public Note (int length, bool isPause)
        {
            _length = length;
            _isPause = isPause;    
        }

        public Note (int frequency, int length, bool isPause) : this(length, isPause)
        {
            _frequency = frequency;
        }

        public int Frequency => _frequency; 
        public int Length => _length; 
        public bool IsPause => _isPause;

        #region Фабричные методы для создания нот до, ре, ми, фа, соль, ля, си и паузы
        public static Note Pause(int frequency, int length, bool isPause)
        {
            return new Note(frequency, length, isPause);
        }

        public static Note NoteDo(int oktava, int length)
        {
            int frequency = ((int)NoteFrequency.DO) * oktava;
            return new Note(frequency, length, false);
        }

        public static Note NoteRe(int oktava, int length)
        {
            int frequency = ((int)NoteFrequency.RE) * oktava;
            return new Note(frequency, length, false);
        }

        public static Note NoteMi(int oktava, int length)
        {
            int frequency = ((int)NoteFrequency.MI) * oktava;
            return new Note(frequency, length, false);
        }

        public static Note NoteFa(int oktava, int length)
        {
            int frequency = ((int)NoteFrequency.FA) * oktava;
            return new Note(frequency, length, false);
        }

        public static Note NoteSol(int oktava, int length)
        {
            int frequency = ((int)NoteFrequency.SOL) * oktava;
            return new Note(frequency, length, false);
        }

        public static Note NoteLya(int oktava, int length)
        {
            int frequency = ((int)NoteFrequency.LYA) * oktava;
            return new Note(frequency, length, false);
        }

        public static Note NoteSi(int oktava, int length)
        {
            int frequency = ((int)NoteFrequency.SI) * oktava;
            return new Note(frequency, length, false);
        }
        #endregion
    }
}
