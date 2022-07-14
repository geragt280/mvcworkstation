namespace MVCApp.Models
{
    public class Books
    {
        public int id { get; set; }

        public string name { get; set; }

        public string author { get; set; }

        public Books(int id, string name, string author)
        {
            this.id = id;
            this.name = name;
            this.author = author;
        }
    }
}
