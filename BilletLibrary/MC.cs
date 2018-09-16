using System;

namespace BilletLibrary
{
    /// <summary>Pre-made class, Motorcycle</summary>
    public class MC : Vehicle
    {
        private string _nummerPlade;

        public string NummerPlade
        {
            get => _nummerPlade;
            set => _nummerPlade = value.Length <= 7 ? value
                : throw new ArgumentException("Nummerpladen må ikke være længere end 7 tegn!");
        }

        public DateTime Dato { get; set; }
        public bool Brobizz { get; set; }
        
        /// <summary>
        /// Returns the price formatted as decimal.
        /// If Brobizz is set to true then the price is reduced by 5%.
        /// </summary>
        public override decimal Pris()
        {
            return !Brobizz ? 125 : 125 - ((125 * 5) / 100);
        }

        /// <summary>
        /// Returns which type of vehicle this is formatted as string.
        /// </summary>
        public override string Køretøj()
        {
            return "MC";
        }
    }
}