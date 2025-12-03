using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Models
{
    internal class HighScore
    {
        public string Name { get; set;}
        public int Score { get; set;}
        public DateTime Date { get; set;}

        public HighScore(string name, int score)
        {
            this.Name = name;
            this.Score = score;
            this.Date = DateTime.Now;
        }

    }
}
