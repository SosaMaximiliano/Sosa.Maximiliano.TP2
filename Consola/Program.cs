// See https://aka.ms/new-console-template for more information
using Entidades;

Jugador jugador = new Jugador("Max", "Payne", 1);
TirarDados tirar = jugador.TirarDados;



jugador.JugarMano();
jugador.GuardarDados(Sala.Dados);
Console.WriteLine(Jugador.MostrarDadosGuardados(jugador.DadosParaEscalera, jugador.DadosParaFullPokerGenerala));
Console.WriteLine();

jugador.JugarMano();
jugador.GuardarDados(Sala.Dados);
Console.WriteLine(Jugador.MostrarDadosGuardados(jugador.DadosParaEscalera, jugador.DadosParaFullPokerGenerala));
Console.WriteLine();

jugador.JugarMano();
jugador.GuardarDados(Sala.Dados);
Console.WriteLine(Jugador.MostrarDadosGuardados(jugador.DadosParaEscalera, jugador.DadosParaFullPokerGenerala));
Console.WriteLine();