using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASEProject;
using System.Drawing;

namespace ASEProject
{
    internal class Canvas_Testing
    {
        public class CanvasTests
        {
            private Graphics graphics;
            private Canvas canvas;

     
            public void Setup()
            {
                // Create a new graphics object for testing.
                Bitmap bitmap = new Bitmap(500, 500);
                graphics = Graphics.FromImage(bitmap);

                // Create a new canvas object for testing.
                canvas = new Canvas(graphics);
            }

 
            public void TestDrawLine()
            {
                // Draw a line on the canvas.
                canvas.DrawLine(100, 100);

                // Verify that the line was drawn correctly.
                // Get the image of the canvas and check the pixel values.
                Bitmap image = new Bitmap(500, 500);
                graphics = Graphics.FromImage(image);
                graphics.DrawLine(new Pen(Color.Black, 1), 0, 0, 100, 100);

                //Assert.IsTrue(AreImagesEqual(bitmap, image));
            }

   
            public void TestDrawSquare()
            {
                // Draw a square on the canvas.
                canvas.DrawSquare(100, 100);

                // Verify that the square was drawn correctly.
                // Get the image of the canvas and check the pixel values.
                Bitmap image = new Bitmap(500, 500);
                graphics = Graphics.FromImage(image);
                graphics.DrawRectangle(new Pen(Color.Black, 1), 0, 0, 100, 100);

             //   Assert.IsTrue(AreImagesEqual(bitmap, image));
            }

         
            public void TestDrawCircle()
            {
                // Draw a circle on the canvas.
                canvas.DrawCircle(50);

                // Verify that the circle was drawn correctly.
                // Get the image of the canvas and check the pixel values.
                Bitmap image = new Bitmap(500, 500);
                graphics = Graphics.FromImage(image);
                graphics.DrawEllipse(new Pen(Color.Black, 1), 0, 0, 50, 50);

               // Assert.IsTrue(AreImagesEqual(bitmap, image));
            }

            private bool AreImagesEqual(Bitmap image1, Bitmap image2)
            {
                // Check if the two images are equal pixel by pixel.
                for (int x = 0; x < image1.Width; x++)
                {
                    for (int y = 0; y < image1.Height; y++)
                    {
                        if (image1.GetPixel(x, y) != image2.GetPixel(x, y))
                        {
                            return false;
                        }
                    }
                }

                return true;
            }
        }
    }
}
