using Dto.Dtos.AppUserDtos;
using FluentValidation;
using System.Text;

namespace Business.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator() 
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad Alanı Boş Bırakılamaz");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyadı Alanı Boş Bırakılamaz");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı Adı Alanı Boş Bırakılamaz");
            RuleFor(x => x.EMail).NotEmpty().WithMessage("E-Posta Alanı Boş Bırakılamaz");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre Alanı Boş Bırakılamaz");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre Alanı Boş Bırakılamaz");
            RuleFor(x => x.ConfirmPassword).Equal(y=>y.Password).WithMessage("Şifreler Eşleşmiyor Doğru Giriniz");
            RuleFor(x => x.EMail).EmailAddress().WithMessage("Lütfen Geçerli E-Posta Adresi Giriniz...");
        }
    }
}
