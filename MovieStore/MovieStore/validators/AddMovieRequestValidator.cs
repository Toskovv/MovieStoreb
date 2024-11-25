﻿using FluentValidation;
using MovieStore.Models.Request;
using System.Reflection;

namespace MovieStore.Validators
{
    public class AddMovieRequestValidator : AbstractValidator<AddMovieRequest>
    {
        public AddMovieRequestValidator()
        {
            RuleFor( x => x.Title)
                .NotEmpty()
                .NotNull()
                .MaximumLength(100)
                .MinimumLength(2);

            RuleFor(x => x.Year)
               .GreaterThan(1900)
               .LessThan(2100);
        }
    }
}