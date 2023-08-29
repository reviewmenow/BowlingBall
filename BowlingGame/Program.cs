using Game.Bowling.Models;
using Game.Bowling.Services;
using System;
using System.Collections.Generic;

namespace BowlingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            ScoreCalculationService scoreCalculationService = new ScoreCalculationService();
            
            var data = new List<Frame>
            {
                new Frame{Rolls= new List<Roll>{ new Roll { Score =10} } },
                 new Frame{Rolls= new List<Roll>{ new Roll { Score =10} }},
                 new Frame{Rolls= new List<Roll>{ new Roll { Score =10} }},
                 new Frame{Rolls= new List<Roll>{ new Roll { Score =10} }},
                new Frame{Rolls= new List<Roll>{ new Roll { Score =10} }},
                new Frame{Rolls= new List<Roll>{ new Roll { Score =10} }},
                new Frame{Rolls= new List<Roll>{ new Roll { Score =10} }},
                 new Frame{Rolls= new List<Roll>{ new Roll { Score =10} }},
                new Frame{Rolls= new List<Roll>{ new Roll { Score =10} }},
                new Frame{Rolls= new List<Roll>{ new Roll { Score =10},new Roll { Score =6},new Roll { Score =4} }},
            };
            var result = scoreCalculationService.CalculateTotalScore(data);
            Console.WriteLine($"Total score - {result}");
        }
    }
}
