namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Calculations
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }
        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            return a / b;
        }
        public int Mid(int x, int y, int z)
        { // return median of x, y, z
            int mid = z;
            if (y < z)  //if-0
            {
                if (x < y)  //if-1
                {
                    mid = y;
                }
                else if (x < z) //if-2
                {
                    mid = x;
                }
            }
            else
            {
                if (x > y) //if-3
                {
                    mid = y;
                }
                else if (x > z) //-if-4
                {
                    mid = x;
                }
            }
            return mid;
        }
    }
}