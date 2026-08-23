namespace _16_OOP_6_Interface_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    interface IInsan
    {
        public int Boy { get; set; }
        public int Agirlik { get; set; }
    }

    interface IVatandas
    {
        public long TC { get; set; }
    }

    class IK : IInsan, IVatandas
    {
        public int Boy { get; set; }
        public int Agirlik { get; set; }
        public long TC { get; set; }
    }
}
