using System;
using System.Collections.Generic;
using System.Text;

namespace Statistics
{
    /// <summary>
    /// EmailAlert class 
    /// </summary>
    public class EmailAlert : IAlerter
    {
        public bool emailSent { get; set; }
        public bool ledGlows { get; set; }
    }
    /// <summary>
    /// LEDAlert Class
    /// </summary>
    public class LEDAlert : IAlerter
    {
        public bool emailSent { get; set; }
        public bool ledGlows { get; set; }
    }
    /// <summary>
    /// StatsAlert class 
    /// </summary>
    public class StatsAlerter
    {
        public float maxThreshold;
        public IAlerter[] iAlerters;
        /// <summary>
        /// Constructor initialization
        /// </summary>
        /// <param name="maxValue"> maxValue which is limit set by user </param>
        /// <param name="ialerter">Alert casses onject array </param>
        public StatsAlerter(float maxValue, IAlerter[] ialerter)
        {
            maxThreshold = maxValue;
            iAlerters = ialerter;
        }
        /// <summary>
        /// If list contains number higher than thresold setting emailSen =t and ledGlows to true
        /// </summary>
        /// <param name="numbers">list of number</param>
        public void checkAndAlert(List<float> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > maxThreshold)
                {
                    iAlerters[0].emailSent = true;
                    iAlerters[1].ledGlows = true;
                }
            }

        }

    }
}
