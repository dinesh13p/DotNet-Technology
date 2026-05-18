using System;

namespace dotnettutorials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LAB TASK 1
            //     //
                Console.WriteLine("Enter Id:");
                string idInput = Console.ReadLine();
                int id;
                if (!int.TryParse(idInput, out id) || id < 0)
                    id = 0;

                Console.WriteLine("Enter Name:");
                string name = Console.ReadLine();
                name = Capitalize(name);

                Console.WriteLine("Enter Category:");
                string category = Console.ReadLine();
                category = Capitalize(category);

                Console.WriteLine("Enter Price:");
                string priceInput = Console.ReadLine();
                double price;
                if (!double.TryParse(priceInput, out price))
                    price = 0;

                Console.WriteLine("Enter Stock Quantity:");
                string stockInput = Console.ReadLine();
                int stock;
                if (!int.TryParse(stockInput, out stock))
                    stock = 0;

                Console.WriteLine("Enter Supplier Email:");
                string email = Console.ReadLine();

                Console.WriteLine("Enter Rating (1-5):");
                string ratingInput = Console.ReadLine();
                double rating;
                if (!double.TryParse(ratingInput, out rating))
                    rating = 0;

                Console.WriteLine("Enter Discount Percentage:");
                string discountInput = Console.ReadLine();
                double discount;
                if (!double.TryParse(discountInput, out discount))
                    discount = 0;

                // Create struct object
                Product p = new Product(id, name, category, price, stock, email, rating, discount);

                // Step 2: Calling methods
                Console.WriteLine("\n--- Product Details ---");
                Console.WriteLine("Full Info: " + p.FullProductInfo());
                Console.WriteLine("Price After Discount: Rs. " + p.PriceAfterDiscount());
                Console.WriteLine("Rating Status: " + p.RatingStatus());
            }
            static string Capitalize(string input)
            {
                if (string.IsNullOrEmpty(input))
                    return input;

                return char.ToUpper(input[0]) + input.Substring(1).ToLower();
            }

        }

    }