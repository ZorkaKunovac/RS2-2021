using AutoMapper;
using eProdaja.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class KorisniciService : IKorisniciService
    {
        public eProdajaContext Context { get; set; }
        protected readonly IMapper _mapper;

        public KorisniciService(eProdajaContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }
        public List<Model.Korisnici> Get()
        {
            return Context.Korisnicis.ToList().Select(x => _mapper.Map<Model.Korisnici>(x)).ToList();
        }
    }
}
