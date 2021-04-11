using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eProdaja.Database;
using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KorisniciController : Controller
    {
        private readonly IKorisniciService _korisniciService;
        protected readonly IMapper _mapper;
        public KorisniciController(IKorisniciService korisniciService, IMapper mapper)
        {
            _korisniciService = korisniciService;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<Model.Korisnici> Get()
        {
            return _korisniciService.Get();
        }
    }
}
