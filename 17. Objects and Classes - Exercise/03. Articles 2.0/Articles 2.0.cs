// Change the program from the previous problem in such a way, that you will be able to store a list of articles. You
// will not need to use the previous methods anymore (except the "ToString()"). On the first line, you will receive
// the number of articles. On the next lines, you will receive the articles in the same format as in the previous
// problem: "{title}, {content}, {author}". Print the articles.

namespace _02._Articles
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
           
            List<Article> article = new List<Article>();
            int comands = int.Parse(Console.ReadLine());

            for (int i = 0; i < comands; i++)
            {
                List<string> listArticles = Console.ReadLine().Split(", ").ToList();
                Article articles = new Article(listArticles[0], listArticles[1], listArticles[2]);
                article.Add(articles);
            }

            foreach (var item in article)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class Article
    {

        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }


        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}