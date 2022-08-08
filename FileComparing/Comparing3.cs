using CSVComparing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVComparing.FileComparing
{
    public class Comparing3
    {
        /// <summary>
        /// Først, læser den de to filer, kendt som path1 og path2, hvor den sammenligner længden på linjen på hver de to output, og viser om de er lige lange = om de to filer er ens eller ej.
        /// Så laves linjerne om til værdier for Consistency til de to lister.
        /// Så bliver indholdet af de to lister valgt ud og bliver sammenlignet med metoden fra Consistency-klassen.
        /// </summary>
        /// <param name="path1"></param>
        /// <param name="path2"></param>
        public static void ReadCSVFile2(string path1, string path2)
        {
            var lines = File.ReadAllLines(path1);
            var lines2 = File.ReadAllLines(path2);
            var list = new List<Consistency>();
            var list2 = new List<Consistency>();
            if (lines.Length != lines2.Length)
            {
                Console.WriteLine("The two files are not the same");
            }
            else
            {
                Console.WriteLine("The two files are the same");
            }

            foreach (var line in lines)
            {
                var values = line.Split(';');
                var contact = new Consistency() { RecordIdentifier = values[0], AfkastkravsGruppe = values[1], CoversGrundlag1Order = values[2], CoversGrundform = values[3], InsuredAge = values[4], CoversReverse1Order = values[5], CoversFGB = values[6], CoversCFBenefit_t0 = values[7] };
                list.Add(contact);
            }

            foreach (var line in lines2)
            {
                var values = line.Split(';');
                var contact = new Consistency() { RecordIdentifier = values[0], AfkastkravsGruppe = values[1], CoversGrundlag1Order = values[2], CoversGrundform = values[3], InsuredAge = values[4], CoversReverse1Order = values[5], CoversFGB = values[6], CoversCFBenefit_t0 = values[7] };
                list2.Add(contact);
            }

            for (int i = 0; i < list2.Count; i++)
            {
                //differencelog += list2[i].CompareWithOther(list[i]);
                //Console.WriteLine(differencelog);
                var differenceLog = list2[i].CompareWithOther(list[i]);
                Console.WriteLine(differenceLog);
                if (differenceLog == "Identifikationen er forkert! Den er ude af synch, så en af filerne skal rettes!")
                {
                    break;
                }

            }
        }
    }
}
