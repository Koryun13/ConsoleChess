using System;

namespace ChessBoardClass.Shared;

public struct Coordinate
{
    public int X { get; private set; }
    public int Y { get; private set; }

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

        X = '8' - rowChar;
        Y = columnChar - 'A';
    }

    private Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }

    public static readonly string[] AllCoordinates = {
            "A1", "B1", "C1", "D1", "E1", "F1", "G1", "H1",
            "A2", "B2", "C2", "D2", "E2", "F2", "G2", "H2",
            "A3", "B3", "C3", "D3", "E3", "F3", "G3", "H3",
            "A4", "B4", "C4", "D4", "E4", "F4", "G4", "H4",
            "A5", "B5", "C5", "D5", "E5", "F5", "G5", "H5",
            "A6", "B6", "C6", "D6", "E6", "F6", "G6", "H6",
            "A7", "B7", "C7", "D7", "E7", "F7", "G7", "H7",
            "A8", "B8", "C8", "D8", "E8", "F8", "G8", "H8"
        };

    public static (int X, int Y) SetCoordinate(string coordinateString)
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

        int x = '8' - rowChar;
        int y = columnChar - 'A';

        return (x, y);
    }

    public static Coordinate operator +(Coordinate c1, Coordinate c2)
        {
            return new Coordinate(c1.X + c2.X, c1.Y + c2.Y);
        }

        public static Coordinate operator -(Coordinate c1, Coordinate c2)
        {
            return new Coordinate(c1.X - c2.X, c1.Y - c2.Y);
        }

        public static bool operator ==(Coordinate c1, Coordinate c2)
        {
            return c1.X == c2.X && c1.Y == c2.Y;
        }

        public static bool operator !=(Coordinate c1, Coordinate c2)
        {
            return !(c1 == c2);
        }
}