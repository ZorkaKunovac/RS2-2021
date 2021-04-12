using AutoMapper;
using eProdaja.Database;
using eProdaja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class VrsteProizvodumService : IVrsteProizvodumService
    {
        public eProdajaContext Context;
        protected readonly IMapper _mapper;
        public VrsteProizvodumService(eProdajaContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }

        public IEnumerable<Model.VrsteProizvodum> Get()
        {
            return Context.VrsteProizvoda.ToList().Select(x => _mapper.Map<Model.VrsteProizvodum>(x)).ToList();
        }

        public Model.VrsteProizvodum GetById(int id)
        {
            var entity = Context.VrsteProizvoda.Find(id);
            return _mapper.Map<Model.VrsteProizvodum>(entity);
        }
    }
}

