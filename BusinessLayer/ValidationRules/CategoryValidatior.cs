using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidatior : AbstractValidator<Category>
    {
        public CategoryValidatior()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adı boş geçilemez!");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Kategori açıklaması boş geçilemez!");

            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Kategori adı en az 3 karakterden oluşmalıdır!");
            RuleFor(x => x.CategoryDescription).MinimumLength(10).WithMessage("Kategori açıklaması en az 10 karakterden oluşmalıdır!");

            RuleFor(x => x.CategoryName).MaximumLength(50).WithMessage("Kategori adı 20 karakterden uzun olamaz!");
            RuleFor(x => x.CategoryDescription).MaximumLength(200).WithMessage("Kategori açıklaması 100 karakterden uzun olamaz!");
        }
    }
}
