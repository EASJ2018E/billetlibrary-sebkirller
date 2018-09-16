using System;

namespace BilletLibrary
{
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
        
        public override decimal Pris()
        {
            return !Brobizz ? 125 : 125 - ((125 * 5) / 100);
        }

        public override string Køretøj()
        {
            return "MC";
        }
    }
}