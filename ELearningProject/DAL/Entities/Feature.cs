using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ELearningProject.DAL.Entities
{
    public class Feature
    {
        public int FeatureID { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string ImageURL { get; set; }
    }
}