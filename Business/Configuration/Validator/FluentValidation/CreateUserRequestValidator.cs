using DTO.User;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Configuration.Validator.FluentValidation
{
   public class CreateUserRequestValidator:AbstractValidator<CreateUserRequest>
    {
        public CreateUserRequestValidator()
        {
            RuleFor(x => x.NameSurname).NotEmpty();
            RuleFor(x => x.NameSurname).Length(0, 50);
            RuleFor(x => x.IdentityNumber).NotEmpty();
            RuleFor(x => x.IdentityNumber).Matches(@"^\d+$");
            RuleFor(x => x.IdentityNumber).Length(11);
            RuleFor(x => x.Email).Length(1,60);
            RuleFor(x => x.Email).EmailAddress();
            RuleFor(x => x.Phone).Length(10,20);
            RuleFor(x => x.Phone).Matches(@"^\d+$");
            RuleFor(x => x.CarInfo).Length(1, 20);
            ValidatorOptions.Global.LanguageManager.Enabled = false;
        }
    }
}
