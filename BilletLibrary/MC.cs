using System;

namespace BilletLibrary
{
    public class MC
    {
        public string Nummerplade { get; set; }
        public DateTime Dato { get; set; }
        
        public decimal Pris()
        {
            return 125;
        }

        public string Køretøj()
        {
            return "MC";
        }
    }
}