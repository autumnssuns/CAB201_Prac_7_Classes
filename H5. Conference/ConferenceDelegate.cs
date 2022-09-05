namespace Conference
{
    /// <summary>
    /// The conference delegate.
    /// </summary>
    class ConferenceDelegate
    {
        /// <summary>
        /// The attendee's name.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The attendee's email.
        /// </summary>
        public string Email { get; private set; }

        /// <summary>
        /// The shirt.
        /// </summary>
        public Shirt MyShirt { get; private set; }

        /// <summary>
        /// The conference delegate.
        /// </summary>
        /// <param name="name">The attendee's name.</param>
        /// <param name="email">The attendee's email.</param>
        /// <param name="shirtSize">The attendee's shirt size.</param>
        /// <param name="shirtColour">The attendee's shirt colour.</param>
        public ConferenceDelegate(string name, string email, int shirtSize, string shirtColour)
        {
            this.Name = name;
            this.Email = email;
            this.MyShirt = new Shirt(shirtSize, shirtColour);
        }
    }
}
