internal class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Masukan nama panggilan praktikan : ");
        string nama = Console.ReadLine();

        HaloGeneric.SapaUser(nama);
    }
    public class HaloGeneric()
    {
        public static void SapaUser<T>(T X)
        {
            Console.WriteLine("Halo user " + X);
        }
    }
}