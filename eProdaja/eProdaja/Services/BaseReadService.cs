﻿using AutoMapper;
using eProdaja.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class BaseReadService<T,TDb> : IReadService<T> where T : class where TDb:class
    {
        public eProdajaContext Context;
        protected readonly IMapper _mapper;
        public BaseReadService(eProdajaContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }
        public virtual IEnumerable<T> Get()
        {
            var entity = Context.Set<TDb>();

            var list = entity.ToList();
            return _mapper.Map<List<T>>(list);
        }

        public virtual T GetById(int id)
        {
            var set = Context.Set<T>();
            var entity = set.Find(id);
            return _mapper.Map<T>(entity);
        }
    }
}
