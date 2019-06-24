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

namespace Zadanie_Junior
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(openFile.FileName);
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ComboBox4_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_MouseClick(object sender, MouseEventArgs e)
        {
            string[] fullTxt;

            fullTxt = richTextBox1.Text.Split('\n');
            richTextBox1.Text = "";
            foreach (string search in fullTxt)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    if (comboBox2.SelectedIndex == 0)
                    {
                        if (comboBox3.SelectedIndex == 0)
                        {
                            if (comboBox4.SelectedIndex == 0)
                            {
                                if (search.Contains(textBox1.Text) && search.Contains(textBox2.Text) &&
                                    search.Contains(textBox3.Text) && search.Contains(textBox4.Text))
                                    richTextBox1.Text += search + "\n";
                            }
                            else
                            {
                                if (search.Contains(textBox1.Text) && search.Contains(textBox2.Text) &&
                                    search.Contains(textBox3.Text))
                                    richTextBox1.Text += search + "\n";
                            }
                        }
                        else if (comboBox4.SelectedIndex == 0)
                        {
                            if (search.Contains(textBox1.Text) && search.Contains(textBox2.Text) &&
                                search.Contains(textBox4.Text))
                                richTextBox1.Text += search + "\n";
                        }
                        else
                        {
                            if (search.Contains(textBox1.Text) && search.Contains(textBox2.Text))
                                richTextBox1.Text += search + "\n";
                        }
                    }
                    else if (comboBox3.SelectedIndex == 0)
                    {
                        if (comboBox4.SelectedIndex == 0)
                        {
                            if (search.Contains(textBox1.Text) && search.Contains(textBox3.Text) &&
                                search.Contains(textBox4.Text))
                                richTextBox1.Text += search + "\n";
                        }
                        else
                        {
                            if (search.Contains(textBox1.Text) && search.Contains(textBox3.Text))
                                richTextBox1.Text += search + "\n";
                        }
                    }
                    else if (comboBox4.SelectedIndex == 0)
                    {
                        if (search.Contains(textBox1.Text) && search.Contains(textBox4.Text))
                            richTextBox1.Text += search + "\n";
                    }
                    else
                    {
                        if (search.Contains(textBox1.Text))
                            richTextBox1.Text += search + "\n";
                    }
                }
                else if (comboBox2.SelectedIndex == 0)
                {
                    if (comboBox3.SelectedIndex == 0)
                    {
                        if (comboBox4.SelectedIndex == 0)
                        {
                            if (search.Contains(textBox2.Text) && search.Contains(textBox3.Text) &&
                                search.Contains(textBox4.Text))
                                richTextBox1.Text += search + "\n";
                        }
                        else
                        {
                            if (search.Contains(textBox2.Text) && search.Contains(textBox3.Text))
                                richTextBox1.Text += search + "\n";
                        }
                    }
                    else if (comboBox4.SelectedIndex == 0)
                    {
                        if (search.Contains(textBox2.Text) && search.Contains(textBox4.Text))
                            richTextBox1.Text += search + "\n";
                    }
                    else
                    {
                        if (search.Contains(textBox2.Text))
                            richTextBox1.Text += search + "\n";
                    }
                }
                else if (comboBox3.SelectedIndex == 0)
                {
                    if (comboBox4.SelectedIndex == 0)
                    {
                        if (search.Contains(textBox3.Text) && search.Contains(textBox4.Text))
                            richTextBox1.Text += search + "\n";
                    }
                    else
                    {
                        if (search.Contains(textBox3.Text))
                            richTextBox1.Text += search + "\n";
                    }
                }
                else if (comboBox4.SelectedIndex == 0)
                {
                    if (search.Contains(textBox4.Text))
                        richTextBox1.Text += search + "\n";
                }
                else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 1 &&
                    comboBox3.SelectedIndex == 1 && comboBox4.SelectedIndex == 1)
                {
                    if (search.Contains(textBox1.Text) || search.Contains(textBox2.Text) ||
                       search.Contains(textBox3.Text) || search.Contains(textBox4.Text))
                        richTextBox1.Text += search + "\n";
                }
            }
        }

    }
}