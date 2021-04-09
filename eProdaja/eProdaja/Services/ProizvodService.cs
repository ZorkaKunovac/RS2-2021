﻿using eProdaja.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class ProizvodService : IProizvodService
    {
        private static List<Proizvod> _proizvodi;

        static ProizvodService()
        {
            _proizvodi = new List<Proizvod>()
            {
                new Proizvod()
                {
                    Id=1,
                    Naziv="Laptop"
                },
                new Proizvod()
                {
                    Id=2,
                    Naziv="Mis"
                }
            };

        }
        public IEnumerable<Proizvod> Get()
        {
            return _proizvodi;
        }

        public Proizvod GetById(int id)
        {
            return _proizvodi.FirstOrDefault(x => x.Id == id);
        }

        public Proizvod Insert(Proizvod proizvod)
        {
            _proizvodi.Add(proizvod);
            return proizvod;
        }

        public Proizvod Update(int id, Proizvod proizvod)
        {
            var current = _proizvodi.FirstOrDefault(x => x.Id == id);
            current.Naziv = proizvod.Naziv;

            return current;
        }

    }

}
