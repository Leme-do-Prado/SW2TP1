namespace Command2
{
    public class LivroRepositorioCsv
    {

        private static readonly string nomeArquivoCsv = "D:\\ArquivoCsv.csv";

        public LivroRepositorioCsv()
        {
            using (var file = File.OpenText(LivroRepositorioCsv.nomeArquivoCsv))
            {
                while (!file.EndOfStream)
                {
                    var line = file.ReadLine();
                    if (String.IsNullOrEmpty(line))
                    {
                        continue;
                    }
                }
            }
        }
        public void PrintCsvContents()
        {
            string csvContents = File.ReadAllText(LivroRepositorioCsv.nomeArquivoCsv);
            Console.WriteLine(csvContents);
        }

        public void Add(Book book)
        {
            using (var file = File.AppendText(LivroRepositorioCsv.nomeArquivoCsv))
            {
                file.WriteLine(book.ToString());
            }
        }
    }
}
