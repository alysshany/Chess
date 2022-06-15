//Galieva Zilya 220, ChessTask, 12/04/22
using System;

namespace ChessTaskCore
{
    public class Rook : Figure
    {
        public Rook(string s) : base(s) { }

        public override bool IsRightMove(int x1, int y1)
        {
            return (X == x1 || Y == y1);
        }
    }
}