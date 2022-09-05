namespace SwimingPool
{
    /// <summary>
    /// A class that represents a swimming pool.
    /// </summary>
    public class SwimmingPool
    {
        /// <summary>
        /// The length of the swimming pool.
        /// </summary>
        private int length;

        /// <summary>
        /// The width of the swimming pool.
        /// </summary>
        private int width;

        /// <summary>
        /// The depth of the swimming pool.
        /// </summary>
        private int depth;

        /// <summary>
        /// The time is takes for water entering the swimming pool.
        /// </summary>
        private double poolIn;

        /// <summary>
        /// The time is takes for water leaving the swimming pool.
        /// </summary>
        private double poolOut;

        /// <summary>
        /// The swiming pool.
        /// </summary>
        /// <param name="length">The length of the swimming pool.</param>
        /// <param name="width">The width of the swimming pool.</param>
        /// <param name="depth">The depth of the swimming pool.</param>
        /// <param name="poolIn">The time is takes for water entering the swimming pool.</param>
        /// <param name="poolOut">The time is takes for water leaving the swimming pool.</param>
        public SwimmingPool(int length, int width, int depth, double poolIn, double poolOut)
        {
            this.length = length;
            this.width = width;
            this.depth = depth;
            this.poolIn = poolIn;
            this.poolOut = poolOut;
        }

        /// <summary>
        /// Caculates the size of a swimming pool.
        /// </summary>
        /// <returns>The size of the swimming pool.</returns>
        public double SwimingPoolSize()
        {
            return length * width * depth;
        }

        /// <summary>
        /// The size of a swiming pool minus the current volume.
        /// </summary>
        /// <param name="volume">The volume.</param>
        /// <returns>The size of a swiming pool minus the current volume</returns>
        public double SwimingPoolSize(double volume)
        {
            return SwimingPoolSize() - volume;
        }

        /// <summary>
        /// The time it takes to fill up a swimming pool
        /// </summary>
        /// <returns>The time it takes to fill up a swimming pool</returns>
        public double TimeToFill()
        {
            return SwimingPoolSize() / poolIn;
        }

        /// <summary>
        /// The time it takes to fill up a swimming pool with a volume.
        /// </summary>
        /// <param name="volume">The volume.</param>
        /// <returns>The time it takes to fill up a swimming pool with a volume.</returns>
        public double TimeToFill(double volume)
        {
            return SwimingPoolSize(volume) / poolIn;
        }

        /// <summary>
        /// The time it takes to empty a swimming pool.
        /// </summary>
        /// <returns>The time it takes to empty a swimming pool.</returns>
        public double TimeToEmpty()
        {
            return SwimingPoolSize() / poolOut;
        }

        /// <summary>
        /// The time it takes to empty a swimming pool with a volume.
        /// </summary>
        /// <param name="volume">The volume.</param>
        /// <returns>The time it takes to empty a swimming pool with a volume.</returns>
        public double TimeToEmpty(double volume)
        {
            return volume / poolOut;
        }

    }
}

