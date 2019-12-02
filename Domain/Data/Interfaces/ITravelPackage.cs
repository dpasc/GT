using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Data
{
   public interface ITravelPackage
   {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int StatusId { get;  set; }
        public decimal RRP { get; set; }


    }
}
