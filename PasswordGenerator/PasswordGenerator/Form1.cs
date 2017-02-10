using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClassLibrary;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        private string ArrHexadecimal = "0123456789ABCDEF";
        private string ArrInteger = "0123456789";
        private string ArrSimbol = @"!@#$%^&*()_+|}{:?><\][';/.,""";
        private string ArrUppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private string ArrLowercase = "abcdefghijklmnopqrstuvwxyz";
        private string ArrAllSimbols = @"0123ABCDEF';/.,""GHIJKLMopqrstuvwxyzN456789ab_+|}{:?>OPQRSTUVWXYZ<\][cdefghijklmn!@#$%^&*() ";
        private byte length;
        private int count;
        private bool error = true;
        PassName.ListName passnumber;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            error = true;
            if (textBox2.Text != "" || textBox1.Text != "")
            {
                if (textBox2.Text != "" && error)
                {
                    if (0 < long.Parse(textBox2.Text) && 500 >= long.Parse(textBox2.Text))
                    {
                    }
                    else
                    {
                        MessageBox.Show("Count Range 1-500!!");
                        error = false;
                    }
                }
                if (passnumber == PassName.ListName.pincode)
                {
                    if (textBox2.Text != "" && error)
                    {
                        length = 4;
                        count = int.Parse(textBox2.Text);
                        passgenerator();
                    }
                    else
                    {
                        if (error)
                        {
                            MessageBox.Show("The Number Of Passwords Is Not Specified!!");
                            error = false;
                        }
                    }
                }
                if (textBox1.Text != "")
                {
                    if (0 < long.Parse(textBox1.Text) && 255 >= long.Parse(textBox1.Text))
                    {
                        length = byte.Parse(textBox1.Text);
                    }
                    else
                    {
                        if (passnumber != PassName.ListName.pincode)
                        {
                            MessageBox.Show("Length Range 1-255!!");
                            error = false;
                        }
                    }
                }
                if (textBox2.Text != "" && textBox1.Text != "" && passnumber != PassName.ListName.pincode && error)
                {
                    count = int.Parse(textBox2.Text);
                    passgenerator();
                }
                else
                {
                    if (textBox1.Text != "" && passnumber != PassName.ListName.pincode && error)
                    {
                        MessageBox.Show("The Number Of Passwords Is Not Specified!!");
                        error = false;
                    }
                    else
                    {
                        if (textBox1.Text == "" && error)
                        {
                            if (passnumber != PassName.ListName.pincode)
                            {
                                MessageBox.Show("Length Of The Password Is Not Set!!");
                            }
                        }
                    }
                }
            }
            else
            {
                if (passnumber != PassName.ListName.pincode)
                {
                    MessageBox.Show("Please Enter Data!!!");
                }
                else
                {
                    MessageBox.Show("The Number Of Passwords Is Not Specified!!");
                }
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
            if (textBox1.Text == "")
            {
                length = 0;
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioHexadecimal_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            passnumber = PassName.ListName.hexadecimal;
            length = 0;
        }
        private void radioInteger_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            passnumber = PassName.ListName.integer;
            length = 0;
        }
        private void radioUppercase_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            passnumber = PassName.ListName.uppercase;
            length = 0;
        }
        private void radioLowercase_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            passnumber = PassName.ListName.lowercase;
            length = 0;
        }
        private void radioSimbol_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            passnumber = PassName.ListName.simbol;
            length = 0;
        }
        private void radioAllSimbols_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            passnumber = PassName.ListName.allsimbols;
            length = 0;
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
        private void passgenerator()
        {
            PWFanctions pwf = new PWFanctions();
            switch (passnumber)
            {
                case PassName.ListName.hexadecimal:
                    listBox1.Items.Clear();
                    PassPrint(pwf.GetPassword(length, count, ArrHexadecimal.Length, ArrHexadecimal.ToCharArray()));
                    break;
                case PassName.ListName.integer:
                    listBox1.Items.Clear();
                    PassPrint(pwf.GetPassword(length, count, ArrInteger.Length, ArrInteger.ToCharArray()));
                    break;
                case PassName.ListName.uppercase:
                    listBox1.Items.Clear();
                    PassPrint(pwf.GetPassword(length, count, ArrUppercase.Length, ArrUppercase.ToCharArray()));
                    break;
                case PassName.ListName.lowercase:
                    listBox1.Items.Clear();
                    PassPrint(pwf.GetPassword(length, count, ArrLowercase.Length, ArrLowercase.ToCharArray()));
                    break;
                case PassName.ListName.simbol:
                    listBox1.Items.Clear();
                    PassPrint(pwf.GetPassword(length, count, ArrSimbol.Length, ArrSimbol.ToCharArray()));
                    break;
                case PassName.ListName.allsimbols:
                    listBox1.Items.Clear();
                    PassPrint(pwf.GetPassword(length, count, ArrAllSimbols.Length, ArrAllSimbols.ToCharArray()));
                    break;
                case PassName.ListName.pincode:
                    listBox1.Items.Clear();
                    PassPrint(pwf.GetPassword(length, count, ArrInteger.Length, ArrInteger.ToCharArray()));
                    break;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "" || listBox1.Items.Count != 0)
            {
                listBox1.Items.Clear();
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("There Is Nothing To Clean Up!!");
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8 || textBox1.Text == "" && chr == '0')
            {
                e.Handled = true;
                if (chr != '0' && !Char.IsControl(chr))
                {
                    MessageBox.Show("Field Only Accepts Numbers(0 - 9)");
                }
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8 || textBox2.Text == "" && chr == '0')
            {
                e.Handled = true;
                if (chr != '0' && !Char.IsControl(chr))
                {
                    MessageBox.Show("Field Only Accepts Numbers(0 - 9)");
                }
            }
        }
    }
}
