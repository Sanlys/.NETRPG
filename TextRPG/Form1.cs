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
        public void printToConsole(string x)
        {
            textBox1.AppendText(x);
        }

        public Form1()
        {
            InitializeComponent();
            Quest testQuest = new Quest();
            quests questList = new quests();
            testQuest.name = "Test Quest";
            testQuest.description = "This quest is just a test";
            testQuest.faction = "The test guild";
            testQuest.activity = "Test";
            string x = questList.testQuest1(testQuest.name, testQuest.description, testQuest.faction, testQuest.activity);
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
    }
}
