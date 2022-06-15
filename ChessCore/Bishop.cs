//Galieva Zilya 220, ChessTask, 12/04/22
using System;

namespace ChessTaskCore
{
    public class Bishop : Figure
    {
        public Bishop(string s) : base(s) { }

        public override bool IsRightMove(int x1, int y1)
        {
            return (Math.Abs(X - x1) == Math.Abs(Y - y1));
        }
    }
}