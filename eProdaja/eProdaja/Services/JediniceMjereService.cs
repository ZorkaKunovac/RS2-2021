using AutoMapper;
using eProdaja.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class JediniceMjereService : IJediniceMjereService
    {
        public eProdajaContext Context { get; set; }
        protected readonly IMapper _mapper;

        public JediniceMjereService(eProdajaContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }
        public IEnumerable<Model.JediniceMjere> Get()
        {
            return Context.JediniceMjeres.ToList().Select(x => _mapper.Map<Model.JediniceMjere>(x)).ToList();
        }

        public Model.JediniceMjere GetById(int id)
        {
            var entity = Context.JediniceMjeres.Find(id);
            return _mapper.Map<Model.JediniceMjere>(entity);
        }
    }
}
