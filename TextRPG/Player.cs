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

        public int maxHealth;
        public int maxStamina;
        public int maxMagic;

        public int xp;
        public int level;

        public Item l_equipped; //left hand weapon
        public Item r_equipped; //right hand weapon
        public Item h_equipped; //head armor
        public Item n_equipped; //necklace
        public Item c_equipped; //chestplate
        public Item j_equipped; //Jewelry/ring
        public Item p_equipped; //pants/leggings
        public Item s_equipped; //shoes/boots

        public int gold;
        public int weight;

        public Item slot1;
        public Item slot2;
        public Item slot3;
        public Item slot4;
        public Item slot5;
        public Item slot6;
        public Item slot7;
        public Item slot8;

        //Weapon stats
        public string ItemType; //Sword, Axe, Bow ETC
        public int damage; //Raw damage 
        //public int attackSpeed; //How many turns it takes to use
        public int staminaCost;
        //public int stun; //How many turns to stun for
        //public int bleed; //How much damage per turn
        //public int bleedTime; //How many turns to bleed for
        public int accuracy; //In percentage
        public int armor;
    }
}