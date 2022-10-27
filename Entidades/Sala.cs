using System.Diagnostics.Tracing;

namespace Entidades
{
    public static class Sala
    {
        private static List<Dado> dados;
        private static List<Dado> posibleEscalera;
        private static List<Dado> posibleFullPokerGenerala;
        private static Cubilete cubilete;
        public static int mano;

        static Sala()
        {
            dados = new List<Dado>();
            cubilete = new Cubilete(Dados);
            mano = 0;
            posibleEscalera = new List<Dado>();
            posibleFullPokerGenerala = new List<Dado>();
        }

        public static Cubilete Cubilete { get => cubilete;}
        public static List<Dado> Dados { get => dados; set => dados = value; }
        public static List<Dado> PosibleEscalera { get => posibleEscalera; set => posibleEscalera = value; }
        public static List<Dado> PosibleFullPokerGenerala { get => posibleFullPokerGenerala; set => posibleFullPokerGenerala = value; }
    }
}