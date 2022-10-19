using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class Group : IEntity
    {
        public int Capacity { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
