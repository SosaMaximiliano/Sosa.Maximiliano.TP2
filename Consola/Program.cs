// See https://aka.ms/new-console-template for more information
using Entidades;

Jugador jugador = new Jugador("Max", "Payne", 1);
TirarDados tirar = jugador.TirarDados;

//Sala.Dados.ForEach(dado => Console.WriteLine(dado));

jugador.JugarMano();
//Console.WriteLine(Jugador.MostrarDadosGuardados(jugador.DadosParaEscalera, jugador.DadosParaFullPokerGenerala));
Console.WriteLine();

jugador.JugarMano();
//Console.WriteLine(Jugador.MostrarDadosGuardados(jugador.DadosParaEscalera, jugador.DadosParaFullPokerGenerala));
Console.WriteLine();

jugador.JugarMano();
//Console.WriteLine(Jugador.MostrarDadosGuardados(jugador.DadosParaEscalera, jugador.DadosParaFullPokerGenerala));
Console.WriteLine();



