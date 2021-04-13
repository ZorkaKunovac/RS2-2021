using AutoMapper;
using eProdaja.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class JediniceMjereService : BaseReadService<Model.JediniceMjere, Database.JediniceMjere,object>, IJediniceMjereService
    {
        public JediniceMjereService(eProdajaContext context, IMapper mapper)
        :base(context, mapper)
        {

        }       
    }
}
