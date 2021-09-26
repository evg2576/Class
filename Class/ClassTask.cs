using System;
using System.Collections.Generic;
using System.Linq;

namespace Class
{
    public class Rectangle
    {
        private double sideA, sideB;
        public Rectangle (double sideA, double sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }
        public Rectangle(double sideA)
        {
            this.sideA = sideA;
            sideB = 5;
        }
        public Rectangle()
        {
            sideA = 4;
            sideB = 3;
        }

        public double GetSideA()
        {
            return sideA;
        }
        public double GetSideB()
        {
            return sideB;
        }
        public double Area()
        {
            return sideA * sideB;
        }
        public double Perimeter()
        {
            return (2 * (sideA + sideB));
        }
        public bool IsSquare()
        {
            return (sideA == sideB);
        }
        public void ReplaceSides()
        {
            sideA += sideB;
            sideB = sideA - sideB;
            sideA -= sideB;
        }
    }

    public class ArrayRectangles
    {
        private Rectangle[] rectangle_array;
        public ArrayRectangles(int n)
        {
            rectangle_array = new Rectangle[n];
        }
        public ArrayRectangles(Rectangle[] array)
        {
            rectangle_array = array;
        }
        public ArrayRectangles(IEnumerable<Rectangle> array)
        {
            rectangle_array = array.ToArray();
        }
        public bool AddRectangle(Rectangle rectangle)
        {
            for (int i = 0; i < rectangle_array.Length; i++)
            {
                if (rectangle_array[i] == null)
                {
                    rectangle_array[i] = rectangle;
                    return true;
                }
            }
            return false;
        }
        public int NumberMaxArea()
        {
            double maximum = rectangle_array[0].Area();
            int index = -1;
            foreach (Rectangle rectangle in rectangle_array)
                if (rectangle.Area() > maximum)
                {
                    maximum = rectangle.Area();
                    index = Array.IndexOf(rectangle_array, rectangle);
                }
            return index;
        }
        public int NumberMinPerimeter()
        {
            double minimum = rectangle_array[0].Perimeter();
            int index = -1;
            foreach (Rectangle rectangle in rectangle_array)
                if (rectangle.Perimeter() < minimum)
                {
                    minimum = rectangle.Perimeter();
                    index = Array.IndexOf(rectangle_array, rectangle);
                }
            return index;
        }
        public int NumberSquare()
        {
            int numberSquare = 0;
            foreach (Rectangle rectangle in rectangle_array)
                if (rectangle.IsSquare())
                    numberSquare++;
            return numberSquare;
        }
    }
}
