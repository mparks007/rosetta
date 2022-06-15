namespace datatypes
{
    partial class Program
    {
        interface IShape
        {
            double GetArea();
        }

        class Square : IShape
        {
            private double _side;

            public double Side
            {
                get => _side;
                set => _side = value;
            }

            public Square() { }

            public Square(double side)
            {
                Side = side;
            }

            public virtual double GetArea()
            {
                return Side * Side;
            }

            public override string ToString() => $"Side:{Side}";
        }

        class Rectangle : IShape
        {
            private double _height;
            private double _width;

            public double Height
            {
                get => _height;
                set => _height = value;
            }

            public double Width
            {
                get => _width;
                set => _width = value;
            }

            public Rectangle() { }

            public Rectangle(double height, double width)
            {
                Height = height;
                Width = width;
            }

            public virtual double GetArea()
            {
                return Height * Width;
            }

            public override string ToString() => $"Height:{Height}, Width:{Width}";
        }
    }
}