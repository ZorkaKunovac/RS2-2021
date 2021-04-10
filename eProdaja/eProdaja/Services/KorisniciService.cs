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
        public KorisniciService(eProdajaContext context)
        {
            Context = context;
        }
        public List<Korisnici> Get()
        {
            return Context.Korisnicis.ToList();
        }
    }
}
