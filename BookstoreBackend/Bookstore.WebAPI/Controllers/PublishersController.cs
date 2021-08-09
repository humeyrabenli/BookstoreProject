using Bookstore.Business.Abstract;
using Bookstore.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublishersController : ControllerBase
    {
        IPublisherService _publisherService;

        public PublishersController(IPublisherService publisherService)
        {
            _publisherService = publisherService;
        }

        [HttpPost("add")]
        public IActionResult Add(Publisher publisher)
        {

            var result = _publisherService.Add(publisher);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);


        }

        [HttpPost("delete")]
        public IActionResult Delete(Publisher publisher)
        {
            var result = _publisherService.Delete(publisher);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPut("update/{publisherid}")]
        public IActionResult Update(int publisherid, [FromBody] Publisher publisher)
        {
            publisher.PublisherId = publisherid;
            var result = _publisherService.Update(publisher);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _publisherService.GetAll();

            return Ok(result);

        }

        [HttpGet("getbyid/{id}")]
        public IActionResult GetById(int id)
        {
            var result = _publisherService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
