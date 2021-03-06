using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BaseReadController<T, TSearch> : Controller where T:class where TSearch : class
    {
        protected readonly IReadService<T, TSearch> _service;
        public BaseReadController(IReadService<T, TSearch> service)
        {
            _service = service;
        }


        [HttpGet]
        public virtual IEnumerable<T> Get([FromQuery] TSearch search)
        {
            return _service.Get(search);
        }

        [HttpGet("{id}")]
        public virtual T GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}
