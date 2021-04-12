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
    public class JediniceMjereController : ControllerBase
    {
        private readonly IJediniceMjereService _jediniceMjereService;
        protected readonly IMapper _mapper;
        public JediniceMjereController(IJediniceMjereService jediniceMjereService, IMapper mapper)
        {
            _jediniceMjereService = jediniceMjereService;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<Model.JediniceMjere> Get()
        {
            return _jediniceMjereService.Get();
        }

        [HttpGet("{id}")]
        public Model.JediniceMjere GetById(int id)
        {
            return _jediniceMjereService.GetById(id);
        }
    }
}
