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
        public string description;
        public string faction;
        public string activity;
    }

    //defining quests
    public class quests
    {
        public string testQuest1(string name, string description, string faction, string activity)
        {
            //action.ShowDialog();
            //action.text = "I have been tasked by the " + faction + ". They want me to " + activity + " the new thing.";
            Program.Form.printToConsole("Testing");

            return "0";
        }
        
    }
}