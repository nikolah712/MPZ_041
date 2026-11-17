namespace Domain.Models;

// Zajednički osnovni tip iz koga se mogu izvesti modeli konkretnog zadatka.
// Polja, nazive i nasledjivanje prilagoditi dodeljenoj specifikaciji.
public abstract class Zapis
{
    protected Zapis() { }

    protected Zapis(Guid id, string naziv, string opis, DateTimeOffset kreiranoUtc)
    {
        Id = id;
        Naziv = naziv;
        Opis = opis;
        KreiranoUtc = kreiranoUtc;
    }

    public Guid Id { get; init; } = Guid.NewGuid();
    public string Naziv { get; init; } = string.Empty;
    public string Opis { get; init; } = string.Empty;
    public DateTimeOffset KreiranoUtc { get; init; } = DateTimeOffset.UtcNow;

}
