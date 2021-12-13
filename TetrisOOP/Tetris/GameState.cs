using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class GameState
    {
        public int Frame { get; set; }
        public int FramesToMoveFigure { get; private set; }
        public Figures CurrentFig { get; set; }
        public int CurrentFigRow { get; set; }
        public int CurrentFigCol { get; set; }
        public bool[,] TetrisField { get; private set; }

        public GameState(int tetrisRows, int tetrisCols)
        {
            this.Frame = 0;
            this.FramesToMoveFigure = 20;
            this.CurrentFig = null;
            this.CurrentFigRow = 0;
            this.CurrentFigCol = 0;
            this.TetrisField = new bool[tetrisRows, tetrisCols];
        }

    }
}
