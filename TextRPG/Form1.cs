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

namespace TextRPG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Program._Form = this;
            Program._Form.Show();

            #region Items
            #region Weapons
            #region Steel Sword
            S_sword.name = "Steel Sword";
            S_sword.type = "Sword";
            S_sword.damage = 30;
            S_sword.weight = 5;
            S_sword.stamina = 10;
            S_sword.accuracy = 100;
            #endregion
            #endregion
            #region Misc
            Empty.name = "Empty";
            Empty.value = 0;
            Empty.weight = 0;
            #endregion
            #endregion

            #region playerStats
            player.health = 100;
            player.magic = 100;
            player.stamina = 100;
            player.armor = 0;
            player.damage = 10;
            player.l_equipped = Empty;
            player.r_equipped = Empty;
            //Program._Form.player.quest.name = "Yo";
            player.gold = 0;
            
            player.slot1 = S_sword;
            player.slot2 = Empty;
            player.slot3 = Empty;
            player.slot4 = Empty;
            player.slot5 = Empty;
            player.slot6 = Empty;
            player.slot7 = Empty;
            player.slot8 = Empty;


            #endregion

            #region UI Setup
            updateGUI();
            #endregion
            
            #region Starting Quests
            //questList.testQuest1(testQuest.name, testQuest.description, testQuest.faction, testQuest.activity, testQuest.objective);
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
            return value;
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
            showInventory();
        }

        public int attackEnemy(int enemyHealth, int damage, int enemyArmor)
        {
            double x = Convert.ToDouble(enemyHealth);
            double y = Convert.ToDouble(damage);
            double z = Convert.ToDouble(enemyArmor);
            x -= y * ((100 - z) / 100);
            return Convert.ToInt32(Math.Round(x));
        }

        public void updateGUI()
        {
            textBox3.Text = Convert.ToString(player.health);
            textBox2.Text = Convert.ToString(player.magic);
            textBox4.Text = Convert.ToString(player.stamina);
            textBox7.Text = Convert.ToString(player.armor);
            textBox6.Text = Convert.ToString(player.damage);
            textBox5.Text = Convert.ToString(player.l_equipped.name);
            textBox8.Text = Convert.ToString(player.r_equipped.name);
            textBox12.Text = Convert.ToString(player.gold);
            //textBox11.Text = player.quest.name;
            textBox10.Text = Convert.ToString(player.weight);
        }

        public void showInventory()
        {
            Inventory inventory = new Inventory();
            inventory.radioButton2.Text = player.slot1.name;
            inventory.radioButton1.Text = player.slot2.name;
            inventory.radioButton3.Text = player.slot3.name;
            inventory.radioButton4.Text = player.slot4.name;
            inventory.radioButton7.Text = player.slot5.name;
            inventory.radioButton8.Text = player.slot6.name;
            inventory.radioButton6.Text = player.slot7.name;
            inventory.radioButton5.Text = player.slot8.name;
            inventory.ShowDialog();
        }

        public void giveItem(int slot)
        {

        }

        public void equipItem(RadioButton x)
        {
            if(player.slot1.name == x.Text)
            {
                player.r_equipped = player.slot1;
                updateGUI();
            }

            //Check through all slots which text matches the radiobutton
            //i.e. if(radiobutton2.text = x) equip(radiobutton2)
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}