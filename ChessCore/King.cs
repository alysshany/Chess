//Galieva Zilya 220, ChessTask, 12/04/22
using System;

namespace ChessCore
{
    public class King : Figure
    {
        public King(string s) : base(s) { }

        public override bool IsRightMove(int x1, int y1)
        {
            return (Math.Abs(X - x1) <= 1 && Math.Abs(Y - y1) <= 1);
        }
    }
}