using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

namespace Tetris
{
    class Program
    {
        static Random rnd = new Random();

        #region Settings
        static int tetrisRows = 20;
        static int tetrisCols = 10;
        static int infoCols = 10;
        static int consoleRows = 1 + tetrisRows + 1;
        static int consoleCols = 1 + tetrisCols + 1 + infoCols + 1;
        static string ScoresFile = "scores.txt";
        static int[] scorePerLines = { 0, 40, 100, 300, 1200 };
        #endregion
        #region Figures
        static List<bool[,]> tetrisFigs = new List<bool[,]>()
        {
            new bool[,] // I
            {
                {true, true, true ,true }
            },
            new bool[,] // O
            {
                {true, true },
                {true, true }
            },
            new bool[,] // T
            {
                {false, true, false },
                {true, true, true }
            },
            new bool[,] // S
            {
                {false, true, true },
                {true, true, false }
            },
            new bool[,] // Z
            {
                {true, true, false },
                {false, true, true }
            },
            new bool[,] // J
            {
                {true, false,false },
                {true, true, true }

            },
            new bool[,] // L
            {
                {false, false, true },
                {true, true, true }
            },
        };
        #endregion
        #region  Values
        static int highScore = 0;
        static int score = 0;
        static int frame = 0;
        static int framesToMoveFigure = 20;
        static bool[,] currentFig = tetrisFigs[0];
        static int currentFigRow = 0;
        static int currentFigCol = 0;
        static bool[,] tetrisField = new bool[tetrisRows, tetrisCols];

        public static object RegEx { get; private set; }
        #endregion

        static void Main(string[] args)
        {
            
            if (File.Exists(ScoresFile))
            {
                var allScores = File.ReadAllLines(ScoresFile);
                foreach (var score in allScores)
                {
                    var match = Regex.Match(score, @"=> (?<score>[0-9]+)");
                    //highscore takes the max value from the list
                    highScore = Math.Max(highScore, int.Parse(match.Groups["score"].Value) - 1);
                }
            }
            //loops the theme song
            var thread = new Thread(() =>
            {
                Sound();
            });
            thread.Start();

            Console.Title = "Tetris v1.0";
            Console.WindowHeight = consoleRows + 1;
            Console.WindowWidth = consoleCols;
            Console.BufferHeight = consoleRows + 1;
            Console.BufferWidth = consoleCols;
            Console.CursorVisible = false;

            //start with random figure
            currentFig = tetrisFigs[rnd.Next(0, tetrisFigs.Count)];
            //default start position
            currentFigCol = 3;


            while (true)
            {
                frame++;

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
                        frame = 1;
                        score++;
                        currentFigRow++;
                    }

                    //if the figure has room to the left, it moves to the left
                    if (key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.A)
                    {
                        if (currentFigCol != 0)
                        {
                            currentFigCol--;
                        }
                    }

                    //if the figure has room to the right, it moves to the right
                    if (key.Key == ConsoleKey.RightArrow || key.Key == ConsoleKey.D)
                    {
                        if (currentFigCol < tetrisCols - currentFig.GetLength(1))
                        {
                            currentFigCol++;
                        }
                    }

                    if (key.Key == ConsoleKey.Spacebar || key.Key == ConsoleKey.W || key.Key == ConsoleKey.UpArrow)
                    {
                        RotateCurrentFig();
                    }
                }
                //drops the figure 1 row automatically
                if (frame % framesToMoveFigure == 0)
                {
                    currentFigRow++;
                    frame = 1;
                }
                //if it detects collision with the current figure
                if (Collision(currentFig))
                {
                    AddCurrentFigToTetrisField();
                    //checks for full lines
                    int lines = CheckForFullLines();
                    //adds the score corresponding to the lines removed
                    score += scorePerLines[lines];

                    //gives the next random figure and puts it in the center at the beginning
                    currentFig = tetrisFigs[rnd.Next(0, tetrisFigs.Count)];
                    currentFigRow = 0;
                    currentFigCol = 3;

                    //detects if it collides immediately with another object
                    if (Collision(currentFig))
                    {
                        score--;
                        //puts information in the scores file
                        File.AppendAllLines(ScoresFile, new List<string>
                        {
                            $"[{DateTime.Now.ToString()}] {Environment.UserName} => {score}"
                        });
                        //puts the new score because it causes bugs 
                        Write(score.ToString(), 2, 3 + tetrisCols, ConsoleColor.Green);
                        var scoreAsString = score.ToString();
                        scoreAsString += new string(' ', 7 - scoreAsString.Length);
                        Write("╔════════════╗", 5, 5);
                        Write("║    Game    ║", 6, 5);
                        Write("║    Over!   ║", 7, 5);
                        Write("║    Score:  ║", 8, 5);
                        Write($"║    {scoreAsString} ║", 9, 5);
                        Write("╚════════════╝", 10, 5);
                        Thread.Sleep(100000);
                        return;
                    }
                }

                //1. Draws the border.
                DrawBorder();
                //2. Draws the information on the right side.
                DrawInfo();
                //3. Draws the tetris field.
                DrawTetrisField();
                //4. Draws the current figure on top of everything
                DrawCurrentFig();
                //5. The thread delays so it can be just like the original game
                Thread.Sleep(41);
            }
        }

        static void RotateCurrentFig()
        {
            var newFig = new bool[currentFig.GetLength(1), currentFig.GetLength(0)];
            //rotated the row to column / 90 degree rotation clockwise
            for (int row = 0; row < currentFig.GetLength(0); row++)
            {
                for (int col = 0; col < currentFig.GetLength(1); col++)
                {
                    newFig[col, currentFig.GetLength(0) - row - 1] = currentFig[row, col];
                }
            }
            //if there is no collision with anythins, out figure rotates and becomes the new figure
            if (!Collision(newFig))
            {
                currentFig = newFig;
            }
        }
        static int CheckForFullLines()
        {
            int lines = 0;

            for (int row = 0; row < tetrisField.GetLength(0); row++)
            {
                bool rowIsFull = true;
                for (int col = 0; col < tetrisField.GetLength(1); col++)
                {
                    //if one of the coloums of the tetris field is false, it breaks one stage of the loop
                    if (tetrisField[row, col] == false)
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
                        for (int col = 0; col < tetrisField.GetLength(1); col++)
                        {
                            //the rows drops, but the columns stay the same
                            tetrisField[rowToMove, col] = tetrisField[rowToMove - 1, col];
                        }
                    }

                    lines++;
                }
            }
            //helps with scoring system
            return lines;
        }
        static void Write(string text, int row, int col, ConsoleColor color = ConsoleColor.Yellow)
        {
            //self explanatory
            Console.ForegroundColor = color;
            Console.SetCursorPosition(col, row);
            Console.Write(text);
            Console.ResetColor();
        }
        static void DrawBorder()
        {
            //just draws the borders at the posisions
            Console.SetCursorPosition(0, 0);
            string line = "╔";
            for (int i = 0; i < tetrisCols; i++)
            {
                line += "═";
            }
            line += "╦";

            for (int i = 0; i < infoCols; i++)
            {
                line += "═";
            }
            line += "╗";
            Console.Write(line);

            //draws for each row the borders and spaces
            for (int i = 0; i < tetrisRows; i++)
            {
                string middleLine = "║";
                middleLine += new string(' ', tetrisCols);
                middleLine += "║";
                middleLine += new string(' ', infoCols);
                middleLine += "║";
                Console.Write(middleLine);
            }

            //same here
            string endLine = "╚";
            endLine += new string('═', tetrisCols);
            endLine += "╩";
            endLine += new string('═', infoCols);
            endLine += "╝";
            Console.Write(endLine);
        }
        static void DrawInfo()
        {
            //if the current score is bigger than the highscore, the highscore becomes the score
            if (score > highScore)
            {
                highScore = score;
            }
            
            Write("Score:", 1, 3 + tetrisCols, ConsoleColor.Green);
            Write(score.ToString(), 2, 3 + tetrisCols, ConsoleColor.Green);
            Write("Best:", 4, 3 + tetrisCols, ConsoleColor.Blue);
            Write(highScore.ToString(), 5, 3 + tetrisCols, ConsoleColor.Blue);
            Write("Made by:", 18, 3 + tetrisCols, ConsoleColor.Cyan);
            Write($"Renis", 19, 3 + tetrisCols, ConsoleColor.Cyan);

        }
        static void DrawCurrentFig()
        {
            for (int row = 0; row < currentFig.GetLength(0); row++)
            {
                for (int col = 0; col < currentFig.GetLength(1); col++)
                {
                    //wherever is our current figure, it places "*" on its position
                    if (currentFig[row, col] == true)
                    {
                        Write("*", row + 1 + currentFigRow, col + 1 + currentFigCol, ConsoleColor.Green);
                    }
                }
            }
        }
        static void DrawTetrisField()
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
        static bool Collision(bool[,] figure)
        {
            if (currentFigCol > tetrisCols - figure.GetLength(1))
            {
                //right border
                return true;
            }

            if (currentFigRow + figure.GetLength(0) == tetrisRows)
            {
                //down border
                return true;
            }

            for (int row = 0; row < figure.GetLength(0); row++)
            {
                for (int col = 0; col < figure.GetLength(1); col++)
                {
                    //check if there is a collision between figures
                    if (figure[row, col] && tetrisField[currentFigRow + row + 1, currentFigCol + col])
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        static void AddCurrentFigToTetrisField()
        {
            for (int row = 0; row < currentFig.GetLength(0); row++)
            {
                for (int col = 0; col < currentFig.GetLength(1); col++)
                {
                    if (currentFig[row, col])
                    {
                        //transform tetris field's row and col to true
                        tetrisField[currentFigRow + row, currentFigCol + col] = true;
                    }
                }
            }
            score += 9;
        }
        static void Sound()
        {
            while (true)
            {
                const int soundLenght = 100;
                Console.Beep(1320, soundLenght * 4);
                Console.Beep(990, soundLenght * 2);
                Console.Beep(1056, soundLenght * 2);
                Console.Beep(1188, soundLenght * 2);
                Console.Beep(1320, soundLenght);
                Console.Beep(1188, soundLenght);
                Console.Beep(1056, soundLenght * 2);
                Console.Beep(990, soundLenght * 2);
                Console.Beep(880, soundLenght * 4);
                Console.Beep(880, soundLenght * 2);
                Console.Beep(1056, soundLenght * 2);
                Console.Beep(1320, soundLenght * 4);
                Console.Beep(1188, soundLenght * 2);
                Console.Beep(1056, soundLenght * 2);
                Console.Beep(990, soundLenght * 6);
                Console.Beep(1056, soundLenght * 2);
                Console.Beep(1188, soundLenght * 4);
                Console.Beep(1320, soundLenght * 4);
                Console.Beep(1056, soundLenght * 4);
                Console.Beep(880, soundLenght * 4);
                Console.Beep(880, soundLenght * 4);
                Thread.Sleep(soundLenght * 2);
                Console.Beep(1188, soundLenght * 4);
                Console.Beep(1408, soundLenght * 2);
                Console.Beep(1760, soundLenght * 4);
                Console.Beep(1584, soundLenght * 2);
                Console.Beep(1408, soundLenght * 2);
                Console.Beep(1320, soundLenght * 6);
                Console.Beep(1056, soundLenght * 2);
                Console.Beep(1320, soundLenght * 4);
                Console.Beep(1188, soundLenght * 2);
                Console.Beep(1056, soundLenght * 2);
                Console.Beep(990, soundLenght * 4);
                Console.Beep(990, soundLenght * 2);
                Console.Beep(1056, soundLenght * 2);
                Console.Beep(1188, soundLenght * 4);
                Console.Beep(1320, soundLenght * 4);
                Console.Beep(1056, soundLenght * 4);
                Console.Beep(880, soundLenght * 4);
                Console.Beep(880, soundLenght * 4);
                Thread.Sleep(soundLenght * 4);
                Console.Beep(1320, soundLenght * 4);
                Console.Beep(990, soundLenght * 2);
                Console.Beep(1056, soundLenght * 2);
                Console.Beep(1188, soundLenght * 2);
                Console.Beep(1320, soundLenght);
                Console.Beep(1188, soundLenght);
                Console.Beep(1056, soundLenght * 2);
                Console.Beep(990, soundLenght * 2);
                Console.Beep(880, soundLenght * 4);
                Console.Beep(880, soundLenght * 2);
                Console.Beep(1056, soundLenght * 2);
                Console.Beep(1320, soundLenght * 4);
                Console.Beep(1188, soundLenght * 2);
                Console.Beep(1056, soundLenght * 2);
                Console.Beep(990, soundLenght * 6);
                Console.Beep(1056, soundLenght * 2);
                Console.Beep(1188, soundLenght * 4);
                Console.Beep(1320, soundLenght * 4);
                Console.Beep(1056, soundLenght * 4);
                Console.Beep(880, soundLenght * 4);
                Console.Beep(880, soundLenght * 4);
                Thread.Sleep(soundLenght * 2);
                Console.Beep(1188, soundLenght * 4);
                Console.Beep(1408, soundLenght * 2);
                Console.Beep(1760, soundLenght * 4);
                Console.Beep(1584, soundLenght * 2);
                Console.Beep(1408, soundLenght * 2);
                Console.Beep(1320, soundLenght * 6);
                Console.Beep(1056, soundLenght * 2);
                Console.Beep(1320, soundLenght * 4);
                Console.Beep(1188, soundLenght * 2);
                Console.Beep(1056, soundLenght * 2);
                Console.Beep(990, soundLenght * 4);
                Console.Beep(990, soundLenght * 2);
                Console.Beep(1056, soundLenght * 2);
                Console.Beep(1188, soundLenght * 4);
                Console.Beep(1320, soundLenght * 4);
                Console.Beep(1056, soundLenght * 4);
                Console.Beep(880, soundLenght * 4);
                Console.Beep(880, soundLenght * 4);
                Thread.Sleep(soundLenght * 4);
                Console.Beep(660, soundLenght * 8);
                Console.Beep(528, soundLenght * 8);
                Console.Beep(594, soundLenght * 8);
                Console.Beep(495, soundLenght * 8);
                Console.Beep(528, soundLenght * 8);
                Console.Beep(440, soundLenght * 8);
                Console.Beep(419, soundLenght * 8);
                Console.Beep(495, soundLenght * 8);
                Console.Beep(660, soundLenght * 8);
                Console.Beep(528, soundLenght * 8);
                Console.Beep(594, soundLenght * 8);
                Console.Beep(495, soundLenght * 8);
                Console.Beep(528, soundLenght * 4);
                Console.Beep(660, soundLenght * 4);
                Console.Beep(880, soundLenght * 8);
                Console.Beep(838, soundLenght * 16);
                Console.Beep(660, soundLenght * 8);
                Console.Beep(528, soundLenght * 8);
                Console.Beep(594, soundLenght * 8);
                Console.Beep(495, soundLenght * 8);
                Console.Beep(528, soundLenght * 8);
                Console.Beep(440, soundLenght * 8);
                Console.Beep(419, soundLenght * 8);
                Console.Beep(495, soundLenght * 8);
                Console.Beep(660, soundLenght * 8);
                Console.Beep(528, soundLenght * 8);
                Console.Beep(594, soundLenght * 8);
                Console.Beep(495, soundLenght * 8);
                Console.Beep(528, soundLenght * 4);
                Console.Beep(660, soundLenght * 4);
                Console.Beep(880, soundLenght * 8);
                Console.Beep(838, soundLenght * 16);
            }
        }
    }
}