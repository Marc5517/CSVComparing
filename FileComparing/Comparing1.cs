using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVComparing.FileComparing
{
    public class Comparing1
    {
        /// <summary>
        /// Denne metode læser alle bytes fra de to csv-filer path1 og path2.
        /// Bagefter bliver sammenligner metoden længden på bytes'ne og ser om de passer eller ej.
        /// </summary>
        /// <param name="path1"></param>
        /// <param name="path2"></param>
        /// <returns>Sandt hvis de er lige lange, falsk hvis de ikke er.</returns>
        public static bool CSVEquals(string path1, string path2)
        {
            byte[] Consistency0 = File.ReadAllBytes(path1);
            byte[] Consistency1 = File.ReadAllBytes(path2);
            if (Consistency0.Length == Consistency1.Length)
            {
                for (int i = 0; i < Consistency0.Length; i++)
                {
                    if (Consistency0[i] != Consistency1[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
    }
}
