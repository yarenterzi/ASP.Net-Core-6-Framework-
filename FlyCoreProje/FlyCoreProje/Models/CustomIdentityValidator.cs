using Microsoft.AspNetCore.Identity;

namespace FlyCoreProje.Models
{
    //Yapılmak istenen kısıtlama ve istekler türkçe hali olarak gelmesi için sınırlama ataması oluşturulur
    //Bu işlemi de program.cs de CustomIdentityValidator belirteci ile gösterilir
    public class CustomIdentityValidator:IdentityErrorDescriber
	{
		public override IdentityError PasswordTooShort(int length)
		{
			return new IdentityError()
			{
				Code = "PasswordTooShort",
				Description = $"Parola Minimum {length} karakter olmalıdır"
			};
		}
		public override IdentityError PasswordRequiresUpper()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresUpper",
				Description = "Parola en az 1 büyük harf içermelidir"
			};
		}
		public override IdentityError PasswordRequiresLower()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresLower",
				Description = "Parola en az 1 küçük harf içermelidir"
			};
		}
		public override IdentityError PasswordRequiresNonAlphanumeric()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresNonAlphanumeric",
				Description = "Parola en az 1 sembol içermelidir"
			};
		}
	}
}
