namespace Maximum_Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            Maximum max=new Maximum();
            max.MaximumInt(7, 39, 98);
            max.Maximumfloat(12.33, 36.89, 22.68);
            max.Maximumstring("Apple", "Peach", "Banana");
        }
    }
}
