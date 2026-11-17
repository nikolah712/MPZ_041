using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public sealed class DigitalniProizvod : Zapis
    {
        //public DigitalniProizvod() { }

        public DigitalniProizvod(Guid id, string naziv, string opis, DateTimeOffset kreiranoUtc, string formatPreuzimanja) : base(id, naziv, opis, kreiranoUtc)
        {
            FormatPreuzimanja = formatPreuzimanja;
        }

        public string FormatPreuzimanja { get; set; } = string.Empty;
    }
}
