using System;

namespace BilletLibrary
{
    public abstract class Vehicle
    {
        private string NummerPlade { get; set; }
        private DateTime Dato { get; set; }

        public abstract decimal Pris();

        public abstract string Køretøj();
    }
}
