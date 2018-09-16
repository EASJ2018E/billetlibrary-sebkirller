using System;

namespace BilletLibrary
{
    public class Bil : Vehicle
    {
        public override decimal Pris()
        {
            return 240;
        }

        public override string Køretøj()
        {
            return "Bil";
        }
    }
}
