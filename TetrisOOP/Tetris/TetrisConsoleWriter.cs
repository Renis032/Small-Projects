using System;

namespace Tetris
{
    public class TetrisConsoleWriter
    {
        private int tetrisRows = 20;
        private int tetrisCols = 10;
        private int infoCols;
        private int consoleRows;
        private int consoleCols;

        public TetrisConsoleWriter(int tetrisRow = 20, int tetrisCols = 10, int infoCols = 11)
        {
            this.tetrisCols = tetrisCols;
            this.infoCols = infoCols;
            this.consoleRows = 1 + this.tetrisRows + 1;
            this.consoleCols = 1 + tetrisCols + 1 + infoCols + 1;

            Console.WindowHeight = this.consoleRows + 1;
            Console.WindowWidth = this.consoleCols;
            Console.BufferHeight = this.consoleRows + 1;
            Console.BufferWidth = this.consoleCols;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Title = "Tetris v1.1";
            Console.CursorVisible = false;
        }

        public void DrawAll(GameState State, ScoreManager scoreManager)
        {
            this.DrawBorder();
            this.DrawGameState(3 + tetrisCols, State, scoreManager);
            this.DrawTetrisField(State.TetrisField);
            this.DrawCurrentFig(State.CurrentFig, State.CurrentFigRow, State.CurrentFigCol);
        }
        private void Write(string text, int row, int col, ConsoleColor color = ConsoleColor.Yellow)
        {
            //self explanatory
            Console.ForegroundColor = color;
            Console.SetCursorPosition(col, row);
            Console.Write(text);
            Console.ResetColor();
        }

        public void DrawGameState(int startCol, GameState state, ScoreManager scoreManager)
        {
            this.Write("Score:", 1, startCol, ConsoleColor.Green);
            this.Write(scoreManager.Score.ToString(), 2, startCol, ConsoleColor.Green);
            this.Write("HighScore:", 4, startCol, ConsoleColor.Blue);
            this.Write(scoreManager.HighScore.ToString(), 5, startCol, ConsoleColor.Blue);
            this.Write("Made by:", 18, startCol, ConsoleColor.Cyan);
            this.Write($"Renis", 19, startCol, ConsoleColor.Cyan);
        }

        public void DrawBorder()
        {
            //just draws the borders at the posisions
            Console.SetCursorPosition(0, 0);
            string line = "╔";
            for (int i = 0; i < this.tetrisCols; i++)
            {
                line += "═";
            }
            line += "╦";

            for (int i = 0; i < this.infoCols; i++)
            {
                line += "═";
            }
            line += "╗";
            Console.Write(line);

            //draws for each row the borders and spaces
            for (int i = 0; i < this.tetrisRows; i++)
            {
                string middleLine = "║";
                middleLine += new string(' ', this.tetrisCols);
                middleLine += "║";
                middleLine += new string(' ', this.infoCols);
                middleLine += "║";
                Console.Write(middleLine);
            }

            //same here
            string endLine = "╚";
            endLine += new string('═', this.tetrisCols);
            endLine += "╩";
            endLine += new string('═', this.infoCols);
            endLine += "╝";
            Console.Write(endLine);
        }

        public void WriteGameOver(int score)
        {
            int row = this.tetrisRows / 2;
            int col = (this.tetrisCols + 3 + this.infoCols) / 2 - 6;
            var scoreAsString = score.ToString();
            scoreAsString += new string(' ', 7 - scoreAsString.Length);
            Write("╔════════════╗", row, 5);
            Write("║    Game    ║", row + 1, col);
            Write("║    Over!   ║", row + 2, col);
            Write("║    Score:  ║", row + 3, col);
            Write($"║    {scoreAsString} ║", row + 4, col);
            Write("╚════════════╝", row + 5, col);
        }

        public void DrawCurrentFig(Figures currentFig, int currentFigRow, int currentFigCol)
        {
            for (int row = 0; row < currentFig.Body.GetLength(0); row++)
            {
                for (int col = 0; col < currentFig.Body.GetLength(1); col++)
                {
                    //wherever is our current figure, it places "*" on its position
                    if (currentFig.Body[row, col] == true)
                    {
                        Write("*", row + 1 + currentFigRow, col + 1 + currentFigCol, ConsoleColor.Green);
                    }
                }
            }
        }

        public void DrawTetrisField(bool[,] tetrisField)
        {
            for (int row = 0; row < tetrisField.GetLength(0); row++)
            {
                for (int col = 0; col < tetrisField.GetLength(1); col++)
                {
                    //if elements from the tetris field are true, it prints "*" 
                    if (tetrisField[row, col] == true)
                    {
                        Write("*", row + 1, col + 1);
                    }
                }
            }
        }
    }
}
