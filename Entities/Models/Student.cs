using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class Student : IEntity
    {
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
