using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace TextRPG
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Program._Form = this;
            Program._Form.Show();

            #region player stats
            Player player = new Player();
            player.health = 100;
            player.stamina = 100;
            player.magic = 100;
            player.armor = 0;
            player.damage = 1;
            player.l_equipped = "";
            player.r_equipped = "";
            player.h_equipped = "";
            player.n_equipped = "";
            player.c_equipped = "";
            player.j_equipped = "";
            player.p_equipped = "";
            player.s_equipped = "";
            player.gold = 0;
            player.quest = "";
            player.weight = 0;
            #endregion

            #region questSetup
            Quest testQuest = new Quest();
            quests questList = new quests();
            #endregion

            #region Quests
            testQuest.name = testQuest.activity + " an " + testQuest.objective + ".";
            testQuest.description = "Kill kill kill kill kill kill";
            testQuest.faction = "assasin guild";
            testQuest.activity = "kill";
            testQuest.objective = "enemy";
            string x = questList.testQuest1(testQuest.name, testQuest.description, testQuest.faction, testQuest.activity, testQuest.objective);
            #endregion

        }

        public void printToConsole(string x)
        {
            textBox1.AppendText(x);
            textBox1.AppendText(Environment.NewLine);
        }

        public string readFromConsole() //Possibly add feature to customize dialog box later
        {
            string value = "";
            using (Form dialog = new Form())
            {
                dialog.StartPosition = FormStartPosition.Manual;
                dialog.Location = new Point(50, 50);
                dialog.Text = "Input";
                Button option1 = new Button();
                dialog.Controls.Add(option1);
                option1.Text = "Attack";
                Button option2 = new Button();
                dialog.Controls.Add(option2);
                option2.Text = "Heal";
                option2.Location = new Point(80, 0);
                dialog.Size = new Size(250, 75);
                option1.Click += new EventHandler(option1_Click);
                option2.Click += new EventHandler(option2_Click);
                void option1_Click(object sender, EventArgs e)
                {
                    value = "1";
                    dialog.Close();
                }
                void option2_Click(object sender, EventArgs e)
                {
                    value = "2";
                    dialog.Close();
                }
                dialog.ShowDialog();
            }
            string x = value;
            return x;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.Name, textBox1.Font.Size + 1, textBox1.Font.Style);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.Name, textBox1.Font.Size - 1, textBox1.Font.Style);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.ShowDialog();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
