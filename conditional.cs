namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {

            string a = "3782";
            var b = Convert.ToInt32(a);

            double c = b / 100;

            var x = c % 10;
            var y = a[1];


            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine(x == 7 && y == 7 ? "You are correct" : "You are wrong");


        }

    }

} 
