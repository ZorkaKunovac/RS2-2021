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
        private eProdajaContext Context;
        protected readonly Mapper _mapper;
        public JediniceMjereService (eProdajaContext context, Mapper mapper) {
            Context = context;
            _mapper = mapper;
        }
        public List<Model.JediniceMjere> Get()
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
