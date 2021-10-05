using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VocaBuilder.Core
{
    public class Word : Entity
    {
        public string WordList { get; set; }
        public string Definition { get; set; }
        public int Lesson { get; set; }
    }
}
