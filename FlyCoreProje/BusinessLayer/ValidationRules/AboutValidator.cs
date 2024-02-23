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
    public class AboutValidator:AbstractValidator<About>
    {
        //RuleFor FluentValidator paketi'nin kütüphanesinden çağırılır
        public AboutValidator() 
        {
            //Hangi tablo alanı için işlem kısıtı yapılacak ise bu atama yapılır
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama kısmını boş geçemezsiniz..!");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Lütfen görsel seçiniz..!");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("En az 50 karakter sınırı vardır..!");
            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("Açıklamayı kısaltınız..!");
        }
    }
}
