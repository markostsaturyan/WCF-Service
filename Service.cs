using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace ServiceLibrary
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Service : IService
    {
        List<Book> booksList;

        public Service()
        {
            booksList = new List<Book>();
        }

        public Result Add(Book book)
        {
            if (booksList.Count(book1 => book1.Id == book.Id) == 0)
            {
                booksList.Add(book);
                return new Result()
                {
                    Status = "Success",
                    Message = "Book is added in library."
                };
            }
            return new Result()
            {
                Status = "Failed",
                Message = "A book with this "+ book.Id + " already exists․"
            };

        }

        public Result UpdatePrice(int id, double price)
        {
            var book = booksList.Find(book1 => book1.Id == id);

            if (book != null)
            {
                book.Price = price;
                return new Result()
                {
                    Status = "Success",
                    Message = "Price is updated"
                };
            }

            return new Result()
            {
                Status = "Failed",
                Message = "No books with this " + id
            };
        }
    }
}
