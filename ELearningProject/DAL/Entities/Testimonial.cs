using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ELearningProject.DAL.Entities
{
	public class Testimonial
	{
		public int TestimonialID { get; set; }
		public string NameSurname { get; set; }
		public string Title { get; set; }
		public string ImageURL { get; set; }
		public string Comment { get; set; }
		public bool Status { get; set; }

	}
}