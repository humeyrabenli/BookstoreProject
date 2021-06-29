using Bookstore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Entities
{
    public class Book:IEntity
    {
        public int BookId { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
        public string BookName { get; set; }
        public DateTime PublicationDate { get; set; }
        public int NumberOfPage { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public string Description { get; set; }
        public int PublisherId { get; set; }
        public string Cover { get; set; }
        
    }
}
