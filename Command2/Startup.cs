using System.Text;

namespace Command2
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {

            var builder = new RouteBuilder(app);
            builder.MapRoute("Livro/Nome", BookName);
            builder.MapRoute("Livro/ToString", BookToString);
            builder.MapRoute("Livro/GetAuthorNames", BookGetAuthorNames);
            builder.MapRoute("Livro/ApresentarLivro", BookShowBook);
            var rotas = builder.Build();
            app.UseRouter(rotas);
        }

        public Task BookName(HttpContext context)
        {
            Author[] authors = new Author[2];
            authors[0] = new Author("Owen King", "owenking@hotmail.com", 'M');
            authors[1] = new Author("Stephen King", "stephking64@shining.com", 'M');
            return context.Response.WriteAsync(new Book("Belas Adormecidas", authors, 45.00, 3).getName());
        }

        public Task BookToString(HttpContext context)
        {
            Author[] authors = new Author[2];
            authors[0] = new Author("Owen King", "owenking@hotmail.com", 'M');
            authors[1] = new Author("Stephen King", "stephking64@shining.com", 'M');
            return context.Response.WriteAsync(new Book("Belas Adormecidas", authors, 45.00, 3).ToString());
        }

        public Task BookGetAuthorNames(HttpContext context)
        {
            Author[] authors = new Author[2];
            authors[0] = new Author("Owen King", "owenking@hotmail.com", 'M');
            authors[1] = new Author("Stephen King", "stephking64@shining.com", 'M');
            return context.Response.WriteAsync(new Book("Belas Adormecidas", authors, 45.00, 3).GetAuthorNames());
        }

        public Task BookShowBook(HttpContext context)
        {
            Author[] authors = new Author[2];
            authors[0] = new Author("Owen King", "owenking@hotmail.com", 'M');
            authors[1] = new Author("Stephen King", "stephking64@shining.com", 'M');

            var book = new Book("Belas Adormecidas", authors, 45.00, 3);

            string htmlContent = $@"
        <!DOCTYPE html>
        <html>
        <head>
            <title>Apresentação do Livro</title>
        </head>
        <body>
            <h1>Informações do Livro</h1>
            <p><strong>Nome do Livro:</strong> {book.getName()}</p>
            <h2>Autores:</h2>
            <ul>
                {GenerateAuthorList(authors)}
            </ul>
        </body>
        </html>";

            context.Response.ContentType = "text/html";
            return context.Response.WriteAsync(htmlContent);
        }

        private string GenerateAuthorList(Author[] authors)
        {
            StringBuilder authorList = new StringBuilder();
            foreach (var author in authors)
            {
                authorList.Append($"<li>{author.Name} - Email: {author.Email}</li>");
            }
            return authorList.ToString();
        }
    }
}