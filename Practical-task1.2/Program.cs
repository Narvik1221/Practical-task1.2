namespace ConsoleApp4
{


    class Figure

    {
        private double _square;
        private string name;
        


        

        public Figure(double height, double a )
        {
            _square = 0.5*(a*height);
            name = "triangle area: ";

        }
        public Figure(double height, double a, double b)
        {
            _square = 0.5 * height*(a + b);
            name = "trapezoid area: ";


        }
        public Figure(double a)
        {
            _square = Math.Pow(a,2);
            name = "square area: ";

        }
        public string Name
        {

            get { return name; }
        }


        public double Square
        {
           
            get { return _square; }
        }
      



    }
    class Func
    {
        public double X;
        public double S;
        public double func(double x)
        {
            S = x - 2 + Math.Exp(x);
            
            return S;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
             Figure square = new Figure(5);
            Console.WriteLine(square.Name + square.Square);
             Figure triangle=new Figure(4,3);
            Console.WriteLine(triangle.Name +  triangle.Square);
             Figure trapezoid = new Figure(4, 3,5);
             Console.WriteLine(trapezoid.Name +  trapezoid.Square);
             
           
        }
    }
}