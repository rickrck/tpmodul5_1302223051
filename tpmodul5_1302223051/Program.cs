internal class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Masukan nama panggilan praktikan : ");
        string nama = Console.ReadLine();

        HaloGeneric.SapaUser(nama);

        Console.Write("Masukan NIM praktikan : ");
        string nim = Console.ReadLine();

        DataGeneric<string> dataNIM = new DataGeneric<string>(nim);
        dataNIM.PrintData();
    }
    public class HaloGeneric()
    {
        public static void SapaUser<T>(T X)
        {
            Console.WriteLine("Halo user " + X);
        }
    }
    public class DataGeneric<T>()
    {
        private T data;

        public DataGeneric(T userInput) : this()
        {
            data = userInput;
        }

        public void PrintData()
        {
            T Y = data;
            Console.WriteLine("Data yang tersimpan adalah : " + Y);
        }
    }
}