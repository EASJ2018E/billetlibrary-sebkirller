using System;

namespace BilletLibrary
{
    public class MC : Vehicle
    {
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