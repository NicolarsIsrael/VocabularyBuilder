using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VocaBuilder.Core
{
    public class Entity
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsDeleted { get; set; }
    }
}
