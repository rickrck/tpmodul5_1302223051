internal class Program
{
    public class HaloGeneric()
    {
        public static void SapaUser<T>(T X)
        {
            Console.WriteLine("Halo user " + X);
        }
    }
}