using Library.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Repository
{
    public interface ITravelProvider
    {
        IEnumerable<TravelProvider> GetAll();
        TravelProvider GetById(int id);
        void Insert(TravelProvider tp);
        void Update(TravelProvider tp);
        void Delete(int id);
        void Save();

    }
}
