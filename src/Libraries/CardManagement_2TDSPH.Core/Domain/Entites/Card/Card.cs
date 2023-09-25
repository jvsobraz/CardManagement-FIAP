namespace CardManagement_2TDSPH.Core.Domain.Entites.Card;

public class Card
{
    public string Name { get; set; }
    public string? Type { get; set; }
    public string? ManaValue { get; set; }
    public string? Subtype { get; set; }
    public string? Power { get; set; }
    public string? Toughness { get; set; }
    
    public virtual ICollection<Print> Prints { get; set; } = new List<Print>();
    public virtual ICollection<NoteAndRule> NotesAndRules { get; set; } = new List<NoteAndRule>();
    public virtual ICollection<RelatedLink> RelatedLinks { get; set; } = new List<RelatedLink>();
    public virtual ICollection<Legalty> Legalties { get; set; } = new List<Legalty>();
}