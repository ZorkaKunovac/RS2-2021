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
    public class BaseReadController<T> : Controller where T:class
    {
        protected readonly IReadService<T> _service;
        public BaseReadController(IReadService<T> service)
        {
            _service = service;
        }


        [HttpGet]
        public virtual IEnumerable<T> Get()
        {
            return _service.Get();
        }

        [HttpGet("{id}")]
        public virtual T GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}
