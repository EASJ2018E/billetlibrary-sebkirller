using System;

namespace BilletLibrary
{
    public class Bil
    {
        public string NummerPlade { get; set; }
        public DateTime Dato { get; set; }

        public decimal Pris()
        {
            return 240;
        }

        public string Køretøj()
        {
            return "Bil";
        }
    }
}
