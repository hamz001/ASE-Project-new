using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Class definition of Triangle for the Factory Method to call this class

namespace ASEProject
{
    class Triangle : Shape
    {
        int xpos, ypos;
        int toX, toY;
        int width;
        

        public Triangle() : base()
        {
            this.xpos = 0;
            this.ypos = 0;
        }

        /// <summary>
        /// sets the colour of the pen and allows the size to be specified
        /// </summary>
        /// <param name="colour">sets the colour of the pen</param>
        /// <param name="x">sets the x position of the shape</param>
        /// <param name="y">sets the y position of the shape</param>
        /// <param name="width">specifies the width of the triangle</param>
        public Triangle(Color colour, int x, int y, int width)
        {
            this.width = width;
        }

        /// <summary>
        /// overrides the set method from the parent class to be specialised
        /// </summary>
        /// <param name="colour">changes the colour of the pen</param>
        /// <param name="list">an array of values to set the pen position and the size of the shape</param>
        public override void set(Color colour, params int[] list)
        {
            base.set(colour, list[0], list[1]);
            this.width = list[2];
        }

        public override void draw(Graphics g)
        {
            Point[] triangle = new Point[] { new Point(x, y - (width / 2)), new Point(x + (width / 2), y + (width / 2)), new Point(x - (width / 2), y + (width / 2)) }; // math for calculating the points of a polygon

            Pen p = new Pen(Color.Black, 2);
            SolidBrush b = new SolidBrush(colour);
            g.FillPolygon(b, triangle);
            g.DrawPolygon(p, triangle);
        }
    }
}
