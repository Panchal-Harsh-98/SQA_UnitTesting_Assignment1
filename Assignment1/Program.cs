using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Assignment1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var flag = true;
            Console.Write("Please Enter width of the rectangle :- ");
            var width = int.Parse(Console.ReadLine());
            Console.Write("Please Enter length of the rectangle :- ");
            var length = int.Parse(Console.ReadLine());
            Rectangle rectObj = new Rectangle(length, width);
            while (flag)
            {
                Console.Write("\n\n\n");
                Console.WriteLine("Please Select an option from the menu");
                Console.Write("\t1. Get Rectangle Length\n" +
                              "\t2. Change Rectangle Length\n" +
                              "\t3. Get Rectangle Width\n" +
                              "\t4. Change Rectangle Width\n" +
                              "\t5. Get Rectangle Perimeter\n" +
                              "\t6. Get Rectangle Area\n" +
                              "\t7. Exit\n\n");
                Console.Write("Please enter the number in front of the option to Proceed :- ");
                ConsoleKeyInfo key = Console.ReadKey();
                int option = int.Parse(key.KeyChar.ToString());
            
                while (option < 1 || option>7)
                {
                    Console.Write("\nPlease select a valid option to Proceed :- ");
                    key = Console.ReadKey();
                    option = int.Parse(Console.ReadKey().KeyChar.ToString());
                }
            
        
            
                Console.WriteLine("\n\noption "+int.Parse(key.KeyChar.ToString())+" selected");
            
                var selectedOption = key.KeyChar.ToString();
                switch (selectedOption)
                {
                    case "1":
                        Console.WriteLine("Length of rectangle :- " + rectObj.getLength());
                        break;
                    case "2":
                        Console.WriteLine("Please Enter length of the rectangle");
                        length = int.Parse(Console.ReadLine() ?? "1");
                        rectObj.setLength(length);
                        break;
                    case "3":
                        Console.WriteLine("Width of rectangle :- " + rectObj.getWidth());
                        break;
                    case "4":
                        Console.WriteLine("Please Enter width of the rectangle");
                        width = int.Parse(Console.ReadLine() ?? "1");
                        rectObj.setWidth(width);
                        break;
                    case "5":
                        var perimeter = rectObj.getPerimeter();
                        Console.WriteLine("Perimeter of rectangle is " + perimeter);
                        break;
                    case "6":
                        var area = rectObj.getArea();
                        Console.WriteLine("Area of rectangle is :- " + area);
                        break;
                    case "7":
                        flag = false;
                        System.Environment.Exit(0);
                        break;
                }
            }
            
        }
    }
}