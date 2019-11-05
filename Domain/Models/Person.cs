using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models.Models
{
    public class Person :IEntity
    {
        public int Id { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
  

    }
}
