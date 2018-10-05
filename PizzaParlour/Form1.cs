using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaParlour
{
    public partial class Form1 : Form
    {
        //some useful variables
        int toppings = 0;
        const int STDPRICE = 7;
        double price;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Red, 60);

            g.DrawLine(drawPen, 0, 30, this.Width, 30);

            Font writeFont = new Font("Arial", 16);
            SolidBrush writeBrush = new SolidBrush(Color.White);

            g.DrawString("Pizza Parlour", writeFont, writeBrush, this.Width / 2 - 80, 20);
        }

        private void inputTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    toppings = Convert.ToInt16(inputTextbox.Text);
                    price = STDPRICE + toppings * 1.25;
                    outputLabel.Text = "You have to pay " + price.ToString("C");
                }
                catch
                {
                    outputLabel.Text = "Please, insert only numbers in the box above";
                    inputTextbox.Text = null;
                    return;
                }
            }
        }
    }
}
    
