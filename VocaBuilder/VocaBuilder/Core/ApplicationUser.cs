using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VocaBuilder.Core
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser() : base() { }
        public double AveragePercentage { get; set; }
        public int CorrectAnswers { get; set; }
        public int TotalTrials { get; set; }
    }
}
