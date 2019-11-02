using Library.Models;
using Library.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Repository
{
    public class TravelProviderRepository:ITravelProvider
    {
        private readonly GTContext _gTContext;


        public TravelProviderRepository()
        {
            _gTContext = new GTContext();
        }

        public TravelProviderRepository(GTContext gTContext)
        {
            _gTContext = gTContext;
        }

        public void Delete(int id)
        {
            TravelProvider travelProvider = _gTContext.TravelProviders.Find(id);
            _gTContext.TravelProviders.Remove(travelProvider);
        }

        public IEnumerable<TravelProvider> GetAll()
        {
            return _gTContext.TravelProviders.ToList();
        }

        public TravelProvider GetById(int id)
        {
            return _gTContext.TravelProviders.Find(id);
        }

        public void Insert(TravelProvider tp)
        {
            _gTContext.TravelProviders.Add(tp);
        }

        public void Save()
        {
            _gTContext.SaveChanges();
        }

        public void Update(TravelProvider tp)
        {
            throw new NotImplementedException();
        }
    }
}
