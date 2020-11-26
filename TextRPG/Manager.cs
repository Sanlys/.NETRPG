using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class Manager
    {
        public class playerStats
        {
        Player player = new Player();
        player.health = 100;
        player.stamina = 100;
        player.magic = 100;
        player.armor = 0;
        player.damage = 10;
        player.l_equipped = "Empty";
        player.r_equipped = "Empty";
        player.h_equipped = "Empty";
        player.n_equipped = "Empty";
        player.c_equipped = "Empty";
        player.j_equipped = "Empty";
        player.p_equipped = "Empty";
        player.s_equipped = "Empty";
        player.gold = 0;
        player.quest = testQuest;
        player.weight = 0;
        }
        #region questSetup
        Quest testQuest = new Quest();
        testQuest.description = "Kill kill kill kill kill kill";
        testQuest.faction = "assasin guild";
        testQuest.activity = "kill";
        testQuest.objective = "enemy";
        testQuest.name = "I've been assigned to " + testQuest.activity + " an " + testQuest.objective + ".";

        quests questList = new quests();
        #endregion
    }
}
