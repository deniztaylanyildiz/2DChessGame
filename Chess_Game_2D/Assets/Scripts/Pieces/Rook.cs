using UnityEngine;

public class Rook : ChessPiece
{
    public Rook(string color, Vector2Int position) : base(color, position) { }

    public override bool IsValidMove(Vector2Int newPosition)
    {
        // Rook moves in straight lines: vertical or horizontal
        return (newPosition.x == Position.x || newPosition.y == Position.y);
    }
}