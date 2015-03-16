using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEEU_Data_Mining.Similarity
{
    /// <summary>
    /// Kalkulimi i distances ndermjet dy stringjeve
    /// http://en.wikipedia.org/wiki/Damerau%E2%80%93Levenshtein_distance
    /// </summary>
    public class LevensteinDistance
    {
        /// <summary>
        /// Funksion qe kalkulon distancen ndermjet dy stringjeve
        /// </summary>
        /// <param name="stringu1"></param>
        /// <param name="stringu2"></param>
        /// <returns></returns>
        public int Kalkulo(string stringu1, string stringu2)
        {
            int n = stringu1.Length;
            int m = stringu2.Length;
            int[,] d = new int[n + 1, m + 1];

            //Nese stringu i pare eshte i shprazet
            if (n == 0)
            {
                return m;
            }
            //Nese stringu  i dyte eshte i shprazet
            if (m == 0)
            {
                return n;
            }

            //Inicializim
            for (int i = 0; i <= n; d[i, 0] = i++)
            {
            }

            for (int j = 0; j <= m; d[0, j] = j++)
            {
            }

            // Kalkulimi i editimeve (shih levenstein per me teper)
            for (int i = 1; i <= n; i++)
            {
      
                for (int j = 1; j <= m; j++)
                {                
                    int cost = (stringu2[j - 1] == stringu1[i - 1]) ? 0 : 1;

                    
                    d[i, j] = Math.Min(
                        Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1), d[i - 1, j - 1] + cost);
                }
            }

            return d[n, m];
        }
    }
}
