using System;
using System.Collections.Generic;
using System.Linq;
namespace Statistics
{
    /// <summary>
    /// Declaring class which includes values that needs to be returned
    /// </summary>
    public class Stats
    {
        public double average { get; set; }
        public double max { get; set; }
        public double min { get; set; }

    }
    /// <summary>
    /// Declaring class which will perform calculations for provides list
    /// </summary>
    public class StatsComputer
    {
        Stats statValues = new Stats();
        /// <summary>
        /// Perform calculation based on list and return Stats type object
        /// </summary>
        /// <param name="numbers">list of numbers on which calculations to be done</param>
        /// <returns></returns>
        public Stats CalculateStatistics(List<float> numbers) {
            double avgResult = 0;
            if (numbers.Count > 0)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    avgResult = avgResult + numbers[i];
                }
                statValues.average = avgResult / numbers.Count;
                statValues.max = numbers.Max();
                statValues.min = numbers.Min();
            }
            else
            {
                statValues.average = Double.NaN;
                statValues.max = Double.NaN;
                statValues.min = Double.NaN;
            }
            return statValues;
        }
        
    }
}
