using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public sealed class FizickiProizvod : Zapis
    {
        public FizickiProizvod() { }

        public FizickiProizvod(Guid id, string naziv, string opis, DateTimeOffset kreiranoUtc, uint masaPaketa) : base(id, naziv, opis, kreiranoUtc)
        {
            MasaPaketa = masaPaketa;
        }

        public uint MasaPaketa { get; set; }
    }
}
