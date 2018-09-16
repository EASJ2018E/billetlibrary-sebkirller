namespace BilletLibrary
{
    /// <summary>Abstract base class which is used to make new vehicles to keep code DRY.</summary>
    public abstract class Vehicle
    {
        /// <summary>
        /// Method for returning the price formatted as decimal.
        /// </summary>
        public abstract decimal Pris();

        /// <summary>
        /// Method for returning the type of vehicle formatted as string.
        /// </summary>
        public abstract string Køretøj();
    }
}
