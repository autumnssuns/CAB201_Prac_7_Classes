namespace Newspaper
{

    /// <summary>
    /// A class to represent a stock photo.
    /// </summary>
    class StockPhoto
    {
        /// <summary>
        /// The stock caption.
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// The image filename.
        /// </summary>
        public string ImageFilename { get; private set; }

        /// <summary>
        /// The stock photo.
        /// </summary>
        /// <param name="caption">The stock caption.</param>
        /// <param name="imagefilename">The image filename.</param>
        public StockPhoto(string caption, string imagefilename)
        {
            this.Caption = caption;
            this.ImageFilename = imagefilename;
        }


    }
}
