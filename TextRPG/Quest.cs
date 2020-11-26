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
            public string testQuest1(string name, string description, string faction, string activity, string objective)
            {
                Program._Form.printToConsole("I have been tasked by the " + faction + ". They want me to " + activity + " a " + objective + ".");
                Program._Form.printToConsole("I have encountered an enemy. I think I can take it on.");
                int enemyHealth = 100;
                int playerHealth = 100;
                while (enemyHealth >= 0 || playerHealth >= 0)
                {
                    switch (Program._Form.readFromConsole())
                    {
                        case "1":
                            enemyHealth = Program._Form.attackEnemy(enemyHealth, 100, 20);
                            break;
                        case "2":
                            playerHealth += 10;
                            break;
                        default:
                            break;
                    }

                    playerHealth -= 5;
                    Program._Form.printToConsole("Player Health: " + playerHealth);
                    Program._Form.textBox3.Text = Convert.ToString(playerHealth);
                    Program._Form.printToConsole("Enemy Health: " + enemyHealth);
                    if (enemyHealth <= 0 && playerHealth > 0)
                    {
                        Program._Form.printToConsole("You won!");
                        break;
                    }
                }
                return "0";
            }

        }
}