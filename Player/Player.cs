using System;

public class Player : IPlayer
{
    private string _name;
    private readonly IGameUI _ui;

    public Player(string name, IGameUI ui)
    {
        this._name = name;
        this._ui = ui;
    }  
    
    public (int row, int column) GetMove(Board Board)
    {
       return _ui.GetPlayerMove(); 
    }
}