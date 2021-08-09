using Bookstore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Entities
{
    public class Publisher:IEntity
    {
        public int PublisherId { get; set; }
        public string PublisherName { get; set; }
    }
}
