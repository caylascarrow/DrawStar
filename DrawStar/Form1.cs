using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawStar
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            
            InitializeComponent();
          
        }
        /// <summary>
        /// Method for drawing stars
        /// </summary>
        /// <param name="g">graphics name for drawing</param>
        /// <param name="pen">pen used to draw star</param>
        /// <param name="x">where to start drawing star on the x axis</param>
        /// <param name="y">where to start drawing star on the y axis</param>
        /// <param name="finalSize"> the size of star drawn</param>
        public void DrawStar(Graphics g, Pen pen, float x, float y, float finalSize)
        {
            g.DrawLine(pen, (finalSize * (0 + x)) / 205, (finalSize * (75 + y)) / 195, (finalSize * (79 + x)) / 205, (finalSize * (75 + y)) / 195);
            g.DrawLine(pen, (finalSize * (79 + x)) / 205, (finalSize * (75 + y)) / 195, (finalSize * (103 + x)) / 205, (finalSize * (0 + y)) / 195);
            g.DrawLine(pen, (finalSize * (103 + x)) / 205, (finalSize * (0 + y)) / 195, (finalSize * (127 + x)) / 205, (finalSize * (75 + y)) / 195);
            g.DrawLine(pen, (finalSize * (127 + x)) / 205, (finalSize * (75 + y)) / 195, (finalSize * (205 + x)) / 205, (finalSize * (75 + y)) / 195);
            g.DrawLine(pen, (finalSize * (205 + x)) / 205, (finalSize * (75 + y)) / 195, (finalSize * (141 + x)) / 205, (finalSize * (122 + y)) / 195);
            g.DrawLine(pen, (finalSize * (141 + x)) / 205, (finalSize * (122 + y)) / 195, (finalSize * (165 + x)) / 205, (finalSize * (195 + y)) / 195);
            g.DrawLine(pen, (finalSize * (165 + x)) / 205, (finalSize * (195 + y)) / 195, (finalSize * (103 + x)) / 205, (finalSize * (149 + y)) / 195);
            g.DrawLine(pen, (finalSize * (103 + x)) / 205, (finalSize * (149 + y)) / 195, (finalSize * (39 + x)) / 205, (finalSize * (195 + y)) / 195);
            g.DrawLine(pen, (finalSize * (39 + x)) / 205, (finalSize * (195 + y)) / 195, (finalSize * (64 + x)) / 205, (finalSize * (122 + y)) / 195);
            g.DrawLine(pen, (finalSize * (64 + x)) / 205, (finalSize * (122 + y)) / 195, (finalSize * (0 + x)) / 205, (finalSize * (75 + y)) / 195);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float size = 75;
            float yValue = 10;
            float xValue = 70;
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.Black, 1);
            DrawStar(g, pen, xValue, yValue, size);
        }
    }
}
