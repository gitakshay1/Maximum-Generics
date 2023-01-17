namespace Maximum_Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            Maximum max=new Maximum();
            max.Max(7, 39, 98);
            max.Max(12.33, 36.89, 22.68);
            max.Max("Apple", "Peach", "Banana");
        }
    }
}
