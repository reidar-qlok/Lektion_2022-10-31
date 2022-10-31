namespace Lektion_2022_10_31
{
    public delegate void ExDelegate(int x, int y);
    public class Mat
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("Add resultatet: {0}", a+b );
        }
        public void Sub(int c, int d)
        {
            Console.WriteLine("Sub resultatet: {0}", c - d);
        }
        public void Mult(int e, int f)
        {
            Console.WriteLine("Mult resultatet: {0}", e * f);
        }

    }
    internal class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Delegate");
            Mat m = new Mat();
            ExDelegate dlg = m.Add;
            dlg += m.Sub;
            dlg += m.Mult;
            dlg(10, 12);
        }
    }
}