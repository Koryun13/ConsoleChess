namespace ChessBoardClass.Shared;

public struct Coordinate
{
    public int X { get; }
    public int Y { get; }

    public Coordinate(string coordinateString)
    {
        if (coordinateString.Length != 2)
        {
            throw new ArgumentException("Invalid coordinate string.");
        }

        char columnChar = char.ToUpper(coordinateString[0]);
        char rowChar = coordinateString[1];

        if (columnChar < 'A' || columnChar > 'H' || rowChar < '1' || rowChar > '8')
        {
            throw new ArgumentException("Invalid coordinate string.");
        }

        X = rowChar - '1';
        Y = columnChar - 'A';
    }
}
