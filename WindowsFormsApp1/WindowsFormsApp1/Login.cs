using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.classes;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
             
            User user1 = new User();
            user1.Username = username.Text;
            user1.Password = password.Text;

            bool logined = false;
            foreach (User item in Users.AllUsers)
            {
                if (item.Username == user1.Username && item.Password == user1.Password)
                {
                    logined = true;
                    break;
                }
            }
            if (logined)
            {
                Product product = new Product(this);
                this.Hide();
                product.Show();
            }
            else
            {
                Registor registor = new Registor();
                this.Hide();
                registor.Show();
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registor registor = new Registor();
            this.Hide();
            registor.Show();
        }
    }
}
