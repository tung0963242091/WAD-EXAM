using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WAD_Wxam.Models
{
    public class Subject
    {
        [Key]
        public int ExamId { get; set; }
        [Required]
        public string ExamSubject { get; set; }
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm}")]
        public DateTime StartTime { get; set; }
        [DisplayFormat(DataFormatString ="{0:đ/MM/yyyy}")]
        public DateTime ExamData { get; set; }
        [Required]
        public int ExamDuration { get; set; }
        [Required]
        public string Room { get; set; }
        [Required]

        public string Faculty { get; set; }

        public ExamStatus Status { get; set; }

    }

    public enum ExamStatus
    {
        upconming = 1, ongoing = -1, done = 0
    }
}