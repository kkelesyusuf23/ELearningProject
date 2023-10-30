using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ELearningProject.DAL.Entities
{
	public class Student
	{
		public int StudentID { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Mail { get; set; }
		public string Password { get; set; }
		public List<CourseRegister> CourseRegisters { get; set; }
	}
}