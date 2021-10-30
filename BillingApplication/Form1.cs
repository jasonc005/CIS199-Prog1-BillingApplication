//This application totals up the prices of 5 items in a shopping cart

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingApplication
{
    public partial class BillingApp : Form
    {
        public BillingApp()
        {
            InitializeComponent();
        }

        //Calculates and displays the total
        private void calculateTotalButton_Click(object sender, EventArgs e)
        {
            double total = 0;
            
            //Make sure textboxes aren't empty
            if (descriptionBox1.Text == "" || priceBox1.Text == "" || quantityBox1.Text == "" ||
                descriptionBox2.Text == "" || priceBox2.Text == "" || quantityBox2.Text == "" ||
                descriptionBox3.Text == "" || priceBox3.Text == "" || quantityBox3.Text == "" ||
                descriptionBox4.Text == "" || priceBox4.Text == "" || quantityBox4.Text == "" ||
                descriptionBox5.Text == "" || priceBox5.Text == "" || quantityBox5.Text == "")
            {
                MessageBox.Show("Please provide a full set of inputs: Product description, product price, and product quantity");
            }
            
            else
            {
                //Check for bad inputs
                try
                {
                    //Calculate total
                    total = double.Parse(priceBox1.Text) * double.Parse(quantityBox1.Text)
                        + double.Parse(priceBox2.Text) * double.Parse(quantityBox2.Text)
                        + double.Parse(priceBox3.Text) * double.Parse(quantityBox3.Text)
                        + double.Parse(priceBox4.Text) * double.Parse(quantityBox4.Text)
                        + double.Parse(priceBox5.Text) * double.Parse(quantityBox5.Text);

                    totalBox.Text = total.ToString("c");
                }
                
                catch (Exception ex)
                {
                    MessageBox.Show("Please only input numbers in the price and quantity boxes");
                }
            }
        }
    }
}
