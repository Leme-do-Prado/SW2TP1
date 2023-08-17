namespace Command2
{
    public class Author
    {
        protected String name;
        protected String email;
        protected char gender;

        public Author(string name, string email, char gender)
        {
            this.name = name;
            this.email = email;
            this.gender = gender;
        }
        public string Name { get => name; set => name = value; }

        public string getName()
        {
            return name;
        }

        public string Email { get => email; set => email = value; }

        public char Gender { get => gender; set => gender = value; }

    }
}
