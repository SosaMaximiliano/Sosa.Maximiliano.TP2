using System.Diagnostics.Tracing;

namespace Entidades
{
    public static class Sala
    {
        private static List<Dado> dados;
        private static Cubilete cubilete;
        public static int mano;

        static Sala()
        {
            dados = new List<Dado>();
            cubilete = new Cubilete(Dados);
            mano = 0;
        }

        public static Cubilete Cubilete { get => cubilete;}
        public static List<Dado> Dados { get => dados; set => dados = value; }
    }
}