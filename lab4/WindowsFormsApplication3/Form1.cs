using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> list = new List<string>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "text file|*.txt";

            if (fd.ShowDialog()== DialogResult.OK)
            {
                Stopwatch t = new Stopwatch();
                t.Start();

                string text = File.ReadAllText(fd.FileName);
                char[] separators = new char[]  {' ','.',',','!','?','/','\t','\n'};                string[] textArray = text.Split(separators);

                foreach (string strTemp in textArray)
                {
                    string str = strTemp.Trim();
                    if (!list.Contains(str)) list.Add(str);
                }
                t.Stop();

                this.label2.Text = t.Elapsed.ToString();
                this.label6.Text = list.Count.ToString();
            }
            else
            {
                MessageBox.Show("Must select file!");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string word = this.textBox2.Text.Trim();

            if (!string.IsNullOrWhiteSpace(word) && list.Count > 0)
            {
                string wordUpper = word.ToUpper();

                List<string> tempList = new List<string>();

                Stopwatch t = new Stopwatch();
                t.Start();

                foreach (string str in list)
                {
                    if (str.ToUpper().Contains(wordUpper))
                    {
                        tempList.Add(str);
                    }
                }
                t.Stop();
                this.label4.Text = t.Elapsed.ToString();
                this.listBox1.BeginUpdate();
                this.listBox1.Items.Clear();

                foreach(string str in tempList)
                {
                    this.listBox1.Items.Add(str);
                }
                this.listBox1.EndUpdate();
            }
            else
            {
                MessageBox.Show("Must select file and input word for search!");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            string word = listBox1.SelectedItem.ToString();
            if(!string.IsNullOrWhiteSpace(word) && list.Count > 0)
            {
                for (int i=0; i<list.Count-1;i++)
                {
                    if (list[i] == word)
                    {
                        if (i > 6)
                        {
                            if (i + 6 < list.Count)
                            {
                                textBox1.Text = "...";
                                for (int j = -5; j < 6; j++)
                                {
                                    textBox1.Text += list[i + j] + " ";
                                }
                                textBox1.Text += "...";
                            }
                            else if (i + 3 < list.Count)
                            {
                                textBox1.Text = "...";
                                for (int j = -5; j < 4; j++)
                                {
                                    textBox1.Text += list[i + j] + " ";
                                }
                                textBox1.Text += "...";
                            }
                            else
                            {
                                textBox1.Text = "...";
                                for (int j = -5; j < 0; j++)
                                {
                                    textBox1.Text += list[i + j] + " ";
                                }
                                textBox1.Text += ".";
                            }
                        }
                        else if (i > 4)
                        {
                            if (i + 4 < list.Count)
                            {
                                textBox1.Text = "...";
                                for (int j = -3; j < 6; j++)
                                {
                                    textBox1.Text += list[i + j] + " ";
                                }
                                textBox1.Text += "...";
                            }
                            else if (i + 3 < list.Count)
                            {
                                textBox1.Text = "...";
                                for (int j = -3; j < 4; j++)
                                {
                                    textBox1.Text += list[i + j] + " ";
                                }
                                textBox1.Text += "...";
                            }
                            else
                            {
                                textBox1.Text = "...";
                                for (int j = -3; j < 0; j++)
                                {
                                    textBox1.Text += list[i + j] + " ";
                                }
                                textBox1.Text += ".";
                            }
                        }
                        else
                        {
                            if (i + 6 < list.Count)
                            {
                                textBox1.Text = "...";
                                for (int j = 0; j < 6; j++)
                                {
                                    textBox1.Text += list[i + j] + " ";
                                }
                                textBox1.Text += "...";
                            }
                            else if (i + 3 < list.Count)
                            {
                                textBox1.Text = "...";
                                for (int j = 0; j < 4; j++)
                                {
                                    textBox1.Text += list[i + j] + " ";
                                }
                                textBox1.Text += "...";
                            }
                            else
                            {
                                textBox1.Text = "...";
                                for (int j = 0; j < 0; j++)
                                {
                                    textBox1.Text += list[i + j] + " ";
                                }
                                textBox1.Text += ".";
                            }
                        }
                    }
                }
            }
        }
    }
}
