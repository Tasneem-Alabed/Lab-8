using Lab_08;

namespace TestLibrary
{
    public class UnitTest1
    {
      
        Library library = new Library();
        [Fact]
        public void test1()
        {

            library.Add("php", "web", "web", 40);
            library.Add("web", "tasneem", "alabed", 15);
            library.Borrow("web");
            int res = library.Count;
            Assert.Equal(1, res);
        }
        [Fact]
        public void test2()
        {

            library.Add("php", "web", "web", 40);
            int res = library.Count;
            Assert.Equal(1, res);
        }
        
        [Fact]
        public void test3()
        {


            library.Add("php", "web", "web", 40);

            Book borrowedBook = library.Borrow("php");

            Assert.DoesNotContain(borrowedBook, library);

        }
        [Fact]
        public void test4()
        {
          ;
            library.Add("1", "FIRST", "LAST", 100);
            library.Add("2", "FIRST", "LAST", 200);
            Book book = library.Borrow("4");
            Assert.Equal(book, null);

        }
        [Fact]
        public void test5()
        {

            library.Add("php", "web", "web", 40);
            library.Add("web", "tasneem", "alabed", 15);
            Book book = library.Borrow("php");
            library.Return(book);

            Assert.Contains(book, library);
        }
        [Fact]
        public void test0()
        {

            library.Add("php", "web", "web", 40);
            library.Add("web", "tasneem", "alabed", 15);
            Book book = library.Borrow("web");
            library.Return(book);
            int res = library.Count;
            Assert.Equal(2, res);
        }
        
     

    }
}