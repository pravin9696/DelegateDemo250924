
namespace DelegateDemo250924
{
    class class1
    {
        public void multiplication(int m,int n )
        {
            Console.WriteLine("Multiplication method called..");
            Console.WriteLine("Result="+m*n);
        }
        public void sum(int x,int y)
        {
            Console.WriteLine("SUM method called..");
            Console.WriteLine(x+y);
        }
        public float Total(float f1,float f2)
        {
            return f1 + f2;
        }
    }
    class XYZ
    {
        public bool isPrime(int n)
        {
            return true;
        }
        public void Addition(int P, int Q)
        {
            Console.WriteLine("addition method called..");
            int ans = P + Q;
            Console.WriteLine($"Addition of {P} AND {Q} is "+ans);
        }
    }
    internal class Program
    {
        public delegate void del1(int a, int b);//delegate declaration
        public delegate float myDelegate2(float f1, float f2);
        static void Main(string[] args)
        {

            //class1 obj1=new class1();



            // del1 dd1 = new del1(obj1.sum);//0X0001

            // dd1(100, 200);//300


            // dd1 = new del1(new XYZ().Addition);//0X0002

            // dd1(100, 200);


            //----------------------------------------------------
            //method chaining

            //del1 dd1 = new del1(new class1().sum);

            //dd1 += new XYZ().Addition;
            //dd1 += new class1().multiplication;
            //int n1 = 111;
            //int n2 = 222;
            //dd1.Invoke(n1, n2);
            //----------------------------------------------------

            myDelegate2 md2 = new myDelegate2((new class1()).Total);

            //float T= md2(1.1f, 2.2f);
            float T = md2.Invoke(111, 222);
            Console.WriteLine(T);
            var nn=Math.Sqrt(4);
        }
    }
}
