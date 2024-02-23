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
    public class GuideValidator:AbstractValidator<Guide>
    {
        //RuleFor FluentValidator paketi'nin kütüphanesinden çağırılır
        public GuideValidator() 
        {
            //Hangi tablo alanı için işlem kısıtı yapılacak ise bu atama yapılır
            RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen personel adını giriniz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Lütfen yolculuk açıklamasını giriniz ");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Lütfen personel adını giriniz");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Lütfen 30 karakteri geçmeyen bir isim giriniz");

        }
    }
}
