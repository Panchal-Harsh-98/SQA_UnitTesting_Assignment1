using System.Reflection;
using NUnit.Framework;
using Assignment1;
namespace Tests
{
    [TestFixture]
    public class Tests
    {
        
        // test case to check the get methods
        [Test]
        public void CheckMeasurementReturns()
        {
            Rectangle defaultObj = new Rectangle();
            Assert.AreEqual(1,defaultObj.getWidth());
            Assert.AreEqual(1,defaultObj.getLength());
        }

        // test case to check the set methods
        [Test]
        public void CheckSetMeasurement()
        {
            // arrange
            int setLength = 44;
            int setWidth = 33;
            Rectangle obj = new Rectangle();
            // act
            obj.setLength(setLength);
            obj.setWidth(setWidth);
            // assert
            var actualLength = obj.getLength();
            var actualWidth = obj.getWidth();
            Assert.AreEqual(setLength,actualLength,"Length is not set properly");
            Assert.AreEqual(setWidth,actualWidth,"width is not set properly");
        }
        
        // test case to check the perimeter of the rectangle methods
        [Test]
        public void CheckPerimeterMeasurement()
        {
            int length = 37;
            int width = 54;
            int setPerimeter = 182;
            Rectangle obj = new Rectangle(length, width);
            var actualPerimeter = obj.getPerimeter();
            Assert.AreEqual(setPerimeter,actualPerimeter,"Perimeter is not as the actual perimeter");
        }

        // test case to check the area of the rectangle
        [Test]
        public void CheckAreaMeasurement()
        {
            int length = 37;
            int width = 54;
            int setArea = 1998;
            Rectangle obj = new Rectangle(length, width);
            var actualArea = obj.getArea();
            Assert.AreEqual(setArea,actualArea,"Area is not as actual perimeter");
        }
    }
}