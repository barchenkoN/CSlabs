namespace Pr_3.ClassesForTask1
{
    class Author
    {
        private string author;

        public Author(string author)
        {
            this.author = author;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Author: " + author);
            Console.ResetColor();
        }
    }
}