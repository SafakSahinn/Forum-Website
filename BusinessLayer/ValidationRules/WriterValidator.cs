using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı boş geçilemez!");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar soyadı boş geçilemez!");
            RuleFor(x => x.WrıterAbout).NotEmpty().WithMessage("Hakkında kısmı boş geçilemez!");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Ünvan kısmı boş geçilemez!");

            RuleFor(x => x.WriterName).MinimumLength(3).WithMessage("Yazar adı en az 3 karakterden oluşmalıdır!");
            RuleFor(x => x.WriterSurname).MinimumLength(3).WithMessage("Yazar soyadı en az 3 karakterden oluşmalıdır!");
            RuleFor(x => x.WrıterAbout).MinimumLength(3).WithMessage("Hakkında kısmı en az 3 karakterden oluşmalıdır!");
            RuleFor(x => x.WriterTitle).MinimumLength(3).WithMessage("Ünvan kısmı en az 3 karakterden oluşmalıdır!");

            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Yazar adı 50 karakterden uzun olamaz!");
            RuleFor(x => x.WriterSurname).MaximumLength(50).WithMessage("Yazar soyadı 50 karakterden uzun olamaz!");
            RuleFor(x => x.WrıterAbout).MaximumLength(100).WithMessage("Hakkında kısmı 100 karakterden uzun olamaz!");
            RuleFor(x => x.WriterTitle).MaximumLength(50).WithMessage("Ünvan kısmı 100 karakterden uzun olamaz!");
        }
    }
}
