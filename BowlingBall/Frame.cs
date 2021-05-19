using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall
{
    class Frame
    {
        /// <summary>
        /// How many pins have been knocked down in each roll
        /// </summary>
        public List<int> Results { get; } = new List<int>();

        /// <summary>
        /// No more rolls can be registered on a closed Frame
        /// </summary>
        public bool IsClosed => !isLastFrame && standingPins == 0 ||
                                    !isLastFrame && Results.Count == 2 ||
                                    Results.Count == 3;

        private int standingPins;
        private readonly bool isLastFrame;
        public Frame(int startingPinCount, bool isLastFrame = false)
        {
            standingPins = startingPinCount;
            this.isLastFrame = isLastFrame;
        }

        public void RegisterKnockedDownPins(int knockedDownPins)
        {
            Results.Add(knockedDownPins);
            standingPins -= knockedDownPins;
        }
    }
}
