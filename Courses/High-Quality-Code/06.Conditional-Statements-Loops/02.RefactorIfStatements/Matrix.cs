using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorIfStatements
{
    public class Matrix
    {
        private int x = 0;
        private int y = 5;
        private bool isVisited = true;
       
        public void VisitCell()
        {
            bool isInRange = CheckIsInRange(x, y);

            if (isInRange && !isVisited)
            {
                isVisited = true;
            }
        }

        public bool CheckIsInRange(int x, int y)
        {
            const int MinX = 0;
            const int MaxX = 100;
            const int MinY = 0;
            const int MaxY = 50;

            bool xInRange = MinX <= x && x <= MaxX;
            bool yInRange = MinY <= y && y <= MaxY;

            return xInRange && yInRange;
        }
    }
}
