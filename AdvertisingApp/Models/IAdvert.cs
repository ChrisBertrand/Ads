using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvertisingApp.Models
{
    interface IAdvert
    {
        int Id{ get; set; }
        string Name { get; set; }
        int Length { get; set; }
    }

    public class Advert : IAdvert
    {
        public Advert()
        {
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Length { get; set; }
    }

    public class AdvertValidator : AbstractValidator<Advert>
    {
        public AdvertValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.Name).Length(2, 10);
            RuleFor(x => x.Length).GreaterThan(5);
        }
    }
}
