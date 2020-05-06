using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_5__6_i_7
{
    class ReminderNote : Note
    {
        public ReminderNote(string message, ITheme theme) : base(message, theme) { }

        public override void show()
        {
            this.ChangeColor();
            Console.WriteLine("REMINDER: ");
            string framedMessage = this.GetFramedMessage();

            Console.WriteLine(framedMessage);
            Console.ResetColor();
        }

    }
}
