namespace Command2
{
    public class Book
    {
        protected string name;
        protected Author[] authors;
        protected double price;
        protected int qty = 0;

        public Book(string name, Author[] authors, double price)
        {
            this.name = name;
            this.authors = authors;
            this.price = price;
        }

        public Book(string name, Author[] authors, double price, int qty)
        {
            this.name = name;
            this.authors = authors;
            this.price = price;
            this.qty = qty;
        }

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public Author[] getAuthors()
        {
            return authors;
        }

        public Double getPrice()
        {
            return price;
        }

        public void setPrice(double price)
        {
            this.price = price;
        }

        public int getQty()
        {
            return qty;
        }

        public void setQty(int qty)
        {
            this.qty = qty;
        }

        public override string ToString()
        {
            string authorsStr = string.Join(", ", authors.Select(author => author.getName()));

            return $"Book[name={name}, authors{{{authorsStr}}}, price={price}, qty={qty}]";
        }

        public string GetAuthorNames()
        {
            string authorNames = string.Join(", ", authors.Select(author => author.Name));
            return authorNames;
        }
    }
}
