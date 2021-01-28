using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
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
        /// If max of list is higher than thresold setting emailSent to true and ledGlows to true
        /// </summary>
        /// <param name="numbers">list of number</param>
        public void checkAndAlert(List<float> numbers)
        {
            float max = numbers.Max();
            
            if (max > maxThreshold)
            {
                    iAlerters[0].emailSent = true;
                    iAlerters[1].ledGlows = true;
            }
            

        }

    }
}
