using BookStoreManagement.Interfaces.Models;
using BookStoreManagement.StaticData.StaticData;

namespace BookStoreManagement.Models.Models
{
    public class Book : IBook
    {
        private string _title;
        private string _author;
        private decimal _price;
        private int _quantity;
        private string? _description;

        public int Id { get; set; }

        public string Title
        {
            get => _title;
            set
            {
                bool isNotValid = string.IsNullOrEmpty(value) || value.Length > BookStoreStaticData.BookTitleMaxLength;

                if (isNotValid)
                {
                    throw new Exception();
                }
                _title = value;
            }
        }

        public string Author
        {
            get => _author;
            set
            {
                bool isNotValid = string.IsNullOrEmpty(value) || value.Length > BookStoreStaticData.BookAuthorMaxLength;

                if (isNotValid)
                {
                    throw new Exception();
                }
                _author = value;
            }
        }

        public decimal Price
        {
            get => _price;
            set
            {
                bool isNotValid = value <= BookStoreStaticData.LowestBookPrice;

                if (isNotValid)
                {
                    throw new Exception();
                }
                _price = value;
            }
        }

        public int Quantity
        {
            get => _quantity;
            set
            {
                bool isNotValid = value <= BookStoreStaticData.LowestBookQuantity;

                if (isNotValid)
                {
                    throw new Exception();
                }
                _quantity = value;
            }
        }

        public string? Description
        {
            get => _description;
            set
            {
                bool isNotValid = value?.Length > BookStoreStaticData.BookDescriptionMaxLength;

                if (isNotValid)
                {
                    throw new Exception();
                }
                _description = value;
            }
        }
    }
}
