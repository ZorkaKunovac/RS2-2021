using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProdaja.Model;
using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    public class ProizvodiController : BaseReadController<Model.Proizvodi, ProizvodiSearchObject>
    {
        public ProizvodiController(IProizvodiService service) : base(service)
        {
        }
        
    }
}
