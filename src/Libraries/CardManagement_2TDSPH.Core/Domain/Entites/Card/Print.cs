using CardManagement_2TDSPH.Core.Domain.Entites.Enums;

namespace CardManagement_2TDSPH.Core.Domain.Entites.Card;

public class Print
{
    public Rarity Rarity { get; set; }
    public string? CardText { get; set; }
    public string? FlavorText { get; set; }
    public Language Language { get; set; }
    public int Number { get; set; }
    public bool Foil { get; set; }

    public virtual Card Card { get; set; }
    public virtual Set Set { get; set; }
    public virtual Ilustrator Ilustrator { get; set; }
}