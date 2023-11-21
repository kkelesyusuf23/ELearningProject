using ELearningProject.DAL.Entities;
using System.ComponentModel.DataAnnotations;

namespace ELearningProject.Models
{
    public class ReviewCommentViewModel
    {
        [Required]
        public int CourseID { get; set; }

        [Required]
        public int ReviewScore { get; set; }
        public int ReviewID { get; set; }
        public int StudentID { get; set; }
        public int CommentID { get; set; }

        [Required]
        public string CommentText { get; set; }
    }
}
