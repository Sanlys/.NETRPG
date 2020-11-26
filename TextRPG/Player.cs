using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class Player
    {
        public int health;
        public int stamina;
        public int magic;

        public int armor;
        public int damage;
        public string l_equipped; //left hand weapon
        public string r_equipped; //right hand weapon
        public string h_equipped; //head armor
        public string n_equipped; //necklace
        public string c_equipped; //chestplate
        public string j_equipped; //Jewelry/ring
        public string p_equipped; //pants/leggings
        public string s_equipped; //shoes/boots

        public int gold;
        public Quest quest;
        public int weight;
    }
}