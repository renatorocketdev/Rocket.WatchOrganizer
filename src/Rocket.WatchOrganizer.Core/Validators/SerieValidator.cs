using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using Rocket.WatchOrganizer.Core.Models;

namespace Rocket.WatchOrganizer.Core.Validators
{
    public class SerieValidator : AbstractValidator<Serie>
    {
        public SerieValidator()
        {
            RuleFor(x => x.Titulo).NotNull();
        }
    }
}
