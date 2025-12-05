public class Board
{
    public Piece[,] Grid { get; set; } = new Piece[8,8];

    public void Initialize()
    {
        // לדוגמה, יצירת פיון לבן בשורה 1
        for (int i = 0; i < 8; i++)
        {
            Grid[i,1] = new Piece { Type = PieceType.Pawn, Color = PieceColor.White, Position = new Vector2(i,1) };
        }
    }
}
