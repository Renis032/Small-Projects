using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

namespace Tetris
{
    public static class Program
    {
        static Random rnd = new Random();
        public static object RegEx { get; private set; }

        #region Settings
        static int tetrisRows = 20;
        static int tetrisCols = 10;

        static int[] scorePerLines = { 0, 40, 100, 300, 1200 };
        #endregion
        #region Figures
        static List<Figures> tetrisFigs = new List<Figures>()
        {
            new Figures(new bool[,] // I
            {
                {true },
                {true }, 
                {true },
                {true }
            }),
            new Figures(new bool[,] // O
            {
                {true, true },
                {true, true }
            }),
            new Figures(new bool[,] // T
            {
                {false, true, false },
                {true, true, true }
            }),
            new Figures(new bool[,] // S
            {
                {false, true, true },
                {true, true, false }
            }),
            new Figures(new bool[,] // Z
            {
                {true, true, false },
                {false, true, true }
            }),
            new Figures(new bool[,] // J
            {
                {true, false,false },
                {true, true, true }

            }),
            new Figures(new bool[,] // L
            {
                {false, false, true },
                {true, true, true }
            }),
        };
        #endregion
        #region  Values
        static GameState State = new GameState(tetrisRows,tetrisCols);
        #endregion

        static void Main()
        {
            ScoreManager scoreManager = new ScoreManager("scores.txt");
            //loops the theme song
            var music = new MusicPlayer();
            music.PlayMusic();
            
            var tetrisConsoleWriter = new TetrisConsoleWriter(tetrisRows, tetrisCols);

            //start with random figure
            State.CurrentFig = tetrisFigs[rnd.Next(0, tetrisFigs.Count)];
            //default start position
            State.CurrentFigCol = 3;


            while (true)
            {
                State.Frame++;

                //checks for pressed key
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Escape)
                    {
                        return;
                    }

                    //drops the figure one row and resets the frame so it does not skip rows
                    if (key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.S)
                    {
                        State.Frame = 1;
                        scoreManager.AddScore(scoreManager.Score);
                        State.CurrentFigRow++;
                    }

                    //if the figure has room to the left, it moves to the left
                    if (key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.A)
                    {
                        if (State.CurrentFigCol != 0)
                        {
                            State.CurrentFigCol--;
                        }
                    }

                    //if the figure has room to the right, it moves to the right
                    if (key.Key == ConsoleKey.RightArrow || key.Key == ConsoleKey.D)
                    {
                        if (State.CurrentFigCol < tetrisCols - State.CurrentFig.Height)
                        {
                            State.CurrentFigCol++;
                        }
                    }

                    if (key.Key == ConsoleKey.Spacebar || key.Key == ConsoleKey.W || key.Key == ConsoleKey.UpArrow)
                    {
                        var newFig = State.CurrentFig.GetRotate();

                        //if there is no collision with anythins, out figure rotates and becomes the new figure
                        if (!Collision(newFig))
                        {
                            State.CurrentFig = newFig;
                        }
                    }
                }
                //drops the figure 1 row automatically
                if (State.Frame % State.FramesToMoveFigure == 0)
                {
                    State.CurrentFigRow++;
                    State.Frame = 1;
                }
                //if it detects collision with the current figure
                if (Collision(State.CurrentFig))
                {
                    AddCurrentFigToTetrisField();
                    //checks for full lines
                    int lines = CheckForFullLines();
                    //adds the score corresponding to the lines removed
                    scoreManager.AddScore(scorePerLines[lines]);
                   
                    State.CurrentFig = tetrisFigs[rnd.Next(0, tetrisFigs.Count)];
                    State.CurrentFigRow = 0;
                    State.CurrentFigCol = 3;

                    //detects if it collides immediately with another object
                    if (Collision(State.CurrentFig))
                    {
                        scoreManager.AddScore(-1);
                        //puts information in the scores file
                        scoreManager.AddToHighScoreFile();
                        //puts the new score because it causes bugs 
                        //Write(State.Score.ToString(), 2, 3 + tetrisCols, ConsoleColor.Green);
                        tetrisConsoleWriter.DrawAll(State, scoreManager);
                        tetrisConsoleWriter.WriteGameOver(scoreManager.Score);

                        Thread.Sleep(100000);
                        return;
                    }
                }

                tetrisConsoleWriter.DrawAll(State, scoreManager);
                Thread.Sleep(41);
            }
        }

        
        static int CheckForFullLines()
        {
            int lines = 0;

            for (int row = 0; row < State.TetrisField.GetLength(0); row++)
            {
                bool rowIsFull = true;
                for (int col = 0; col < State.TetrisField.GetLength(1); col++)
                {
                    //if one of the coloums of the tetris field is false, it breaks one stage of the loop
                    if (State.TetrisField[row, col] == false)
                    {
                        //so the row is not full
                        rowIsFull = false;
                        break;
                    }
                }
                //if it is still true
                if (rowIsFull)
                {
                    //drop all the rows above 1 level
                    for (int rowToMove = row; rowToMove >= 1; rowToMove--)
                    {
                        for (int col = 0; col < State.TetrisField.GetLength(1); col++)
                        {
                            //the rows drops, but the columns stay the same
                            State.TetrisField[rowToMove, col] = State.TetrisField[rowToMove - 1, col];
                        }
                    }

                    lines++;
                }
            }
            //helps with scoring system
            return lines;
        }
       
        static bool Collision(Figures figure)
        {
            if (State.CurrentFigCol > tetrisCols - figure.Height)
            {
                //right border
                return true;
            }

            if (State.CurrentFigRow + figure.Width == tetrisRows)
            {
                //down border
                return true;
            }

            for (int row = 0; row < figure.Width; row++)
            {
                for (int col = 0; col < figure.Height; col++)
                {
                    //check if there is a collision between figures
                    if (figure.Body[row, col] && State.TetrisField[State.CurrentFigRow + row + 1, State.CurrentFigCol + col])
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        static void AddCurrentFigToTetrisField()
        {
            for (int row = 0; row < State.CurrentFig.Width; row++)
            {
                for (int col = 0; col < State.CurrentFig.Height; col++)
                {
                    if (State.CurrentFig.Body[row, col])
                    {
                        //transform tetris field's row and col to true
                        State.TetrisField[State.CurrentFigRow + row, State.CurrentFigCol + col] = true;
                    }
                }
            }
        }
    
    }
}