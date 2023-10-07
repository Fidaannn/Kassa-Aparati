using mehsulsatiwi.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace mehsulsatiwi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Product p = new Product();
        decimal result = 0;
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox4.Text = btn.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)(sender);
            textBox4.Text += btn.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)(sender);
            textBox4.Text += btn.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox4.Text += btn.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox4.Text += btn.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox4.Text += btn.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox4.Text += btn.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox4.Text += btn.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox4.Text += btn.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox4.Text += btn.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox4.Text += btn.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
        }



        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                $"202: Lays \n" +
                $"203: Coca-Cola \n" +
                $"204: Kurassan \n");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "202")
            {
                object[] list = { p.Name = "Lays", p.Price = 2.20M };

                foreach (var item in list)
                {
                    listBox1.Items.Add(item);
                }
                result = result + p.Price;

            }
            else if (textBox1.Text == "203")
            {
                object[] list = { p.Name = "Coca-Cola", p.Price = 1.20M };

                foreach (var item in list)
                {
                    listBox1.Items.Add(item);
                }
                result = result + p.Price;

            }
            else
            {
                MessageBox.Show("Mehsul kodu movcud deyil");
            }



            label3.Text = result.ToString() + " " + "azn";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            decimal money = Convert.ToDecimal(textBox4.Text);

            if (money < result)
            {
                MessageBox.Show("Odenilen mebleg umumi meblegden kicik ola bilmez!");
                label5.ForeColor = Color.Red;
                label5.Text = money.ToString() + " " + "azn";

            }
            else
            {
                decimal tot = money - result;
                label7.Text = tot.ToString() + " " + "azn";
                label7.ForeColor = Color.Green;
                label5.ForeColor = Color.White;
                label5.Text = money.ToString() + " " + "azn";

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
