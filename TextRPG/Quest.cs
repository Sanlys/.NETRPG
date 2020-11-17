using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class Quest
    {
        public string name;
        public string faction;
        public int stages;
        public string message1;

        public string stage()
        {
            return message1;
        }
        public string Win()
        {
            return ("You won");
        }
    }
}
