using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ELearningProject.DAL.Entities
{
    public class Subscribe
    {
        public int SubscribeID { get; set; }
        public string Mail { get; set; }
        public bool Status { get; set; }
    }
}