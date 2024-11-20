using UnityEngine;
using UnityEngine.UIElements;

public class Pawn : ChessPiece
{
    public Pawn(string color, Vector2Int position) : base(color, position) { }

    public override bool IsValidMove(Vector2Int newPosition)
    {
        // Example movement logic for a Pawn
        if (Color == "White")
        {
            // White pawns move forward (y + 1)
            return (newPosition.x == Position.x && newPosition.y == Position.y + 1);
        }
        else
        {
            // Black pawns move forward (y - 1)
            return (newPosition.x == Position.x && newPosition.y == Position.y - 1);
        }
    }
}