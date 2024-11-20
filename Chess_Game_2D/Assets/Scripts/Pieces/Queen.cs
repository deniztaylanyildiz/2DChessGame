using UnityEngine;

public class Queen : ChessPiece
{
    public Queen(string color, Vector2Int position) : base(color, position) { }

    public override bool IsValidMove(Vector2Int newPosition)
    {
        // Queen moves like both a Rook and a Bishop: any number of squares in a row, column, or diagonal
        int dx = Mathf.Abs(newPosition.x - Position.x);
        int dy = Mathf.Abs(newPosition.y - Position.y);

        return (dx == 0 || dy == 0 || dx == dy); // Vertical, Horizontal or Diagonal
    }
}