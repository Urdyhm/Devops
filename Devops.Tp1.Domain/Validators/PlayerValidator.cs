using Devops.Tp1.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops.Tp1.Domain.Validators
{
    public class PlayerValidator : AbstractValidator<Player>
    {
        public PlayerValidator()
        {
            RuleFor(X => X.Name).NotEmpty().WithMessage("La propiedad Name es Obligatorio");
            RuleFor(X => X.Name).MaximumLength(50).WithMessage("La Propiedad Name debe tener menos de 50 caracteres");
            RuleFor(X => X.LastName).NotEmpty().WithMessage("La Propiedad LastName es Obligatorio");
            RuleFor(X => X.LastName).MaximumLength(50).WithMessage("La propiedad LastName debe tener menos de 50 caracteres");
            RuleFor(X => X.Birthday).NotEmpty().WithMessage("La propiedad Birthday es obligatorio");
        }
    }
}
