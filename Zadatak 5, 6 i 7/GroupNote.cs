using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_5__6_i_7
{
    class GroupNote : Note
    {
        private List<string> members;

        public GroupNote(string message, ITheme theme): base(message,theme)
        {
            members = new List<string>();
            members.Add(message);

        }

        public void AddMember(string member)
        {
            members.Add(member);
        }

        public void RemoveMember(string member)
        {
            members.Remove(member);
        }


        public override void show()
        {
            this.ChangeColor();

            foreach (var member in members)
            {
                string framedMessage = this.GetFramedMessage();
                Console.WriteLine(member);

            }
            Console.ResetColor();
        }

    }
}
