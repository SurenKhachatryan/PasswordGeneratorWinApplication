using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClassLibrary;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        private string[] ArrHexadecimal = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
        private string[] ArrInteger = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        private string[] ArrSimbol = { "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "+", "|", "}", "{", ":", "?", ">", "<", "\",", "]", "[", "'", ";", "/", "." };
        private string[] ArrUppercase = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        private string[] ArrLowercase = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        private string[] ArrAllSimbols = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G", "H", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "+", "|", "}", "{", ":", "?", ">", "<", "\",", "]", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "[", "'", ";", "/", ".", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        private byte length;
        private int count;
        PassName.ListName passnumber;

        public Form1()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            PWFanctions pwf = new PWFanctions();
            if (passnumber == PassName.ListName.pincode)
            {
                length = 4;
            }
            else
            {
                length = byte.Parse(textBox1.Text);
            }
            count = int.Parse(textBox2.Text);
            switch (passnumber)
            {
                case PassName.ListName.hexadecimal:
                    listBox1.Items.Clear();
                    PassPrint(pwf.GetPassword(length, count, ArrHexadecimal.Length, ArrHexadecimal));
                    break;
                case PassName.ListName.integer:
                    listBox1.Items.Clear();
                    PassPrint(pwf.GetPassword(length, count, ArrInteger.Length, ArrInteger));
                    break;
                case PassName.ListName.uppercase:
                    listBox1.Items.Clear();
                    PassPrint(pwf.GetPassword(length, count, ArrUppercase.Length, ArrUppercase));
                    break;
                case PassName.ListName.lowercase:
                    listBox1.Items.Clear();
                    PassPrint(pwf.GetPassword(length, count, ArrLowercase.Length, ArrLowercase));
                    break;
                case PassName.ListName.simbol:
                    listBox1.Items.Clear();
                    PassPrint(pwf.GetPassword(length, count, ArrSimbol.Length, ArrSimbol));
                    break;
                case PassName.ListName.allsimbols:
                    listBox1.Items.Clear();
                    PassPrint(pwf.GetPassword(length, count, ArrAllSimbols.Length, ArrAllSimbols));
                    break;
                case PassName.ListName.pincode:
                    listBox1.Items.Clear();
                    PassPrint(pwf.GetPassword(length, count, ArrInteger.Length, ArrInteger));
                    break;
                default:

                    break;
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioHexadecimal_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            passnumber = PassName.ListName.hexadecimal;
        }

        private void radioInteger_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            passnumber = PassName.ListName.integer;
        }

        private void radioUppercase_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            passnumber = PassName.ListName.uppercase;
        }

        private void radioLowercase_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            passnumber = PassName.ListName.lowercase;
        }

        private void radioSimbol_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            passnumber = PassName.ListName.simbol;
        }

        private void radioAllSimbols_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            passnumber = PassName.ListName.allsimbols;
        }

        private void radioPincode_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            passnumber = PassName.ListName.pincode;
        }
        private void PassPrint(List<string> velue)
        {
            foreach (var item in velue)
            {
                listBox1.Items.Add(item);
            }
            velue.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
