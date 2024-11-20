using UnityEngine;

public class Bishop : ChessPiece
{
    public Bishop(string color, Vector2Int position) : base(color, position) { }

    public override bool IsValidMove(Vector2Int newPosition)
    {
        // Bishop moves diagonally
        int dx = Mathf.Abs(newPosition.x - Position.x);
        int dy = Mathf.Abs(newPosition.y - Position.y);
        return (dx == dy);
    }
}