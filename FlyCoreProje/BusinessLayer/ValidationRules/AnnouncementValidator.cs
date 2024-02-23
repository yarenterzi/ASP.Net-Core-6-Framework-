using DTOLayer.DTOs.AnnouncementDTOs;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    //Gerekli alanlar için sınırlama getirilmesi için Validator işlemi uygulanır
    public class AnnouncementValidator:AbstractValidator<AnnouncementAddDto>
    {
        //RuleFor FluentValidator paketi'nin kütüphanesinden çağırılır
        public AnnouncementValidator() 
        {
            //Hangi tablo alanı için işlem kısıtı yapılacak ise bu atama yapılır
            RuleFor(x => x.Title).NotEmpty().WithMessage("Lütfen başlık girişi yapınız");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Lütfen duyuru girişi yapınız");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Lütfen en az 5 karakter girişi yapınız");
            RuleFor(x => x.Content).MinimumLength(5).WithMessage("Lütfen en az 20 karakter girişi yapınız");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter girişi yapınız");
            RuleFor(x => x.Content).MaximumLength(500).WithMessage("Lütfen en fazla 500 karakter girişi yapınız");

        }
    }
}
