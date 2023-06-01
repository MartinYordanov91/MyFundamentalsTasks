// Create a class Article with the following properties:
// • Title – a string
// • Content – a string
// • Author – a string
// The class should have a constructor and the following methods:
// • Edit (new content) – change the old content with the new one
// • ChangeAuthor (new author) – change the author
// • Rename (new title) – change the title of the article
// • Override the ToString method – print the article in the following format:
// "{title} - {content}: {author}"
// Create a program that reads an article in the following format "{title}, {content}, {author}". On the next
// line, you will receive a number n, representing the number of commands, which will follow after it. On the next n
// lines, you will be receiving the following commands:
// • "Edit: {new content}"
// • "ChangeAuthor: {new author}"
// • "Rename: {new title}"
// In the end, print the final state of the article.

namespace _02._Articles
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listArticles = Console.ReadLine().Split(", ").ToList();

            Article article = new Article(listArticles[0] , listArticles[1], listArticles[2]);

            //string title = listArticles[0];
            //string content = listArticles[1];
            //string author = listArticles[2];
            int comands = int.Parse(Console.ReadLine());

            for (int i = 0; i < comands; i++)
            {
                List<string> curentComand = Console.ReadLine().Split(": ").ToList();

                if (curentComand[0] == "Edit")
                {
                    article.Content = curentComand[1];
                }
                else if (curentComand[0] == "ChangeAuthor")
                {
                    article.Author = curentComand[1];
                }
                else if (curentComand[0] == "Rename")
                {
                    article.Title= curentComand[1];
                }
            }
            Console.WriteLine(article);
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