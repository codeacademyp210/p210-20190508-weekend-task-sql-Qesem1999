using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.classes;

namespace WindowsFormsApp1
{
    public partial class Registor : Form
    {
        public Registor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User reg = new User();

            reg.name = textBox2.Text;
            reg.Surname = textBox3.Text;
            reg.Username = textBox1.Text;
            reg.Email = textBox4.Text;
            reg.Password = textBox5.Text;
            Users.AllUsers.Add(reg);
            Regex letters = new Regex(@"^[a-zA-Z]+$");
            Match nameMatch = letters.Match(textBox2.Text);
            Match surnameMatch = letters.Match(textBox3.Text);
            Regex emailPattern = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match emailMatch = emailPattern.Match(textBox4.Text);
            Regex passwordPattern = new Regex(@"^[a-zA-Z0-9]+$");
            Match passwordMatch = passwordPattern.Match(textBox5.Text);

            if (!nameMatch.Success)
            {
                MessageBox.Show("Fill name correctly");
            }
            else if (!surnameMatch.Success)
            {
                MessageBox.Show("Fill surname correctly");
            }
            else if (!emailMatch.Success)
            {
                MessageBox.Show("Fill email correctly");
            }
            else if (!passwordMatch.Success)
            {
                MessageBox.Show("Password consists of only numbers and letters");
            }
            else
            {
                User reg1 = new User();

                reg1.name = textBox2.Text;
                reg1.Surname = textBox3.Text;
                reg1.Username = textBox1.Text;
                reg1.Email = textBox4.Text;
                reg1.Password = textBox5.Text;
                Users.AllUsers.Add(reg1);
                Product product = new Product(this);
                this.Hide();
                product.Show();
            }


        }

        
    }
}
