using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ASEProject
{
    class Circle : Shape
    {
        int width;
        int height;

        /// <summary>
        /// the constructor that is calling tp the shape decloration for the width and the height
        /// </summary>
        public Circle() : base()
        {
            this.width = 10;
            this.height = 10;
        }

        /// <summary>
        /// Allows an additinal construction method to create a circle where the colour, locaiton and size are different
        /// </summary>
        /// <param name="colour">sets the colour of the pen</param>
        /// <param name="x">sets the x position for the shape to be drawn</param>
        /// <param name="y">sets the y position for the shape to be drawn</param>
        /// <param name="width">specifies the width of the circle. the radius of the circle</param>
        /// <param name="height">specifies the height of the circle. the radius of the circle</param>
        public Circle(Color colour, int x, int y, int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public override void draw(Graphics g)
        {
            throw new NotImplementedException();
        }
    }
}
