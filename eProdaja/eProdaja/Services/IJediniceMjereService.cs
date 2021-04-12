using eProdaja.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public interface IJediniceMjereService
    {
        IEnumerable<Model.JediniceMjere> Get();
        public Model.JediniceMjere GetById(int id);

    }
}
