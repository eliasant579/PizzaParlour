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

            g.DrawString("Pizza Parlour", writeFont, writeBrush, this.Width/2 - 80, 20);


        }
    }
}
