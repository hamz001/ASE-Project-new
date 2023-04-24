using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Class definition of Rectangle for the Factory Method to call this class

namespace ASEProject
{
    class Rectangle : Shape
    {
        int xpos;
        int ypos;
        int height;
        int width;

        public Rectangle() : base()
        {
            this.xpos = 0;
            this.ypos = 0;
        }

        /// <summary>
        /// allows and aditional contructor method to create a rectangle with the colour, location and size 
        /// </summary>
        /// <param name="colour">colours of the pen</param>
        /// <param name="x">sets the x position</param>
        /// <param name="y">sets the y position</param>
        /// <param name="width">sets the width</param>
        /// <param name="height">sets the height</param>
        public Rectangle(Color colour, int x, int y, int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public override void set(Color colour, params int[] list)
        {
            base.set(colour, list[0], list[1]);
            this.width = list[2];
            this.height = list[3];
        }

        public override void draw(Graphics g)
        {
            Pen p = new Pen(Color.Black, 2);
            SolidBrush b = new SolidBrush(colour);
            g.FillRectangle(b, xPos, yPos, width, height);
            g.DrawRectangle(p, xPos, yPos, width, height);
        }

    }
}
