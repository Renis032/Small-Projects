using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Tetris
{
    public class ScoreManager
    {
        private readonly string highScoreFile;

        public ScoreManager(string highScoreFile)
        {
            this.highScoreFile = highScoreFile;
            this.HighScore = this.GetHighScore();
        }
        public int Score { get; private set; }

        public int HighScore { get; private set; }


        private int GetHighScore()
        {
            var highScore = 0;

            if (File.Exists(this.highScoreFile))
            {
                var allScores = File.ReadAllLines(this.highScoreFile);
                foreach (var score in allScores)
                {
                    var match = Regex.Match(score, @"=> (?<score>[0-9]+)");
                    //highscore takes the max value from the list
                    highScore = Math.Max(highScore, int.Parse(match.Groups["score"].Value) - 1);
                }
            }

            return highScore + 1;
        }
        public void AddToHighScoreFile()
        {
            File.AppendAllLines(this.highScoreFile, new List<string>
                        {
                            $"[{DateTime.Now.ToString()}] {Environment.UserName} => {this.Score}"
                        });
        }

        public void AddScore(int addToScore)
        {
            this.Score += addToScore;

            if (this.Score > this.HighScore)
            {
                this.HighScore = this.Score;
            }
        }
    }
}