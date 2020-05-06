using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_5__6_i_7
{
    class Notebook
    {
        private List<Note> notes;
        private ITheme notebookTheme;

        public Notebook() { this.notes = new List<Note>(); }

        public Notebook(ITheme theme)
        {
            this.notes = new List<Note>();
            this.notebookTheme = theme;
            
        }

        public void AddNote(Note note)
        {
            note.Theme = notebookTheme;
            this.notes.Add(note);

        }

        public void ChangeTheme(ITheme theme)
        {
            foreach (Note note in notes)
            {
                note.Theme = theme;
            }
        }

        public void Display()
        {
            foreach (var note in notes)
            {
                note.show();
                Console.WriteLine("\n");
            }
        }

    }
}
