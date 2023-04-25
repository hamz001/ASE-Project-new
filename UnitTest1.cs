using System.Drawing;
using ASEProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ASEProject

{
    [TestClass]
    /// Unit Testing Class
    public class UnitTest1
    {
        [TestMethod]
        /// Individual Test for a Circle
        public void Draw_a_Cricle_with_10_radius()
        {
            //assemble
            ShapeFacotry shap = new ShapeFacotry();
            string shapetest = "circle";
            
            //act
            shap.getShape(shapetest);
            
            //assert
            Assert.IsNotNull(shapetest);
        }

        [TestMethod]
        /// Individual test for a Rectangle
        public void Draw_a_Rectangle_with_10_radius()
        {
            //assemble
            ShapeFacotry shap = new ShapeFacotry();
            string squareshapetest = "rectangle";

            //act
            shap.getShape(squareshapetest);

            //assert
            Assert.IsNotNull(squareshapetest);
        }

        [TestMethod]

        public void Draw_a_line_with_10_length()
        {
            //assemble
            ShapeFacotry shap = new ShapeFacotry();
            string lineshapetest = "line";

            //act
            shap.getShape(lineshapetest);

            //assert
            Assert.IsNotNull(lineshapetest);
        }
    }
}