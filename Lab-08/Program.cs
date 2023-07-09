namespace Lab_08
{
    public class Program
    {
        static void Main(string[] args)
        {
            var Book_Shop = new Library();

            Book_Shop.Add("Java Book", "Kan", "h.u", 90);
            Book_Shop.Add("C#", "Kaled", "ttt", 897);

            var b1 = new Backpack<Book>();
          
            b1.Pack(Book_Shop.Borrow("Java Book"));
            Console.WriteLine("book in library");
            foreach (Book book in Book_Shop)
            {
                Console.WriteLine($" title : {book.Title} || Author :{book.Author}");
            }
          
            Console.WriteLine("Book in Bag");
            foreach (var bookInPack in b1)
            {
                Console.WriteLine(bookInPack.Title);
            }
           
            Console.WriteLine("Operation");
            Book_Shop.Return(b1.Unpack(0));
        }
    }
}