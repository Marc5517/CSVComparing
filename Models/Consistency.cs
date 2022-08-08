using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVComparing.Models
{
    public class Consistency
    {
        private string _recordIdentifier;
        private string _afkastkravsGruppe;
        private string _coversGrundlag1Order;
        private string _coversGrundform;
        private string _insuredAge;
        private string _coversReverse1Order;
        private string _coversFGB;
        private string _coversCFBenefit_t0;

        public Consistency(string recordIdentifier, string afkastkravsGruppe, string coversGrundlag1Order, string coversGrundform, string insuredAge, string coversReverse1Order, string coversFGB, string coversCFBenefit_t0)
        {
            _recordIdentifier = recordIdentifier;
            _afkastkravsGruppe = afkastkravsGruppe;
            _coversGrundlag1Order = coversGrundlag1Order;
            _coversGrundform = coversGrundform;
            _insuredAge = insuredAge;
            _coversReverse1Order = coversReverse1Order;
            _coversFGB = coversFGB;
            _coversCFBenefit_t0 = coversCFBenefit_t0;
        }

        public Consistency()
        {

        }

        public string RecordIdentifier
        {
            get { return _recordIdentifier; }
            set { _recordIdentifier = value; }
        }

        public string AfkastkravsGruppe
        {
            get { return _afkastkravsGruppe; }
            set { _afkastkravsGruppe= value; }
        }

        public string CoversGrundlag1Order
        {
            get { return _coversGrundlag1Order; }
            set { _coversGrundlag1Order = value; }
        }

        public string CoversGrundform
        {
            get { return _coversGrundform; }
            set { _coversGrundform = value; }
        }

        public string InsuredAge
        {
            get { return _insuredAge; }
            set { _insuredAge = value; }
        }

        public string CoversReverse1Order
        {
            get { return _coversReverse1Order; }
            set { _coversReverse1Order = value; }
        }

        public string CoversFGB
        {
            get { return _coversFGB; }
            set { _coversFGB = value; }
        }

        public string CoversCFBenefit_t0
        {
            get { return _coversCFBenefit_t0;}
            set
            {
                _coversCFBenefit_t0 = value;
            }
        }

        /// <summary>
        /// Metoden sammenligner indholdet af den anden liste med den første liste.
        /// Hvis de ikke er det samme, så melder den tilbage og viser forskellen mellem de to ved deres ID.
        /// Hvis der ikke er en forskel, så returnere den en null.
        /// Dog, hvis der er noget galt med de to ID'er, så melder den tilbage og stopper.
        /// </summary>
        /// <param name="other"></param>
        /// <returns>En string besked med enten forskellen mellem de to output, en null, eller en besked om at idenfikationen er forkert.</returns>
        public string CompareWithOther(Consistency other)
        {
            try
            {
                if (this._recordIdentifier != other._recordIdentifier)
                {
                    Console.WriteLine();
                    throw new NullReferenceException("Identifikationen er forkert! Den er ude af synch, så en af filerne skal rettes!");
                }

                if (this._afkastkravsGruppe != other._afkastkravsGruppe)
                    return $"Feltet _afkavsGruppe i {this._recordIdentifier} er forskelligt i de to output! Nye: {this._afkastkravsGruppe}, Gamle: {other._afkastkravsGruppe}\n ";
                if (this._coversGrundlag1Order != other._coversGrundlag1Order)
                    return $"Feltet _coversGrundlag1Order i {this._recordIdentifier} er forskelligt i de to output! Nye: {this._coversGrundlag1Order}, Gamle: {other._coversGrundlag1Order}\n ";
                if (this._coversGrundform != other._coversGrundform)
                    return $"Feltet _coversGrundform i {this._recordIdentifier} er forskelligt i de to ouput! Nye: {this._coversGrundform}, Gamle {other._coversGrundform}\n ";
                if (this._insuredAge != other._insuredAge)
                    return $"Feltet _insuredAge i {this._recordIdentifier} er forskelligt i de to output! Nye: {this._insuredAge}, Gamle: {other._insuredAge}\n ";
                if (this._coversReverse1Order != other._coversReverse1Order)
                    return $"Feltet _coversReverse1Order i {this._recordIdentifier} er forskelligt i de to output! Nye {this._coversReverse1Order}, Gamle: {other._coversReverse1Order}\n ";
                if (this._coversFGB != other._coversFGB)
                    return $"Feltet _coversFGB i {this._recordIdentifier} er forskelligt i de to output! Nye: {this._coversFGB}, Gamle: {other._coversFGB}\n ";
                if (this._coversCFBenefit_t0 != other._coversCFBenefit_t0)
                    return $"Feltet _coversCFBenefit i {this._recordIdentifier} er forskelligt i de to output! Nye: {this._coversCFBenefit_t0}, Gamle: {other._coversCFBenefit_t0}\n ";
                return null;
            }
            catch (Exception exp)
            {
                return $"{exp.Message}";
            }
        }
    }
}
