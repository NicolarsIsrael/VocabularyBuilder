using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VocaBuilder.Models
{
    public class AddWordDto
    {
        public int Id { get; set; }

        [Display(Name="Word")]
        [Required(ErrorMessage ="Word is required")]
        public string WordList { get; set; }

        [Required(ErrorMessage ="Definition is required")]
        public string Definition { get; set; }

        [Required(ErrorMessage ="Lesson is required")]
        [Range(1,int.MaxValue,ErrorMessage ="Lesson must start from 1")]
        public int Lesson { get; set; }
    }
}
