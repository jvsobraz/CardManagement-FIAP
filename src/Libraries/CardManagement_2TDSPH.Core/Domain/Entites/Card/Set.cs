namespace CardManagement_2TDSPH.Core.Domain.Entites.Card;

public class Set
{
    public string Name { get; set; }
    public string Acronym { get; set; }
    public DateTime ReleaseDate { get; set; }
    public string LogoUrl { get; set; }
    public virtual ICollection<Print> Prints { get; set; } = new List<Print>();
}