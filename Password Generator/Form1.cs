using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<string> WordList = null;

        private void cmdGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                int numsToDo = (int)nudNumbers.Value;
                int symbToDo = (int)nudSymbols.Value;
                if (WordList == null)
                {
                    WordList = new List<string>();
                    using (var f = System.IO.File.OpenText("wordlist.txt"))
                    {
                        string line;
                        while ((line = f.ReadLine()) != null)
                        {
                            if (line.Length >= 6 && line.Length < 12)
                            {
                                WordList.Add(line);
                            }
                        }
                    }
                }
                //using (var f = System.IO.File.CreateText("shortlist.txt"))
                //{
                //    foreach (var line in WordList)
                //    {
                //        f.WriteLine(line);
                //    }
                //}
                bool Good = false;
                int first = 0;
                int second = 0;
                int len = 0;
                Random rnd = new Random();
                    
                while (!Good)
                {
                    first = rnd.Next(WordList.Count);
                    second = -1;
                    for (int i = 0; i < 1000; i++)
                    {
                        second = rnd.Next(WordList.Count);
                        len = WordList[first].Length + WordList[second].Length;
                        if (len > 15 && len < 18)
                        {
                            Good = true;
                            break;
                        }
                    }
                }
                string[] symb = new string[] { "!", "@", "#", "$", "%", "^", "&", "*", "(", ")" };
                int mid = WordList[first].Length;
                string pwd = WordList[first] + WordList[second];
                List<int> positions = new List<int>();
                for (int i = 0; i < len; i++)
                {
                    positions.Add(i);
                }
                // capitalize 4 random letters
                for (int i = 0; i < 4; ++i)
                {
                    int pos = positions[rnd.Next(positions.Count)];
                    positions.Remove(pos);
                    pwd = pwd.Substring(0, pos) + pwd[pos].ToString().ToUpper() + pwd.Substring(pos + 1, len - pos - 1);
                }
                // Insert a symbol between the two words
                if (symbToDo > 0)
                {
                    pwd = pwd.Substring(0, mid) + symb[rnd.Next(symb.Length)] + pwd.Substring(mid, len - mid);
                    len++;
                    symbToDo--;
                }
                // insert random numbers.
                for (int i = 0; i < numsToDo; ++i)
                {
                    int pos = rnd.Next(len + 1);
                    pwd = pwd.Substring(0, pos) + (rnd.Next(8) + 2).ToString() + pwd.Substring(pos, len - pos);
                    len++;
                }
                // insert two random symbols.
                for (int i = 0; i < symbToDo; ++i)
                {
                    int pos = rnd.Next(len + 1);
                    pwd = pwd.Substring(0, pos) + symb[rnd.Next(symb.Length)] + pwd.Substring(pos, len - pos);
                    len++;
                }
                lblPassword.Text = pwd;
                
            }
            catch (Exception ex)
            {
                lblPassword.Text = ex.Message;
            }
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblPassword.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmdGenerate.PerformClick();
        }
    }
}
