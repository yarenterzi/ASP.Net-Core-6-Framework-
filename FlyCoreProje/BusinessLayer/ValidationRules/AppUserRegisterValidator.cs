using DTOLayer.DTOs.AppUserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    //Gerekli alanlar için sınırlama getirilmesi için Validator işlemi uygulanır
    public class AppUserRegisterValidator:AbstractValidator<AppUserRegisterDTOs>
    {
        //RuleFor FluentValidator paketi'nin kütüphanesinden çağırılır
        public AppUserRegisterValidator() 
        {
            //Hangi tablo alanı için işlem kısıtı yapılacak ise bu atama yapılır
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanını boş geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyadı alanını boş geçilemez");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail alanını boş geçilemez");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı alanını boş geçilemez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanını boş geçilemez");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre tekrar alanını boş geçilemez");
            RuleFor(x => x.Username).MinimumLength(5).WithMessage("Lütfen en az 5 karakter veri girişi yapınız");
            RuleFor(x => x.Username).MaximumLength(20).WithMessage("Lütfen en fazla 20 karakter veri girişi yapınız");
            RuleFor(x => x.Password).Equal(y=>y.ConfirmPassword).WithMessage("Şifreler uyuşmuyor");

        }
    }
}
