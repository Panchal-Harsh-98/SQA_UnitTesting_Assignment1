using System;

namespace Assignment1
{
    public class Rectangle
    {
        private int length;
        private int width;

        Rectangle()
        {
            this.length = 1;
            this.width = 1;
        }

        Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public int getLength()
        {
            return this.length;
        }

        public int getWidth()
        {
            return this.width;
        }
        
        //setlength setwidth get perimeter getarea
        public void setLength(int length)
        {
            this.length = length;
        }

        public void setWidth(int width)
        {
            this.width = width;
        }

        public int getPerimeter()
        {
            var perimeter = 2 * (width + length);
            return perimeter;
        }

        public int getArea()
        {
            var area = length * width;
            return area;
        }
        
    }
}