using UnityEngine;

public abstract class ChessPiece : MonoBehaviour
{
    public string Color { get; private set; } // "White" or "Black"
    public Vector2Int Position { get; private set; } // Position on the board

    // Constructor for the ChessPiece
    public ChessPiece(string color, Vector2Int position)
    {
        Color = color;
        Position = position;
    }

    // Abstract method for each piece to define its movement logic
    public abstract bool IsValidMove(Vector2Int newPosition);

    // Set position for the piece
    public void SetPosition(Vector2Int newPosition)
    {
        Position = newPosition;
    }

    // Additional behavior (optional): Move piece visually
    public void MovePiece(Vector2Int newPosition)
    {
        transform.position = new Vector3(newPosition.x, 0, newPosition.y);
        Position = newPosition;
    }
}