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
            public string objective;
        }

        //defining quests
        public class quests
        {
            public void testQuest1()
            {  
                Program._Form.printToConsole("I have encountered an enemy.");
                int enemyHealth = 100;
                while (enemyHealth >= 0 || Program._Form.player.health >= 0)
                {
                    switch (Program._Form.readFromConsole())
                    {
                        case "1":
                            enemyHealth = Program._Form.attackEnemy(enemyHealth, Program._Form.player.damage, 20);
                            break;
                        case "2":
                            if (Program._Form.player.magic >= 15)
                            {
                                Program._Form.player.health += 20;
                                Program._Form.player.magic -= 15;
                            }
                            break;
                        default:
                            break;
                    }
                    Program._Form.player.health -= 10;
                    Program._Form.updateGUI();
                    Program._Form.printToConsole("Enemy Health: " + enemyHealth);
                    if (Program._Form.player.health <= 0)
                    {
                        Program._Form.printToConsole("You lost!");
                        break;
                    }
                    if (enemyHealth <= 0 && Program._Form.player.health > 0)
                    {
                        Program._Form.printToConsole("You won!");
                        Program._Form.player.xp += 15;
                        Program._Form.levelUp();
                        break;
                    }
                }
            }
        }
}