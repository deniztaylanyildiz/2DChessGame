using UnityEngine;

public class Board : MonoBehaviour
{
    public GameObject[] piecePrefabs; // Assign piece prefabs in the Unity editor
    private ChessPiece[,] board = new ChessPiece[8, 8];

    void Start()
    {
        SetupBoard();
    }

    void SetupBoard()
    {
        // Instantiate pawns
        for (int i = 0; i < 8; i++)
        {
            SpawnPiece("Pawn", "White", new Vector2Int(i, 1));
            SpawnPiece("Pawn", "Black", new Vector2Int(i, 6));
        }
        // Add other pieces...
    }

    void SpawnPiece(string type, string color, Vector2Int position)
    {
        GameObject pieceObject = Instantiate(piecePrefabs[0]); // Example: index 0 is a pawn prefab
        ChessPiece piece = pieceObject.GetComponent<ChessPiece>();
        piece.SetPosition(position);
        board[position.x, position.y] = piece;
    }
}