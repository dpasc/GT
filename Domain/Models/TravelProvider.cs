using Domain.Models;

namespace Library.Models.Models
{
    public class TravelProvider:IEntity
    {
        public TravelProvider()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }


    }
}