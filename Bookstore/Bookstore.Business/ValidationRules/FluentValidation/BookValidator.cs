using Bookstore.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Business.ValidationRules.FluentValidation
{
    public class BookValidator:AbstractValidator<Book>
    {
        public BookValidator()
        {
            RuleFor(b => b.BookName).NotEmpty();
            RuleFor(b => b.UnitPrice).NotEmpty();
            RuleFor(b => b.NumberOfPage).NotEmpty();
            RuleFor(b => b.PublicationDate).NotEmpty();
            RuleFor(b => b.UnitPrice).GreaterThan(5);
        }

    }
}
