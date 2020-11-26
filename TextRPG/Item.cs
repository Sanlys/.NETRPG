using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class Item
    {
            public string name; //Name showed on GUI
            public string type; //Sword, Axe, Bow ETC
            public int damage; //Raw damage 
            public int weight; //Weight, only affects carry weight
            //public int attackSpeed; //How many turns it takes to use
            public int stamina;
            //public int stun; //How many turns to stun for
            //public int bleed; //How much damage per turn
            //public int bleedTime; //How many turns to bleed for
            public int accuracy; //In percentage
            public int value;
    }
}
