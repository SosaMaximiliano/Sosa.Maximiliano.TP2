namespace ConsoleApp1
{
    internal class Program
    {
        delegate int BuscarMayorNumero(List<int> lista);

        static int BuscarMayor(List<int> lista)
        {
            return lista.OrderByDescending(x => x).First();
        }


        static void Main(string[] args)
        {
            BuscarMayorNumero delegado = BuscarMayor;

            Console.WriteLine(delegado(new List<int> { 2, 4, 8, 7, 7, 16, 9, 4, 7 }));


        }
    }
}