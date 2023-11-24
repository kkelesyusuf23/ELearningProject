using ELearningProject.DAL.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ELearningProject.ValidationRules
{
	public class StudentValidator:AbstractValidator<Student>
	{
		public StudentValidator()
		{
			RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail alanını boş geçemezsiniz.").EmailAddress().WithMessage("Geçerli bir e-posta adresi giriniz.");
			RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanını boş geçemezsiniz.");
		}
	}
}