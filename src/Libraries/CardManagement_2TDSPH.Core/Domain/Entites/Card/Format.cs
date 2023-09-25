namespace CardManagement_2TDSPH.Core.Domain.Entites.Card;

public class Format
{
    public string Name { get; set; }
    public virtual ICollection<Legalty> Legalties { get; set; } = new List<Legalty>();
}