using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex
{
    enum Attack {SP_Attack,SP_Defense,Attack,Defense}
    struct Pokemon
        {
        string Name;
        string Type;
        int level;
        Attack AttackType;
        int HP;
        int EXP;
        bool Legendary;
        bool Shiny;
        int Generation;
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists ("Pokemon.txt"))
            { 
            StreamReader inFile = new StreamReader("Pokemon.txt");
            string s = inFile.ReadToEnd();
             inFile.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DebugBox.Clear();
            DebugBox.Text += NameBox.Text;
            DebugBox.Text += "|";
            DebugBox.Text += TypeBox.Text;
            DebugBox.Text += "|";
            DebugBox.Text += LevelBox.Value;
            DebugBox.Text += "|";
            DebugBox.Text += HPBox.Value;
            DebugBox.Text += "|";
            DebugBox.Text +=EXPBox.Value;
            DebugBox.Text += "|";
            DebugBox.Text += GenerationBox.Value;
            DebugBox.Text += "|";
            DebugBox.Text += AttackBox.Text;
            DebugBox.Text += "|";
            DebugBox.Text += LegendaryBox.Text;
            DebugBox.Text += "|";
            DebugBox.Text += ShinyBox.Text;
            StreamWriter outfile = new StreamWriter("Pokemon.txt");
            outfile.WriteLine(DebugBox.Text);
            outfile.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
