using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Summative_Assessment_Part_B.Nondumiso_Mhlongo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newWord =   textBox1.Text.Trim();
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter a word.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBox1.Items.Contains(textBox1.Text))
            {
                MessageBox.Show("The word has already been entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            comboBox1.Items.Add(textBox1.Text);
            comboBox2.Items.Add(textBox1.Text);


            textBox1.Clear();


            comboBox1.SelectedItem = newWord;
            comboBox2.SelectedItem = newWord;
       
            MessageBox.Show("The new word has been added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String textBoxText = textBox1.Text;
            if (radioButton1.Checked || radioButton2.Checked)
            {
                // Check if a word has been selected from a ComboBox control
                if (comboBox2.SelectedItem == null && comboBox2.SelectedItem == null)
                {
                    // Display a MessageBox
                    MessageBox.Show("Please select a word from a ComboBox control.");
                    return;
                }
                // Remove the selected word from the corresponding ComboBox control.
                else if ( comboBox1.SelectedItem != null)
                {
                    comboBox1.Items.Remove(comboBox1.SelectedItem);
                }
                else if (comboBox2.SelectedItem != null)
                   
                {
                    comboBox2.Items.Remove(comboBox2.SelectedItem);
                 
                }
                MessageBox.Show("The word has been removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            else

            {
                if ( comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)

                {
                    MessageBox.Show("Please select a word from both ComboBox controls.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (comboBox1.SelectedItem.ToString () == comboBox2.SelectedItem.ToString())
                    
                {
                    MessageBox.Show("Please select different words from the ComboBox controls.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                 

                string concatenatedWord = comboBox1.SelectedItem.ToString() + comboBox2.SelectedItem.ToString();

                button2.Text = concatenatedWord;
            }

            string[] txtEnterWord = textBoxText.Split(' ');

            if (txtEnterWord.Length > 1 && txtEnterWord[0] == txtEnterWord[1])
            {
                MessageBox.Show("The TextBox contains the same word twice.");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                button2.Text = "Remove Item";
            }
            else
            {
                button2.Text = "Concatenate";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                button2.Text = "Remove Item";
            }
            else
            {
                button2.Text = "Concatenate";
            }
        }
    }
    }


