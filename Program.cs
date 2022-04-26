using System;

namespace CSharp.LabExercise4
{
    interface IShape
    {
        public string Name { get; set; }

        public decimal Area { get; set; }

        public void ComputeArea(decimal sideLength);

        public void ComputeArea(decimal length, decimal width);
    }

    class Circle : IShape
    {
        public string Name
        {
            get => "Circle";
            set { }
        }
        public decimal Area
        {
            get;
            set;
        }
        public void ComputeArea(decimal diameter)
        {
        this.Area = diameter * Convert.ToDecimal(Math.PI);
        }
        public void ComputeArea(decimal length, decimal width) { }
    }

    class Square: IShape
    {
        public string Name
        {
            get => "Square";
            set { }
        }
        public decimal Area
        {
            get;
            set;
        }
        public void ComputeArea(decimal sideLength)
        {
            this.Area = sideLength * sideLength;
        }
        public void ComputeArea(decimal length, decimal width) { }

    }

    class Rectangle: IShape
    {
        public string Name
        {
            get => "Rectangle";
            set { }
        }
        public decimal Area
        {
            get;
            set;
        }
        public void ComputeArea(decimal sideLength) { }
        public void ComputeArea(decimal length, decimal width) 
        {
            this.Area = length * width;
        }
    }

    class AreaCalculator
    {
        public void ComputeArea(IShape shape, decimal sideLength)
        {
            shape.ComputeArea(sideLength);
        }
        public void ComputeArea(IShape shape, decimal length, decimal width)
        {
            shape.ComputeArea(length, width);
        }
    }

    class Renderer
    {
        public void Render(IShape shape)
        {
            Console.WriteLine("\nYour shape is: {0}.\n It's area is: {1} square units.\n", shape.Name, shape.Area);
        }
    }


    interface IOperators
    {
        public void Calculate(decimal num1, decimal num2)
        { }
    }

    class Addition: IOperators
    {
        public void Calculate(decimal num1, decimal num2)
        {
            decimal result = num1 + num2;
            Console.WriteLine("{0} + {1} = {2}", num1, num2, result);
        }
    }
    class Subtraction : IOperators
    {
        public void Calculate(decimal num1, decimal num2)
        {
            decimal result = num1 - num2;
            Console.WriteLine("{0} - {1} = {2}", num1, num2, result);
        }
    }
    class Multiplication : IOperators
    {
        public void Calculate(decimal num1, decimal num2)
        {
            decimal result = num1 * num2;
            Console.WriteLine("{0} * {1} = {2}", num1, num2, result);
        }
    }
    class Division : IOperators
    {
        public void Calculate(decimal num1, decimal num2)
        {
            decimal result = num1 / num2;
            Console.WriteLine("{0} / {1} = {2}", num1, num2, result);
        }
    }



    class Program
    {
        static void Number1()
        {
            AreaCalculator areaCalculator = new AreaCalculator();
            Renderer Renderer = new Renderer();

            Console.WriteLine("Welcome to Area Calculator\n");

            IShape circle = new Circle();
            Console.WriteLine("\nEnter diameter of circle.");
            decimal diameter = Convert.ToDecimal(Console.ReadLine());
            areaCalculator.ComputeArea(circle, diameter);
            Renderer.Render(circle);

            IShape square = new Square();
            Console.WriteLine("\nEnter length of square.");
            decimal sideLength = Convert.ToDecimal(Console.ReadLine());
            areaCalculator.ComputeArea(square, sideLength);
            Renderer.Render(square);

            IShape rectangle = new Rectangle();
            Console.WriteLine("\nEnter length of rectangle.");
            decimal length = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\nEnter width of rectangle.");
            decimal width = Convert.ToDecimal(Console.ReadLine());
            areaCalculator.ComputeArea(rectangle, length, width);
            Renderer.Render(rectangle);
        }

        static void Number2()
        {
            IOperators addOperator = new Addition();
            addOperator.Calculate(4, 2);

            IOperators minusOperator = new Subtraction();
            minusOperator.Calculate(4, 2);

            IOperators timesOperator = new Multiplication();
            timesOperator.Calculate(4, 2);

            IOperators divideOperator = new Division();
            divideOperator.Calculate(4, 2);
        }

        static void Main(string[] args)
        {
            Number1();
            Number2();
        }
    }
}
