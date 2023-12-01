﻿using System;
class Jogador
{
    public string Nome { get; set; }
    public string Nacionalidade { get; set; }
    public int Idade { get; set; }
    public string Posicao { get; set; }

    public Jogador(){}
}
class Program
{
    static void Main()
    {
        Jogador jogador = new Jogador();
        jogador.Nome = Console.ReadLine();
        jogador.Nacionalidade = Console.ReadLine();
        jogador.Idade = int.Parse(Console.ReadLine());
        jogador.Posicao = Console.ReadLine();
        
        Console.WriteLine($"Jogador criado!\n{jogador.Nome}\n{jogador.Nacionalidade}\n{jogador.Idade}\nPosição: {jogador.Posicao}");       
    }
}