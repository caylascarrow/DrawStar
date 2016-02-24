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
        public void DrawStar(Graphics g, Pen pen, int x, int y, int finalSize)
        {
            Point point1 = new Point((finalSize * (0 + x)) / 205, (finalSize * (75 + y)) / 195);
            Point point2 = new Point((finalSize * (79 + x)) / 205, (finalSize * (75 + y)) / 195);
            Point point3 = new Point((finalSize * (103 + x)) / 205, (finalSize * (0 + y)) / 195);
            Point point4 = new Point((finalSize * (127 + x)) / 205, (finalSize * (75 + y)) / 195);
            Point point5 = new Point((finalSize * (205 + x)) / 205, (finalSize * (75 + y)) / 195);
            Point point6 = new Point((finalSize * (141 + x)) / 205, (finalSize * (122 + y)) / 195);
            Point point7 = new Point((finalSize * (165 + x)) / 205, (finalSize * (195 + y)) / 195);
            Point point8 = new Point((finalSize * (103 + x)) / 205, (finalSize * (149 + y)) / 195);
            Point point9 = new Point((finalSize * (39 + x)) / 205, (finalSize * (195 + y)) / 195);
            Point point10 = new Point((finalSize * (64 + x)) / 205, (finalSize * (122 + y)) / 195);

            Point[] star = { point1, point2, point3, point4, point5, point6, point7, point8, point9, point10 };

            g.DrawPolygon(pen, star);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int xValue = 70;
            int size = 75;
            int yValue = 10;
            
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.Black, 1);
            DrawStar(g, pen, xValue, yValue, size);

            
        }
    }
}
