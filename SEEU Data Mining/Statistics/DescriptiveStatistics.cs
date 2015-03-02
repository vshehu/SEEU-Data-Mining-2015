using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEEU_Data_Mining.Statistics
{
    public class DescriptiveStatistics : IDescriptiveStatistics
    {
        
        private float[] data;

        public DescriptiveStatistics(float[] input_data)
        {
            data = input_data;

            Array.Sort(data);
        }

        public object Max()
        {
            //int max = data[0];
            //for (int i = 1; i < data.Length; i++)
            //{
            //    if (max < data[i])
            //        max = data[i];
            //}
            //return max;
            return data.Max();
        }

        public object Min()
        {
            return data.Min();
        }

        public float Median()
        {
         if ((data.Count() % 2) == 0)
            {
                int mesi = data.Count();
                float mesatarja = (data[mesi] + data[mesi + 1]) / 2;
                return mesatarja;
            }
            else //numer tek i elementeve
            {
                int mesi = (data.Count() / 2) + 1;
                return (float)data[mesi];
            }
        }

        public float StandardDeviation()
        {
            float m = Mean();

            double shuma = 0;
            for (int i = 0; i < data.Length; i++)
            {
                shuma = shuma + ((data[i] - m) * (data[i] - m));
            }

            return (float)Math.Sqrt(shuma) / data.Count();        
        }

        public float Mean()
        {
            return (float)data.Average();
        }

        public Dictionary<float, int> Frequency(float[] data)
        {
            Dictionary<float, int> ret = new Dictionary<float, int>();

            for (int i = 0; i < data.Length; i++)
            {
                if (ret.ContainsKey(data[i]))
                {
                    ret[data[i]]++;
                }
                else
                {
                    ret.Add(data[i], 1);
                }
            }
            return ret;

        }

        public float Mode()
        {
            throw new NotImplementedException();
        }
    }
}
