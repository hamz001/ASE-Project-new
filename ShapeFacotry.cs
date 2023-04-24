using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASEProject
{
    /// <summary>
    /// the shape facotry is for creating the instances of the shapes.
    /// used for removing any dependencies
    /// </summary>
    class ShapeFacotry
    {
        /// <summary>
        /// this retrieves the shape objects to be instanciated if the inputted string matches any of the case statments
        /// exception is thrown if no cases are matched
        /// </summary>
        /// <param name="shapeType">the string used for comparing to retrieve the case shape</param>
        /// <returns>each case is to return the shape that it is referencing </returns>
        /// <exception cref="ArgumentException">the exception is to be thorwn id none of the cases match</exception>
        /// getShape is the factory method, calling sub classes of Circle, Rectangle, Triangle or line
        public Shape getShape(String shapeType)
        {
            shapeType = shapeType.ToLower().Trim();
            switch (shapeType)
            {
                case "circle":
                    return new Circle();
                case "rectangle":
                    return new Rectangle();
                case "triangle":
                    return new Triangle();
                case "line":
                    return new Line();
                default:
                    System.ArgumentException argEx = new System.ArgumentException("factory error: " + shapeType + "Does not exist");
                    throw argEx;
            }
        }
    }
}
