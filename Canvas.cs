using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ASEProject
{
    /// <summary>
    /// the canvas class used for drawing all the graphics onto the form.
    /// used the graphics class
    /// </summary>
    class Canvas
    {
        Color c;
        Graphics g;
        Pen pen;
        int xPos, yPos;
        Boolean fill = false;
        SolidBrush brush;
        

        /// <summary>
        /// instantiates the pen and brush, and sets the x and y positions for drawing the shapes.
        /// the brush is used for filling in the shapes. the pen is used for drawing the shapes 'not filled'.
        /// </summary>
        /// <param name="gIn"></param>
        public Canvas(Graphics gIn)
        {
            this.g = gIn;
            xPos = yPos = 0;
            pen = new Pen(Color.Black, 1);
            brush = new SolidBrush(Color.Black);
        }

        /// <summary>
        /// used for drawing a line on the form screen
        /// </summary>
        /// <param name="toX">where you want the line going to be along the X axis</param>
        /// <param name="toY">where you want the line going to be along the Y axis</param>
        public void DrawLine(int toX, int toY)
        {
            g.DrawLine(pen, xPos, yPos, toX, toY);
            xPos = toY;
            yPos = toY;
        }

        /// <summary>
        /// used for drawing a rectangle
        /// effected by the fill method, for drawing shapes that are solid in colour
        /// </summary>
        /// <param name="width">the width of the shape</param>
        /// <param name="height">the height of the shape</param>
        public void DrawSquare(int width, int height)
        {
            if (fill == false)
            {
                g.DrawRectangle(pen, xPos, yPos, width, height);
            }
            else
            {
                if (fill == true)
                {
                    g.FillRectangle(brush, xPos, yPos, width, height);
                }
            }
        }

        /// <summary>
        /// used for drawing a circle
        /// this also has the ability to be filled or not
        /// </summary>
        /// <param name="radius">the size of the circle</param>
        public void DrawCircle(int radius)
        {
            int height = radius;
            int width = radius;
            if (fill == false)
            {
                g.DrawEllipse(pen, xPos, yPos, width, height);
            }
            else
            {
                if (fill == true)
                {
                    g.FillEllipse(brush, xPos, yPos, width, height);
                }
            }
        }

        /// <summary>
        /// allows the user to change the location of the new pen from where it was left
        /// </summary>
        /// <param name="toX">the new x position for the pen</param>
        /// <param name="toY">the new y position for the pen</param>
        public void MoveTo(int toX, int toY)
        {
            xPos = toX;
            yPos = toY;
        }

        /// <summary>
        /// sets the image to white to make it appear as it been cleared
        /// </summary>
        public void Clear()
        {
            g.Clear(Color.White);
        }

        /// <summary>
        /// restes the pen location to its initial location
        /// </summary>
        public void Reset()
        {
            xPos = 0;
            yPos = 0;
        }

        /// <summary>
        /// used the shape factory to draw a triangle
        /// </summary>
        /// <param name="width"></param>
        public void DrawTriangle(int width)
        {
            int[] paramValues = { xPos, yPos, width };
            ShapeFacotry sf = new ShapeFacotry();
            Shape s;
            s = sf.getShape("triangle");
            s.set(c, paramValues);
            s.draw(g);
        }

        /// <summary>
        /// sets the fill value to true or false.
        /// determines if a shape is drawn as filled or as an outline.
        /// </summary>
        /// <param name="b">takes in the string to be parsed</param>
        /// <returns></returns>
        public Boolean Fill(String b)
        {
            b = b.ToLower().Trim();
            if (b.Equals("true"))
            {
                fill = true;
            }
            else
            {
                if (b.Equals("false"))
                {
                    fill = false;
                }
            }
            return fill;
        }

        /// <summary>
        /// sets the colour of the pen to one of four choices
        /// </summary>
        /// <param name="colour"></param>
        public void Colour(String colour)
        {
            colour = colour.ToLower().Trim();
            switch (colour)
            {
                case "red":
                    c = Color.Red;
                    break;
                case "blue":
                    c = Color.Blue;
                    break;
                case "black":
                    c = Color.Black;
                    break;
                case "green":
                    c = Color.Green;
                    break;
            }
        }
    }
}
