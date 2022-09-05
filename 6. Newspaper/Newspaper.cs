using System.Collections.Generic;

namespace Newspaper
{
    /// <summary>
    /// The newspaper.
    /// </summary>
    class Newspaper
    {
        /// <summary>
        /// The title of the newspaper.
        /// </summary>
        string Title;

        /// <summary>
        /// The cost of the newspaper.
        /// </summary>
        double Cost;

        /// <summary>
        /// The articles of the newspaper.
        /// </summary>
        List<NewspaperArticle> articles;


        /// <summary>
        /// The newspaper.
        /// </summary>
        /// <param name="title">The title of the newspaper.</param>
        /// <param name="cost">The cost of the newspaper.</param>
        public Newspaper(string title, double cost)
        {
            Title = title;
            Cost = cost;
            articles = new List<NewspaperArticle>();
        }

        /// <summary>
        /// A method to add an article to the newspaper.
        /// </summary>
        /// <param name="title">The article's title.</param>
        /// <param name="articleText">The article's text.</param>
        /// <param name="stockCaption">The stock caption.</param>
        /// <param name="stockFilename">The image filename.</param>
        public void AddArticle(string title, string articleText, string stockCaption, string stockFilename)
        {
            NewspaperArticle article = new NewspaperArticle(title, articleText, stockCaption, stockFilename);
            articles.Add(article);
        }

    }
}
