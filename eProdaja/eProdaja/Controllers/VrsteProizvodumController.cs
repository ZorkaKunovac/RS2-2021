using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    public class VrsteProizvodumController : ControllerBase
    {

        private readonly IVrsteProizvodumService _vrsteProizvodumService;
        protected readonly IMapper _mapper;
        public VrsteProizvodumController(IVrsteProizvodumService vrsteProizvodumService, IMapper mapper)
        {
            _vrsteProizvodumService = vrsteProizvodumService;
            _mapper = mapper;
        }


        [HttpGet]
        public IEnumerable<Model.VrsteProizvodum> Get()
        {
            return _vrsteProizvodumService.Get();
        }

        [HttpGet("{id}")]
        public Model.VrsteProizvodum GetById(int id)
        {
            return _vrsteProizvodumService.GetById(id);
        }


    }
}
