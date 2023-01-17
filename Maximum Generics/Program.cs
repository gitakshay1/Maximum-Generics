namespace Maximum_Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            Maximum<int> maxint=new Maximum<int>();
            maxint.Max(7, 39, 98);
            Maximum<double> maxdouble = new Maximum<double>();
            maxdouble.Max(12.33, 36.89, 22.68);
            Maximum<string> maxstring = new Maximum<string>();
            maxstring.Max("Apple", "Peach", "Banana");
        }
    }
}
