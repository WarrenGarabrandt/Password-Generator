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


        private void cmdGenerate_Click(object sender, EventArgs e)
        {

            try
            {
                int numsToDo = 2;
                int symbToDo = 2;

                bool Good = false;
                int first = 0;
                int second = 0;
                int len = 0;
                Random rnd = new Random();

                while (!Good)
                {
                    first = rnd.Next(Words.WordList.Count);
                    second = -1;
                    for (int i = 0; i < 1000; i++)
                    {
                        second = rnd.Next(Words.WordList.Count);
                        len = Words.WordList[first].Length + Words.WordList[second].Length;
                        if (len >= 12 && len < 16)
                        {
                            Good = true;
                            break;
                        }
                    }
                }
                string[] symb = new string[] { "!", "@", "#", "$", "%", "^", "&", "*", "(", ")" };
                int mPos = Words.WordList[first].Length;
                string pwd = Words.WordList[first] + Words.WordList[second];
                // always capitalize 'l' because its easy to confuse, but these don't count toward the required capital letter count.
                pwd = pwd.Replace('l', 'L');
                List<int> positions = new List<int>();
                for (int i = 0; i < len; i++)
                {
                    // don't capitalize Os or Is, because those are easy to confuse, and ignore the Ls because they don't count.
                    if (pwd[i] != 'o' && pwd[i] != 'i' && pwd[i] != 'L')
                    {
                        positions.Add(i);
                    }
                }
                // capitalize 4 random letters
                for (int i = 0; i < 4; ++i)
                {
                    int pos = positions[rnd.Next(positions.Count)];
                    positions.Remove(pos);
                    pwd = pwd.Substring(0, pos) + pwd[pos].ToString().ToUpper() + pwd.Substring(pos + 1, len - pos - 1);
                }

                // split up the words again for easy combining later
                string fw = pwd.Substring(0, mPos);
                string sw = pwd.Substring(mPos, len - mPos);
                string pre = "";
                string mid = "";
                string post = "";

                // add symbols and numbers in random order
                while (numsToDo > 0 || symbToDo > 0)
                {
                    // 0 = add number
                    // 1 = add symbol
                    int rng = rnd.Next(2);
                    // if we've run out of numbers we need, change to a symbol
                    if (rng == 0 && numsToDo == 0)
                    {
                        rng = 1;
                    }
                    // if we've run ou of symbols we need, change to a number
                    if (rng == 1 && symbToDo == 0)
                    {
                        rng = 0;
                    }

                    if (rng == 0)
                    {
                        // add a number
                        rng = rnd.Next(3);
                        // 0 = Pre, 1 = Mid, 2 = Post
                        if (rng == 0 && pre.Length < 2)
                        {
                            // don't use 0 or 1, because those get confused with O and l
                            pre = pre + (rnd.Next(8) + 2).ToString();
                            numsToDo--;
                        }
                        else if (rng == 1 && mid.Length < 2)
                        {
                            mid = mid + (rnd.Next(8) + 2).ToString();
                            numsToDo--;
                        }
                        else if (rng == 2 && post.Length < 2)
                        {
                            post = post + (rnd.Next(8) + 2).ToString();
                            numsToDo--;
                        }
                    }
                    else
                    {
                        // add a symbol
                        rng = rnd.Next(3);
                        // 0 = Pre, 1 = Mid, 2 = Post
                        if (rng == 0 && pre.Length < 2)
                        {
                            pre = pre + symb[rnd.Next(symb.Length)];
                            symbToDo--;
                        }
                        else if (rng == 1 && mid.Length < 2)
                        {
                            mid = mid + symb[rnd.Next(symb.Length)];
                            symbToDo--;
                        }
                        else if (rng == 2 && mid.Length < 2)
                        {
                            post = post + symb[rnd.Next(symb.Length)];
                            symbToDo--;
                        }
                    }
                }
                // combine the results
                pwd = pre + fw + mid + sw + post;

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
