using DTOLayer.DTOs.AnnouncementDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRule
{
    public class AnnouncementValidator : AbstractValidator<AnnouncementAddDTO>
    {
        public AnnouncementValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık kısmı boş geçilemez.");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Başlık minimum 5 karakter olmalıdır.");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Başlık maksimum 50 karakter olmalıdır.");
            RuleFor(x => x.Content).NotEmpty().WithMessage("İçerik kısmı boş geçilemez.");
            RuleFor(x => x.Content).MinimumLength(20).WithMessage("İçerik minimum 20 karakter olmalıdır.");
            RuleFor(x => x.Content).MaximumLength(500).WithMessage("İçerik maksimum 500 karakter olmalıdır.");
        }
    }
}
