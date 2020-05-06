using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_5__6_i_7
{
    class DarkTheme : ITheme
    {
        public string GetFooter(int width)
        {
            return new string('_', width);
        }

        public string GetHeader(int width)
        {
            return new string('_', width);
        }

        public void SetBackgroundColor()
        {
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public void SetFontColor()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }
}
