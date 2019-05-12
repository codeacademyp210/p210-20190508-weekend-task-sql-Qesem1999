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
    public partial class Product : Form
    {
        private Form MainForm;
        public Product(Form mainForm)
        {
            MainForm = mainForm;
            InitializeComponent();
        }

        private void Product_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MainForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex letters = new Regex(@"^[a-zA-Z]+$");
            Match nameMatch = letters.Match(textBox1.Text);
            Match adMatch = letters.Match(textBox7.Text);
            Match brandMatch = letters.Match(textBox3.Text);
            Match colorMatch = letters.Match(textBox2.Text);


            Regex numbers = new Regex(@"^[0-9_]+$");
            Match priceMatch = numbers.Match(textBox5.Text);
            Match barcodeMatch = numbers.Match(textBox6.Text);
            Match stockMatch = numbers.Match(textBox8.Text);


            if (!nameMatch.Success)
            {
                MessageBox.Show("Fill name correctly");
            }
            else if (!priceMatch.Success)
            {
                MessageBox.Show("Price can be only numbers");
            }
            else if (!brandMatch.Success)
            {
                MessageBox.Show("Brand consists of only letters");
            }
            else if (!colorMatch.Success)
            {
                MessageBox.Show("Color consists of only letters");
            }
            else if (!barcodeMatch.Success)
            {
                MessageBox.Show("Barcode consists of only numbers");
            }
            else if (!stockMatch.Success)
            {
                MessageBox.Show("Quantity(stock) can be only numbers");
            }
            else if (!adMatch.Success)
            {
                MessageBox.Show("Fill your name correctly");
            }
            else
            {
                Product1 newProduct = new Product1();

                newProduct.Name = textBox1.Text;
                newProduct.Price = Convert.ToDouble(textBox5.Text);
                newProduct.Category = textBox4.Text;
                newProduct.Brand = textBox3.Text;
                newProduct.Color = textBox2.Text;
                newProduct.Barcode = Convert.ToInt32(textBox6.Text);
                newProduct.Stock = textBox8.Text;
                newProduct.Ad = textBox7.Text;


                dataGridView1.Rows.Add(newProduct.Name, newProduct.Price, newProduct.Category, newProduct.Brand, newProduct.Color, newProduct.Barcode, newProduct.Stock, newProduct.Ad);

                Products.AllProducts.Add(newProduct);


                textBox1.Clear();
                textBox5.Clear();
                textBox4.Clear();
                textBox3.Clear();
                textBox2.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();


            }
        }
    }
}
