using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace NotesTracker.Models
{
    public class Note
    {
        //Define Note Attributes
        public int ID { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Display(Name = "Title")]
        public string TaskTitle { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(30)]
        [Display(Name = "Description")]
        public string TaskDescription { get; set; }

        [Display(Name = "Due Date")]
        [DataType(DataType.Date)]
        public DateTime TaskDueDate { get; set; }
    }
}
