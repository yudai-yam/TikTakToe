using System;
using System.Data;

public interface IPlayer
{
    (int row, int column) GetMove(Board Board);
}
