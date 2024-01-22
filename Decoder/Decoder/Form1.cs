using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'a':
                    Label1.Text += "(";
                    break;
                    case 'b':
                    Label1.Text += "%";
                    break;
                case 'c':
                    Label1.Text += "[";
                    break;
                case 'd':
                    Label1.Text += "|";
                    break;
                    case 'e':
                    Label1.Text += "]";
                    break;
                case 'f':
                    Label1.Text += "."; 
                    break;
                case 'g':
                    Label1.Text += ";";
                    break;
                case 'h':
                    Label1.Text += ":";
                    break;
                case 'i':
                    Label1.Text += "{";
                    break;
                case 'j':
                    Label1.Text += "`";
                    break;
                case 'k':
                    Label1.Text += "~";
                    break ;
                case 'l':
                    Label1.Text += "-";
                    break;
                case 'm':
                    Label1.Text += "=";
                    break;
                case 'n':
                    Label1.Text += "^";
                    break;
                case'o':
                    Label1.Text += "&";
                    break;
                case 'p':
                    Label1.Text += "?";
                    break;
                case 'q':
                    Label1.Text += "+";
                    break;
                case 'r':
                    Label1.Text += "}";
                    break;
                case 's':
                    Label1.Text += "/";
                    break;
                case 't':
                    Label1.Text += "<";
                    break;
                case 'u':
                    Label1.Text += ">";
                    break;
                case 'v':
                    Label1.Text += "*";
                    break;
                case 'w':
                    Label1.Text += "!";
                    break;
                case 'x':
                    Label1.Text += "@";
                    break;
                case 'y':
                    Label1.Text += "#";
                    break;
                case 'z':
                    Label1.Text += "_";
                    break;
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '(':
                    label2.Text += "a";
                    break;
                case '%':
                    label2.Text += "b";
                    break;
                case '[':
                    label2.Text += "c";
                    break;
                case '|':
                    label2.Text += "d";
                    break;
                case ']':
                    label2.Text += "]";
                    break;
                case '.':
                    label2.Text += "f";
                    break;
                case ';':
                    label2.Text += "g";
                    break;
                case ':':
                    label2.Text += "h";
                    break;
                case '{':
                    label2.Text += "i";
                    break;
                case '`':
                    label2.Text += "j";
                    break;
                case '~':
                    label2.Text += "k";
                    break;
                case '-':
                    label2.Text += "l";
                    break;
                case 'm':
                    label2.Text += "=";
                    break;
                case '^':
                    label2.Text += "n";
                    break;
                case '&':
                    label2.Text += "o";
                    break;
                case '?':
                    label2.Text += "p";
                    break;
                case '+':
                    label2.Text += "q";
                    break;
                case '}':
                    label2.Text += "r";
                    break;
                case '/':
                    label2.Text += "s";
                    break;
                case '<':
                    label2.Text += "t";
                    break;
                case '>':
                    label2.Text += "u";
                    break;
                case '*':
                    label2.Text += "v";
                    break;
                case '!':
                    label2.Text += "w";
                    break;
                case '@':
                    label2.Text += "x";
                    break;
                case '#':
                    label2.Text += "y";
                    break;
                case '_':
                    label2.Text += "z";
                    break;
            }
        }
    }
}
