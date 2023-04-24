using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASEProject
{
    /// <summary>
    /// shpae is using the interface called Shapes
    /// it is an abstract class so that the individual shapes can be added on
    /// </summary>
    abstract class Shape:Shapes
    {
        protected Color colour;
        protected int x, y;
        public int xPos, yPos;

        /// <summary>
        /// sets the base color and co-ordinates fir the shapes,
        /// </summary>
        public Shape()
        {
            colour = Color.Black;
            xPos = yPos = 0;
        }

        /// <summary>
        /// setting the basic colour and co-orinates for the child classes. 
        /// </summary>
        /// <param name="colour"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Shape(Color colour, int x, int y)
        {
            this.colour = colour;
            this.xPos = x;
            this.yPos = y;

        }


        public abstract void draw(Graphics g); // passing the declaration of the method on to the children

        /// <summary>
        /// creating a set declaration that canb be overwritten by the child classes so they can be more specific to each class
        /// </summary>
        /// <param name="colour"></param>
        /// <param name="list"></param>
        public virtual void set(Color colour, params int[] list)
        {
            this.colour = colour;
            this.xPos = list[0];
            this.yPos = list[1];
        }

        public override string ToString()
        {
            return base.ToString() + "   " + this.xPos + "," + this.yPos + " : ";
        }
    }
}
