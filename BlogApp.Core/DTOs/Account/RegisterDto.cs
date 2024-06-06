using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BlogApp.Core.DTOs.Account
{
    public record RegisterDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }

    public class RegisterDtoValidator:AbstractValidator<RegisterDto>
    {
        public RegisterDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("Duzgun format daxil edin")
                .MinimumLength(3)
                .WithMessage("Uzunluq 3 den cox olmalidir");
            RuleFor(x => x.Password)
                .NotNull()
                .NotEmpty()
                .WithMessage("Duzgun format daxil edin")
                .MaximumLength(15)
                .WithMessage("Passwordun uzunlugu max 15 ola biler")
                .Must(p =>
                {
                    Regex reg = new Regex(@"^(?=.*[a-z])(?=.*\d).{8,}$");
                    Match match = reg.Match(p);
                    return match.Success;

                }).MinimumLength(8).WithMessage("Password must be cotains 8 character ");
            RuleFor(x => x.ConfirmPassword).Matches(x => x.Password);
            RuleFor(x=>x.Email).Matches(@"^[^@\s]+@[^@\s]+\.[^@\s]+$").WithMessage("Email is not a valid email address.");

        }
    }
}
