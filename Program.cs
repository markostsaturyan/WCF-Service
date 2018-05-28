using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {

            ServiceClient.ServiceClient client = new ServiceClient.ServiceClient();

            while (true)
            {
                Console.WriteLine("Choose the operation.");
                Console.WriteLine("Add or UpdatePrice and Exit to exit the program.");

                switch (Console.ReadLine())
                {
                    case "Add":
                        {
                            Console.WriteLine("Enter the book Id");
                            var id = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter the book author");
                            var author = Console.ReadLine();

                            Console.WriteLine("Enter the book title");
                            var title = Console.ReadLine();

                            Console.WriteLine("Enter the book price");
                            var price = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Enter the book year");
                            var year = Convert.ToInt32(Console.ReadLine());

                            var book = new ServiceClient.Book()
                            {
                                Id = id,
                                Author = author,
                                Title = title,
                                Price = price,
                                Year = year
                            };

                            var result = client.Add(book);

                            Console.WriteLine(result.Status +" " + result.Message);

                            break;
                        }
                    case "UpdatePrice":
                        {
                            Console.WriteLine("Enter the book Id");
                            var id = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter the new price");
                            var price = Convert.ToDouble(Console.ReadLine());

                            var result = client.UpdatePrice(id, price);

                            Console.WriteLine(result.Status + " " + result.Message);

                            break;
                        }
                    case "Exit":
                        {
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("Incorrect input, try again.");

                            break;
                        }
                }
            }
        }
    }
}
