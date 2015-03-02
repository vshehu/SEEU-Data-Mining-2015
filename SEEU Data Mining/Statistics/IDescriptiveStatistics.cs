using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEEU_Data_Mining.Statistics
{
    /// <summary>
    /// Interface qe implementon metodat e nevojshme per statistika deskriptive
    /// Statistikat do te kalkulohen kundrejt nje objekti (varg, liste sipas deshires)
    /// </summary>
    public interface IDescriptiveStatistics
    {
        object Max();
        object Min();
        float Median();
        float StandardDeviation();
        float Mean();

        Dictionary<float, int> Frequency(float[] data);
        float Mode();
    }
}
