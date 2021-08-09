using Bookstore.Business.Abstract;
using Bookstore.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        IBookService _bookService;
        private readonly IWebHostEnvironment _hostEnvironment;

        public BooksController(IBookService bookService, IWebHostEnvironment hostEnvironment)
        {
            _bookService = bookService;
            _hostEnvironment = hostEnvironment;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            
            var result = _bookService.GetBookDetails();
            
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

     

        [HttpPost("add")]
        public IActionResult Add(Book book)
        {
           
            var result = _bookService.Add(book);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Book book)
        {
            var result = _bookService.Delete(book);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPut("update/{bookid}")]
        public IActionResult Update(int bookid, [FromBody] Book book)
        {
            book.BookId = bookid;
            var result = _bookService.Update(book);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }


        [HttpGet("getbyid/{id}")]
        public IActionResult GetById(int id)
        {
            var result = _bookService.GetByBookId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyauthor/{authorid}")]
        public IActionResult GetByAuthor
            (int authorid)
        {
            var result = _bookService.GetBookByAuthorId(authorid);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbybookname/{bookname}")]
        public IActionResult GetBooksByName(string bookname)
        {
            var result = _bookService.GetBooksByName(bookname);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyauthorname/{authorname}")]
        public IActionResult GetBooksByAuthorName(string authorname)
        {
            var result = _bookService.GetBooksByAuthorName(authorname);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbycategoryname/{categoryname}")]
        public IActionResult GetBooksByCategoryName(string categoryname)
        {
            var result = _bookService.GetBooksByCategoryName(categoryname);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //[HttpGet("categoryId={categoryid}")]
        [HttpGet("getallbycategoryid/{categoryid}")]
        public IActionResult GetByCategory
          (int categoryid)
        {
            var result = _bookService.GetAllByCategoryId(categoryid);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


         
        }
    }

