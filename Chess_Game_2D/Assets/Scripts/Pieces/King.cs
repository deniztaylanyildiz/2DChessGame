using UnityEngine;

public class Knight : ChessPiece
{
    public Knight(string color, Vector2Int position) : base(color, position) { }

    public override bool IsValidMove(Vector2Int newPosition)
    {
        // Knight moves in "L" shape: 2 squares in one direction, 1 in the other
        int dx = Mathf.Abs(newPosition.x - Position.x);
        int dy = Mathf.Abs(newPosition.y - Position.y);
        return (dx == 2 && dy == 1) || (dx == 1 && dy == 2);
    }
}