using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRule
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description1).NotEmpty().WithMessage("Açıklama kısmı boş geçilemez.");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Lütfen görsel seçiniz.");
            RuleFor(x => x.Description1).MinimumLength(50).WithMessage("Lütfen en az 50 karakterlik açıklama giriniz.");
            RuleFor(x => x.Description1).MaximumLength(1500).WithMessage("Maksimum 1500 karakterlik açıklama girebilirsiniz.");
        }
    }
}
