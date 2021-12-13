using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class Figures
    {

        public Figures(bool[,] body)
        {
            this.Body = body;
        }

        public bool[,] Body { get; set; }

        public int Width => this.Body.GetLength(0);
        public int Height => this.Body.GetLength(1);

        public Figures GetRotate()
        {
            var newFig = new bool[this.Height, this.Width];
            //rotated the row to column / 90 degree rotation clockwise
            for (int row = 0; row < this.Width; row++)
            {
                for (int col = 0; col < this.Height; col++)
                {
                    newFig[col, this.Width - row - 1] = this.Body[row, col];
                }
            }

            return new Figures(newFig);
        }
    }
}