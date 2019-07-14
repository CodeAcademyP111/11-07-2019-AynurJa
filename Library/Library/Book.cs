namespace Library
{
    public class Book
    {
        private static int _id = 1;
        public Book()
        {
            _id++;
        }
        public int ID { get; set; }
        public string BookName { get; set; }
        public int ISBN { get; set; }
        public int Price { get; set; }
        public string Author { get; set; }
    }
}
