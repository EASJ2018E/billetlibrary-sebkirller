using System;

namespace BilletLibrary
{
    public class MC : Vehicle
    {
        private string _nummerPlade;

        private string NummerPlade
        {
            get => _nummerPlade;
            set => _nummerPlade = value.Length <= 7 ? value
                : throw new ArgumentException("Nummerpladen må ikke være længere end 7 tegn!");
        }

        private DateTime Dato { get; set; }
        
        public override decimal Pris()
        {
            return 125;
        }

        public override string Køretøj()
        {
            return "MC";
        }
    }
}