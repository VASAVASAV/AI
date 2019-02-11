using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euristic
{
    class Cell
    {
        public List<Cell> NeighBors;
        public Cell Ancestor = null;
        public double Val;
        public double f;  
        public int x, y;
        public double Cost;
        public Cell(int NewX, int NewY)
        {
            x = NewX;
            y = NewY;
            NeighBors = new List<Cell>();
        }

        public void AddNeigh(Cell newCell)
        {
            NeighBors.Add(newCell);
        }
    }
}
