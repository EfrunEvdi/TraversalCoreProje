using DTOLayer.DTOs.ContactDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRule.ContactUs
{
    public class SendContactUsValidator : AbstractValidator<SendMessageDto>
    {
        public SendContactUsValidator()
        {
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail alanı boş geçilemez.");
            RuleFor(x => x.Mail).MinimumLength(5).WithMessage("Mail alanı minimum 5 karakter olmalıdır..");
            RuleFor(x => x.Mail).MaximumLength(100).WithMessage("Mail alanı maksimum 100 karakter olmalıdır.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu alanı boş geçilemez.");
            RuleFor(x => x.Subject).MinimumLength(5).WithMessage("Konu alanı minimum 5 karakter olmalıdır.");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("Konu alanı maksimum 100 karakter olmalıdır.");
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim alanı boş geçilemez.");
            RuleFor(x => x.MessageBody).NotEmpty().WithMessage("Mesaj alanı boş geçilemez.");
        }
    }
}
