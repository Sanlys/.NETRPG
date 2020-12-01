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
            player.level = 1;
            player.xp = 0;
            player.health = 100;
            player.magic = 100;
            player.stamina = 100;
            player.maxHealth = player.health;
            player.maxMagic = player.magic;
            player.maxStamina = player.stamina;
            player.armor = 0;
            player.damage = 0;
            player.l_equipped = Empty;
            player.r_equipped = Empty;
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


                option1.Click += new EventHandler(option1_Click);
                option2.Click += new EventHandler(option2_Click);

                Button inventory = new Button();
                dialog.Controls.Add(inventory);
                inventory.Text = "Inventory";
                inventory.Location = new Point(160, 0);

                dialog.Size = new Size(275, 75);

                inventory.Click += new EventHandler(inventory_Click);

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

                void inventory_Click(object sender, EventArgs e)
                {
                    showInventory();
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
            textBox10.Text = Convert.ToString(player.level);
            textBox9.Text = Convert.ToString(player.xp);
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
            if (player.slot1.name == x.Text)
            {
                player.r_equipped = player.slot1;
                player.damage = player.slot1.damage;
                player.accuracy = player.slot1.accuracy;
                player.staminaCost = player.slot1.stamina;
            } else if (player.slot2.name == x.Text)
            {
                player.r_equipped = player.slot2;
                player.damage = player.slot2.damage;
                player.accuracy = player.slot2.accuracy;
                player.staminaCost = player.slot2.stamina;
            }
            else if (player.slot3.name == x.Text)
            {
                player.r_equipped = player.slot3;
                player.damage = player.slot3.damage;
                player.accuracy = player.slot3.accuracy;
                player.staminaCost = player.slot3.stamina;
            }
            else if (player.slot4.name == x.Text)
            {
                player.r_equipped = player.slot4;
                player.damage = player.slot4.damage;
                player.accuracy = player.slot4.accuracy;
                player.staminaCost = player.slot4.stamina; 
            }
            else if (player.slot5.name == x.Text)
            {
                player.r_equipped = player.slot5;
                player.damage = player.slot5.damage;
                player.accuracy = player.slot5.accuracy;
                player.staminaCost = player.slot5.stamina;
            }
            else if (player.slot6.name == x.Text)
            {
                player.r_equipped = player.slot6;
                player.damage = player.slot6.damage;
                player.accuracy = player.slot6.accuracy;
                player.staminaCost = player.slot6.stamina;
            }
            else if (player.slot7.name == x.Text)
            {
                player.r_equipped = player.slot7;
                player.damage = player.slot7.damage;
                player.accuracy = player.slot7.accuracy;
                player.staminaCost = player.slot7.stamina;
            }
            else if (player.slot8.name == x.Text)
            {
                player.r_equipped = player.slot8;
                player.damage = player.slot8.damage;
                player.accuracy = player.slot8.accuracy;
                player.staminaCost = player.slot8.stamina;
            }

            updateGUI();
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

        private void button2_Click(object sender, EventArgs e)
        {
            questList.testQuest1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(player.stamina >= 15)
            {
                player.health = player.maxHealth;
                player.magic = player.maxMagic;
                player.stamina -= 15;
            }
            
            updateGUI();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            player.health = player.maxHealth;
            player.magic = player.maxMagic;
            player.stamina = player.maxStamina;

            updateGUI();

            timer1.Interval = 10000 * player.level;
            timer1.Tick += timer1_Tick;
            timer1.Start();
            button2.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button2.Enabled = true;
            timer1.Stop();
        }

        public void levelUp()
        {
            if (player.xp >= player.level*100) { player.level += 1; updateGUI(); }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}