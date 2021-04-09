using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProizvodController : ControllerBase
    {
        private static List<Proizvod> _proizvodi;

        static ProizvodController()
        {
            _proizvodi = new List<Proizvod>()
            {
                new Proizvod()
                {
                    Id=1,
                    Naziv="Laptop"
                },
                new Proizvod()
                {
                    Id=2,
                    Naziv="Mis"
                }
            };
        }


        [HttpGet]
        public IEnumerable<Proizvod>  Get()
        {
            //List<Proizvod> list = new List<Proizvod>()
            //{
            //    new Proizvod()
            //    {
            //        Id=1,
            //        Naziv="Laptop"
            //    },
            //    new Proizvod()
            //    {
            //        Id=2,
            //        Naziv="Mis"
            //    }
            //};

            return _proizvodi;
        }

        [HttpGet ("{id}")]
        public Proizvod GetById(int id) {
            return new Proizvod()
            {
                Id = id,
                Naziv = $"Proizvod {id} "
            };
        }
    }

    public class Proizvod
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
    }
}
 