using System;
using System.CodeDom;

namespace Assignment1
{
    public class Rectangle
    {
        private int length;
        private int width;

        public Rectangle()
        {
            this.length = 1;
            this.width = 1;
        }

        public Rectangle(int length, int width)
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
            if (length > 1)
            {
                this.length = length;    
            }
            else
            {
                Console.WriteLine("Length should not be less than 1");
            }
            
        }

        public void setWidth(int width)
        {
            if (width > 1)
            {
                this.width = width;
            }
            else
            {
                Console.WriteLine("Width should not be less than 1");
            }
            
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