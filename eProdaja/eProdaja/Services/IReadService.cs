using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public interface IReadService<T> where T:class
    {
        IEnumerable<T> Get();
        public T GetById(int id);
    }
}
