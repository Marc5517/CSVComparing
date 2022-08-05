using CSVComparing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVComparing.FileComparing
{
    public class Comparing2
    {
        /// <summary>
        /// Metoden læser alle linjer fra de to filer fra path1 og path2.
        /// De linjer bliver delt ved ';' og sat ind i to forskellige lister, som skal indeholde værdier om Consistency.
        /// Til sidst bliver de to lister sammelignet.
        /// </summary>
        /// <param name="path1"></param>
        /// <param name="path2"></param>
        public static void ReadCSVFile(string path1, string path2)
        {
            var lines = File.ReadAllLines(path1);
            var lines2 = File.ReadAllLines(path2);
            var list = new List<Consistency>();
            var list2 = new List<Consistency>();
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

            if (list.SequenceEqual(list2))
            {
                Console.WriteLine("The two files are the same!");
            }
            else
            {
                Console.WriteLine("The two files are not the same...");
                //var list3 = list.Where(i => !list2.Contains(i)).ToList();
                //var list4 = list2.Where(i => !list.Contains(i)).ToList();
                //foreach (var x in list3)
                //{
                //    Console.WriteLine($"{x.RecordIdentifier}\t{x.AfkastkravsGruppe}\t{x.CoversGrundlag1Order}\t{x.CoversGrundform}\t{x.InsuredAge}\t{x.CoversReverse1Order}\t{x.CoversFGB}\t{x.CoversCFBenefit_t0}");
                //}
                //foreach (var y in list4)
                //{
                //    Console.WriteLine($"{y.RecordIdentifier}\t{y.AfkastkravsGruppe}\t{y.CoversGrundlag1Order}\t{y.CoversGrundform}\t{y.InsuredAge}\t{y.CoversReverse1Order}\t{y.CoversFGB}\t{y.CoversCFBenefit_t0}");
                //}
            }
        }
    }
}
