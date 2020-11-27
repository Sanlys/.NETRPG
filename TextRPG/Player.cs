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
        public Item l_equipped; //left hand weapon
        public Item r_equipped; //right hand weapon
        public Item h_equipped; //head armor
        public Item n_equipped; //necklace
        public Item c_equipped; //chestplate
        public Item j_equipped; //Jewelry/ring
        public Item p_equipped; //pants/leggings
        public Item s_equipped; //shoes/boots

        public int gold;
        public Quest quest;
        public int weight;

        public Item slot1;
        public Item slot2;
        public Item slot3;
        public Item slot4;
        public Item slot5;
        public Item slot6;
        public Item slot7;
        public Item slot8;
    }
}