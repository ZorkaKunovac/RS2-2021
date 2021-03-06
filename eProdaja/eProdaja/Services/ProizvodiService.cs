using AutoMapper;
using eProdaja.Database;
using eProdaja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class ProizvodiService : BaseReadService<Model.Proizvodi, Database.Proizvodi, ProizvodiSearchObject>, IProizvodiService
    {
        public ProizvodiService(eProdajaContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IEnumerable<Model.Proizvodi> Get(ProizvodiSearchObject search = null)
        {
            var entity = Context.Set<Database.Proizvodi>().AsQueryable();
            if(!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                entity = entity.Where(x => x.Naziv.Contains(search.Naziv));
            }
            if(search.JedinicaMjereId.HasValue)
            {
                entity = entity.Where(x => x.JedinicaMjereId == search.JedinicaMjereId);
            }
            if(search.VrstaId.HasValue)
            {
                entity = entity.Where(x => x.VrstaId == search.VrstaId);
            }

            var list = entity.ToList();
            return _mapper.Map<List<Model.Proizvodi>>(list);
        }
    }
}
