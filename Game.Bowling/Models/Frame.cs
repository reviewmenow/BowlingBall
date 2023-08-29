using Game.Bowling.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Bowling.Models
{
    public class Frame
    {
        public List<Roll> Rolls { get; set; }
        public bool HasStriked
        {
            get
            {
                return this.Rolls.First().Score == ApplicationConstants.NUMBER_OF_PINS;
            }
        }
        public bool HasSpare
        {
            get
            {
                return this.Rolls.Count == 2 && this.Rolls.Sum(s => s.Score) == ApplicationConstants.NUMBER_OF_PINS;
            }
        }
    }
}
