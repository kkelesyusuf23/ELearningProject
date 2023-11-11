using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ELearningProject.DAL.Entities
{
    public class CourseWatchList
    {
        public int CourseWatchListID { get; set; }
        public int CourseID { get; set; }
        public Course Course { get; set; }
        public string VideoUrl { get; set; }
    }
}