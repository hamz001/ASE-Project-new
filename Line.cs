using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Class definition of Line for the Factory Method to call this class

namespace ASEProject
{
    /// <summary>
    /// the class for drawing a line on the screen this inherits from the shape class
    /// </summary>
    class Line : Shape
    {
        int xpos, ypos;
        int toX, toY;

        /// <summary>
        /// the constructor that is calling to the shape decloration for the x and y positions
        /// </summary>
        public Line() : base()
        {
            this.xpos = 0;
            this.ypos = 0;
        }

        /// <summary>
        /// Overriding the set moethod from the parent class so that it can be specialised to the class
        /// </summary>
        /// <param name="colour">sets the pen colour</param>
        /// <param name="list">sets the x and y positions</param>
        public override void set(Color colour, params int[] list)
        {
            base.set(colour, list[0], list[1]);
            this.toX = xpos + list[2];
            this.toY = ypos + list[3];
        }

        /// <summary>
        /// overriding the draw method form the parent class to be specialised to the child class
        /// </summary>
        /// <param name="g">the graphics class that is being passed</param>
        public override void draw(Graphics g)
        {
            Pen p = new Pen(colour, 2);
            g.DrawLine(p, xPos, yPos, toX, toY);
           
        }
    }
}
