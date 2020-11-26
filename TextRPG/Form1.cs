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

            #region UI Setup
            textBox3.Text = Convert.ToString(player.health);
            textBox2.Text = Convert.ToString(player.magic);
            textBox4.Text = Convert.ToString(player.stamina);
            textBox7.Text = Convert.ToString(player.armor);
            textBox6.Text = Convert.ToString(player.damage);
            textBox5.Text = Convert.ToString(player.l_equipped);
            textBox8.Text = Convert.ToString(player.r_equipped);
            textBox12.Text = Convert.ToString(player.gold);
            textBox11.Text = player.quest.name;
            textBox10.Text = Convert.ToString(player.weight);

            #endregion

            #region Starting Quests

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

        public int attackEnemy(int enemyHealth, int damage, int enemyArmor)
        {
            double x = Convert.ToDouble(enemyHealth);
            double y = Convert.ToDouble(damage);
            double z = Convert.ToDouble(enemyArmor);
            x -= y * ((100 - z) / 100);
            return Convert.ToInt32(Math.Round(x));
        }
    }
}