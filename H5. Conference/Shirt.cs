namespace Conference
{
    /// <summary>
    /// The shirt.
    /// </summary>
    class Shirt
    {

        /// <summary>
        /// The shirt's size.
        /// </summary>
        public int Size { get; private set; }

        /// <summary>
        /// The shirt's colour.
        /// </summary>
        public string Colour { get; private set; }

        /// <summary>
        /// The shirt.
        /// </summary>
        /// <param name="size">The shirt's size.</param>
        /// <param name="colour">The shirt's colour.</param>
        public Shirt(int size, string colour)
        {
            this.Size = size;
            this.Colour = colour; 
        }

    }
}
