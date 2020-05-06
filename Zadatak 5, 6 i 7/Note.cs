using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_5__6_i_7
{
    abstract class Note
    {
        private string message;
        private ITheme theme;

        public Note(string message, ITheme theme)
        {
            this.Message = message;
            this.Theme = theme;
        }

        public string Message { get => message; set => message = value; }
        internal ITheme Theme { get => theme; set => theme = value; }

        protected void ChangeColor()
        {
            this.theme.SetBackgroundColor();
            this.theme.SetFontColor();
        }

        protected string GetFramedMessage()
        {
            int width = this.message.Length;
            return this.theme.GetHeader(width) + "\n" + message + "\n" + this.theme.GetFooter(width);
        }

        public abstract void show();

    }
}
