using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public KorisniciController(IKorisniciService korisniciService)
        {
            _korisniciService = korisniciService;
        }

        [HttpGet]
        public IEnumerable<Model.Korisnici> Get()
        {
            return _korisniciService.Get();
        }
    }
}
