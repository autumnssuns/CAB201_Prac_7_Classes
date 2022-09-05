using System;
using System.Collections.Generic;
using System.Text;

namespace Newspaper
{
    /// <summary>
    /// The newspaper article.
    /// </summary>
    class NewspaperArticle
    {
        /// <summary>
        /// The title.
        /// </summary>
        string Title;

        /// <summary>
        /// The article text.
        /// </summary>
        string ArticleText;

        /// <summary>
        /// The stock photo.
        /// </summary>
        StockPhoto Photo;


        /// <summary>
        /// The newspaper article. 
        /// </summary>
        /// <param name="title">The article's title.</param>
        /// <param name="articleText">The article's text.</param>
        /// <param name="stockCaption">The stock caption.</param>
        /// <param name="stockFilename">The image filename.</param>
        public NewspaperArticle(string title, string articleText, string stockCaption, string stockFilename)
        {
            Title = title;
            ArticleText = articleText;
            Photo = new StockPhoto(stockCaption, stockFilename);
        }


    }
}
