using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRule
{
    public class GuideValidator : AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen rehber isim ve soyismini giriniz.");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Lütfen rehber isim ve soyismini maksimum 30 karakter olarak giriniz.");
            RuleFor(x => x.Name).MinimumLength(8).WithMessage("Lütfen rehber isim ve soyismini minimum 8 karakter olarak giriniz.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Lütfen rehber açıklaması giriniz.");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Lütfen rehber profil fotoğrafını giriniz.");
        }
    }
}
