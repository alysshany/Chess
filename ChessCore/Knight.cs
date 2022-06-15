//Galieva Zilya 220, ChessTask, 12/04/22
using System;

namespace ChessTaskCore
{
    public class Knight : Figure
    {
        public Knight(string s) : base(s) { }

        public override bool IsRightMove(int x1, int y1)
        {
            return ((Math.Abs(X - x1) == 2 && Math.Abs(Y - y1) == 1) ||
                    (Math.Abs(X - x1) == 1 && Math.Abs(Y - y1) == 2));
        }
    }
}