using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_5__6_i_7
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////////////////////////////////////// Zadatak 5
            /*
            DarkTheme dark = new DarkTheme();
            LightTheme light = new LightTheme();

            Note note = new ReminderNote("This is a test of a reminder note", dark);
            Note note2 = new ReminderNote("This is second test", light);
            note.show();
            note2.show();
            */

            ////////////////////////////////////////////////////////////////// Zadatak 6
            /*
            DarkTheme dark = new DarkTheme();
            LightTheme light = new LightTheme();
            GroupNote groupLV1 = new GroupNote("TEAM OFFENCE: ",dark);

            groupLV1.AddMember("Corona");
            groupLV1.AddMember("Covid");
            groupLV1.AddMember("Cough");

            groupLV1.show();

            GroupNote groupLV2 = new GroupNote("TEAM DEFENCE: ",light);

            groupLV2.AddMember("Alemka");
            groupLV2.AddMember("Vili");
            groupLV2.AddMember("Davor");

            groupLV2.show();
            */

            ////////////////////////////////////////////////////////////////// Zadatak 7
            DarkTheme dark = new DarkTheme();
            LightTheme light = new LightTheme();

            Note note = new ReminderNote("This is a test of a reminder note", dark);
            Note note2 = new ReminderNote("This is second test", light);
            
            Notebook notebook = new Notebook(dark);
            notebook.AddNote(note);
            notebook.AddNote(note2);
            notebook.Display();
            
        }
    }
}
