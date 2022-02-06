namespace Task2
{
    internal class NoteGamma
    {
        private Note[] gamma;

        //Создание гаммы нот
        public NoteGamma(int length, int oktava)
        {           
            gamma = new Note[7] {
                Note.NoteSi(oktava, length),
                Note.NoteDo(oktava, length),
                Note.NoteRe(oktava, length),
                Note.NoteMi(oktava, length),
                Note.NoteFa(oktava, length),
                Note.NoteSol(oktava, length),
                Note.NoteLya(oktava, length)                
            };
        }

        public Note this[int index]
        {
            get { return gamma[index]; }
            set { gamma[index] = value; }
        }

    }
}
