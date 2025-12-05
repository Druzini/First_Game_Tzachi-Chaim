public enum PieceType { King, Queen, Rook, Bishop, Knight, Pawn }
public enum PieceColor { White, Black }

public class Piece
{
    public PieceType Type { get; set; }
    public PieceColor Color { get; set; }
    public Vector2 Position { get; set; } // מיקום על הלוח
}
public struct Vector2
{
    public int X { get; set; }
    public int Y { get; set; }

    public Vector2(int x, int y)
    {
        X = x;
        Y = y;
    }
}