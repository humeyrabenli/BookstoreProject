using Bookstore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Entities.DTOs
{
    public class BookDetailDto:IDto
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string CategoryName { get; set; }
        public string AuthorName { get; set; }
        public string AuthorLastName { get; set; }

    }
}
