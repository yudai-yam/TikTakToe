using System;

class ConsoleUI : IGameUI
{
    public ConsoleUI()
    {
        Console.WriteLine("Console UI constructor initialized");
    }

    public int DrawBoard()
}