using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ELearningProject.DAL.Entities
{
    public class ContactInformation
    {
        public int ContactInformationID { get; set; }
        public string InformationTitle { get; set; }
        public string InformationIcon { get; set; }
        public string Information { get; set; }
    }
}