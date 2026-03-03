public class Player : IPlayer
{
    private readonly IGameUI _ui;

    public Player(IGameUI ui)
    {
        this._ui = ui;
    }  
    
    public (int row, int column) GetMove(Board board)
    {
       return _ui.GetPlayerMove(); 
    }
}