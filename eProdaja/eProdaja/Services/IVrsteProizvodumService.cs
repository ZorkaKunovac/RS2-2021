﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public interface IVrsteProizvodumService
    {
   
        IEnumerable<Model.VrsteProizvodum> Get();
        public Model.VrsteProizvodum GetById(int id);
    }
}
