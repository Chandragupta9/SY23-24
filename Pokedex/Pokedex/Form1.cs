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
        public string Name;
        public string Type;
        public int level;
        public Attack AttackType;
        public int HP;
        public int EXP;
        public bool Legendary;
        public bool Shiny;
        public int Generation;
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
                Pokemon p = ReadPokemon(s);
                ShowPokemon(p);
             inFile.Close();
            }
        }
        private Pokemon ReadPokemon(string s)
        {
            Pokemon p=new Pokemon();
            string[] fields = s.Split('|'); 
            p.Name=fields[0];
            p.Type=fields[1];
            p.level = int.Parse(fields[2]);
            p.AttackType =(Attack)Enum.Parse(typeof(Attack), fields[3]);
            p.HP = int.Parse(fields[4]);
            p.EXP = int.Parse(fields[5]);
            if (fields[6] == "True")
                p.Legendary = true;
            else
            p.Legendary = false;
            if (fields[7] == "True")
                p.Shiny = true;
            else
                p.Shiny=false;
            p.Generation = int.Parse(fields[8]);
            return p;
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

        private void ShowPokemon(Pokemon P)
        {
            NameBox.Text = P.Name;
        }
    }
}
