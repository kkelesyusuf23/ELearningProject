﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ELearningProject.DAL.Entities
{
    public class Service
    {
        public int ServiceID { get; set; }
        public string Icon { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}