struct Product
{
    // Attributes
    public int Id;
    public string Name;
    public string Category;
    public double Price;
    public int StockQuantity;
    public string SupplierEmail;
    public double Rating;
    public double DiscountPercentage;

    // Constructor
    public Product(int id, string name, string category, double price,
                   int stockQuantity, string supplierEmail,
                   double rating, double discountPercentage)
    {
        Id = id > 0 ? id : 0;
        Name = name;
        Category = category;
        Price = price;
        StockQuantity = stockQuantity;
        SupplierEmail = supplierEmail;
        Rating = rating;
        DiscountPercentage = discountPercentage;
    }

    // Method 1: Full Product Info
    public string FullProductInfo()
    {
        return Name + " | " + Category + " | Rs. " + Price;
    }

    // Method 2: Price After Discount
    public double PriceAfterDiscount()
    {
        double discountAmount = (DiscountPercentage / 100) * Price;
        return Price - discountAmount;
    }

    // Method 3: Rating Status
    public string RatingStatus()
    {
        if (Rating >= 4.5)
            return "Excellent";
        else if (Rating >= 3.0)
            return "Good";
        else if (Rating >= 1.0)
            return "Average";
        else
            return "Poor";
    }
}



/*
Question (LAB TASK 1):
SK- 1 [C# Type Conversion] Create a struct named Product along with the attributes & methods mentioned below:

Attributes: Id [Only Positive Number]
Data Type: Integral Type
Name Data Type: String
Category Data Type: String
Price Data Type: Floating Type
StockQuantity Data Type: Integral Type
SupplierEmail Data Type: String
Rating Data Type: Floating Type (scale 1-5)
DiscountPercentage Data Type: Floating Type (Percentage)


Methods:
1. Constructor
Functionality: A parameterized constructor that accepts all the attributes as input and initializes them in the struct.

2. FullProductInfo
Return Type: String
Functionality: Return a concatenation of product name, category, and price.

3. PriceAfterDiscount
Return Type: Floating Type
Functionality:
i) Calculate the discount amount in price: [Discount Percentage * Price]
ii) Deduct the discount from the original price and return the new price after applying the discount.
4. RatingStatus
Return Type: String
Functionality: Return a status based on the rating:
"Excellent" for rating 4.5 and above
"Good" for rating between 3.0 and 4.4
"Average" for rating between 1.0 and 2.9
"Poor" for rating below 1.0


Step - 1 Use Console.ReadLine() to ask for the following input from the user in a Console Application:
Id, Name, Category, Price, StockQuantity, SupplierEmail, Rating, DiscountPercentage

i) Perform the necessary type conversions and pass all type-casted input parameters into the struct constructor to create a struct object.
ii) While collecting information from the user, if a user provides invalid information (i.e., fails the type conversion), assign default values to the attributes.
iii) Make the first letter of Name and Category capitalized (uppercase) after input from the user.

Step - 2
i) Call the available functions using the struct object and display the full product information, the price after applying the discount, and the rating status

*/