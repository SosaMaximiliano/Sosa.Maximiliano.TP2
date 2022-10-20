namespace Entidades
{
    public static class Sala
    {
        private static List<Dado> dados;
        private static Cubilete cubilete;

        static Sala()
        {
            dados = new List<Dado>();
            cubilete = new Cubilete(Dados);

        }

        public static Cubilete Cubilete { get => cubilete;}
        public static List<Dado> Dados { get => dados; set => dados = value; }
    }
}