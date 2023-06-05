namespace BookStoreManagement.StaticData.StaticData
{
    public static class BookStoreStaticData
    {
        public const string MainMenu =
                "\n========== Bookstore Management ==========\r\n" +
                "1. Display Books\r\n" +
                "2. Search Books\r\n" +
                "3. Add New Book\r\n" +
                "4. Calculate Total Value\r\n" +
                "5. Apply Discounts\r\n" +
                "6. Save\r\n\r\n" +
                "Enter your choice (1-6):\r\n";

        public const string SaveFileMessage = "Book collection saved to JSON file: BookstoreManagementOutput.json.";

        public const string TableHeader = "ID    " +
            "| Title                                              " +
            "| Author                                             " +
            "| Price " +
            "| Quantity " +
            "| Description     ";

        public const string SearchMessage = "Enter a keyword to search: ";
            
        public const string AddedSuccesfullyMessage = "New book added successfully.";
          
        public const string AddedUnsuccesfullyMessage = "New book didnt meet the requirments";
             
        public const string DiscountMessage = "Discounts applied successfully.";
           
        public const decimal LowestPercentageDiscount = 0.05m;
          
        public const decimal MiddlePercentageDiscount = 0.10m;
            
        public const decimal HighestPercentageDiscount = 0.15m;
             
        public const decimal LowestPriceDiscount = 15;
            
        public const decimal MiddlePriceDiscount = 26;
             
        public const int BookDescriptionMaxLength = 200;
              
        public const int BookAuthorMaxLength = 50;
              
        public const int BookTitleMaxLength = 50;
               
        public const int LowestPossibleIndex = 0;
               
        public const int LowestBookPrice = 0;
               
        public const int LowestBookQuantity = 0;
               
        public const string GetFilePath = "D:\\Json\\BookstoreManagement.json";
               
        public const string PostFilePath = "D:\\Json\\BookstoreManagementOutput.json";
    }
}